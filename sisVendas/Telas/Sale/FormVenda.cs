using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Models.Venda;
using sisVendas.Notificacao;
using sisVendas.Screens.Client;
using sisVendas.Screens.Product;
using sisVendas.Telas.Sale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    public partial class FormVenda : Form
    {
        private Cliente clienteSelecionado = null;
        private Produto produtoSelecionado = null;
        private Vendas vendaSelecionada = null;

        private ctrlCliente controlCliente = new ctrlCliente();
        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlVenda controlVenda = new ctrlVenda();
        private ctrlItensVenda controlItensVenda = new ctrlItensVenda();
        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();

        //private int itemCoupon = 1;

        private double toalVenda = 0;
        private double totalDesconto = 0;
        private double subtotalVenda = 0;
        private double totalPago = 0;
        private int idCaixa;
        private int idFunc;

        DataTable dttParcela = new DataTable();
        DataTable dttProduto = new DataTable();
        public FormVenda()
        {
            InitializeComponent();

            initDataGridView();

            //inserirCabecalhoBobina();
        }
        public FormVenda(int idCaixa, int idFunc) : this()
        {
            this.idCaixa = idCaixa;
            this.idFunc = idFunc;
        }

        #region iniciarDGV

        public void initDataGridView()
        {
            dttProduto.TableName = "products";
            dttProduto.Columns.Add("name");
            dttProduto.Columns.Add("cod");
            dttProduto.Columns.Add("amount", typeof(double));
            dttProduto.Columns.Add("un");
            dttProduto.Columns.Add("valueun");
            dttProduto.Columns.Add("valuetotal");

            dttProduto.PrimaryKey = new DataColumn[] { dttProduto.Columns["name"] };
            dgvProducts.DataSource = dttProduto;

            dttParcela.TableName = "parcelas";
            dttParcela.Columns.Add("valor", typeof(double));
            dttParcela.Columns.Add("tipo_pagamento");
            dttParcela.Columns.Add("data", typeof(DateTime));
        }
        #endregion

        #region Form e hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    if(vendaSelecionada == null)
                        formCliente();
                    break;
                case Keys.F2:
                    if (vendaSelecionada == null) 
                        formProduto();
                    break;
                case Keys.F4:
                    resetarForm();
                    break;

                case Keys.F5:
                    formBuscarVenda();
                    break;
                case Keys.F6:
                    CancelarVenda();
                    break;
                case Keys.F9:
                    if (vendaSelecionada == null)
                        FormCalcularTroco();
                    break;
                case Keys.F10:
                    formCompensarParcela();
                    break;
                case Keys.F11:
                    if (vendaSelecionada == null)
                        formDesconto();
                    break;
                case Keys.F12:
                    if (vendaSelecionada == null)
                        finalizarVenda();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void timer_sale_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("dd/MM/yyyy");
        }
        #endregion

        #region Cliente
        public void formCliente()
        {
            FormBuscarCliente f = new FormBuscarCliente();
            f.ShowDialog();

            Cliente cli = f.returnClient();

            if (cli != null)
            {
                clienteSelecionado = cli;

                preencherCliente(clienteSelecionado);
            }
            mtbCpfClient.Focus();
        }
        private void mtbCpfClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (mtbCpfClient.Mask == "00.000.000/0000-00")
                {
                    mtbCpfClient.Text = "";

                    alterarCpfCnpj(11);
                    resetaCliente();

                }
                else if (clienteSelecionado != null)
                {
                    resetaCliente();
                }
            }
        }
        public void resetaCliente()
        {
            tbNameClient.Enabled = true;
            tbNameClient.Text = "";
            clienteSelecionado = null;

        }
        public void preencherCliente(Cliente cli)
        {
            alterarCpfCnpj(cli.Cpf_cnpj.Count());

            tbNameClient.Text = cli.Nome;
            mtbCpfClient.Text = cli.Cpf_cnpj;
            tbNameClient.Enabled = false;
            lblWarningCpf.Visible = false;
        }
        private void mtbCpfClient_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfClient.Text).Length == 0)
                mtbCpfClient.Select(0, 0);
        }
        private void mtbCpfClient_Leave(object sender, EventArgs e)
        {
            string cpf = mtbCpfClient.Text;

            if (verificarSeClienteExiste(cpf))
            {
                tbNameClient.Enabled = false;
                tbCodProduct.Focus();
            }

        }
        private bool verificarSeClienteExiste(string cpf)
        {

            cpf = Function.replaceAll(cpf);

            if (cpf.Count() == 11)
            {
                if ((Function.isCpfValid(mtbCpfClient.Text)))
                {
                    clienteSelecionado = controlCliente.buscarClientePorCpf(cpf);

                    if (clienteSelecionado != null)
                    {
                        preencherCliente(clienteSelecionado);
                        lblWarningCpf.Visible = false;
                        return true;
                    }
                    lblWarningCpf.Text = "** CPF não encontrado! será inserido um novo cliente com o CFP e o NOME informado! **";

                }
                else
                {
                    lblWarningCpf.Text = "** CPF incorreto **";
                }
            }else if(cpf.Count() > 11)
            {
                return true;
            }
            else if (cpf.Count() == 0)
            {
                lblWarningCpf.Visible = false;
                return true;
            }
            else
            {
                lblWarningCpf.Text = "** CPF incorreto **";
            }

            tbNameClient.Text = "";
            clienteSelecionado = null;
            lblWarningCpf.Visible = true;
            return false;


        }
        #endregion

        #region Funções

        public void alterarCpfCnpj(int qtde)
        {
            if (mtbCpfClient.Mask != "000.000.000-00" && qtde <= 11)
            {
                mtbCpfClient.Mask = "000.000.000-00";

                //mtbCpfClient.Select(qtde, 0);
                lblCpf.Text = "CPF:";
            }
            else if (mtbCpfClient.Mask != "00.000.000/0000-00" && qtde > 11)
            {
                int pos = mtbCpfClient.Text.Count();
                mtbCpfClient.Mask = "00.000.000/0000-00";
                //mtbCpfClient.Select(pos, 0);

                lblCpf.Text = "CNPJ:";
            }

        }
        public void resetarForm()
        {
            dttParcela.Rows.Clear();
            dttProduto.Rows.Clear();

            toalVenda = 0;
            totalDesconto = 0;
            subtotalVenda = 0;
            totalPago = 0;

            mtbCpfClient.Mask = "000.000.000-00";
            produtoSelecionado = null;
            clienteSelecionado = null;
            vendaSelecionada = null;
            tbAmount.Text = "1";
            tbNameClient.Text = tbNameProduct.Text = tbCodProduct.Text = mtbCpfClient.Text = "";
            lblDesconto.Visible = lblTextDesconto.Visible = false;
            lblTotal.Text = lblSubtotal.Text = "R$ 0,00";

            gbProduto.Enabled = gbCliente.Enabled = true;

            lblCancelada.Visible = false;

            mtbCpfClient.Focus();
            btnPesquisarCliente.Visible =
            btnPesquisarProduto.Visible =
            btnCalcularTroco.Visible =
            btnFinalizarVenda.Visible =
            btnDesconto.Visible = true;
        }
        private void calcularParcelas(DataTable dtParcelas)
        {
            totalPago = 0;
            foreach (DataRow parcela in dtParcelas.Rows)
            {
                totalPago += double.Parse(parcela["valor"] + "");
            }
            subtotalVenda = toalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = (toalVenda - totalDesconto - totalPago).ToString("C");
        }
        #endregion

        #region Produto
        public void formProduto()
        {
            FormBuscarProduto f = new FormBuscarProduto();
            f.ShowDialog();

            produtoSelecionado = f.returnProduto();

            if (produtoSelecionado != null)
            {
                preencheProduto(produtoSelecionado);
            }
            else
            {
                resetarProduto();
            }
            tbAmount.Focus();
        }
        private void preencheProduto(Produto prod)
        {

            tbNameProduct.Text = prod.Nome;
            tbCodProduct.Text = prod.Id.ToString();
            tbValorUn.Text = prod.Valor.ToString("C");

            alterarValorTotalProduto();
        }
        private void resetarProduto()
        {
            produtoSelecionado = null;

            tbNameProduct.Text = "";
            tbAmount.Text = "1";
            tbValorTotal.Text = tbValorUn.Text = "";
            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //ENTER
            {
                adicionarProduto(tbAmount.Text);
                dgvProducts.ClearSelection();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                removerProduto();
                dgvProducts.ClearSelection();
            }
        }
        private void removerProduto()
        {
            if (produtoSelecionado != null && Convert.ToDouble(tbAmount.Text) != 0)
            {
                removerProdutoDataTable(produtoSelecionado);
                resetarProduto();
            }
        }
        private void removerProdutoDataTable(Produto prod)
        {
            DataRow row = dttProduto.Rows.Find(prod.Nome);
            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                Function.Alert("Atenção!", "Não é possivel remover um produto que não está na compra!", popupClient.enmType.Warning);
            }
            else //caso ja exista no dt
            {

                if (Convert.ToDouble(tbAmount.Text) <= Convert.ToDouble(row["amount"]))
                {
                    double vTotal = Convert.ToDouble(dttProduto.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));
                    dttProduto.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) - Convert.ToDouble(tbAmount.Text);
                    dttProduto.Rows[index]["valueTotal"] = vTotal.ToString("C");

                    //alterar totais
                    toalVenda = toalVenda - (Convert.ToDouble(produtoSelecionado.Valor) * Convert.ToDouble(tbAmount.Text));
                    subtotalVenda = toalVenda - totalPago - totalDesconto;
                    lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);
                    lblTotal.Text = toalVenda.ToString("C");

                    //caso quantidade seja zero
                    if (Convert.ToDouble(dttProduto.Rows[index]["amount"]) == 0)
                    {
                        dttProduto.Rows[index].Delete();
                    }
                }
                else
                    Function.Alert("Atenção!", "Não é possivel deixar a quantidade negativa!", popupClient.enmType.Warning);
            }
        }
        private void adicionarProduto(string amount)
        {

            if (double.TryParse(amount, out double quanitdade))
            {
                if (produtoSelecionado != null)
                {
                    adicionarProdutoDataTable(quanitdade, produtoSelecionado);
                    resetarProduto();

                }
            }
            else
            {
                Function.Alert("Atenção!", "Quantidade inválida!", popupClient.enmType.Warning);
            }
        }
        private void adicionarProdutoDataTable(double amount, Produto prod)
        {
            string prod_name = prod.Nome;

            DataRow row = dttProduto.Rows.Find(prod_name);

            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                DataRow linha = dttProduto.NewRow();

                linha["name"] = prod.Nome;
                linha["amount"] = amount;
                linha["valueun"] = prod.Valor.ToString("C");
                linha["valuetotal"] = (prod.Valor * amount).ToString("C");
                linha["un"] = prod.Un;
                linha["cod"] = prod.Id;

                dttProduto.Rows.Add(linha);
                dgvProducts.DataSource = dttProduto;
            }
            else //caso ja exista no dt
            {
                double vTotal = Convert.ToDouble(dttProduto.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));

                dttProduto.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) + Convert.ToDouble(amount);
                dttProduto.Rows[index]["valueTotal"] = vTotal.ToString("C");
            }


            //atualizar total

            toalVenda = toalVenda + (Convert.ToDouble(prod.Valor) * Convert.ToDouble(amount));

            subtotalVenda = toalVenda - totalPago - totalDesconto;

            lblTotal.Text = toalVenda.ToString("C"); ;
            lblSubtotal.Text = subtotalVenda.ToString("C");

            //posicionar ultima linha
            dgvProducts.FirstDisplayedScrollingRowIndex = dgvProducts.RowCount - 1;
            //dgvProducts.CurrentCell = dgvProducts(0, dgvProducts.RowCount - 1)
        }
        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            selecionarProduto();
        }
        private void selecionarProduto()
        {
            if (dgvProducts.CurrentRow != null)
            {
                string linha = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[1].Value.ToString();
                tbCodProduct.Text = linha;
                tbCodProduct.Focus();
            }
        }

        private void tbCodProduct_Leave(object sender, EventArgs e)
        {

            if (tbCodProduct.Text.Count() > 0)
            {
                string[] divisao = tbCodProduct.Text.Split('*');
                string strIdProd, quantidade;

                try
                {
                    quantidade = divisao[0];
                    strIdProd = divisao[1];
                }
                catch (Exception)
                {
                    quantidade = "1";
                    strIdProd = divisao[0];
                }
                tbAmount.Text = quantidade;

                Produto prod = buscarProduto(strIdProd);

                if (prod != null)
                {
                    produtoSelecionado = prod;
                    preencheProduto(prod);
                }
                else
                {
                    Function.Alert("Atenção!", "Código de produto inexistente ou não informado!", popupClient.enmType.Warning);

                    resetarProduto();

                    tbCodProduct.Focus();
                    produtoSelecionado = null;
                }
            }
            else
            {
                tbNameProduct.Text = "";
                produtoSelecionado = null;
            }
        }
        private Produto buscarProduto(string cod)
        {

            if (cod.Count() != 0)
            {
                Produto prod = controlProduct.buscarProdutoPorCod(cod);

                return prod;

            }
            return null;

        }
        private void tbCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)42)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //ENTER
            {
                tbAmount.Focus();
                adicionarProduto(tbAmount.Text);
                dgvProducts.ClearSelection();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                tbAmount.Focus();
                removerProduto();
                dgvProducts.ClearSelection();
            }
        }
        #endregion

        #region AbrirForms
        public void formBuscarVenda()
        {

            FormBuscarVenda f = new FormBuscarVenda();
            f.ShowDialog();

            int idVenda = f.retornaVenda();
            resetarForm();
            if (idVenda != 0)
            {
                btnPesquisarCliente.Visible =
                btnPesquisarProduto.Visible =
                btnCalcularTroco.Visible =
                btnFinalizarVenda.Visible =
                btnDesconto.Visible = false;

                vendaSelecionada = controlVenda.buscarVendaPorCod(idVenda);

                foreach (DataRow prod in controlItensVenda.buscarItensVendaPorIDVenda(vendaSelecionada.Id).Rows)
                {

                    //MessageBox.Show(prod[0].ToString()); //qtde
                    //MessageBox.Show(prod[1].ToString()); //idevenda
                    //MessageBox.Show(prod[2].ToString()); //idprod
                    produtoSelecionado = buscarProduto(prod[2].ToString());
                    adicionarProduto(prod[0].ToString());

                }

                DataTable dtParcelas = controlParcelas.buscarParcelas(vendaSelecionada.Id);

                foreach( DataRow parc in dtParcelas.Rows)
                {
                    DataRow linha = dttParcela.NewRow();
                    
                    char tipoPg = char.Parse(parc["tipo"].ToString());
                    if (tipoPg == 'F')
                        linha["tipo_pagamento"] = "Fiado";
                    else if (tipoPg == 'M')
                        linha["tipo_pagamento"] = "Dinheiro";
                    else if (tipoPg == 'D')
                        linha["tipo_pagamento"] = "Débito";
                    else
                        linha["tipo_pagamento"] = "Crédito";

                    linha["valor"] = double.Parse(parc["valor"].ToString());
                    linha["data"] = DateTime.Parse(parc["data"].ToString());
                    dttParcela.Rows.Add(linha);
                }

                calcularParcelas(dttParcela);

                inserirDesconto(vendaSelecionada.Desconto);

                if (totalDesconto != 0)
                {
                    lblDesconto.Visible = lblTextDesconto.Visible = true;
                    lblDesconto.Text = totalDesconto.ToString("C"); ;
                }
                else
                {
                    lblDesconto.Visible = lblTextDesconto.Visible = false;
                }
                subtotalVenda = toalVenda - totalPago - totalDesconto;
                lblSubtotal.Text = (toalVenda - totalDesconto - totalPago).ToString("C"); ;

                gbProduto.Enabled = gbCliente.Enabled = false;

                int idCLient = vendaSelecionada.Id_cliente;
                if (idCLient != 0)
                {
                    clienteSelecionado = controlCliente.buscarClientePorId(idCLient);
                    tbNameClient.Text = clienteSelecionado.Nome;
                    alterarCpfCnpj(clienteSelecionado.Cpf_cnpj.Count());
                    mtbCpfClient.Text = clienteSelecionado.Cpf_cnpj;
                }

                if (vendaSelecionada.Venda_cancelada) // se venda cancelada
                {
                    lblCancelada.Visible = true;
                    btnCancelarVenda.Text = "F6 - Restaurar Venda";
                }
                else
                {
                    lblCancelada.Visible = false;
                    btnCancelarVenda.Text = "F6 - Cancela Venda";
                }
            }

        }
        public void FormCalcularTroco()
        {
            FormCalcularTroco f = new FormCalcularTroco(toalVenda);
            f.ShowDialog();
        }
        public void formCompensarParcela()
        {


            FormInserirParcelas f = new FormInserirParcelas(toalVenda - totalDesconto, dttParcela, vendaSelecionada == null);
            f.ShowDialog();

            this.dttParcela = f.getLparcela();

            calcularParcelas(dttParcela);

        }
        public void formDesconto()
        {
            FormDesconto f = new FormDesconto(toalVenda);
            f.ShowDialog();



            inserirDesconto(f.getDesconto());

        }
        public void inserirDesconto(double desconto)
        {
            totalDesconto = desconto;
            if (desconto != 0)
            {
                lblDesconto.Visible = lblTextDesconto.Visible = true;
                lblDesconto.Text = desconto.ToString("C"); ;
            }
            else
            {
                lblDesconto.Visible = lblTextDesconto.Visible = false;
            }

            subtotalVenda = toalVenda - totalPago - desconto;
            lblSubtotal.Text = (toalVenda - desconto - totalPago).ToString("C"); ;
        }
        #endregion

        #region Venda
        public void finalizarVenda()
        {
            bool isOk = true;
            bool isFiado = false;

            //tirar o foco do mtbCPF para realizar a busca do cliente caso esteja focado
            tbAmount.Focus();



            /*MessageBox.Show(@"Confirmar venda para o CPF: " +clienteSelecionado.Cpf_cnpj+" ?\n"+
                ", deseja inserir \n" +
                ", deseja inserir \n" +
                ", deseja inserir \n" +
                ", deseja inserir \n" +
                ", deseja inserir \n " +
                ", deseja inserir \n" +
                ", deseja inserir \n" +
                ", deseja inserir \n " +
                ", deseja inserir " +
                ", deseja inserir " +
                "", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);*/


            string cpf = Function.replaceAll(mtbCpfClient.Text);

            if (clienteSelecionado == null)
            {
                foreach (DataRow parcela in dttParcela.Rows)
                {
                    if (parcela["tipo_pagamento"].ToString() == "Fiado")
                    {
                        isFiado = true;
                    }
                }
                if(isFiado)
                {
                    isOk = false;
                    MessageBox.Show("Existem parcelas \"FIADO\", para continuar a venda informe o CPF do cliente.");
                }
                else
                {
                    if (Function.isCpfValid(cpf))
                    {
                        if (MessageBox.Show("Cliente não cadastrado na base de dados, deseja inserir ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (tbNameClient.Text.Count() > 0)
                            {
                                if (controlCliente.SalvarCliete("0", tbNameClient.Text, cpf, "", "", "", "", "", "", "", "", "", DateTime.Now, 'M', 0))
                                {

                                    if (verificarSeClienteExiste(cpf))
                                    {
                                        MessageBox.Show("Cliente salvo OK");
                                    }
                                    else
                                    {
                                        isOk = false;
                                        MessageBox.Show("Erro ao salvar CLiente.");
                                    }
                                }
                                else
                                {
                                    isOk = false;
                                    MessageBox.Show("Erro ao salvar Cliente");

                                }
                            }
                            else
                            {
                                isOk = false;
                                MessageBox.Show("Preencha o nome do cliente para salvar");
                            }

                        }
                    }
                    else
                    {
                        if (cpf.Count() > 0)
                        {
                            MessageBox.Show("CPF do cliente não é valido");
                            isOk = false;
                        }
                    }
                }

            }

            //verificar se existe produtos
            if (dttProduto.Rows.Count == 0)
            {
                isOk = false;
                MessageBox.Show("Não existe produtos cadastrados!");
            }
            else
            {
                //verificar se foi quitado
                if (subtotalVenda != 0)
                {
                    isOk = false;
                    MessageBox.Show("Não foi quitado!");
                }
            }


            if (isOk)
            {
                if (vendaSelecionada == null)
                {
                    if (clienteSelecionado == null)
                    {
                        isOk = controlVenda.SalvarVenda(0, dttParcela, dttProduto, totalDesconto, idCaixa, idFunc);
                    }
                    else
                    {
                        isOk = controlVenda.SalvarVenda(clienteSelecionado.Id, dttParcela, dttProduto, totalDesconto, idCaixa, idFunc);
                    }

                    if (isOk)
                    {
                        Function.Alert("Sucesso!", "Venda finalizada!", popupClient.enmType.Success);

                        resetarForm();
                    }
                    else
                    {
                        Function.Alert("Erro!", "Não foi possivel gravar a venda!", popupClient.enmType.Error);
                    }
                }
                else
                {
                    MessageBox.Show("UPDATE");
                }
            }
            else
            {
                Function.Alert("Erro!", "Não foi possivel gravar a venda!", popupClient.enmType.Error);
            }

        }
        private void CancelarVenda()
        {

            if (vendaSelecionada != null)
            {
                if (true) ///////////////// ver o que vai fazer aq
                //vendaSelecionada.id
                //if (vendaSelecionada.IdCaixa == idCaixa)
                {
                    if (vendaSelecionada.Venda_cancelada) //verdadeiro por ser 1
                    {
                        if (MessageBox.Show("Deseja restaurar a venda selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            controlVenda.restabelecerVenda(vendaSelecionada.Id, dttProduto);
                            resetarForm();
                            Function.Alert("Sucesso!", "Venda restaurada!", popupClient.enmType.Success);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja excluir a venda selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            controlVenda.removerVenda(vendaSelecionada.Id, dttProduto);
                            resetarForm();
                            Function.Alert("Sucesso!", "Venda removida!", popupClient.enmType.Success);
                        }
                    }
                }
                /*else
                {
                    if (MessageBox.Show("Esta venda não pertence a este caixa, deseja excluir a venda selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Deseja inserir o saldo ao cliente ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {

                            controlVenda.removerVenda(vendaSelecionada.Id, dttProduto);
                            resetarForm();
                            Function.Alert("Sucesso!", "Venda removida!", popupClient.enmType.Success);
                        }
                    }
                }*/

            }
            else
            {

                MessageBox.Show("Venda não selecionada!");
            }
        }
        #endregion

        public void alterarValorTotalProduto()
        {

            if (produtoSelecionado != null)
            {
                if (double.TryParse(tbAmount.Text.Replace("R$ ", ""), out double qtde))
                {
                    tbValorTotal.Text = (qtde * produtoSelecionado.Valor).ToString("C");
                }
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

            alterarValorTotalProduto();

        }
    }
}

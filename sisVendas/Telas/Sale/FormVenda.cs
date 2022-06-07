using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Functions;
using sisVendas.Models;

using sisVendas.Screens.Client;
using sisVendas.Screens.Product;
using sisVendas.Telas.Sale;
using System;
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
        //private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();

        private double totalVenda = 0;
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

            iniciarDGV();
        }
        public FormVenda(int idCaixa, int idFunc) : this()
        {
            this.idCaixa = idCaixa;
            this.idFunc = idFunc;
        }
        public void iniciarDGV()
        {
            dttProduto.TableName = "produtos";
            dttProduto.Columns.Add("nome");
            dttProduto.Columns.Add("codigo");
            dttProduto.Columns.Add("quantidade", typeof(double));
            dttProduto.Columns.Add("un");
            dttProduto.Columns.Add("valor_un");
            dttProduto.Columns.Add("valor_total");

            dttProduto.PrimaryKey = new DataColumn[] { dttProduto.Columns["codigo"] };
            dgvProducts.DataSource = dttProduto;

            dttParcela.TableName = "parcelas";
            dttParcela.Columns.Add("valor", typeof(double));
            dttParcela.Columns.Add("tipo_pagamento");
            dttParcela.Columns.Add("data", typeof(DateTime));
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    if (vendaSelecionada == null)
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
            }
            else if (cpf.Count() > 11)
            {
                return true;
            }
            else if (cpf.Count() == 0)
            {
                lblWarningCpf.Visible = false;
                return false;
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

        private void mtbCpfClient_Leave(object sender, EventArgs e)
        {
            string cpf = mtbCpfClient.Text;


            if (verificarSeClienteExiste(cpf))
            {
                tbNameClient.Enabled = false;
                tbCodProduct.Focus();
            }
        }
        public void alterarCpfCnpj(int qtde)
        {
            if (mtbCpfClient.Mask != "000.000.000-00" && qtde <= 11)
            {
                mtbCpfClient.Mask = "000.000.000-00";

                lblCpf.Text = "CPF:";
            }
            else if (mtbCpfClient.Mask != "00.000.000/0000-00" && qtde > 11)
            {
                int pos = mtbCpfClient.Text.Count();
                mtbCpfClient.Mask = "00.000.000/0000-00";

                lblCpf.Text = "CNPJ:";
            }
        }
        public void resetarForm()
        {
            dttParcela.Rows.Clear();
            dttProduto.Rows.Clear();

            totalVenda = 0;
            totalDesconto = 0;
            subtotalVenda = 0;
            totalPago = 0;

            mtbCpfClient.Mask = "000.000.000-00";

            produtoSelecionado = null;
            clienteSelecionado = null;
            vendaSelecionada = null;

            tbAmount.Text = "1";

            tbNameClient.Text =
            tbNameProduct.Text =
            tbCodProduct.Text =
            mtbCpfClient.Text = "";

            lblDesconto.Visible =
            lblCancelada.Visible = 
            lblTextDesconto.Visible = false;
            lblTotal.Text = lblSubtotal.Text = "R$ 0,00";

            gbProduto.Enabled =
            gbCliente.Enabled = true;

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

            subtotalVenda = totalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = subtotalVenda.ToString("C");
        }
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
        private void resetarProduto()
        {
            produtoSelecionado = null;

            tbNameProduct.Text = "";
            tbAmount.Text = "1";
            tbValorTotal.Text = tbValorUn.Text = "";
            tbCodProduct.Text = tbNameProduct.Text = "";
        }
        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
            eventoKeyPressParaAdicionarOuRemoverProduto(e.KeyChar);
        }

        private void eventoKeyPressParaAdicionarOuRemoverProduto(char key)
        {
            if (key == (char)13) // ENTER
            {
                adicionarProduto(tbAmount.Text);
                dgvProducts.ClearSelection();
                tbCodProduct.Focus();
            }
            else if (key == (char)45) // [MENOS]
            {
                //removerProduto();
                dgvProducts.ClearSelection();
                tbCodProduct.Focus();
            }
        }
        private void adicionarProduto(string strQtde)
        {
            //0 - cod;
            //1 - qtde
            string codigoProd = verificarStringCodigo(tbCodProduct.Text, strQtde);
            verificarSeProdutoExiste(codigoProd);

            if (double.TryParse(tbAmount.Text, out double qtde))
            {

                //MessageBox.Show(qtde + "Quanditdade");
                //MessageBox.Show(codigoProd + "Codigo");

                if (produtoSelecionado != null)
                {
                    adicionarProdutoDataTable(qtde, produtoSelecionado);
                    resetarProduto();
                }
            }
            else
            {
                Alerta.notificacao("Atenção!", "Quantidade inválida!", Alerta.enmType.Warning);
            }
        }

        private string verificarStringCodigo(string strCodigoProduto, string strQtde)
        {
            string tbCodigoProdutoString = tbCodProduct.Text;
            string CodProd = "0";
            string Qtde;

            if (tbCodigoProdutoString.Count() > 0)
            {
                string[] divisao = tbCodigoProdutoString.Split('*');

                try
                {
                    Qtde = divisao[0];
                    CodProd = divisao[1];
                }
                catch (Exception)
                {
                    Qtde = strQtde;
                    CodProd = divisao[0];
                }
                tbAmount.Text = Qtde;
            }
            else
            {
                resetarProduto();
                produtoSelecionado = null;
            }
            return CodProd;
        }

        private void verificarSeProdutoExiste(string cod)
        {
            Produto prod = null;

            if(cod != "0")
            {
                prod = controlProduct.buscarProdutoPorCod(cod);

                if (prod != null)
                {
                    produtoSelecionado = prod;
                    preencheProduto(prod);
                }
                else
                {
                    resetarProduto();
                    produtoSelecionado = null;

                }
            }
        }
        private void adicionarProdutoDataTable(double quantidade, Produto prod)
        {
            DataRow row = dttProduto.Rows.Find(prod.Id);
            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                DataRow linha = dttProduto.NewRow();

                linha["nome"] = prod.Nome;
                linha["quantidade"] = quantidade;
                linha["valor_un"] = prod.Valor.ToString("C");
                linha["valor_total"] = (prod.Valor * quantidade).ToString("C");
                linha["un"] = prod.Un;
                linha["codigo"] = prod.Id;

                dttProduto.Rows.Add(linha);
                //dgvProducts.DataSource = dttProduto;
            }
            else //caso ja exista no dt
            {
                double vTotal = Convert.ToDouble(dttProduto.Rows[index]["quantidade"]) * Convert.ToDouble(row["valor_un"].ToString().Replace("R$", ""));

                dttProduto.Rows[index]["quantidade"] = Convert.ToDouble(row["quantidade"]) + Convert.ToDouble(quantidade);
                dttProduto.Rows[index]["valor_total"] = vTotal.ToString("C");
            }

            
            //atualizar total
            totalVenda = totalVenda + (Convert.ToDouble(prod.Valor) * Convert.ToDouble(quantidade));

            subtotalVenda = totalVenda - totalPago - totalDesconto;

            lblTotal.Text = totalVenda.ToString("C"); ;
            lblSubtotal.Text = subtotalVenda.ToString("C");

            //posicionar ultima linha
            dgvProducts.FirstDisplayedScrollingRowIndex = dgvProducts.RowCount - 1;

            tbCodProduct.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
            {
                MessageBox.Show("É NULL");
            }
        }

        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            string codigoProd = verificarStringCodigo(tbCodProduct.Text, tbAmount.Text);
            verificarSeProdutoExiste(codigoProd);
        }

        private void tbCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventoKeyPressParaAdicionarOuRemoverProduto(e.KeyChar);
        }
        public void FormCalcularTroco()
        {
            FormCalcularTroco f = new FormCalcularTroco(totalVenda);
            f.ShowDialog();
        }

        public void formCompensarParcela()
        {
            double saldo = 0;
            if (clienteSelecionado != null)
                saldo = clienteSelecionado.Saldo;

            FormInserirParcelas f = new FormInserirParcelas(totalVenda - totalDesconto, dttParcela, vendaSelecionada == null, saldo);
            f.ShowDialog();

            this.dttParcela = f.getLparcela();

            calcularParcelas(dttParcela);
        }
        public void formDesconto()
        {
            FormDesconto f = new FormDesconto(totalVenda);
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

            subtotalVenda = totalVenda - totalPago - desconto;
            lblSubtotal.Text = (totalVenda - desconto - totalPago).ToString("C");
        }
        public void finalizarVenda()
        {
            bool isOk = true;
            bool isFiado = false;

            //tirar o foco do mtbCPF para realizar a busca do cliente caso esteja focado
            tbAmount.Focus();

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
                if (isFiado)
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
                        Alerta.notificacao("Sucesso!", "Venda finalizada!", Alerta.enmType.Success);

                        resetarForm();
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Não foi possivel gravar a venda!", Alerta.enmType.Error);
                    }
                }
                else
                {
                    //MessageBox.Show("UPDATE");
                }
            }
            else
            {
                Alerta.notificacao("Erro!", "Não foi possivel gravar a venda!", Alerta.enmType.Error);
            }
        }

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

                DataTable dt = controlItensVenda.buscarItensVendaPorIDVenda(idVenda);

                if (dt.Rows.Count > 0)
                {
                    produtoSelecionado = new Produto();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        produtoSelecionado.Valor = Convert.ToDouble(dt.Rows[i]["iten_valor"]);
                        produtoSelecionado.Nome = dt.Rows[i]["prod_nome"].ToString();
                        produtoSelecionado.Un = dt.Rows[i]["prod_un"].ToString();
                        produtoSelecionado.Id = dt.Rows[i]["iten_idProduto"].ToString();
                        int qtde = Convert.ToInt32(dt.Rows[i]["iten_quantidade"]);

                        adicionarProdutoDataTable(qtde, produtoSelecionado);

                    }
                }

                DataTable dtParcelas = vendaSelecionada.ParcelasVenda;

                foreach (DataRow parc in dtParcelas.Rows)
                {
                    DataRow linha = dttParcela.NewRow();

                    char tipoPg = char.Parse(parc["tipo"].ToString());
                    if (tipoPg == 'F')
                        linha["tipo_pagamento"] = "Fiado";
                    else if (tipoPg == 'M')
                        linha["tipo_pagamento"] = "Dinheiro";
                    else if (tipoPg == 'D')
                        linha["tipo_pagamento"] = "Débito";
                    else if (tipoPg == 'S')
                        linha["tipo_pagamento"] = "Saldo";
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
                subtotalVenda = totalVenda - totalPago - totalDesconto;
                lblSubtotal.Text = (totalVenda - totalDesconto - totalPago).ToString("C"); ;

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
                    btnCancelarVenda.Visible = false;
                    lblCancelada.Visible = true;
                    //btnCancelarVenda.Text = "F6 - Restaurar Venda";
                }
                else
                {
                    btnCancelarVenda.Visible = true;
                    lblCancelada.Visible = false;
                    //btnCancelarVenda.Text = "F6 - Cancela Venda";
                }
            }
        }

        private void CancelarVenda()
        {
            if (vendaSelecionada != null)
            {
                int vendaSelecionadaIdCaixa = controlVenda.verificarMesmoCaixa(vendaSelecionada.Id);
                if (vendaSelecionadaIdCaixa == idCaixa)
                {
                    if (MessageBox.Show("Deseja excluir a compra selecionada ?\n\nAo confirmar a exclusão, não será possivel restaurar a compra!", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (controlVenda.exclusaoFisicaDaVeda(vendaSelecionada.Id, dttProduto))
                        {
                            resetarForm();
                        }
                    }
                    // exclusao TOTAL da venda
                    // remover do banco de dados
                }
                else
                {
                    //MessageBox.Show("A venda não foi realizada no caixa atual!", "Não é possivel excluir a venda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FormExcluirVendaSaldoDoPagamento f = new FormExcluirVendaSaldoDoPagamento();
                    //f.ShowDialog();
                }

            }
            else
            {

                MessageBox.Show("Selecione uma venda para continuar!", "Venda não selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

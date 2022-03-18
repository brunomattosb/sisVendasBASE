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
        private Cliente clienteSelecionado;
        private Produto produtoSelecionado;
        private VendaCompleta vendaSelecionada;

        private ctrlClient controlCliente = new ctrlClient();
        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlVenda controlVenda = new ctrlVenda();
        private ctrlItensVenda controlItensVenda = new ctrlItensVenda();
        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();

        private int itemCoupon = 1;

        private double toalVenda = 0;
        private double totalDesconto = 0;
        private double subtotalVenda = 0;
        private double totalPago = 0;

        DataTable dtParcelas = new DataTable();
        DataTable dtProducts = new DataTable();
        public FormVenda()
        {
            InitializeComponent();

            initDataGridView();

            inserirCabecalhoBobina();
        }

        #region Hotkeys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    abrirFormularioCliente();
                    break;
                case Keys.F2:
                    abrirFormProduto();
                    break;
                case Keys.F5:
                    abrirFormBuscarVenda();
                    break;
                case Keys.F9:
                    abrirFormCalcularTroco();
                    break;
                case Keys.F10:
                    abrirFormCalcularVenda();
                    break;
                case Keys.F11:
                    abrirFormDesconto();
                    break;
                case Keys.F12:
                    finalizarVenda();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Init
        public void initDataGridView()
        {
            dtProducts.TableName = "products";
            dtProducts.Columns.Add("name");
            dtProducts.Columns.Add("cod");
            dtProducts.Columns.Add("amount", typeof(double));
            dtProducts.Columns.Add("un");
            dtProducts.Columns.Add("valueun");
            dtProducts.Columns.Add("valuetotal");

            dtProducts.PrimaryKey = new DataColumn[] { dtProducts.Columns["name"] };
            dgvProducts.DataSource = dtProducts;

            dtParcelas.TableName = "parcelas";
            dtParcelas.Columns.Add("valor", typeof(double));
            dtParcelas.Columns.Add("tipo");
            dtParcelas.Columns.Add("data");
        }
        #endregion

        #region Client
        private void mtbCpfClient_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfClient.Text).Length == 0)
                mtbCpfClient.Select(0, 0);
        }
        public void abrirFormularioCliente()
        {
            FormBuscarCliente f = new FormBuscarCliente();
            f.ShowDialog();

            clienteSelecionado = f.returnClient();

            if (clienteSelecionado != null)
            {

                changeCpfCnpj(clienteSelecionado.Cpf_cnpj.Count());

                tbNameClient.Text = clienteSelecionado.Name;
                mtbCpfClient.Text = clienteSelecionado.Cpf_cnpj;
                tbNameClient.Enabled = false;
                lblWarningCpf.Visible = false;
            }
            mtbCpfClient.Focus();
        }
        private void mtbCpfClient_Leave(object sender, EventArgs e)
        {
            if (verificaSeClienteExiste())
            {
                tbNameClient.Enabled = false;
            }
        }

        private bool verificaSeClienteExiste()
        {
            string cpf = Function.replaceAll(mtbCpfClient.Text);

            if (cpf.Count() > 0 && cpf.Count() <= 11)
            {
                if ((Function.isCpfValid(mtbCpfClient.Text)))//&& isValidCpf
                {
                    clienteSelecionado = null;

                    clienteSelecionado = controlCliente.buscarClientePorCpf(cpf);
                    if (clienteSelecionado != null)
                    {
                        mtbCpfClient.Text = clienteSelecionado.Cpf_cnpj.ToString();
                        tbNameClient.Text = clienteSelecionado.Name.ToString();
                        lblWarningCpf.Visible = false;
                        return true;
                    }
                    clienteSelecionado = null;
                    lblWarningCpf.Text = "** CPF não encontrado! será inserido um novo cliente com o CFP e o NOME informado! **";
                }
                else
                {
                    tbNameClient.Text = "";
                    clienteSelecionado = null;
                    lblWarningCpf.Text = "** CPF incorreto **";
                }
                lblWarningCpf.Visible = true;
            }
            else if (cpf.Count() == 14)
            {
                return true;
            }

            return false;
        }
        private void mtbCpfClient_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        #region product
        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            if (tbCodProduct.Text.Count() > 0)
            {
                if (verificarProdutoExiste(tbCodProduct.Text)) // produto encontrado
                {
                    preencheProduto();

                }
                else
                {
                    Function.Alert("Atenção!", "Código de produto inexistente ou não informado!", popupClient.enmType.Warning);

                    limpaProduto();
                    tbCodProduct.Focus();
                }
            }
            else
            {
                tbNameProduct.Text = "";
                produtoSelecionado = null;
            }
        }
        private bool verificarProdutoExiste(string cod)
        {

            if (cod.Count() != 0)
            {
                Produto prod = controlProduct.buscarProdutoPorCod(cod);

                if (prod == null) // não existe
                {
                    produtoSelecionado = null;
                    return false;
                }
                else //existe
                {
                    produtoSelecionado = prod;
                    return true;
                }
            }
            else
            {
                produtoSelecionado = null;
                return false;
            }
        }
        private void preencheProduto()
        {
            tbNameProduct.Text = produtoSelecionado.Name;

            tbCodProduct.Text = produtoSelecionado.Id.ToString();
        }
        private void limpaProduto()
        {
            produtoSelecionado = null;
            tbCodProduct.Text = tbNameProduct.Text = "";
        }
        public void abrirFormProduto()
        {
            FormBuscarProduto f = new FormBuscarProduto();
            f.ShowDialog();


            produtoSelecionado = f.returnProduto();

            if (produtoSelecionado != null)
            {
                preencheProduto();
            }
            else
            {
                limpaProduto();
            }
            tbAmount.Focus();
        }


        private void tbCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // ENTER
            {
                if (verificarProdutoExiste(tbCodProduct.Text))
                {
                    addProduct(tbAmount.Text);

                }
                else
                {
                    Function.Alert("Atenção!", "Código de produto inexistente ou não informado!", popupClient.enmType.Warning);

                    limpaProduto();
                    tbCodProduct.Focus();
                }
                dgvProducts.ClearSelection();
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //ENTER
            {
                addProduct(tbAmount.Text);
                dgvProducts.ClearSelection();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                removeProduct();
                dgvProducts.ClearSelection();
            }
        }

        private void addProduct(string amount)
        {
            if (amount.Count() > 0)
            {
                if (produtoSelecionado != null && Convert.ToDouble(amount) != 0)
                {
                    //inserirProdutoBobina();
                    addToDataTable(amount);

                    tbAmount.Text = "1";
                }
            }
            else
            {
                Function.Alert("Atenção!", "Quantidade inválida!", popupClient.enmType.Warning);
            }
        }
        private void removeProduct()
        {
            if (produtoSelecionado != null && Convert.ToDouble(tbAmount.Text) != 0)
            {
                removeToDataTable();

            }
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
        #endregion

        #region Print Coil
        public void inserirCabecalhoBobina()
        {
            try
            {
                Bobina.Items.Add(new string('-', 51));
                Bobina.Items.Add("               **     NFC-e     **               ");
                Bobina.Items.Add(new string('-', 51));
                Bobina.Items.Add("ITEM Codigo         Descricao                   ");
                Bobina.Items.Add("QTD.     UN      VL.UNIT.(R$)       VL.ITEM(R$)");
                Bobina.Items.Add(new string('-', 51));
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }
        }
        private void inserirProdutoBobina()
        {
            try
            {
                Bobina.Items.Add(
                new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
                 new string(' ', 43 - produtoSelecionado.Name.Length) + " " + produtoSelecionado.Name.ToString());

                double total = Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text);
                Bobina.Items.Add(
                    new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
                    new string(' ', 3 - 2) + produtoSelecionado.Un + " x " +
                    new string(' ', 10 - produtoSelecionado.Value.ToString().Length) + "R$ " + produtoSelecionado.Value + " " +
                    new string(' ', 5) + new string(' ', 11 - total.ToString().Length) + "R$ " + total
                    );
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }

            //sempre atualiza a seleção no ultimo index;
            Bobina.SelectedIndex = Bobina.Items.Count - 1;
            //contador
            itemCoupon++;

            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }
        private void removerProdutoBobina()
        {
            try
            {
                Bobina.Items.Add(
                new string('0', 3 - Convert.ToString(itemCoupon).Length) + Convert.ToString(itemCoupon) + "  " +
                 new string(' ', 43 - produtoSelecionado.Name.Length) + " " + produtoSelecionado.Name);

                double total = Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text);
                Bobina.Items.Add(
                    new string(' ', 8 - tbAmount.Text.Length) + tbAmount.Text + " " +
                    new string(' ', 3 - 2) + produtoSelecionado.Un + " x " +
                    new string(' ', 9 - produtoSelecionado.Value.ToString().Length) + "R$ " + "-" + produtoSelecionado.Value + " " +
                    new string(' ', 5) + new string(' ', 10 - total.ToString().Length) + "-" + "R$ " + total
                    );
            }
            catch (Exception eError)
            {
                //Log.write(eError.ToString());
            }

            Bobina.SelectedIndex = Bobina.Items.Count - 1;

            itemCoupon++;
            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }
        #endregion

        #region Print DataTable
        private void addToDataTable(string amount)
        {
            string prod_name = produtoSelecionado.Name;

            DataRow row = dtProducts.Rows.Find(prod_name);

            int index = dtProducts.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                DataRow linha = dtProducts.NewRow();

                linha["name"] = produtoSelecionado.Name;
                linha["amount"] = Convert.ToDouble(amount);
                linha["valueun"] = "R$ " + produtoSelecionado.Value;
                linha["valuetotal"] = "R$ " + Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(amount);
                linha["un"] = produtoSelecionado.Un;
                linha["cod"] = produtoSelecionado.Id;

                dtProducts.Rows.Add(linha);
                dgvProducts.DataSource = dtProducts;
            }
            else //caso ja exista no dt
            {

                dtProducts.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) + Convert.ToDouble(amount);
                dtProducts.Rows[index]["valueTotal"] = "R$ " + Convert.ToDouble(dtProducts.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));
            }
            toalVenda = toalVenda + (Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(amount));

            subtotalVenda = toalVenda - totalPago - totalDesconto;

            lblTotal.Text = "R$ " + toalVenda;
            lblSubtotal.Text = "R$ " + subtotalVenda;
        }

        private void removeToDataTable()
        {
            string prod_name = produtoSelecionado.Name;
            DataRow row = dtProducts.Rows.Find(prod_name);
            int index = dtProducts.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                Function.Alert("Atenção!", "Não é possivel remover um produto que não está na compra!", popupClient.enmType.Warning);
            }
            else //caso ja exista no dt
            {

                if (Convert.ToDouble(tbAmount.Text) <= Convert.ToDouble(row["amount"]))
                {
                    removerProdutoBobina();
                    dtProducts.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) - Convert.ToDouble(tbAmount.Text);
                    dtProducts.Rows[index]["valueTotal"] = "R$ " + Convert.ToDouble(dtProducts.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));

                    toalVenda = toalVenda - (Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text));

                    subtotalVenda = toalVenda - totalPago - totalDesconto;
                    lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);
                    lblTotal.Text = "R$ " + (toalVenda);

                    //caso quantidade seja zero
                    if (Convert.ToDouble(dtProducts.Rows[index]["amount"]) == 0)
                    {
                        dtProducts.Rows[index].Delete();
                    }
                }
                else
                    Function.Alert("Atenção!", "Não é possivel deixar a quantidade negativa!", popupClient.enmType.Warning);
            }
        }
        #endregion

        #region Utilitários

        private void timer_sale_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("dd/MM/yyyy");
        }



        #endregion

        #region abrir forms
        public void abrirFormCalcularTroco()
        {
            FormCalcularTroco f = new FormCalcularTroco(toalVenda);
            f.ShowDialog();
        }
        private void calcularParcelas(DataTable dtParcelas)
        {
            totalPago = 0;
            foreach (DataRow parcela in dtParcelas.Rows)
            {
                totalPago += double.Parse(parcela["valor"] + "");
            }
            subtotalVenda = toalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);
        }
        public void abrirFormCalcularVenda()
        {

            FormSimularVenda f = new FormSimularVenda(toalVenda - totalDesconto, dtParcelas);
            f.ShowDialog();

            this.dtParcelas = f.getLparcela();

            calcularParcelas(dtParcelas);

        }
        public void abrirFormDesconto()
        {
            FormDesconto f = new FormDesconto(toalVenda);
            f.ShowDialog();

            totalDesconto = f.getDesconto();

            if (totalDesconto != 0)
            {
                lblDesconto.Visible = lblTextDesconto.Visible = true;
                lblDesconto.Text = "R$ " + (totalDesconto);
            }
            else
            {
                lblDesconto.Visible = lblTextDesconto.Visible = false;
            }
            subtotalVenda = toalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);



        }
        public void abrirFormBuscarVenda()
        {

            FormBuscarVenda f = new FormBuscarVenda();
            f.ShowDialog();

            vendaSelecionada = f.retornaVenda();

            if(vendaSelecionada != null)
            {
                tbNameClient.Text = vendaSelecionada.Cli_name;
                mtbCpfClient.Text = vendaSelecionada.Cli_cpf_cnpj;

                foreach (DataRow prod in controlItensVenda.buscarItensVendaPorIDVenda(vendaSelecionada.Id).Rows)
                {
                    MessageBox.Show(prod[0].ToString() + "id"); //id
                    MessageBox.Show(prod[1].ToString() +"qtde"); //qtde
                    MessageBox.Show(prod[2].ToString() + "idvenda"); //idvenda
                    MessageBox.Show(prod[3].ToString() + "idprod"); //idprod

                    verificarProdutoExiste(prod[3].ToString());
                    addProduct(prod[1].ToString());



                }
                dtParcelas = controlParcelas.buscarParcelas(vendaSelecionada.Id);
                calcularParcelas(dtParcelas);
            }
            
            /*if (totalDesconto != 0)
            {
                lblDesconto.Visible = lblTextDesconto.Visible = true;
                lblDesconto.Text = "R$ " + (totalDesconto);
            }
            else
            {
                lblDesconto.Visible = lblTextDesconto.Visible = false;
            }
            subtotalVenda = toalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);
            */

            
        }
        

        #endregion

        public void finalizarVenda()
        {
            bool isOk = true;
            string cpf = Function.replaceAll(mtbCpfClient.Text);
            
            //tirar o foco do mtbCPF para realizar a busca do cliente caso esteja focado
            if(mtbCpfClient.Focused)
            {
                tbAmount.Focus();
            }

            // validando o cliente
            if(clienteSelecionado == null)
            {
                //Cliente não selecionado

                if (cpf.Count() == 14) // verificar se é CNPJ
                {
                    //é CNPJ
                    MessageBox.Show("É CNPJ");
                }
                else if (Function.isCpfValid(cpf))//verificar se o Cliente é valido
                {   // se for valido vai perguntar se deseja inserir na base de dados
                    if (MessageBox.Show("Cliente não cadastrado na base de dados, deseja inserir ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if(tbNameClient.Text.Count() > 0)
                        {
                            if (controlCliente.SaveClient("0", tbNameClient.Text, cpf, "", "", "", "", "", "", "", "", "", DateTime.MaxValue, 'M', 0))
                            {
                                // inserido
                                if (verificaSeClienteExiste())
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
                                //erro ao inserir
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
                    if(cpf.Count() > 0)
                    {
                        MessageBox.Show("CPF do cliente não é valido");
                        isOk = false;
                    }
                    else
                    {
                        MessageBox.Show("Venda sem CPF");
                        //clienteSelecionado = new Cliente();
                    }
                }
                
            }
            else
            {


                MessageBox.Show("Cliente existente");

            }
            


            //verificar se existe produtos
            if (dtProducts.Rows.Count == 0)
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
                if(clienteSelecionado == null)
                {
                    isOk = controlVenda.SalvarVenda(0, dtParcelas, dtProducts, totalDesconto);
                }
                else
                {
                    isOk = controlVenda.SalvarVenda(clienteSelecionado.Id, dtParcelas, dtProducts, totalDesconto);
                }
                if (isOk)
                {
                    MessageBox.Show("O cliente foi salvo! agora sera apagado tudo");
                    dtParcelas.Rows.Clear();
                    dtProducts.Rows.Clear();
                    toalVenda = 0;
                    totalDesconto = 0;
                    subtotalVenda = 0;
                    totalPago = 0;

                    produtoSelecionado = null;
                    clienteSelecionado = null;
                    tbAmount.Text = "1";
                    tbNameClient.Text = tbNameProduct.Text = tbCodProduct.Text = mtbCpfClient.Text = "";
                    lblDesconto.Visible = lblTextDesconto.Visible = false;
                    lblTotal.Text = lblSubtotal.Text = "R$: ";
                     
                }
                
            }
            else
            {
                MessageBox.Show("FALSE");
            }

        }
        public void changeCpfCnpj(int qtde)
        {
            if (mtbCpfClient.Mask != "000.000.000-00" && qtde <= 11)
            {
                mtbCpfClient.Mask = "000.000.000-00";

                //mtbCpfClient.Select(qtde, 0);
                lblCpf.Text = "*CPF:";
            }
            else if (mtbCpfClient.Mask != "00.000.000/0000-00" && qtde > 11)
            {
                int pos = mtbCpfClient.Text.Count();
                mtbCpfClient.Mask = "00.000.000/0000-00";
                //mtbCpfClient.Select(pos, 0);

                lblCpf.Text = "*CNPJ:";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
                MessageBox.Show("é null");
        }

        private void mtbCpfClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (Function.replaceAll(mtbCpfClient.Text).Count() == 13)
                {
                    mtbCpfClient.Text = "";
                    tbNameClient.Text = "";

                    changeCpfCnpj(11);
                    mtbCpfClient.Focus();
                    tbNameClient.Enabled = true;
                    clienteSelecionado = null;
                }
                else if (clienteSelecionado != null)
                {
                    tbNameClient.Text = "";
                    tbNameClient.Enabled = true;
                    clienteSelecionado = null;
                }
            }
        }
    }
}

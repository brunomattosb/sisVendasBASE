using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using sisVendas.Screens.Client;
using sisVendas.Screens.Product;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    public partial class FormVenda : Form
    {
        private Cliente clienteSelecionado;
        private Produto produtoSelecionado;
        
        private ctrlClient controlCliente = new ctrlClient();
        private ctrlProduct controlProduct = new ctrlProduct();

        private int itemCoupon = 1;
        private double toalVenda = 0;
        //private double totalOffset = 0;
        //private double totalDiscount = 0;


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
                case Keys.F9:
                    abrirFormCalcularTroco();
                    break;
                case Keys.F10:
                    abrirFormCalcularVenda();
                    break;
                case Keys.F11:
                    abrirFormFormaPagamento();
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
            dtProducts.Columns.Add("valueun", typeof(double));
            dtProducts.Columns.Add("valuetotal", typeof(double));

            dtProducts.PrimaryKey = new DataColumn[] { dtProducts.Columns["name"] };
            dgvProducts.DataSource = dtProducts;
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
                tbNameClient.Text = clienteSelecionado.Name;
                mtbCpfClient.Text = clienteSelecionado.Cpf_cnpj;
                lblWarningCpf.Visible = false;
            }
            tbNameClient.Focus();
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

            if (cpf.Count() >= 1)
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
            else
            {
                tbNameClient.Text = "";
                clienteSelecionado = null;
                lblWarningCpf.Visible = false;
            }
            return false;
        }
        private void mtbCpfClient_Enter(object sender, EventArgs e)
        {
            clienteSelecionado = null;
            tbNameClient.Text = "";
            tbNameClient.Enabled = true;
        }
        #endregion

        #region product
        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            if(tbCodProduct.Text.Count() > 0)
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
                    addProduct();

                }
                else
                {
                    Function.Alert("Atenção!", "Código de produto inexistente ou não informado!", popupClient.enmType.Warning);

                    limpaProduto();
                    tbCodProduct.Focus();
                }
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
                addProduct();
            }
            if (e.KeyChar == (char)45) // [MENOS]
            {
                removeProduct();
            }
        }

        private void addProduct()
        {
            if (tbAmount.Text.Count() > 0)
            {
                if (produtoSelecionado != null && Convert.ToDouble(tbAmount.Text) != 0)
                {
                    inserirProdutoBobina();
                    addToDataTable();
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
                /*
                produtoSelecionado = controlProduct.buscarProdutoPorCod()


                    tbCod.Text = linha[0].Value.ToString();

                if (dgv_client.SelectedRows.Count == 1)
                {


                    activeForm();
                    DataGridViewCellCollection linha = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells;

                    fillForm(linha);

                    btnRemove.Enabled = true;
                    mtbCpf.Enabled = false;
                }*/
                //clientSelected = ;
                //Close();
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
                    new string(' ', 3 - 2) + "UN" + " x " +
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
                    new string(' ', 3 - 2) + "UN" + " x " +
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
        private void addToDataTable()
        {
            string prod_name = produtoSelecionado.Name;

            DataRow row = dtProducts.Rows.Find(prod_name);

            int index = dtProducts.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                DataRow linha = dtProducts.NewRow();

                linha["name"] = produtoSelecionado.Name;
                linha["amount"] = Convert.ToDouble(tbAmount.Text);
                linha["valueun"] = produtoSelecionado.Value;
                linha["valuetotal"] = Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text);
                linha["un"] = "UN";
                linha["cod"] = produtoSelecionado.Id;

                dtProducts.Rows.Add(linha);
                dgvProducts.DataSource = dtProducts;
            }
            else //caso ja exista no dt
            {
                dtProducts.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) + Convert.ToDouble(tbAmount.Text);
                dtProducts.Rows[index]["valueTotal"] = Convert.ToDouble(dtProducts.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"]);
            }
            toalVenda = toalVenda + (Convert.ToDouble(produtoSelecionado.Value) * Convert.ToDouble(tbAmount.Text));
            lblTotal.Text = "R$ " + toalVenda;
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
                    dtProducts.Rows[index]["valueTotal"] = Convert.ToDouble(row["valueun"]) * Convert.ToDouble(dtProducts.Rows[index]["amount"]);

                    toalVenda = toalVenda - (Convert.ToDouble(row["valueun"]) * Convert.ToDouble(tbAmount.Text));
                    lblTotal.Text = "R$ " + toalVenda;

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

        #region abrir rorms
        public void abrirFormCalcularTroco()
        {
            FormCalcularTroco f = new FormCalcularTroco(toalVenda);
            f.ShowDialog();
        }
        public void abrirFormCalcularVenda()
        {
            FormSimularVenda f = new FormSimularVenda(toalVenda);
            f.ShowDialog();
        }
        public void abrirFormFormaPagamento()
        {
            FormFormaPagamento f = new FormFormaPagamento();
            f.ShowDialog();


            /*produtoSelecionado = f.returnProduto();

            if (produtoSelecionado != null)
            {
                preencheProduto();
            }
            else
            {
                limpaProduto();
            }
            tbAmount.Focus();*/
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
                MessageBox.Show("Produto é null!");
        }

        
    }
}

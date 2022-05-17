using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using sisVendas.Screens.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Promocao
{
    public partial class FormRegistrarPromocao : Form
    {
        Produto produtoSelecionado;
        int idFunc;
        DataTable dttProduto = new DataTable();
        DataTable dttPromocao = new DataTable();
        ctrlProduct controlProduto = new ctrlProduct();
        ctrlPromocao controlPromocao = new ctrlPromocao();
        //Promocao promocaoSelecionada = new Promocao();

        public FormRegistrarPromocao()
        {
            InitializeComponent();

            

            dttProduto.TableName = "products";
            dttProduto.Columns.Add("nome");
            dttProduto.Columns.Add("cod");
            dttProduto.Columns.Add("quantidade", typeof(double));
            dttProduto.Columns.Add("valor");
            dgv_produtos.Columns["valor"].DefaultCellStyle.Format = "C";
            dttProduto.PrimaryKey = new DataColumn[] { dttProduto.Columns["nome"] };

            dgv_produtos.DataSource = dttProduto;

            updateDGVPromocao("");
        }
        public FormRegistrarPromocao(int idFunc) : this()
        {
            this.idFunc = idFunc;
        }


        private void updateDGVPromocao(string filtro)
        {
            // promocao
            dttPromocao = controlPromocao.Buscar(filtro);
            dgvPromocao.DataSource = dttPromocao;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F2:
                    //if (promocaoSelecionada == null)
                        formProduto();
                    break;
               
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                dgv_produtos.ClearSelection();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                tbAmount.Focus();
                removerProduto();
                dgv_produtos.ClearSelection();
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

                if (Convert.ToDouble(tbAmount.Text) <= Convert.ToDouble(row["quantidade"]))
                {
                    double vTotal = Convert.ToDouble(dttProduto.Rows[index]["quantidade"]) * Convert.ToDouble(row["valor"].ToString().Replace("R$", ""));
                    dttProduto.Rows[index]["quantidade"] = Convert.ToDouble(row["quantidade"]) - Convert.ToDouble(tbAmount.Text);
                    dttProduto.Rows[index]["valor"] = vTotal.ToString("C");

                    //alterar totais
                    //toalVenda = toalVenda - (Convert.ToDouble(produtoSelecionado.Valor) * Convert.ToDouble(tbAmount.Text));
                    //subtotalVenda = toalVenda - totalPago - totalDesconto;
                    //lblSubtotal.Text = "R$ " + (toalVenda - totalDesconto - totalPago);
                    //lblTotal.Text = toalVenda.ToString("C");

                    //caso quantidade seja zero
                    if (Convert.ToDouble(dttProduto.Rows[index]["quantidade"]) == 0)
                    {
                        dttProduto.Rows[index].Delete();
                    }
                }
                else
                    Function.Alert("Atenção!", "Não é possivel deixar a quantidade negativa!", popupClient.enmType.Warning);
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
                Produto prod = controlProduto.buscarProdutoPorCod(cod);

                return prod;

            }
            return null;

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
                dgv_produtos.ClearSelection();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                removerProduto();
                dgv_produtos.ClearSelection();
            }
        }

        private void tbValorUn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
            
        }

        private void tbValorUn_Click(object sender, EventArgs e)
        {
            if (tbValorUn.Text == "R$ 0,00")
            {
                tbValorUn.Text = "";
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

                linha["nome"] = prod.Nome;
                linha["quantidade"] = amount;
                linha["valor"] = prod.Valor.ToString("C");
                linha["cod"] = prod.Id;

                dttProduto.Rows.Add(linha);
                dgv_produtos.DataSource = dttProduto;
            }
            else //caso ja exista no dt
            {
                double vTotal = Convert.ToDouble(dttProduto.Rows[index]["quantidade"]) * Convert.ToDouble(row["valor"].ToString().Replace("R$", ""));

                dttProduto.Rows[index]["quantidade"] = Convert.ToDouble(row["quantidade"]) + Convert.ToDouble(amount);
                dttProduto.Rows[index]["valor"] = vTotal.ToString("C");
            }


            //atualizar total

            //toalVenda = toalVenda + (Convert.ToDouble(prod.Valor) * Convert.ToDouble(amount));

            //subtotalVenda = toalVenda - totalPago - totalDesconto;

            //posicionar ultima linha
            dgv_produtos.FirstDisplayedScrollingRowIndex = dgv_produtos.RowCount - 1;
            //dgvProducts.CurrentCell = dgvProducts(0, dgvProducts.RowCount - 1)
        }
        private void preencheProduto(Produto prod)
        {

            tbNameProduct.Text = prod.Nome;
            tbCodProduct.Text = prod.Id.ToString();
            tbValorUn.Text = prod.Valor.ToString("C");

        }
        
        private void resetarProduto()
        {
            produtoSelecionado = null;

            tbNameProduct.Text = "";
            tbAmount.Text = "1";
            //tbValorTotal.Text = tbValorUn.Text = "";
            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if(dtpInicio.Value > dtpFim.Value)
            {
                MessageBox.Show("Data inicio maior que data final!");
                isOk = false;
            }   

            if(tbNomePromo.Text.Count() == 0)
            {
                MessageBox.Show("Insira um nome para promoção!");
                isOk = false;
            }

            if (isOk)
            {
                //controlPromocao.SalvarPromocao(dttProduto, dtpInicio.Value, dtpFim.Value, tbNameProduct.Text, idFunc);
            }
        }
    }
}

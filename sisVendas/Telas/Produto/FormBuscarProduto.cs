using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Screens.Product
{
    public partial class FormBuscarProduto : Form
    {
        private ctrlProduct controlProduct = new ctrlProduct();
        private DataRow produtoSelecionado;
        private DataTable dttProduct;
        public FormBuscarProduto()
        {
            InitializeComponent();
            updateDgv("");
            tbSearth.Focus();
        }
        private void updateDgv(string filtro)
        {
            dttProduct = controlProduct.searthProduct(filtro);
            dgv_product.DataSource = dttProduct;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    selectProduct();
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbSearth_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearth.Text);
        }

        private void dgv_product_DoubleClick(object sender, EventArgs e)
        {
            selectProduct();
        }
        private void selectProduct()
        {
            if (dgv_product.CurrentRow != null)
            {
                produtoSelecionado = dttProduct.Rows[dgv_product.CurrentRow.Index];
                Close();
            }

        }
        internal Produto returnProduto()
        {
            if(produtoSelecionado != null)
            {
                return controlProduct.buscarProdutoPorCod(produtoSelecionado["prod_id"].ToString());
            }
            else
            {
                return null;
            }
            
        }
    }
}

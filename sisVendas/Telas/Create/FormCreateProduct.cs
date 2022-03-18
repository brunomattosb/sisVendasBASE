using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCreateProduct : Form
    {
        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlProductBrand controlProdBrand = new ctrlProductBrand();
        private ctrlProductCategory controlProdCategory = new ctrlProductCategory();

        private DataTable dtBrand;
        private DataTable dtCategory;
        public FormCreateProduct()
        {
            InitializeComponent();
            neutralForm();

            dtBrand = controlProdBrand.searthProductBrand("");
            dtCategory = controlProdCategory.searthProductCategory("");
            updateCbb(dtBrand, dtCategory);

            updateDgv("");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Control | Keys.Enter:
                    //Verificar se existe para evitar erro de cadastrar CPF já existente.
                    //if (!())
                    //    btnSave.PerformClick();
                    break;
                case Keys.Control | Keys.E:
                    btnCancel.PerformClick();
                    break;
                case Keys.Control | Keys.N:
                    btnNew.PerformClick();
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void updateDgv(string filtro)
        {
            dgv_product.DataSource = controlProduct.searthProduct(filtro);
        }
        public void updateCbb(DataTable dtBrand, DataTable dtCategory)
        {

            cbbBrand.DataSource = dtBrand;
            cbbBrand.DisplayMember = "prodBrand_name";
            cbbBrand.ValueMember = "prodBrand_id";
            cbbBrand.SelectedIndex = -1;

            cbbCategory.DataSource = dtCategory;
            cbbCategory.DisplayMember = "prodCategory_name";
            cbbCategory.ValueMember = "prodCategory_id";
            cbbCategory.SelectedIndex = -1;

        }

        public void cleanForm()
        {
            tbCod.Text=
            tbName.Text =
            tbInventory.Text =
            cbbBrand.Text =
            cbbCategory.Text =
            mtbValue.Text =
            tbComplemento.Text = "";

            cbbCategory.SelectedIndex = -1;
            cbbBrand.SelectedIndex = -1;
            cbbUn.SelectedIndex = -1;
        }
        public void neutralForm()
        {
            
            cleanForm();
            resetColor();
            tbName.Enabled =
            cbbUn.Enabled =
            tbInventory.Enabled = 
            cbbBrand.Enabled = 
            cbbCategory.Enabled = 
            mtbValue.Enabled = 
            tbComplemento.Enabled =
            tbCod.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            btnNew.Enabled = true;


            tbSearch.Focus();
        }
        public void activeForm()
        {
            
            cleanForm();
            resetColor();
            tbName.Enabled =
            cbbUn.Enabled =
            tbInventory.Enabled =
            cbbBrand.Enabled =
            cbbCategory.Enabled =
            mtbValue.Enabled =
            
            tbComplemento.Enabled = true;


            btnNew.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cbbBrand.SelectedIndex = -1;
            cbbCategory.SelectedIndex = -1;
        }
        public void resetColor()
        {
            lblValue.ForeColor =
            lblNome.ForeColor =
            lblMarca.ForeColor =
            lblFuncionario.ForeColor =
            lblEstoque.ForeColor =
            lblComplemento.ForeColor =
            lblCod.ForeColor =
            lblUn.ForeColor =
            lblCategoria.ForeColor = Color.Black;
            

        }
        private void fillForm(DataGridViewCellCollection linha)
        {

            //tbCod.Text = linha[0].Value.ToString();
            //tbName.Text = linha[1].Value.ToString();
            //tbComplemento.Text = linha[2].Value.ToString();
            //cbbUn.Text = (linha[3].Value.ToString());

            //tbInventory.Text = linha[3].Value.ToString();

            //cbbCategory.SelectedIndex = Convert.ToInt32(linha[4].Value);
            //cbbBrand.SelectedValue = Convert.ToInt32(linha[5].Value);

            //
            tbCod.Text = linha[0].Value.ToString();
            tbName.Text = linha[1].Value.ToString();
            tbComplemento.Text = linha[2].Value.ToString();
            cbbUn.Text = (linha[3].Value.ToString());
            tbInventory.Text = linha[4].Value.ToString();
            cbbCategory.SelectedValue = Convert.ToInt32(linha[5].Value);
            cbbBrand.SelectedValue = Convert.ToInt32(linha[6].Value);
            mtbValue.Text = "R$ "+linha[7].Value.ToString();
            


            //cbbSexo.SelectedIndex = cbbSexo.FindString(linha["pac_sexo"].ToString());
            // --------------------------------------------------------------------


            resetColor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            resetColor();
            bool isOk = true;

            if(tbCod.Text.Count() == 0)
            {
                lblCod.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbName.Text.Count() == 0)
            {
                lblNome.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbInventory.Text.Count() == 0)
            {
                lblEstoque.ForeColor = Color.Red;
                isOk = false;
            }
            if (cbbBrand.SelectedIndex == -1)
            {
                lblMarca.ForeColor = Color.Red;
                isOk = false;
            }
            if (cbbUn.SelectedIndex == -1)
            {
                lblUn.ForeColor = Color.Red;
                isOk = false;
            }
            if (cbbCategory.SelectedIndex == -1)
            {
                lblCategoria.ForeColor = Color.Red;
                isOk = false;
            }
            if (mtbValue.Text.ToString().Replace("R$", "").Count() == 0)
            {
                lblValue.ForeColor = Color.Red;
                isOk = false;
            }

            
            if (isOk)
            {

                if (controlProduct.SaveProduct(

                    tbCod.Text,
                    tbName.Text,
                    tbComplemento.Text, 
                    Convert.ToInt32(tbInventory.Text),
                    Convert.ToInt32(cbbCategory.SelectedValue),
                    Convert.ToInt32(cbbBrand.SelectedValue),
                    Convert.ToDouble(mtbValue.Text.Replace("R$", "")),
                    cbbUn.Text.ToString()
                    ))
                {

                    Function.Alert("Sucesso!", "Produto salvo.", popupClient.enmType.Success);

                    updateDgv("");
                    activeForm();
                    tbCod.Focus();
                }
            }
            else
            {
                
                //Function.Alert("Erro!", "Erro ao salvar Produto.", popupClient.enmType.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            activeForm();
            tbCod.Enabled = true;
            tbCod.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            neutralForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCod.Text != "")
            {
                if (MessageBox.Show("Deseja excluir o cliente selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string cod = tbCod.Text;

                    if (controlProduct.removeProduct(cod) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Function.Alert("Sucesso!", "Cliente excluido.", popupClient.enmType.Success);
                    }
                    else
                    {
                        Function.Alert("Erro!", "Erro ao excluir cliente.", popupClient.enmType.Error);

                    }
                }
            }
            else
                MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK);
        }

        private void dgv_productCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_product.SelectedRows.Count == 1)
            {
                activeForm();

                DataGridViewCellCollection linha = dgv_product.Rows[dgv_product.CurrentRow.Index].Cells;

                fillForm(linha);
                tbCod.Enabled = false;
                btnRemove.Enabled = true;
            }
        }

        private void tbInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mtbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void mtbValue_Leave(object sender, EventArgs e)
        {
            string text = mtbValue.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
                mtbValue.Text = String.Format("{0:c}", res);
            else
            {
                mtbValue.Text = "";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }
        private Produto isExistsCod(string cod)
        {
            Produto dt = controlProduct.buscarProdutoPorCod(cod);

            return dt;

        }
        private void tbCod_Leave(object sender, EventArgs e)
        {

            string cod = tbCod.Text;
            
            if(cod.Count() != 0)
            {
                Produto prod = isExistsCod(cod);

                if (prod  != null)
                {
                    if (MessageBox.Show("Deseja alterar o produto com o código inserido ?", "Código existente!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        resetColor();
                        tbCod.Text = prod.Id.ToString();
                        tbName.Text = prod.Name;
                        tbComplemento.Text = prod.Complement;
                        tbInventory.Text = prod.Inventory.ToString();
                        cbbBrand.SelectedValue = prod.Prod_brand;
                        cbbCategory.SelectedValue = prod.Prod_category;
                        cbbUn.SelectedValue = prod.Un;
                        mtbValue.Text = prod.Value.ToString();
                        tbCod.Enabled = false;
                    }
                    else
                    {
                        activeForm();
                        tbCod.Focus();
                    }
                }
            }
            
            



            
        }
    }
}

using sisVendas.Controllers;
using sisVendas.Funcoes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCreateProductCategory : Form
    {
		private ctrlProdutoCategoria controlProductCategory = new ctrlProdutoCategoria();

		private ctrlProduct controlProduct = new ctrlProduct();
		public FormCreateProductCategory()
        {
            InitializeComponent();
            neutralForm();

            updateDgv("");
        }
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F12:
                    btnSave.PerformClick();
                    break;
                case Keys.F4:
                    btnCancel.PerformClick();
                    break;
                case Keys.F1:
                    btnNew.PerformClick();
                    break;
                case Keys.F2:
                    btnRemove.PerformClick();
                    break;


            }
			return base.ProcessCmdKey(ref msg, keyData);
		}
		public void cleanForm()
		{
			tbName.Text =

			tbId.Text = "";

		}
		public void neutralForm()
		{
			cleanForm();

			tbName.Enabled = false;


			btnSave.Enabled = false;
			btnCancel.Enabled = false;
			btnRemove.Enabled = false;
			btnNew.Enabled = true;


			tbSearch.Focus();
		}
		public void activeForm()
		{
			cleanForm();
			tbName.Enabled = true;

			btnNew.Enabled = false;
			btnRemove.Enabled = false;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			tbName.Focus();
		}
		private void fillForm(DataGridViewCellCollection linha)
		{
			tbId.Text = linha[0].Value.ToString();
			tbName.Text = linha[1].Value.ToString();
		}
		private bool isExistsProductCategory()
		{
            string name = Function.replaceAll(tbName.Text);

            if (name.Count() > 0)
            {
                DataTable dt = controlProductCategory.Buscar(name);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            return false;
		}

		public void updateDgv(string filtro)
		{
			dgv_ProductCategory.DataSource = controlProductCategory.Buscar(filtro);
		}

		public void resetColor()
		{
			lblName.ForeColor = Color.Black;
		}
		private void btnSave_Click(object sender, EventArgs e)
        {
            resetColor();

            bool isOk = true;
            if (tbName.Text.Count() < 2)
            {
                isOk = false;
                lblName.ForeColor = Color.Red;
            }
            else
            {
                if (isExistsProductCategory())
                {
                    if (MessageBox.Show("Existe uma categoria muito semelhante a que deseja inserir, deseja continuar ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        isOk = false;
                    }
                }
                if (isOk)
                {
                    if (controlProductCategory.SalvarCategoriaProduto(
                        tbId.Text,
                        tbName.Text

                        ))
                    {

                        Alerta.notificacao("Sucesso!", "Categoria salva.", Alerta.enmType.Success);

                        updateDgv("");
                        activeForm();
                    }
                    tbName.Focus();
                }
                else
                {
                    Alerta.notificacao("Erro!", "Erro ao salvar categoria.", Alerta.enmType.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (tbId.Text != "")
            {
                if (MessageBox.Show("Deseja excluir a categoria de produto ? ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string cod = tbId.Text;

                    if (controlProductCategory.Remover(cod) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Alerta.notificacao("Sucesso!", "Categoria excluida.", Alerta.enmType.Success);
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Erro ao excluir categoria.", Alerta.enmType.Error);

                    }
                }
            }
            else
                MessageBox.Show("Selecione a categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
			neutralForm();
			resetColor();
		}

        private void btnNew_Click(object sender, EventArgs e)
        {
			activeForm();
		}

        private void dgv_ProductCategory_DoubleClick(object sender, EventArgs e)
        {
			if (dgv_ProductCategory.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_ProductCategory.Rows[dgv_ProductCategory.CurrentRow.Index].Cells;

				fillForm(linha);

				btnRemove.Enabled = true;
			}
		}

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
			updateDgv(tbSearch.Text);
        }
    }
}

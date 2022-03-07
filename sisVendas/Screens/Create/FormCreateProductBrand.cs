using sisVendas.Controllers;
using sisVendas.Functions;
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
    public partial class FormCreateProductBrand : Form
    {
		private ctrlProductBrand controlProductBrand = new ctrlProductBrand();
		public FormCreateProductBrand()
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
				case Keys.Control | Keys.Enter:
					// Verificar se existe para evitar erro de cadastrar CPF já existente.
					if (!isExistsProductBrand())
					    btnSave.PerformClick();
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

		private bool isExistsProductBrand()
		{
			string name = Function.replaceAll(tbName.Text);

			if (name.Count() > 0)
			{
				DataTable dt = controlProductBrand.searthProductBrand(name);
				if (dt.Rows.Count > 0)
				{
					return true;
				}
			}
			return false;
		}
		public void updateDgv(string filtro)
		{
			dgv_ProductBrand.DataSource = controlProductBrand.searthProductBrand(filtro);
		}

		public void resetColor()
		{
			lblName.ForeColor = Color.Black;


		}
		private void btnNew_Click(object sender, EventArgs e)
        {
            activeForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            neutralForm();
            resetColor();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

			if (tbId.Text != "")
			{
				if (MessageBox.Show("Deseja excluir a marca de produto ? ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string cod = tbId.Text;

					if (controlProductBrand.removeProduct(cod) == true)
					{
						updateDgv("");

						neutralForm();
						Function.Alert("Sucesso!", "Marca excluida.", popupClient.enmType.Success);
					}
					else
					{
						Function.Alert("Erro!", "Erro ao excluir marca.", popupClient.enmType.Error);

					}
				}
			}
			else
				MessageBox.Show("Selecione a marca", "Atenção", MessageBoxButtons.OK);
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
				if (isExistsProductBrand())
				{
					if (MessageBox.Show("Existe uma marca muito semelhante a que deseja inserir, deseja continuar ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						isOk = false;
					}
				}
				if (isOk)
				{
					if (controlProductBrand.SaveProductBrand(
						tbId.Text,
						tbName.Text

						))
					{

						Function.Alert("Sucesso!", "Marca salva.", popupClient.enmType.Success);

						updateDgv("");
						activeForm();
					}
					tbName.Focus();
				}
				else
				{
					Function.Alert("Erro!", "Erro ao salvar marca.", popupClient.enmType.Error);
				}
			}
		}



        private void dgv_ProductBrand_DoubleClick(object sender, EventArgs e)
        {
			if (dgv_ProductBrand.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_ProductBrand.Rows[dgv_ProductBrand.CurrentRow.Index].Cells;

				fillForm(linha);

				btnRemove.Enabled = true;
			}
		}
    }
}

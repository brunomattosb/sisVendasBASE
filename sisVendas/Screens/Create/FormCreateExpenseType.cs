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
    public partial class FormCreateExpenseType : Form
    {
		private ctrlExpenseType controlExpenseType = new ctrlExpenseType();
		public FormCreateExpenseType()
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
					if (!isExistsExpenseType())
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
		
		public void updateDgv(string filtro)
		{
			dgv_ProductBrand.DataSource = controlExpenseType.searthExpenseType(filtro);
		}

		public void resetColor()
		{
			lblName.ForeColor = Color.Black;


		}
		private bool isExistsExpenseType()
		{
			string name = Function.replaceAll(tbName.Text);

			if (name.Count() > 0)
			{
				DataTable dt = controlExpenseType.searthExpenseType(name);
				if (dt.Rows.Count > 0)
				{
					return true;
				}
			}
			return false;
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
				if (isExistsExpenseType())
				{
					if (MessageBox.Show("Existe uma despesa muito semelhante a que deseja inserir, deseja continuar ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						isOk = false;
					}
				}
				if (isOk)
				{
					if (controlExpenseType.SaveExpenseType(
						tbId.Text,
						tbName.Text
						))
					{

						Function.Alert("Sucesso!", "Tipo de despesa salvo.", popupClient.enmType.Success);

						updateDgv("");
						activeForm();
					}
					tbName.Focus();
				}
				else
				{
					Function.Alert("Erro!", "Erro ao salvar tipo de despesa.", popupClient.enmType.Error);
				}
			}
		}

        private void btnRemove_Click(object sender, EventArgs e)
        {
			if (tbId.Text != "")
			{
				if (MessageBox.Show("Deseja excluir o tipo de despesa ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string cod = tbId.Text;

					if (controlExpenseType.removeExpenseType(cod) == true)
					{
						updateDgv("");

						neutralForm();
						Function.Alert("Sucesso!", "Tipo de despesa excluido.", popupClient.enmType.Success);
					}
					else
					{
						Function.Alert("Erro!", "Erro ao excluir tipo de despesa.", popupClient.enmType.Error);

					}
				}
			}
			else
				MessageBox.Show("Selecione a categoria", "Atenção", MessageBoxButtons.OK);
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

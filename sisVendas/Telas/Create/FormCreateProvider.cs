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
    public partial class FormCreateProvider : Form
    {
		private ctrlProvider controlProvider = new ctrlProvider();
		public FormCreateProvider()
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
					if (!isExistsClient())
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
		public void resetColor()
		{
			lblName.ForeColor =
			lblEnd.ForeColor =
			lblEmail.ForeColor =
			lblCidade.ForeColor =
			lblFantasyName.ForeColor =
			lblCpf.ForeColor =
			lblTelefone.ForeColor = Color.Black;
		}
		public void cleanForm()
		{
			mtbCpf.Text =
			tbName.Text =
			tbAddres.Text =
			tbCity.Text =
			tbDistrict.Text =
			mtbCep.Text =
			cbbUF.Text =
			tbRg.Text =
			tbEmail.Text =
			mtbTelephone.Text =
			tbId.Text = "";
			cbbUF.SelectedIndex = -1;
			
		}
		public void neutralForm()
		{
			cleanForm();

			mtbCpf.Enabled =
			tbName.Enabled =
			tbAddres.Enabled =
			tbFantasyName.Enabled =
			tbCity.Enabled = 
			tbDistrict.Enabled =
			mtbCep.Enabled = 
			cbbUF.Enabled =
			tbRg.Enabled = 
			tbEmail.Enabled =
			mtbTelephone.Enabled =
			btnSave.Enabled =
			btnCancel.Enabled =
			btnRemove.Enabled = false;
			btnNew.Enabled = true;


			tbSearch.Focus();
		}
		public void activeForm()
		{
			cleanForm();
			mtbCpf.Enabled =
			tbName.Enabled =
			tbAddres.Enabled =
			tbCity.Enabled =
			tbDistrict.Enabled =
			mtbCep.Enabled =
			cbbUF.Enabled =
			tbRg.Enabled =
			tbEmail.Enabled =
			mtbTelephone.Enabled = true;
			btnNew.Enabled = false;
			btnRemove.Enabled = false;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			cbbUF.SelectedIndex = 25;
			
		}
		private void fillForm(DataGridViewCellCollection linha)
		{
			
			tbId.Text = linha[0].Value.ToString();
			mtbCpf.Text = linha[1].Value.ToString();
			tbRg.Text = linha[2].Value.ToString();
			tbName.Text = linha[3].Value.ToString();
			tbFantasyName.Text = linha[4].Value.ToString();
			tbAddres.Text = linha[5].Value.ToString();
			tbCity.Text = linha[6].Value.ToString();
			mtbCep.Text = linha[7].Value.ToString();
			tbDistrict.Text = (linha[8].Value.ToString());
			cbbUF.Text = (linha[9].Value.ToString());
			//MessageBox.Show(linha[10].Value.ToString());
			mtbTelephone.Text = linha[11].Value.ToString();
			tbEmail.Text = linha[12].Value.ToString();
			

		}
		private bool isExistsClient()
		{
			string cpf = Function.replaceAll(mtbCpf.Text);

			if (cpf.Count() == 11 || cpf.Count() == 14)
			{
				DataTable dt = controlProvider.searthProvider(cpf);
				if (dt.Rows.Count > 0)
				{
					tbId.Text = dt.Rows[0]["prov_id"].ToString();
					mtbCpf.Text = dt.Rows[0]["prov_cpf_cnpj"].ToString();
					tbRg.Text = dt.Rows[0]["prov_rg_ie"].ToString();
					tbName.Text = dt.Rows[0]["prov_name"].ToString();
					tbFantasyName.Text = dt.Rows[0]["prov_fantazy_name"].ToString();
					tbAddres.Text = dt.Rows[0]["prov_addres"].ToString();
					tbCity.Text = dt.Rows[0]["prov_city"].ToString();
					mtbCep.Text = dt.Rows[0]["prov_zip_code"].ToString();
					tbDistrict.Text = dt.Rows[0]["prov_district"].ToString();
					cbbUF.Text = dt.Rows[0]["prov_uf"].ToString();
					mtbTelephone.Text = dt.Rows[0]["prov_telephone"].ToString();
					tbEmail.Text = dt.Rows[0]["prov_email"].ToString();

					btnRemove.Enabled = true;
					mtbCpf.Enabled = false;

					return true;
				}
			}
			return false;
		}
		public void updateDgv(string filtro)
		{
			dgv_Provider.DataSource = controlProvider.searthProvider(filtro);
		}
		public void changeCpfCnpj(int qtde)
		{
			//MessageBox.Show(qtde + "");
			if (mtbCpf.Mask != "000.000.000-00" && qtde < 11)
			{
				mtbCpf.Mask = "000.000.000-00";

				mtbCpf.Select(qtde, 0);
				tbFantasyName.Enabled = false;
				tbFantasyName.Text = "";
				lblCpf.Text = "*CPF:";
				lblRg.Text = "RG:";
			}
			else if (mtbCpf.Mask != "00.000.000/0000-00" && qtde >= 11)
			{
				int pos = mtbCpf.Text.Count();
				mtbCpf.Mask = "00.000.000/0000-00";
				mtbCpf.Select(pos, 0);

				tbFantasyName.Enabled = true;
				lblCpf.Text = "*CNPJ:";
				lblRg.Text = "IE:";
			}

		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			resetColor();

			bool isOk = true;

			if (!(Function.replaceAll(mtbCpf.Text).Length > 0))
			{
				isOk = false;
				lblCpf.ForeColor = Color.Red;

			}
			if (isOk && !(Function.isCpfValid(mtbCpf.Text)) && Function.replaceAll(mtbCpf.Text).Count() <= 11)//&& isValidCpf
			{
				isOk = false;
				lblCpf.ForeColor = Color.Red;
				Function.Alert("Erro!", "CPF incorreto!", popupClient.enmType.Error);
			}

			if (tbName.Text.Count() < 2)
			{
				lblName.ForeColor = Color.Red;
				isOk = false;
			}

			if (Function.replaceAll(mtbTelephone.Text).Count() < 2)
			{
				lblTelefone.ForeColor = Color.Red;
				isOk = false;
			}

			/*if (tbAddres.Text.Count() < 2)
			{
				lblEnd.ForeColor = Color.Red;
				isOk = false;
			}
			if (tbCity.Text.Count() < 2)
			{
				lblCidade.ForeColor = Color.Red;
				isOk = false;
			}

			if (tbEmail.Text.Count() < 2)
			{
				lblEmail.ForeColor = Color.Red;
				isOk = false;
			}*/

			if (isOk)
			{
				if(controlProvider.SaveProvider(

					tbId.Text,
					Function.replaceAll(mtbCpf.Text),
					Function.replaceAll(tbRg.Text),
					tbName.Text,
					tbFantasyName.Text,
					tbAddres.Text,
					tbCity.Text,
					tbDistrict.Text,
					mtbCep.Text.Replace("     -", ""),
					cbbUF.SelectedItem.ToString(),
					Function.replaceAll(mtbTelephone.Text),
					tbEmail.Text
					))
				{

					Function.Alert("Sucesso!", "Fornecedor salvo.", popupClient.enmType.Success);

					updateDgv("");
					activeForm();
					mtbCpf.Focus();
				}
			}
			else
			{
				//Function.Alert("Erro!", "Erro ao salvar funcionário.", popupClient.enmType.Error);
			}
		}
		private void btnExcluir_Click(object sender, EventArgs e)
        {
			
			if (tbId.Text != "")
			{
				if (MessageBox.Show("Deseja excluir o fornecedor selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string cod = tbId.Text;

					if (controlProvider.removeProvider(cod) == true)
					{
						updateDgv("");

						neutralForm();
						Function.Alert("Sucesso!", "Fornecedor excluido.", popupClient.enmType.Success);
					}
					else
					{
						Function.Alert("Erro!", "Erro ao excluir fornecedor.", popupClient.enmType.Error);

					}
				}
			}
			else
				MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK);
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			neutralForm();
			resetColor();
		}


        private void mtbCpf_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCpf.Text).Length == 0)
				mtbCpf.Select(0, 0);

		}

        private void mtbCep_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCep.Text).Length == 0)
				mtbCep.Select(0, 0);
		}

        private void mtbTelefone_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbTelephone.Text).Length == 0)
				mtbTelephone.Select(0, 0);
		}

        private void dgv_Provider_DoubleClick(object sender, EventArgs e)
        {
			if (dgv_Provider.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_Provider.Rows[dgv_Provider.CurrentRow.Index].Cells;

				fillForm(linha);

				btnRemove.Enabled = true;
				mtbCpf.Enabled = false;
			}
		}

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
			isExistsClient();
		}

        private void btnNew_Click(object sender, EventArgs e)
        {
			activeForm();
			mtbCpf.Focus();
		}

 

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (char.IsNumber(e.KeyChar))
			{
				int count = Function.replaceAll(mtbCpf.Text).Count();
				changeCpfCnpj(count);
			}
		}

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCpf.Text).Count() == 10)
			{
				changeCpfCnpj(Function.replaceAll(mtbCpf.Text).Count());
			}

		}
	}
}

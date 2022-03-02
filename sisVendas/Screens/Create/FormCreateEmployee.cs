using sisVendas.Functions;
using sisVendas.Notificacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCreateEmployee : Form
    {
        public FormCreateEmployee()
        {
            InitializeComponent();
            neutralForm();

			//updateDgv("");

			
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
                    //if (!isExistsClient())
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
		public void cleanForm()
		{
			mtbCpf.Text =
			tbName.Text =
			tbAddres.Text =
			tbCity.Text =
			tbDistrict.Text =
			mtbCep.Text =
			cbbUF.Text =
			mtbDtNasc.Text =
			mtbRg.Text =
			tbEmail.Text =
			mtbTelephone.Text =
			tbId.Text = "";
			tbBaseSalary.Text = "";
			tbUsername.Text = "";
			tbPassword.Text = "";
			mtbAdmission.Text = "";
			mtbDemissao.Text = "";
			cbAccces.Checked = false;
			cbbResignation.SelectedIndex = -1;
			cbbUF.SelectedIndex = -1;
			cbbSex.SelectedIndex = -1;
		}
		public void neutralForm()
		{
			cleanForm();

			mtbCpf.Enabled = false;
			mtbRg.Enabled = false;
			tbName.Enabled = false;
			tbAddres.Enabled = false;
			cbbSex.Enabled = false;
			tbCity.Enabled = false;
			tbDistrict.Enabled = false;
			mtbCep.Enabled = false;
			cbbUF.Enabled = false;
			mtbDtNasc.Enabled = false;
			mtbRg.Enabled = false;
			tbEmail.Enabled = false;
			mtbTelephone.Enabled = false;
			tbBaseSalary.Enabled = false;
			gbAccess.Enabled = false;
			gbAdmission.Enabled = false;

			btnSave.Enabled = false;
			btnCancel.Enabled = false;
			btnRemove.Enabled = false;
			btnNew.Enabled = true;


			tbSearch.Focus();
		}
		public void activeForm()
		{
			cleanForm();
			mtbCpf.Enabled =
			mtbRg.Enabled = 
			tbName.Enabled =
			tbAddres.Enabled =
			cbbSex.Enabled =
			tbCity.Enabled = 
			tbDistrict.Enabled =
			mtbCep.Enabled =
			cbbUF.Enabled = 
			mtbDtNasc.Enabled = 
			mtbRg.Enabled = 
			tbEmail.Enabled = 
			mtbTelephone.Enabled = 
			tbBaseSalary.Enabled = 
			gbAccess.Enabled = 
			gbAdmission.Enabled = true;

			btnNew.Enabled = false;
			btnRemove.Enabled = false;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			cbbUF.SelectedIndex = 25;
			cbbSex.SelectedIndex = 0;
			mtbCpf.Focus();
		}
		private void fillForm(DataGridViewCellCollection linha)
		{

			//changeCpfCnpj(Function.replaceAll(linha[3].Value.ToString()).Count());

			tbId.Text = linha[0].Value.ToString();
			tbName.Text = linha[1].Value.ToString();
			mtbCpf.Text = linha[3].Value.ToString();
			mtbCep.Text = linha[4].Value.ToString();
			tbAddres.Text = linha[5].Value.ToString();
			tbEmail.Text = linha[6].Value.ToString();
			mtbRg.Text = linha[7].Value.ToString();
			mtbTelephone.Text = linha[8].Value.ToString();
			tbCity.Text = linha[9].Value.ToString();
			mtbDtNasc.Text = linha[10].Value.ToString();
			cbbSex.Text = linha[12].Value.ToString();
			cbbUF.Text = (linha[14].Value.ToString());
			tbDistrict.Text = (linha[15].Value.ToString());
		}
		//private bool isExistsClient()
		//{
			/*string cpf = Function.replaceAll(mtbCpf.Text);

			if (cpf.Count() == 11 || cpf.Count() == 14)
			{
				DataTable dt = controlClient.searthClient(cpf);
				if (dt.Rows.Count > 0)
				{
					//changeCpfCnpj(Function.replaceAll(dt.Rows[0]["cli_cpf_cnpj"].ToString()).Count());
					tbCod.Text = dt.Rows[0]["cli_id"].ToString();
					tbName.Text = dt.Rows[0]["cli_name"].ToString();
					tbFantasyName.Text = dt.Rows[0]["cli_fantasy_name"].ToString();
					mtbCpf.Text = dt.Rows[0]["cli_cpf_cnpj"].ToString();
					mtbCep.Text = dt.Rows[0]["cli_zip_code"].ToString();
					tbAddres.Text = dt.Rows[0]["cli_addres"].ToString();
					tbEmail.Text = dt.Rows[0]["cli_email"].ToString();
					mtbRgIe.Text = dt.Rows[0]["cli_rg_ie"].ToString(); ;
					mtbTelephone.Text = dt.Rows[0]["cli_telephone"].ToString();
					tbCity.Text = dt.Rows[0]["cli_city"].ToString();
					mtbDtNasc.Text = dt.Rows[0]["cli_birth_at"].ToString();
					cbbSex.Text = dt.Rows[0]["cli_sex"].ToString();
					tbSaldo.Text = dt.Rows[0]["cli_balance"].ToString();
					cbbEstado.Text = dt.Rows[0]["cli_uf"].ToString();
					tbDistrict.Text = dt.Rows[0]["cli_district"].ToString();

					btnRemove.Enabled = true;
					mtbCpf.Enabled = false;

					return true;
				}
			}
			return false;*/
		//}
		public void updateDgv(string filtro)
        {
			//dgv_employee.DataSource = controlClient.searthClient(filtro);
        }

		public void resetColor()
        {
			lblName.ForeColor =
			lblEnd.ForeColor =
			lblEmail.ForeColor =
			lblSalario.ForeColor =
			lblPassword.ForeColor =
			lblUser.ForeColor =
			lblLicenca.ForeColor =
			lblCidade.ForeColor =
			lblSexo.ForeColor =
			lblNascimento.ForeColor =
			lblAdmissao.ForeColor =
			lblCpf.ForeColor =
			lblTelefone.ForeColor =
			lblNascimento.ForeColor = Color.Black;


		}
        private void btnSalvar_Click(object sender, EventArgs e)
        {
			resetColor();

			bool isOk = true;
			DateTime dateValue = new DateTime();

			if (!(Function.replaceAll(mtbCpf.Text).Length > 0))
			{
				isOk = false;
				lblCpf.ForeColor = Color.Red;

			}
			if (isOk && !(Function.isCpfValid(mtbCpf.Text)))//&& isValidCpf
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

			if (tbAddres.Text.Count() < 2)
			{
				lblEnd.ForeColor = Color.Red;
				isOk = false;
			}
			if (tbCity.Text.Count() < 2)
			{
				lblCidade.ForeColor = Color.Red;
				isOk = false;
			}
			if (mtbDtNasc.Text.Count() < 2)
			{
				lblNascimento.ForeColor = Color.Red;
				isOk = false;
			}
			if (tbEmail.Text.Count() < 2)
			{
				lblEmail.ForeColor = Color.Red;
				isOk = false;
			}
			if (tbBaseSalary.Text.Count() < 2)
			{
				lblSalario.ForeColor = Color.Red;
				isOk = false;
			}
			if (Function.replaceAll(mtbTelephone.Text).Count() < 2)
			{
				lblTelefone.ForeColor = Color.Red;
				isOk = false;
			}

			if (!DateTime.TryParseExact(mtbDtNasc.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateValue))
			{
				lblNascimento.ForeColor = Color.Red;
				isOk = false;
			}
			if (!DateTime.TryParseExact(mtbAdmission.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateValue))
			{
				lblAdmissao.ForeColor = Color.Red;
				isOk = false;
			}


			if (cbAccces.Checked)
            {
				if (tbPassword.Text.Count() < 2)
				{
					lblPassword.ForeColor = Color.Red;
					isOk = false;
				}
				if (tbUsername.Text.Count() < 2)
				{
					lblUser.ForeColor = Color.Red;
					isOk = false;
				}
				if(cbbResignation.SelectedIndex == -1)
                {
					lblLicenca.ForeColor = Color.Red;
					isOk = false;
				}

			}
			

			/*

			

			if (isOk)
			{
				if(controlClient.SaveClient(
					tbCod.Text,
					tbName.Text,
					Function.replaceAll(mtbCpf.Text),
					mtbCep.Text.Replace("     -", ""),
					tbAddres.Text,
					tbDistrict.Text,
					tbEmail.Text,
					Function.replaceAll(mtbRgIe.Text),
					Function.replaceAll(mtbTelephone.Text),
					cbbEstado.SelectedItem.ToString(),
					tbCity.Text,
					tbFantasyName.Text,
					dateValue,
					Convert.ToChar(cbbSex.SelectedItem.ToString()),
					Convert.ToDouble(tbSaldo.Text)
					))
				{

					Function.Alert("Sucesso!", "funcionário salvo.", popupClient.enmType.Success);

					updateDgv("");
					activeForm();
				}
			}
			else
			{
				Function.Alert("Erro!", "Erro ao salvar funcionário.", popupClient.enmType.Error);
			}*/

		}

		private void btnExcluir_Click(object sender, EventArgs e)
        {
			/*
			if (tbCod.Text != "")
			{
				if (MessageBox.Show("Deseja excluir o cliente selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string cod = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells[0].Value.ToString();

					if (controlClient.removeClient(cod) == true)
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
				MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK);*/
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			neutralForm();
			resetColor();
		}

        private void btnNovo_Click(object sender, EventArgs e)
        {
			activeForm();
		}



        private void mtbCep_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCep.Text).Length == 0)
				mtbCep.Select(0, 0);
		}

        private void mtbRg_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbRg.Text).Length == 0)
				mtbRg.Select(0, 0);
		}

        private void mtbCpf_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCpf.Text).Length == 0)
				mtbCpf.Select(0, 0);
		}

        private void mtbDtNasc_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbDtNasc.Text).Length == 0)
				mtbDtNasc.Select(0, 0);
		}

        private void mtbTelephone_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbTelephone.Text).Length == 0)
				mtbTelephone.Select(0, 0);
		}

        private void dgv_employee_DoubleClick(object sender, EventArgs e)
        {
			/*if (dgv_client.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells;

				fillForm(linha);

				btnRemove.Enabled = true;
				mtbCpf.Enabled = false;
			}*/
		}

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
			//isExistsClient();
		}

        private void cbAccces_CheckedChanged(object sender, EventArgs e)
        {
			tbUsername.Enabled = tbPassword.Enabled = cbbResignation.Enabled = cbAccces.Checked;
        }

        private void tbBaseSalary_Leave(object sender, EventArgs e)
        {
			if(double.TryParse(tbBaseSalary.Text, out double res))
				tbBaseSalary.Text = String.Format("{0:c}", res);
			else
            {
				tbBaseSalary.Text = "";
				Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
			}
				

		}

        private void tbBaseSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44)
			{
				e.Handled = true;
			}

		}
	}
    
}

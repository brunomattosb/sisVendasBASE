using sisVendas.Controllers;
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
		private ctrlEmployee controlEmployee = new ctrlEmployee();

		public FormCreateEmployee()
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
                    //Verificar se existe para evitar erro de cadastrar CPF já existente.
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
			tbRg.Text =
			tbEmail.Text =
			mtbTelephone.Text =
			tbId.Text = "";
			tbBaseSalary.Text = "";
			tbUsername.Text = "";
			tbPassword.Text = "";
			mtbAdmission.Text = "";
			mtbDemissao.Text = "";
			cbAccces.Checked = false;
			cbbLicence.SelectedIndex = -1;
			cbbUF.SelectedIndex = -1;
			cbbSex.SelectedIndex = -1;
		}
		public void neutralForm()
		{
			cleanForm();

			mtbCpf.Enabled = false;
			tbRg.Enabled = false;
			tbName.Enabled = false;
			tbAddres.Enabled = false;
			cbbSex.Enabled = false;
			tbCity.Enabled = false;
			tbDistrict.Enabled = false;
			mtbCep.Enabled = false;
			cbbUF.Enabled = false;
			mtbDtNasc.Enabled = false;
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
			tbName.Enabled =
			tbAddres.Enabled =
			cbbSex.Enabled =
			tbCity.Enabled = 
			tbDistrict.Enabled =
			mtbCep.Enabled =
			cbbUF.Enabled = 
			mtbDtNasc.Enabled =
			tbRg.Enabled = 
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
			cbbLicence.SelectedIndex = 0;
			cbbSex.SelectedIndex = 0;
			
		}
		private void fillForm(DataGridViewCellCollection linha)
		{
			tbId.Text = linha[0].Value.ToString();
			tbName.Text = linha[1].Value.ToString();
			mtbCpf.Text = linha[2].Value.ToString();
			mtbCep.Text = linha[3].Value.ToString();
			tbAddres.Text = linha[4].Value.ToString();
			tbDistrict.Text = (linha[5].Value.ToString());
			tbCity.Text = linha[6].Value.ToString();
			mtbTelephone.Text = linha[7].Value.ToString();
			tbRg.Text = linha[8].Value.ToString();
			cbbUF.Text = (linha[9].Value.ToString());
			tbUsername.Text = linha[10].Value.ToString();
			tbPassword.Text = linha[11].Value.ToString();
			cbbLicence.Text = linha[12].Value.ToString();
			mtbDtNasc.Text = linha[13].Value.ToString();


			cbAccces.Checked = tbUsername.Text.Count() > 0;

			
			mtbAdmission.Text = linha[15].Value.ToString();
			mtbDemissao.Text = linha[16].Value.ToString();
			cbbSex.Text = linha[17].Value.ToString();
			tbEmail.Text = linha[18].Value.ToString();
			tbBaseSalary.Text = linha[19].Value.ToString();
		}

		private bool isExistsClient()
		{
			string cpf = Function.replaceAll(mtbCpf.Text);

			if (cpf.Count() == 11)
			{
				DataTable dt = controlEmployee.searthEmployee(cpf);
				if (dt.Rows.Count > 0)
				{
					tbId.Text = dt.Rows[0]["emp_id"].ToString();
					tbName.Text = dt.Rows[0]["emp_name"].ToString();
					mtbCpf.Text = dt.Rows[0]["emp_cpf"].ToString();
					mtbCep.Text = dt.Rows[0]["emp_zip_code"].ToString();
					tbAddres.Text = dt.Rows[0]["emp_addres"].ToString();
					tbDistrict.Text = dt.Rows[0]["emp_district"].ToString();
					tbCity.Text = dt.Rows[0]["emp_city"].ToString();
					mtbTelephone.Text = dt.Rows[0]["emp_telephone"].ToString();
					tbRg.Text = dt.Rows[0]["emp_rg"].ToString();	
					cbbUF.Text = dt.Rows[0]["emp_uf"].ToString();
					tbUsername.Text = dt.Rows[0]["emp_username"].ToString();
					tbPassword.Text = dt.Rows[0]["emp_password"].ToString();
					cbbLicence.Text = dt.Rows[0]["emp_licence"].ToString();
					mtbDtNasc.Text = dt.Rows[0]["emp_birth_at"].ToString();
					
					mtbDemissao.Text = dt.Rows[0]["emp_resignation"].ToString();
					mtbAdmission.Text = dt.Rows[0]["emp_admission"].ToString(); 
					
					cbbSex.Text = dt.Rows[0]["emp_sex"].ToString();
					tbEmail.Text = dt.Rows[0]["emp_email"].ToString();
					tbBaseSalary.Text = dt.Rows[0]["emp_base_salary"].ToString();
					cbAccces.Checked = dt.Rows[0]["emp_username"].ToString().Count() != 0;
					btnRemove.Enabled = true;
					mtbCpf.Enabled = false;

					return true;
				}
			}
			return false;
		}
		public void updateDgv(string filtro)
        {
			dgv_employee.DataSource = controlEmployee.searthEmployee(filtro);
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
			lblDemissao.ForeColor = 
			lblAdmissao.ForeColor = 
			lblNascimento.ForeColor = Color.Black;

			 
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


			DateTime dateNascValue;
			if (Function.replaceAll(mtbDtNasc.Text).Length > 0) //caso tenha dado
			{
				if (!DateTime.TryParseExact(mtbDtNasc.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateNascValue))
				{
					Function.Alert("Erro!", "Data de nascimento inválida.", popupClient.enmType.Error);
					isOk = false;
					lblNascimento.ForeColor = Color.Red;
				}
			}
			else
			{
				isOk = false;
				lblNascimento.ForeColor = Color.Red;
				dateNascValue = DateTime.MaxValue;
			}

			DateTime dateAdmissionValue;
			if (Function.replaceAll(mtbAdmission.Text).Length > 0) //caso tenha dado
			{
				if (!DateTime.TryParseExact(mtbAdmission.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateAdmissionValue))
				{
					Function.Alert("Erro!", "Data de Admissão inválida.", popupClient.enmType.Error);
					isOk = false;
					lblAdmissao.ForeColor = Color.Red;
				}
			}
			else
			{
				isOk = false;
				lblAdmissao.ForeColor = Color.Red;
				dateAdmissionValue = DateTime.MaxValue;
			}

			DateTime dateResignationValue;
			if (Function.replaceAll(mtbDemissao.Text).Length > 0) //caso tenha dado
			{
				if (!DateTime.TryParseExact(mtbDemissao.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateResignationValue))
				{
					Function.Alert("Erro!", "Data de Demissão inválida.", popupClient.enmType.Error);
					isOk = false;
					lblDemissao.ForeColor = Color.Red;
				}
			}
			else
			{
				dateResignationValue = DateTime.MaxValue;
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
				if(cbbLicence.SelectedIndex == -1)
                {
					lblLicenca.ForeColor = Color.Red;
					isOk = false;
				}

			}


			
			if (isOk)
			{
				if (controlEmployee.SavEmployee(
					tbId.Text,
					Function.replaceAll(mtbCpf.Text),
					Function.replaceAll(tbRg.Text),
					tbName.Text,
					tbAddres.Text,
					Convert.ToChar(cbbSex.SelectedItem.ToString()),
					tbCity.Text,
					tbDistrict.Text,
					mtbCep.Text.Replace("     -", ""),
					cbbUF.SelectedItem.ToString(),
					dateNascValue,
					Function.replaceAll(mtbTelephone.Text),
					tbEmail.Text,
					Convert.ToDouble(tbBaseSalary.Text.Replace("R$", "")),
					tbUsername.Text,
					tbPassword.Text,
					cbbLicence.SelectedItem.ToString(),
					dateAdmissionValue,
					dateResignationValue
				))
				{

					Function.Alert("Sucesso!", "Cliente salvo.", popupClient.enmType.Success);

					updateDgv("");
					activeForm();
					mtbCpf.Focus();
				}
			}
			else
			{
				//Function.Alert("Erro!", "Erro ao salvar cliente.", popupClient.enmType.Error);
			}

		}

		private void btnExcluir_Click(object sender, EventArgs e)
        {
			
			if (tbId.Text != "")
			{
				if (MessageBox.Show("Deseja excluir o funcionário selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					string cod = tbId.Text;

					if (controlEmployee.removeEmployee(cod) == true)
					{
						updateDgv("");

						neutralForm();
						Function.Alert("Sucesso!", "Funcionário excluido.", popupClient.enmType.Success);
					}
					else
					{
						Function.Alert("Erro!", "Erro ao excluir funcionário.", popupClient.enmType.Error);

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
			activeForm();
			mtbCpf.Focus();
		}

        private void mtbCep_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbCep.Text).Length == 0)
				mtbCep.Select(0, 0);
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
			if (dgv_employee.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_employee.Rows[dgv_employee.CurrentRow.Index].Cells;

				fillForm(linha);

				btnRemove.Enabled = true;
				mtbCpf.Enabled = false;
			}
		}

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
			isExistsClient();
		}

        private void cbAccces_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbAccces.Checked)
            {
				tbUsername.Text = tbPassword.Text = "";
            }
			tbUsername.Enabled = tbPassword.Enabled = cbbLicence.Enabled = cbAccces.Checked;
        }

        private void tbBaseSalary_Leave(object sender, EventArgs e)
        {
			string text = tbBaseSalary.Text.Replace("R$", "");
			if (double.TryParse(text, out double res))
				tbBaseSalary.Text = String.Format("{0:c}", res);
			else
            {
				tbBaseSalary.Text = "";
				Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
			}
				

		}

        private void tbBaseSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
			{
				e.Handled = true;
			}

		}

        private void mtbAdmission_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbAdmission.Text).Length == 0)
				mtbAdmission.Select(0, 0);
		}

        private void mtbDemissao_Click(object sender, EventArgs e)
        {
			if (Function.replaceAll(mtbDemissao.Text).Length == 0)
				mtbDemissao.Select(0, 0);
		}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

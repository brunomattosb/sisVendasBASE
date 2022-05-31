using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
	public partial class FormCriarFuncionario : Form
	{
		private ctrlFuncionario controlFuncionario = new ctrlFuncionario();

		public FormCriarFuncionario()
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
					if (tbCod.Text == "")
					{
						if (!isExistsFunc())
							btnSave.PerformClick();
					}
					else
					{
						btnSave.PerformClick();
					}
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
			tbRg.Text =
			tbEmail.Text =
			mtbTelephone.Text =
			tbCod.Text =
			tbUsername.Text =
			tbPassword.Text =
			dtpAdmissao.Text =
			dtpDemissao.Text =
			tbBaseSalary.Text = "";
			dtpDtNasc.Value = DateTime.Now;
			cbAccces.Checked = false;
			cbbLicence.SelectedIndex = -1;
			cbbUF.SelectedIndex = -1;
			cbbSex.SelectedIndex = -1;
			cbAtivo.Checked = false;
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
			dtpDtNasc.Enabled = false;
			tbEmail.Enabled = false;
			mtbTelephone.Enabled = false;
			tbBaseSalary.Enabled = false;
			gbAccess.Enabled = false;
			gbAdmission.Enabled = false;
			cbAtivo.Checked = cbAccces.Checked = true;
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
			dtpDtNasc.Enabled =
			tbRg.Enabled =
			tbEmail.Enabled =
			mtbTelephone.Enabled =
			tbBaseSalary.Enabled =
			gbAccess.Enabled =
			gbAdmission.Enabled = true;
			cbAtivo.Checked = true;
			cbAccces.Checked = false;
			btnNew.Enabled = false;
			btnRemove.Enabled = false;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;

			cbbUF.SelectedIndex = 25;
			cbbLicence.SelectedIndex = 0;
			cbbSex.SelectedIndex = 0;
			tbBaseSalary.Text = "R$ 0,00";
		}

		private void fillForm(Funcionario func)
		{
			tbCod.Text = func.Id.ToString();
			tbName.Text = func.Nome;
			mtbCpf.Text = func.Cpf;
			mtbCep.Text = func.Cep;
			tbAddres.Text = func.Endereco;
			tbDistrict.Text = func.Bairro;
			tbCity.Text = func.Cidade;
			mtbTelephone.Text = func.Telefone;
			tbRg.Text = func.Rg;
			cbbUF.Text = func.Uf;
			tbUsername.Text = func.Usuario;
			tbPassword.Text = func.Senha;
			cbbLicence.Text = func.Licenca;
			dtpDtNasc.Value = func.DtNascimento;
			dtpAdmissao.Value = func.Admissao;
			dtpDemissao.Value = func.Demissao;
			cbbSex.Text = func.Sexo.ToString();
			tbEmail.Text = func.Email;
			tbBaseSalary.Text = func.Base_salario.ToString("C");
			cbAccces.Checked = func.Usuario.Count() > 0;
			if (func.Ativo == true)
			{

				cbAtivo.Checked = true;
				dtpDemissao.Enabled = false;
			}
			else
			{
				cbAtivo.Checked = false;
				dtpDemissao.Enabled = true;
			}
		}


		private bool isExistsFunc()
		{
			string cpf = Function.replaceAll(mtbCpf.Text);

			if (cpf.Count() == 11)
			{
				Funcionario func = controlFuncionario.BuscarPorCPF(cpf);
				if (func != null)
				{
					fillForm(func);
					btnRemove.Enabled = true;
					mtbCpf.Enabled = false;
				}
				
			}
			return false;
		}
		public void updateDgv(string filtro)
		{
			dgv_employee.DataSource = controlFuncionario.Buscar(filtro);
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
			if (isOk && !(Function.isCpfValid(mtbCpf.Text)))
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
			if (dtpDtNasc.Text.Count() < 2)
			{
				lblNascimento.ForeColor = Color.Red;
				isOk = false;
			}
			if (tbEmail.Text.Count() < 2)
			{
				lblEmail.ForeColor = Color.Red;
				isOk = false;
			}
			if (Function.replaceAll(mtbTelephone.Text).Count() < 2)
			{
				lblTelefone.ForeColor = Color.Red;
				isOk = false;
			}

			/*
			DateTime dateNascValue;
			if (Function.replaceAll(dtpDtNasc.Text).Length > 0) //caso tenha dado
			{
				if (!DateTime.TryParseExact(dtpDtNasc.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateNascValue))
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
			}*/
			/*
			DateTime dateAdmissionValue;
			if (Function.replaceAll(dtpAdmissao.Text).Length > 0) //caso tenha dado
			{
				if (!DateTime.TryParseExact(dtp.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateAdmissionValue))
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
			}*/

			/*
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
			}*/

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
				if (cbbLicence.SelectedIndex == -1)
				{
					lblLicenca.ForeColor = Color.Red;
					isOk = false;
				}

			}

			if (isOk)
			{
				if (controlFuncionario.salvarFuncionario(
					tbCod.Text,
					Function.replaceAll(mtbCpf.Text),
					Function.replaceAll(tbRg.Text),
					tbName.Text,
					tbAddres.Text,
					Convert.ToChar(cbbSex.SelectedItem.ToString()),
					tbCity.Text,
					tbDistrict.Text,
					mtbCep.Text.Replace("     -", ""),
					cbbUF.SelectedItem.ToString(),
					dtpDtNasc.Value,
					Function.replaceAll(mtbTelephone.Text),
					tbEmail.Text,
					Convert.ToDouble(tbBaseSalary.Text.Replace("R$", "")),
					tbUsername.Text,
					tbPassword.Text,
					cbbLicence.SelectedItem.ToString(),
					dtpAdmissao.Value,
					dtpDemissao.Value,
					cbAtivo.Checked
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
			if (tbCod.Text != "1")
            {
				if (tbCod.Text != "")
				{
					if (MessageBox.Show("Deseja excluir o funcionário selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					{
						string cod = tbCod.Text;

						if (controlFuncionario.Remover(cod) == true)
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
					MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
				MessageBox.Show("A conta principal não pode ser excluida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

				Funcionario func = new Funcionario();

				func.Id = int.Parse(linha[0].Value.ToString());
				func.Nome = linha[1].Value.ToString();
				func.Cpf = linha[2].Value.ToString();
				func.Cep = linha[3].Value.ToString();
				func.Endereco = linha[4].Value.ToString();
				func.Bairro = (linha[5].Value.ToString());
				func.Cidade = linha[6].Value.ToString();
				func.Telefone = linha[7].Value.ToString();
				func.Rg = linha[8].Value.ToString();
				func.Uf = (linha[9].Value.ToString());
				func.Usuario = linha[10].Value.ToString();
				func.Senha = linha[11].Value.ToString();
				func.Licenca = linha[12].Value.ToString();
				func.DtNascimento = DateTime.Parse(linha[13].Value.ToString());
				func.Admissao = DateTime.Parse(linha[15].Value.ToString());
				func.Demissao = DateTime.Parse(linha[16].Value.ToString());
				func.Sexo = char.Parse(linha[17].Value.ToString());
				func.Email = linha[18].Value.ToString();

				func.Ativo = bool.Parse(linha[20].Value.ToString());
				func.Base_salario = double.Parse(linha[19].Value.ToString());

				fillForm(func);

				btnRemove.Enabled = true;

				if (mtbCpf.Text == "999.999.999-99")
					mtbCpf.Enabled = true;
				else
					mtbCpf.Enabled = false;
			}
		}

		private void mtbCpf_Leave(object sender, EventArgs e)
		{
			isExistsFunc();
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
				tbBaseSalary.Text = "R$ 0,00";
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

		private void cbAtivo_CheckedChanged(object sender, EventArgs e)
		{

			dtpDemissao.Enabled = !cbAtivo.Checked;

		}

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
			updateDgv(tbSearch.Text);
        }

        private void tbBaseSalary_Enter(object sender, EventArgs e)
        {
			if(tbBaseSalary.Text == "R$ 0,00")
            {
				tbBaseSalary.Text = "";
			}
		}

		
    }

}

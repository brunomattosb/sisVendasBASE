using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
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
				case Keys.F12:
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
				case Keys.F4:
					btnCancel.PerformClick();
					break;
				case Keys.F2:
					btnRemove.PerformClick();
					break;
				case Keys.F1:
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

			gbCad.Enabled = false;
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
			gbCad.Enabled = true;
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
				Funcionario func = controlFuncionario.BuscarFuncionarioPorCPF(cpf);
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
			dgv_employee.DataSource = controlFuncionario.BuscarParaDGV(filtro);
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

			int lenghtCpf = Function.replaceAll(mtbCpf.Text).Length;
			if (lenghtCpf != 11 && lenghtCpf != 14)
			{
				Alerta.notificacao("Erro!", "CPF/CNPJ incorreto!", Alerta.enmType.Error);
				isOk = false;
				lblCpf.ForeColor = Color.Red;
			}
			else
			{
				if (lenghtCpf == 11)
					if (!(Function.isCpfValid(mtbCpf.Text)))//&& isValidCpf
					{
						Alerta.notificacao("Erro!", "CPF incorreto.", Alerta.enmType.Error);
						isOk = false;
						lblCpf.ForeColor = Color.Red;
					}
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
                if (controlFuncionario.SalvarFuncionario(
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

                    Alerta.notificacao("Sucesso!", "Cliente salvo.", Alerta.enmType.Success);

                    updateDgv("");
                    activeForm();
                    mtbCpf.Focus();
                }
            }
            else
            {
                //Alerta.notificacao("Erro!", "Erro ao salvar cliente.", Alerta.enmType.Error);
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
                            Alerta.notificacao("Sucesso!", "Funcionário excluido.", Alerta.enmType.Success);
                        }
                        else
                        {
                            Alerta.notificacao("Erro!", "Erro ao excluir funcionário.", Alerta.enmType.Error);

                        }
                    }
                }
                else
                    MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
				Funcionario func = controlFuncionario.BuscarFuncionarioPorCPF(dgv_employee.Rows[dgv_employee.CurrentRow.Index].Cells[2].Value.ToString());

				activeForm(); 
				fillForm(func);

				if (mtbCpf.Text == "999.999.999-99")
					mtbCpf.Enabled = true;
				else
					mtbCpf.Enabled = false;

				btnRemove.Enabled = true;
				
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
			string text = tbBaseSalary.Text.Replace("R$ ", "");
			if (double.TryParse(text, out double res))
				tbBaseSalary.Text = String.Format("{0:c}", res);
			else
			{
				tbBaseSalary.Text = "R$ 0,00";
				Alerta.notificacao("Erro!!", "Valor incorreto", Alerta.enmType.Error);
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

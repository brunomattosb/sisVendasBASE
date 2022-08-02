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
    public partial class FormCreiarFornecedor : Form
    {
		private ctrlFornecedor controlProvider = new ctrlFornecedor();
		public FormCreiarFornecedor()
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
						if (!isExistsForn())
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
			tbFantasyName.Text =
			tbCod.Text = "";
			cbbUF.SelectedIndex = -1;
			
		}
		public void neutralForm()
		{
			cleanForm();
			resetColor();
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
			resetColor();
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
		private void fillForm(Fornecedor Forn)
		{
			int qtdeCpf = Function.replaceAll(Forn.Cpf_cnpj).Count() - 1;
			changeCpfCnpj(qtdeCpf);

			tbCod.Text = Forn.Id.ToString();
			mtbCpf.Text = Forn.Cpf_cnpj;
			tbRg.Text = Forn.Rg_ie;
			tbName.Text = Forn.Nome;
			tbFantasyName.Text = Forn.Nome_fantasia;
			tbAddres.Text = Forn.Endereco;
			tbCity.Text = Forn.Cidade;
			mtbCep.Text = Forn.Cep;
			tbDistrict.Text = Forn.Bairro;
			cbbUF.Text = Forn.Uf;
			mtbTelephone.Text = Forn.Telefone;
			tbEmail.Text = Forn.Email;

			btnRemove.Enabled = true;
			mtbCpf.Enabled = false;
		}
		private bool isExistsForn()
		{
            string cnpj = Function.replaceAll(mtbCpf.Text);

            if (cnpj.Count() == 11 || cnpj.Count() == 14)
            {
                Fornecedor forn = controlProvider.BuscarFornecedorPorCnpj(cnpj);
                if (forn != null)
                {
                    fillForm(forn);

                    return true;
                }
            }
            return false;
		}
		public void updateDgv(string filtro)
		{
			dgv_Provider.DataSource = controlProvider.BuscarParaDGV(filtro);
		}
		public void changeCpfCnpj(int qtde)
		{
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
			int cpf_lenght = Function.replaceAll(mtbCpf.Text).Length;

			if (cpf_lenght != 11 || cpf_lenght != 14)
            {
                isOk = false;
                lblCpf.ForeColor = Color.Red;
				if(cpf_lenght == 11)
                {
					if (!(Function.isCpfValid(mtbCpf.Text)))
					{
						isOk = false;
						lblCpf.ForeColor = Color.Red;
						Alerta.notificacao("Erro!", "CPF incorreto!", Alerta.enmType.Error);
					}
				}

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

            if (isOk)
            {
                if (controlProvider.SalvarFornecedor(

                    tbCod.Text,
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

                    Alerta.notificacao("Sucesso!", "Fornecedor salvo.", Alerta.enmType.Success);

                    updateDgv("");
                    activeForm();
                    mtbCpf.Focus();
                }
            }
            else
            {
                Alerta.notificacao("Erro!", "Erro ao salvar funcionário.", Alerta.enmType.Error);
            }
        }
		private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (tbCod.Text != "")
            {
                if (MessageBox.Show("Deseja excluir o fornecedor selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string cod = tbCod.Text;

                    if (controlProvider.removerFornecedor(cod) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Alerta.notificacao("Sucesso!", "Fornecedor excluido.", Alerta.enmType.Success);
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Erro ao excluir fornecedor.", Alerta.enmType.Error);

                    }
                }
            }
            else
                MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
			neutralForm();
			
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
				Fornecedor forn = controlProvider.BuscarFornecedorPorCnpj(dgv_Provider.Rows[dgv_Provider.CurrentRow.Index].Cells[1].Value.ToString());

				fillForm(forn);
				
			}
		}

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
			isExistsForn();
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
			updateDgv(tbSearch.Text);
		}

        private void gerarPdf_Click(object sender, EventArgs e)
        {
			
			
			//DataTable dtFornecedor = controlProvider.BuscarCpfNome();

			//if (dtFornecedor.Rows.Count > 0) // se existir pessoas
			//{
			//	float[] largurasColunas = { 0.5f, 1.5f };
			//	Relatorios.gerarRelatorio($"RelatórioSisVendas.Fornecedor.pdf", "Fornecedores Cadastrados!", dtFornecedor, largurasColunas);
			//}
			
		}
	}
}

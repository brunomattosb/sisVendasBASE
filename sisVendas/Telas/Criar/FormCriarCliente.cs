using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCriarCliente : Form
    {
        private ctrlCliente controlCliente = new ctrlCliente();

        public FormCriarCliente()
        {
            InitializeComponent();

            dgv_client.Columns["cli_saldo"].DefaultCellStyle.Format = "C";
            //Columns["cli_created_at"].DefaultCellStyle.Format = "dd/MM/yyyy";
            

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
                    if(tbCod.Text == "")
                    {
                        if (!isExistsClient())
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
        public void updateDgv(string filtro)
        {
            dgv_client.DataSource = controlCliente.Buscar(filtro);
        }

        public void cleanForm()
        {
            mtbCpf.Text =
            tbName.Text =
            tbFantasyName.Text =
            tbAddres.Text =
            tbCity.Text =
            tbDistrict.Text =
            mtbCep.Text =
            cbbEstado.Text =
            tbRg.Text =
            tbEmail.Text =
            mtbTelephone.Text =
            tbCod.Text = "";
            dtpDtNascimento.Value = DateTime.Now;
            cbbEstado.SelectedIndex = -1;
            cbbSex.SelectedIndex = -1;
        }
        public void neutralForm()
        {
            cleanForm();

            mtbCpf.Enabled = false;
            tbName.Enabled = false;
            tbFantasyName.Enabled = false;
            tbAddres.Enabled = false;
            cbbSex.Enabled = false;
            tbCity.Enabled = false;
            tbDistrict.Enabled = false;
            mtbCep.Enabled = false;
            cbbEstado.Enabled = false;
            dtpDtNascimento.Enabled = false;
            tbRg.Enabled = false;
            tbEmail.Enabled = false;
            mtbTelephone.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            btnNew.Enabled = true;


            tbSearch.Focus();
        }
        public void activeForm()
        {
            cleanForm();
            mtbCpf.Enabled = true;
            tbName.Enabled = true;
            tbAddres.Enabled = true;
            cbbSex.Enabled = true;
            tbCity.Enabled = true;
            tbDistrict.Enabled = true;
            mtbCep.Enabled = true;
            cbbEstado.Enabled = true;
            dtpDtNascimento.Enabled = false;
            tbRg.Enabled = true;
            tbEmail.Enabled = true;
            mtbTelephone.Enabled = true;

            btnNew.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cbbEstado.SelectedIndex = 25;
            cbbSex.SelectedIndex = 0;
            cbDtNascimento.Checked = false;
        }
        


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            /*
            DateTime dateValue = new DateTime();
             if (Function.replaceAll(mtbDtNasc.Text).Length > 0) //caso tenha dado
             {

                 if (!DateTime.TryParseExact(mtbDtNasc.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateValue))
                 {
                     Function.Alert("Erro!", "Data inválida.", popupClient.enmType.Error);
                     isOk = false;
                 }
             }
             else
             {
                 dateValue = DateTime.MaxValue;
             }*/

            int lenghtCpf = Function.replaceAll(mtbCpf.Text).Length;
            if (isOk && lenghtCpf == 0)//&& isValidCpf
            {
                Function.Alert("Erro!", "CPF/CNPJ obrigatório.", popupClient.enmType.Error);
                isOk = false;
            }
            else
            {
                if(lenghtCpf==11)
                if (!(Function.isCpfValid(mtbCpf.Text)))//&& isValidCpf
                {
                    Function.Alert("Erro!", "CPF incorreto.", popupClient.enmType.Error);
                    isOk = false;
                }
            }
            if (!cbDtNascimento.Checked)
            {
                dtpDtNascimento.Text = "01/01/1900";
            }

            if (isOk)
            {
                if(controlCliente.SalvarCliete(
                    tbCod.Text,
                    tbName.Text,
                    Function.replaceAll(mtbCpf.Text),
                    mtbCep.Text.Replace("     -", ""),
                    tbAddres.Text,
                    tbDistrict.Text,
                    tbEmail.Text,
                    Function.replaceAll(tbRg.Text),
                    Function.replaceAll(mtbTelephone.Text),
                    cbbEstado.SelectedItem.ToString(),
                    tbCity.Text,
                    tbFantasyName.Text,
                    dtpDtNascimento.Value,
                    Convert.ToChar(cbbSex.SelectedItem.ToString()),
                    Convert.ToDouble(tbSaldo.Text.Replace("R$ ", ""))
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
        

        private void btnNew_Click(object sender, EventArgs e)
        {

            activeForm();
            mtbCpf.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            neutralForm();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbCod.Text != "")
            {
                if (MessageBox.Show("Deseja excluir o cliente selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string cod = tbCod.Text;


                    if (controlCliente.removeClient(cod) == true)
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
            else if (qtde >= 11)
            {

                int pos = mtbCpf.Text.Count();
                mtbCpf.Mask = "00.000.000/0000-00";
                mtbCpf.Select(pos, 0);

                tbFantasyName.Enabled = true;
                lblCpf.Text = "*CNPJ:";
                lblRg.Text = "IE:";
                
            }

        }
        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {
                int count = Function.replaceAll(mtbCpf.Text).Count();
                changeCpfCnpj(count);
            }
            
            
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {

            if (Function.replaceAll(mtbCpf.Text).Length == 0)
                mtbCpf.Select(0, 0);
            
        }

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
            
            if (Function.replaceAll(mtbCpf.Text).Count() == 10)
            {
                changeCpfCnpj(Function.replaceAll(mtbCpf.Text).Count());
            }
           
        }

        private void mtbCep_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCep.Text).Length == 0)
                mtbCep.Select(0, 0);
        }

        private void mtbTelephone_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbTelephone.Text).Length == 0)
                mtbTelephone.Select(0, 0);
        }

        private void fillForm(Cliente cli)
        {

            int qtdeCpf = Function.replaceAll(cli.Cpf_cnpj).Count() - 1;

            changeCpfCnpj(qtdeCpf);

            if (qtdeCpf < 11)
            {
                dtpDtNascimento.Enabled = true;
            }
            else
            {
                dtpDtNascimento.Enabled = false;
            }

            tbCod.Text = cli.Id+"";
            tbName.Text = cli.Nome;
            tbFantasyName.Text = cli.Nome_fantasia;
            mtbCpf.Text = cli.Cpf_cnpj;
            mtbCep.Text = cli.Cep;
            tbAddres.Text = cli.Endereco;
            tbEmail.Text = cli.Email;
            tbRg.Text = cli.Rg_ie;
            mtbTelephone.Text = cli.Telefone;
            tbCity.Text = cli.Cidade;
            dtpDtNascimento.Value = cli.DtNascimento;
            cbbSex.Text = cli.Sexo+"";
            cbbEstado.Text = cli.Uf;
            tbDistrict.Text = cli.Bairro;
            tbSaldo.Text = cli.Saldo.ToString("C");

            if(cli.DtNascimento.Date.CompareTo(DateTime.Parse("01/01/1900")) == 0) // não tem
            {
                cbDtNascimento.Checked =
                dtpDtNascimento.Enabled = false;
            }
            else
            {
                cbDtNascimento.Checked =
                dtpDtNascimento.Enabled = true;
            }
            btnRemove.Enabled = true;
            mtbCpf.Enabled = false;

        }

        private void dgv_client_DoubleClick(object sender, EventArgs e)
        {
            
            if (dgv_client.SelectedRows.Count == 1)
            {
                activeForm();
                DataGridViewCellCollection linha = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells;

                Cliente cli = new Cliente();

                cli.Id = int.Parse(linha[0].Value.ToString());
                cli.Nome = linha[1].Value.ToString();
                cli.Email = linha[6].Value.ToString();
                cli.Nome_fantasia = linha[2].Value.ToString();
                cli.Rg_ie = linha[7].Value.ToString();
                cli.Telefone = linha[8].Value.ToString();
                cli.Cpf_cnpj = linha[3].Value.ToString();
                cli.Cep = linha[4].Value.ToString();
                cli.Endereco= linha[5].Value.ToString();
                cli.Bairro = (linha[15].Value.ToString());
                cli.Uf = (linha[14].Value.ToString());
                cli.Cidade = linha[9].Value.ToString();
                cli.DtNascimento = DateTime.Parse(linha[10].Value.ToString());
                cli.Sexo = char.Parse(linha[12].Value.ToString());
                cli.Saldo = Double.Parse(linha[13].Value.ToString());

                

                fillForm(cli);

            }
        }

        private bool isExistsClient()
        {
            string cpf = Function.replaceAll(mtbCpf.Text);

            if (cpf.Count() == 11 || cpf.Count() == 14)
            {
                Cliente cli = controlCliente.buscarClientePorCpf(cpf);
                if (cli != null)
                {
                    fillForm(cli);

                    return true;
                }
            }
            return false;
        }
        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            isExistsClient();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearch.Text);
        }

        private void cbDtNascimento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDtNascimento.Checked)
            {
                dtpDtNascimento.Enabled = true;
            }
            else
            {
                dtpDtNascimento.Enabled = false;
            }
        }
    }
}

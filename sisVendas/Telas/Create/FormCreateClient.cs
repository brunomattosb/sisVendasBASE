using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Notificacao;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCreateClient : Form
    {
        private ctrlClient controlClient = new ctrlClient();

        public FormCreateClient()
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
                    if(!isExistsClient())
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
        public void updateDgv(string filtro)
        {
            dgv_client.DataSource = controlClient.searthClient(filtro);
        }

        public void cleanForm()
        {
            mtbCpf.Text =
            mtbRgIe.Text =
            tbName.Text =
            tbFantasyName.Text =
            tbAddres.Text =
            tbCity.Text =
            tbDistrict.Text =
            mtbCep.Text =
            cbbEstado.Text =
            mtbDtNasc.Text =
            mtbRgIe.Text =
            tbEmail.Text =
            mtbTelephone.Text =
            tbCod.Text = "";
            cbbEstado.SelectedIndex = -1;
            cbbSex.SelectedIndex = -1;
        }
        public void neutralForm()
        {
            cleanForm();

            mtbCpf.Enabled = false;
            mtbRgIe.Enabled = false;
            tbName.Enabled = false;
            tbFantasyName.Enabled = false;
            tbAddres.Enabled = false;
            cbbSex.Enabled = false;
            tbCity.Enabled = false;
            tbDistrict.Enabled = false;
            mtbCep.Enabled = false;
            cbbEstado.Enabled = false;
            mtbDtNasc.Enabled = false;
            mtbRgIe.Enabled = false;
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
            mtbRgIe.Enabled = true;
            tbName.Enabled = true;
            tbAddres.Enabled = true;
            cbbSex.Enabled = true;
            tbCity.Enabled = true;
            tbDistrict.Enabled = true;
            mtbCep.Enabled = true;
            cbbEstado.Enabled = true;
            mtbDtNasc.Enabled = true;
            mtbRgIe.Enabled = true;
            tbEmail.Enabled = true;
            mtbTelephone.Enabled = true;

            btnNew.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cbbEstado.SelectedIndex = 25;
            cbbSex.SelectedIndex = 0;
        }
        


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            DateTime dateValue = new DateTime();
            // Validando data de nascimento
            if (Function.replaceAll(mtbDtNasc.Text).Length > 0) //caso tenha dado
            {
                if (!DateTime.TryParseExact(mtbDtNasc.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateValue))
                {
                    Function.Alert("Erro!", "Data inválida.", popupClient.enmType.Success);
                    isOk = false;
                }
            }
            else
            {
                dateValue = DateTime.MaxValue;
            }


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

        private void mtbRgIe_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbRgIe.Text).Length == 0)
                mtbRgIe.Select(0, 0);
            
        }

        private void mtbCep_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCep.Text).Length == 0)
                mtbCep.Select(0, 0);
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

        private void fillForm(DataGridViewCellCollection linha)
        {
            changeCpfCnpj(Function.replaceAll(linha[3].Value.ToString()).Count()-1);

            tbCod.Text = linha[0].Value.ToString();
            tbName.Text = linha[1].Value.ToString();
            tbFantasyName.Text = linha[2].Value.ToString();
            mtbCpf.Text = linha[3].Value.ToString();
            mtbCep.Text = linha[4].Value.ToString();
            tbAddres.Text = linha[5].Value.ToString();
            tbEmail.Text = linha[6].Value.ToString();
            mtbRgIe.Text = linha[7].Value.ToString();
            mtbTelephone.Text = linha[8].Value.ToString();
            tbCity.Text = linha[9].Value.ToString();
            mtbDtNasc.Text = linha[10].Value.ToString();
            cbbSex.Text = linha[12].Value.ToString();
            cbbEstado.Text = (linha[14].Value.ToString());
            tbDistrict.Text = (linha[15].Value.ToString());
            tbSaldo.Text = linha[13].Value.ToString();
        }
        
        private void dgv_client_DoubleClick(object sender, EventArgs e)
        {
            
            if (dgv_client.SelectedRows.Count == 1)
            {
                

                activeForm();
                DataGridViewCellCollection linha = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells;

                fillForm(linha);

                btnRemove.Enabled = true;
                mtbCpf.Enabled = false;
            }
        }

        private bool isExistsClient()
        {
            string cpf = Function.replaceAll(mtbCpf.Text);

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
            return false;
        }
        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            isExistsClient();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
             
        }
    }
}


using DFe.Classes.Entidades;
using DFe.Utils;
using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Create
{
    public partial class FormCriarCliente : Form
    {
        private ctrlCliente controlCliente = new ctrlCliente();
        private ctrlMunicipio controlMunicipio = new ctrlMunicipio();
        private IList<Estado> lEstado;
        private Estado estadoSelecionado;

        public FormCriarCliente()
        {
            InitializeComponent();


            lEstado = EnumParaLista.EnumToList<Estado>();
            CarregandoComboBox();



            dgv_client.Columns["cli_saldo"].DefaultCellStyle.Format = "C";
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
                    if (tbCod.Text == "")
                    {
                        if (!isExistsClient())
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
            tbNumero.Text =
            tbComplemento.Text =
            mtbCpf.Text =
            tbName.Text =
            tbFantasyName.Text =
            tbAddres.Text =
            tbDistrict.Text =
            mtbCep.Text =
            tbRg.Text =
            tbEmail.Text =
            mtbTelephone.Text =
            tbCod.Text = "";
            dtpDtNascimento.Value = DateTime.Now;
            cbbEstado.Text = "SP";
            cbbMunicipio.Text = "Presidente Epitácio";
            cbbSex.SelectedIndex = -1;
        }
        public void neutralForm()
        {
            cleanForm();

            mtbCpf.Enabled =
            tbName.Enabled = 
            tbFantasyName.Enabled = 
            tbAddres.Enabled = 
            cbbSex.Enabled = 
            cbbMunicipio.Enabled = 
            tbDistrict.Enabled = 
            mtbCep.Enabled = 
            cbbEstado.Enabled = 
            dtpDtNascimento.Enabled = 
            tbRg.Enabled = 
            tbEmail.Enabled = 
            mtbTelephone.Enabled = 
            btnSave.Enabled = 
            btnCancel.Enabled = 
            tbNumero.Enabled =
            tbComplemento.Enabled =
            cbDtNascimento.Enabled =
            btnRemove.Enabled = false;
            btnNew.Enabled = true;


            tbSearch.Focus();
        }

        public void activeForm()
        {
            mtbCpf.Enabled =
            tbName.Enabled =
            tbFantasyName.Enabled =
            tbAddres.Enabled =
            cbbSex.Enabled =
            cbbMunicipio.Enabled =
            tbDistrict.Enabled =
            mtbCep.Enabled =
            cbbEstado.Enabled =
            dtpDtNascimento.Enabled =
            tbRg.Enabled =
            tbEmail.Enabled =
            mtbTelephone.Enabled =
            btnSave.Enabled =
            btnCancel.Enabled =
            tbNumero.Enabled =
            tbComplemento.Enabled =
            cbDtNascimento.Enabled =

            tbSearch.Focus();

            btnNew.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cbbEstado.Text = "SP";
            cbbMunicipio.Text = "Presidente Epitácio";
            cbbSex.SelectedIndex = 0;

            cbDtNascimento.Checked = false;
        }
        public void updateDgv(string filtro)
        {
            dgv_client.DataSource = controlCliente.BuscarParaDGV(filtro);
        }
        private void CarregandoComboBox()
        {            
            //Carregar Estados com descrição
            foreach (Estado status in lEstado)
            {
                cbbEstado.Items.Add(status.ToString());
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            Nullable<DateTime> dtNascimento;

            lblCpf.ForeColor = Color.Black;

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

            
            if (!cbDtNascimento.Checked)
            {
                dtNascimento = null;
            }
            else
            {
                dtNascimento = dtpDtNascimento.Value.Date;
            }
            string CEP = mtbCep.Text.Replace("-", "").Replace("     ","");
            if (CEP.Length > 0 && CEP.Length < 8)
            {

                Alerta.notificacao("Erro!", string.Format(@"CEP deve ter 8 números. Tamanho informado: {0}!", CEP.Length), Alerta.enmType.Error);
                isOk = false;
            }
            if (isOk)
            {
                if (controlCliente.SalvarCliete(
                    tbCod.Text,
                    tbName.Text,
                    tbFantasyName.Text,
                    Function.replaceAll(mtbCpf.Text),
                    CEP,
                    tbAddres.Text,
                    tbNumero.Text,
                    tbDistrict.Text,
                    cbbMunicipio.Text,
                    long.Parse(cbbMunicipio.SelectedValue+""),
                    Function.replaceAll(mtbTelephone.Text),
                    Function.replaceAll(tbRg.Text),
                    cbbEstado.SelectedItem.ToString(),
                    dtNascimento,
                    Convert.ToChar(cbbSex.SelectedItem.ToString()),
                    Convert.ToDouble(tbSaldo.Text.Replace("R$ ", "")),
                    tbEmail.Text,
                    tbComplemento.Text
                    ))
                {

                    Alerta.notificacao("Sucesso!", "Cliente salvo.", Alerta.enmType.Success);

                    updateDgv("");
                    neutralForm();
                    mtbCpf.Focus();
                }
            }
            else
            {
                //Alerta.notificacao("Erro!", "Erro ao salvar cliente.", Alerta.enmType.Error);
            }
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            estadoSelecionado = (Estado)Enum.Parse(typeof(Estado), cbbEstado.SelectedItem.ToString());
            //Cbb Minicipio
            cbbMunicipio.DataSource = controlMunicipio.Buscar((int)estadoSelecionado);
            cbbMunicipio.DisplayMember = "muni_nome";
            cbbMunicipio.ValueMember = "muni_cod";
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

        private void mtbTelephone_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbTelephone.Text).Length == 0)
                mtbTelephone.Select(0, 0);
        }

        private void gerarPdf_Click(object sender, EventArgs e)
        {
            //DataTable dtClientes = controlCliente.buscarCpfNome();

            //if (dtClientes.Rows.Count > 0) // se existir pessoas
            //{
            //    float[] largurasColunas = { 0.5f, 1.5f };
            //    Relatorios.gerarRelatorio($"RelatórioSisVendas.Clientes.pdf", "Clientes Cadastrados!", dtClientes, largurasColunas);
            //}
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearch.Text);
        }

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Count() == 10)
            {
                changeCpfCnpj(Function.replaceAll(mtbCpf.Text).Count());
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


                    if (controlCliente.RemoverCliente(cod) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Alerta.notificacao("Sucesso!", "Cliente excluido.", Alerta.enmType.Success);
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Erro ao excluir cliente.", Alerta.enmType.Error);

                    }
                }
            }
            else
                MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_client_DoubleClick(object sender, EventArgs e)
        {
           if (dgv_client.SelectedRows.Count == 1)
           {
                activeForm();
                Cliente cli = controlCliente.buscarClientePorCpf(dgv_client.Rows[dgv_client.CurrentRow.Index].Cells[2].Value.ToString());

                fillForm(cli);
            }
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
            mtbCep.Text = cli.Endereco.CEP;
            tbAddres.Text = cli.Endereco.xLgr;
            tbEmail.Text = cli.Email;
            tbRg.Text = cli.Rg_ie;
            mtbTelephone.Text = cli.Endereco.fone.ToString();
            cbbMunicipio.Text = cli.Endereco.xMun;
            cbbSex.Text = cli.Sexo.ToString();
            cbbEstado.Text = cli.Endereco.UF;
            tbDistrict.Text = cli.Endereco.xBairro;
            tbSaldo.Text = cli.Saldo.ToString("C");
            tbComplemento.Text = cli.Endereco.xCpl;
            tbNumero.Text = cli.Endereco.nro;

            
            if (!DateTime.TryParse(cli.DtNascimento.ToString(), out DateTime result))
            {
                // é null
                dtpDtNascimento.Value = DateTimePicker.MinimumDateTime;
                cbDtNascimento.Checked =
                dtpDtNascimento.Enabled = false;
            }
            else
            {
                dtpDtNascimento.Value = result;
                cbDtNascimento.Checked =
                dtpDtNascimento.Enabled = true;
            }

            btnRemove.Enabled = true;
            mtbCpf.Enabled = false;
        }

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            isExistsClient();
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
    }
}

using sisVendas.Controllers;
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
    public partial class FormCreateClient : Form
    {
        private ctrlClient controlClient = new ctrlClient();
        private IFormatProvider enUS;

        public FormCreateClient()
        {
            InitializeComponent();
            enable("neutral");
        }

        public void enable(string op)
        {
            if (op == "neutral")
            {
                mtbCpf.Enabled =
                mtbRgIe.Enabled =
                tbName.Enabled =
                tbFantasyName.Enabled =
                tbAddres.Enabled =
                cbbSex.Enabled =
                tbCity.Enabled =
                tbDistrict.Enabled =
                mtbCep.Enabled =
                cbbEstado.Enabled =
                mtbDtNasc.Enabled =
                mtbRgIe.Enabled =
                tbEmail.Enabled =
                mtbTelephone.Enabled = false;
                
                btnSave.Enabled =
                btnCancel.Enabled = 
                btnRemove.Enabled = false;
                btnNew.Enabled = true;

                cbbEstado.SelectedIndex = -1;
                cbbSex.SelectedIndex = -1;
                tbSearch.Focus();

            }else if (op == "active")
                {
                    mtbCpf.Enabled =
                    mtbRgIe.Enabled =
                    tbName.Enabled =
                    tbFantasyName.Enabled =
                    tbAddres.Enabled =
                    cbbSex.Enabled =
                    tbCity.Enabled =
                    tbDistrict.Enabled =
                    mtbCep.Enabled =
                    cbbEstado.Enabled =
                    mtbDtNasc.Enabled =
                    mtbRgIe.Enabled =
                    tbEmail.Enabled =
                    mtbTelephone.Enabled = true;

                    btnNew.Enabled =
                    btnRemove.Enabled = false;
                    btnSave.Enabled = 
                    btnCancel.Enabled = true;

                    cbbEstado.SelectedIndex = 24;
                    cbbSex.SelectedIndex = 0;
                    mtbCpf.Focus();

                }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            DateTime dateValue = new DateTime();
            // Validando data de nascimento
            if (mtbDtNasc.Text.Replace("  /", "").Length > 0) //caso tenha dado
            {
                if (!DateTime.TryParseExact(mtbDtNasc.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out dateValue))
                {
                    MessageBox.Show("Data inválida!", "ERRO!");
                    isOk = false;
                }
            }



            controlClient.SaveClient(
                    tbCod.Text,
                    tbName.Text,
                    mtbCpf.Text,
                    mtbCep.Text,
                    tbAddres.Text,
                    tbDistrict.Text,
                    tbEmail.Text,
                    mtbRgIe.Text,
                    mtbTelephone.Text,
                    cbbEstado.SelectedItem.ToString(),
                    tbCity.Text,
                    tbFantasyName.Text,
                    dateValue,
                    Convert.ToChar(cbbSex.SelectedItem.ToString()),
                    Convert.ToDouble(tbSaldo.Text)
                    );
            


            //cbbEstado.SelectedItem.ToString(),
            //char.Parse(cbbSexo.SelectedItem.ToString()),




            //enable("active");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enable("active");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enable("neutral");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            enable("neutral");
        }
    }
}

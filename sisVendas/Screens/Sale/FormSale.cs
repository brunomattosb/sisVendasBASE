using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    public partial class gbProduto : Form
    {
        public gbProduto()
        {
            InitializeComponent();
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
                    //btnCancel.PerformClick();
                    break;
                case Keys.Control | Keys.N:
                    //btnNew.PerformClick();
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void updateDgv(string filtro)
        {
            //dgv_client.DataSource = controlClient.searthClient(filtro);
        }

        public void cleanForm()
        {
            /*mtbCpf.Text =
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
            cbbSex.SelectedIndex = -1;*/
        }
        public void neutralForm()
        {
            cleanForm();

            /*mtbCpf.Enabled = false;
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


            tbSearch.Focus();*/
        }
        public void activeForm()
        {
            cleanForm();
            /*mtbCpf.Enabled = true;
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
            cbbSex.SelectedIndex = 0;*/
        }

        private void timer_sale_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

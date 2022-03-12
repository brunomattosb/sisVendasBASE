using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Screens.Client
{
    public partial class FormBuscarCliente : Form
    {
        private ctrlClient controlClient = new ctrlClient();
        private DataRow clientSelected;
        private DataTable dttClient;
        public FormBuscarCliente()
        {
            InitializeComponent();
            updateDgv("");
            tbSearth.Focus();

        }
        public void updateDgv(string filtro)
        {
            dttClient = controlClient.searthClient(filtro);
            dgv_client.DataSource = dttClient;
            
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    selectClient();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbSearth_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearth.Text);
        }

        private void dgv_client_DoubleClick(object sender, EventArgs e)
        {
            selectClient();
        }
        private void selectClient()
        {
            if (dgv_client.CurrentRow != null)
            {
                clientSelected = dttClient.Rows[dgv_client.CurrentRow.Index];
                Close();
            }
        }
        public Cliente returnClient()
        {
            if(clientSelected != null)
            {
                return controlClient.buscarClientePorCpf(clientSelected["cli_cpf_cnpj"].ToString());
            }
            else { 
                return null; 
            }

        }

    }
}

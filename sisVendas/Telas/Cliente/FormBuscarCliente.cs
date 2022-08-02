using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Screens.Client
{
    public partial class FormBuscarCliente : Form
    {
        private ctrlCliente controlClient = new ctrlCliente();
        private string cpfCliente = "";
        private DataTable dttClient;
        public FormBuscarCliente()
        {
            InitializeComponent();

            dgv_client.Columns["cli_saldo"].DefaultCellStyle.Format = "C";
            updateDgv("");
            tbSearth.Focus();

        }
        public void updateDgv(string filtro)
        {
            dttClient = controlClient.BuscarParaDGV(filtro);
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

                cpfCliente = dgv_client.Rows[dgv_client.CurrentRow.Index].Cells[2].Value.ToString();
                Close();
            }
        }
        public Cliente returnClient()
        {
            if (cpfCliente != "")
            {
                return controlClient.buscarClientePorCpf(cpfCliente);
            }
            else
            {
                return null;
            }

        }

    }
}

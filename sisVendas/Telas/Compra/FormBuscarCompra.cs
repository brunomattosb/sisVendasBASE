using sisVendas.Functions;
using sisVendas.Notificacao;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Compra
{
    public partial class FormBuscarCompra : Form
    {
        private ctrlCompra controlCompra = new ctrlCompra();
        private int idCompraSelecionada = 0;
        private DataTable dttCompra;
        public FormBuscarCompra()
        {
            InitializeComponent();
            dgv_compra.Columns["total"].DefaultCellStyle.Format = "C";
            dgv_compra.Columns["desconto"].DefaultCellStyle.Format = "C";

            updateDgv("");
        }
        private void updateDgv(string filtro)
        {
            dttCompra = controlCompra.buscarCompra(filtro);
            dgv_compra.DataSource = dttCompra;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    selecionarCompra();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void selecionarCompra()
        {
            if (dgv_compra.CurrentRow != null)
            {
                DataRow row = dttCompra.Rows[dgv_compra.CurrentRow.Index];

                idCompraSelecionada = Convert.ToInt32(row[0]);

                Close();
            }
        }

        private void dgv_venda_DoubleClick(object sender, EventArgs e)
        {
            selecionarCompra();
        }
        public int retornaCompra()
        {
            return idCompraSelecionada;
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Length == 0)
                mtbCpf.Select(0, 0);
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            string text = tbValor.Text.Replace("R$", "");

            if (double.TryParse(text, out double res))
                tbValor.Text = String.Format("{0:c}", res);
            else
            {
                tbValor.Text = "";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";
            if (cbbMN.SelectedIndex != -1)
            {
                if (tbValor.Text != "")
                {
                    filtro = "total_compra " + cbbMN.Text + tbValor.Text.Replace("R$", "").Replace(".", "").Replace(",", ".");
                }
            }

            if (Function.replaceAll(mtbCpf.Text).Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "forn_cpf_cnpj like '" + mtbCpf.Text.Replace(",", "").Replace("-", "").Trim() + "%'";
            }
            if (tbName.Text.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "forn_nome like '%" + tbName.Text + "%'";
            }

            if(cbPesquisarPorPeriodo.Checked)
            {
                if (dtpInicio.Value.Date <= dtpFim.Value.Date)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "compra_criado_em BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }
                else
                {
                    Function.Alert("Alerta!", "Data Inicio maior que data Fim", popupClient.enmType.Warning);
                }
            }
            Console.WriteLine(filtro);
            updateDgv(filtro);
        }
    }
}

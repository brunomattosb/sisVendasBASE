using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Sale
{
    public partial class FormBuscarVenda : Form
    {
        
        private ctrlVenda controlVenda = new ctrlVenda();
        private int vendaSelecionada = 0;
        private DataTable dttVenda;

        public FormBuscarVenda()
        {
            InitializeComponent();
            dgv_venda.Columns["total"].DefaultCellStyle.Format = "C";
            dgv_venda.Columns["desconto"].DefaultCellStyle.Format = "C";

            updateDgv("");
        }
         
        private void updateDgv(string filtro)
        {
            dttVenda = controlVenda.buscarVendas(filtro);
            dgv_venda.DataSource = dttVenda;
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    selecionarVenda();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void selecionarVenda()
        {
            if (dgv_venda.CurrentRow != null)
            {
                DataRow row = dttVenda.Rows[dgv_venda.CurrentRow.Index];

                vendaSelecionada = Convert.ToInt32(row[0]);

                Close();
            }
        }
        
        private void dgv_venda_DoubleClick(object sender, EventArgs e)
        {
            selecionarVenda();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if(cbbMN.SelectedIndex > 0)
            {
                if (tbValor.Text != "")
                {
                    filtro = "total_venda " + cbbMN.Text + tbValor.Text.Replace("R$", "").Replace(".", "").Replace(",", ".");
                }
            }

            string cpf = Function.replaceAll(mtbCpf.Text);

            if (cpf.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_cpf_cnpj like '" + cpf.Trim()+ "%'";
            }
            if (tbName.Text.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_nome like '%" + tbName.Text+ "%'";
            }
            
            if(cbPesquisarPeriodo.Checked)
            {
                if (dtpInicio.Value.Date <= dtpFim.Value.Date)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "venda_criado_em BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }
                else
                {
                    Function.Alert("Alerta!", "Data Inicio maior que data Fim", popupClient.enmType.Warning);
                }
            }

            Console.WriteLine(filtro);
            updateDgv(filtro);

        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            string text = tbValor.Text.Replace("R$", "");

            if (double.TryParse(text, out double res))
                tbValor.Text = String.Format("{0:c}", res);
            else
            {
                tbValor.Text = "R$ 0,00";
            }
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Length == 0)
                mtbCpf.Select(0, 0);
        }

        public int retornaVenda()
        {
             return vendaSelecionada;
        }

        private void tbValor_Enter(object sender, EventArgs e)
        {
            if(tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
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
                lblCpf.Text = "CPF:";

            }
            else if (qtde >= 11)
            {

                int pos = mtbCpf.Text.Count();
                mtbCpf.Mask = "00.000.000/0000-00";
                mtbCpf.Select(pos, 0);

                lblCpf.Text = "CNPJ:";
            }

        }

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Count() == 10)
            {
                changeCpfCnpj(Function.replaceAll(mtbCpf.Text).Count());
            }
        }
    }
}

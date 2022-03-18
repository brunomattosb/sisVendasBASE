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
        private VendaCompleta vendaSelecionada;
        private DataTable dttVenda;

        public FormBuscarVenda()
        {
            InitializeComponent();
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

                vendaSelecionada = new VendaCompleta();
                vendaSelecionada.Id = Convert.ToInt32(row[0]);
                vendaSelecionada.Desconto = Convert.ToDouble(row[1].ToString().Replace("R$",""));
                vendaSelecionada.Total_venda = Convert.ToDouble(row[2].ToString().Replace("R$", ""));
                vendaSelecionada.Venda_criado_em = Convert.ToDateTime(row[3]);
                vendaSelecionada.Cli_name = Convert.ToString(row[4]);
                vendaSelecionada.Cli_cpf_cnpj = Convert.ToString(row[5]);

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
            if(cbbMN.SelectedIndex != -1)
            {
                if (tbValor.Text != "")
                {
                    filtro = "total_venda " + cbbMN.Text + tbValor.Text.Replace("R$", "").Replace(",",".");
                }
            }

            if(Function.replaceAll(mtbCpf.Text).Length == 11)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_cpf_cnpj = " + mtbCpf.Text.Replace(",", "").Replace("-", "");
            }
            if (tbName.Text.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_name = '" + tbName.Text+"'";
            }
            if (DateTime.TryParse(mtbDtInicio.Text, out DateTime ini) && DateTime.TryParse(mtbDtFim.Text, out DateTime fim))
            {
                if (ini < fim)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "venda_criado_em BETWEEN '" + ini.Date.ToString() + "' AND '" + fim.Date.ToString()+"'";
                }
            }
            updateDgv(filtro);
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

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void mtbDtInicio_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbDtInicio.Text).Length == 0)
                mtbDtInicio.Select(0, 0);
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Length == 0)
                mtbCpf.Select(0, 0);
        }

        private void mtbDtFim_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbDtFim.Text).Length == 0)
                mtbDtFim.Select(0, 0);
        }

        public VendaCompleta retornaVenda()
        {
            if (vendaSelecionada != null)
            {
                return vendaSelecionada;
            }


            return null;
            

        }
    }
}

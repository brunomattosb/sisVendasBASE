using sisVendas.Functions;
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

namespace sisVendas.Screens.Sale
{
    public partial class FormSimularVenda : Form
    {
        private double totalVenda;
        private double totalOffset = 0;
        public FormSimularVenda()
        {
            InitializeComponent();
            tbValor.Focus();
        }
        public FormSimularVenda(double value):this()
        {
            lblValor.Text = "R$ " + value;
            this.totalVenda = value; 
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbValor.Text.Count() > 0)
            {
                string text = tbValor.Text.Replace("R$", "");
                double value = double.Parse(text);
                if (totalOffset + value <= totalVenda)
                {
                    totalOffset = totalOffset + value;
                    lbListOffsetValue.Items.Add(tbValor.Text);

                    tbTotalOffset.Text = "R$: " + totalOffset.ToString();
                    tbSubtotalOffset.Text = "R$: " + (totalVenda - totalOffset) + "";

                    tbValor.Text = "";
                    tbValor.Focus();
                }
                else
                {
                    Function.Alert("Alerta!", "Valor a ser pago maior que saldo devedor.", popupClient.enmType.Warning);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbValor.Text.Count() > 0)
            {
                string text = tbValor.Text.Replace("R$", "");
                double value = double.Parse(text);

                if (value <= totalOffset)
                {
                    totalOffset = totalOffset - value;
                    lbListOffsetValue.Items.Add("-" + tbValor.Text);

                    tbTotalOffset.Text = "R$: " + totalOffset.ToString();
                    tbSubtotalOffset.Text = "R$: " + (totalVenda - totalOffset) + "";

                    tbValor.Text = "";
                    tbValor.Focus();
                }
                else
                {
                    Function.Alert("Alerta!", "Valor a ser pago maior que saldo devedor.", popupClient.enmType.Warning);
                }
            }
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
            if(text.Count()>0)
                if (double.TryParse(text, out double res))
                    tbValor.Text = String.Format("{0:c}", res);
                else
                {
                    tbValor.Text = "";
                    Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
                }
        }
    }
}

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
    public partial class FormCalcularTroco : Form
    {
        public FormCalcularTroco()
        {
            InitializeComponent();
        }
        public FormCalcularTroco(double value) : this()
        {
            if (value > 0)
            {
                tbValor.Text = value.ToString("C");
                tbRecebido.Focus();
            }
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
        private void CalculaTroco(double recebido, double valorTotal)
        {

            if (recebido >= valorTotal)
            {
                lblTroco.Text = (recebido - valorTotal).ToString("C");
            }
            else
            {
                //lblTroco.Text = "R$ 0,00";
            }

            
        }
        private void tbReceived_Leave(object sender, EventArgs e)
        {
            string text = tbRecebido.Text.Replace("R$ ", "");

            if (double.TryParse(text, out double recebido))
            {
                tbRecebido.Text = recebido.ToString("C");

                if (double.TryParse(tbValor.Text.Replace("R$ ", ""), out double valorTotal))
                    CalculaTroco(recebido, valorTotal);
            }
            else
            {
                tbRecebido.Text = "R$ 0,00";
            }
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
   
        private void tbValue_Leave(object sender, EventArgs e)
        {
            string text = tbValor.Text.Replace("R$ ", "");

            if (double.TryParse(text, out double valorTotal))
            {
                tbValor.Text = valorTotal.ToString("C");

                if (double.TryParse(tbRecebido.Text.Replace("R$ ", ""), out double recebido))
                    CalculaTroco(recebido, valorTotal);
            }
            else
            {
                tbValor.Text = "R$ 0,00";
            }
        }

        private void tbValue_Enter(object sender, EventArgs e)
        {
            if(tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
            }
        }

        private void tbReceived_Enter(object sender, EventArgs e)
        {
            if (tbRecebido.Text == "R$ 0,00")
            {
                tbRecebido.Text = "";
            }
        }
    }
}

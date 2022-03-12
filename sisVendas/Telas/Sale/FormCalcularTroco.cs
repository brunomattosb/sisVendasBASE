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
        public FormCalcularTroco(double value) :this()
        {
            if(value > 0)
            {
                tbValue.Text = "R$" + value;
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
        private void tbReceived_Leave(object sender, EventArgs e)
        {
            string text = tbReceived.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbReceived.Text = String.Format("{0:c}", res);
                if (tbReceived.Text.Count() > 0 && tbValue.Text.Count() > 0)
                {
                    double received = Convert.ToDouble(tbReceived.Text.Replace("R$",""));
                    double valueTotal = Convert.ToDouble(tbValue.Text.Replace("R$", ""));

                    if (received >= valueTotal)
                    {
                        lblThing.Text = "R$ " + (received - valueTotal).ToString("F");
                    }
                    else
                    {
                        Function.Alert("Atenção!", "Troco negativo.", popupClient.enmType.Error);
                    }
                }
            }
            else
            {
                tbValue.Text = "";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
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
            string text = tbValue.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
                tbValue.Text = String.Format("{0:c}", res);
            else
            {
                tbValue.Text = "";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }
    }
}

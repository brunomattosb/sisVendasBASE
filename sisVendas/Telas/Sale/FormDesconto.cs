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
    public partial class FormDesconto : Form
    {
        double valorDesconto = 0;
        double totalVenda;
        public FormDesconto()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    calculaDesconto(); 
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public FormDesconto(double totalVenda) : this()
        {
            this.totalVenda = totalVenda;
            tbValueDiscount.Focus();
        }
        public double getDesconto()
        {
            return valorDesconto;
        }

        private void ccbMoney_Click(object sender, EventArgs e)
        {
            if (ccbPercent.Checked == true)
            {
                ccbPercent.Checked = false;
            }
            ccbMoney.Checked = true;
        }

        private void ccbPercent_Click(object sender, EventArgs e)
        {
            if (ccbMoney.Checked == true)
            {
                ccbMoney.Checked = false;
            }
            ccbPercent.Checked = true;
        }

        private void tbValueDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13) //ENTER
            {
                calculaDesconto();
            }
        }

        private void calculaDesconto()
        {
            string strValor = tbValueDiscount.Text;
            if (strValor.Count() > 0)
            {
                double valor = double.Parse(strValor);
                if (ccbMoney.Checked == true)
                {

                    valorDesconto = valor;

                }
                else
                {
                    valorDesconto = (valor / 100) * totalVenda;
                }
            }
            else
            {
                valorDesconto = 0;
            }

            Close();
        }
        private void btnAppDiscount_Click(object sender, EventArgs e)
        {
            calculaDesconto();
        }
    }
}

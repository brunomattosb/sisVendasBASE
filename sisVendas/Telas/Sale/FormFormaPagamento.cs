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
    public partial class FormFormaPagamento : Form
    {
        public FormFormaPagamento()
        {
            InitializeComponent();
        }

        private void ccbMoney_CheckedChanged(object sender, EventArgs e)
        {
            ccbMoney.Checked = !ccbPercent.Checked;
        }

        private void ccbPercent_CheckedChanged(object sender, EventArgs e)
        {
            ccbPercent.Checked = !ccbMoney.Checked;
        }

    }
}

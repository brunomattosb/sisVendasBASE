using sisVendas.Screens.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }


        private void menuBtnFuncionario_Click(object sender, EventArgs e)
        {
            FormCreateEmployee f = new FormCreateEmployee();
            f.ShowDialog();
        }


        private void menuBtnClient_Click(object sender, EventArgs e)
        {
            FormCreateClient f = new FormCreateClient();
            f.ShowDialog();
        }

        private void menuBtnProvider_Click(object sender, EventArgs e)
        {
            FormCreateProvider f = new FormCreateProvider();
            f.ShowDialog();
        }

        private void menuBtnProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct f = new FormCreateProduct();
            f.ShowDialog();
        }

        private void menuBtnProductCategory_Click(object sender, EventArgs e)
        {
            FormCreateProductCategory f = new FormCreateProductCategory();
            f.ShowDialog();
        }

        private void menuBtnProductBrand_Click(object sender, EventArgs e)
        {
            FormCreateProductBrand f = new FormCreateProductBrand();
            f.ShowDialog();
        }

        private void menuBtnExpense_Click(object sender, EventArgs e)
        {
            FormCreateExpense f = new FormCreateExpense();
            f.ShowDialog();
        }

        private void menuBtnExpenseType_Click(object sender, EventArgs e)
        {
            FormCreateExpenseType f = new FormCreateExpenseType();
            f.ShowDialog();
        }

        private void menuBtnParameterization_Click(object sender, EventArgs e)
        {
            FormParameterization f = new FormParameterization();
            f.ShowDialog();
        }
    }
}

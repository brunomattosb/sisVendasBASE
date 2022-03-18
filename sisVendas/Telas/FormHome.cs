using sisVendas.Screens.Create;
using sisVendas.Screens.Sale;
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
            lembretes();
        }
        public void lembretes()
        {
            richTextBox1.Text = @"Performance:

                            Fazer:
                            [] Não deixar excluir uma categoria e uma marca que esteja em uso.
                            [] Nas buscar onde só envolve um item, tirar o foreach.
                            [] Adicionar controle de estoque ao realizar uma venda
                            [] ctrl enter do cadastrar produto não funciona
                            [] 
                            [] 
                            [] 
                            [] update de funcionario não funciona
                            [] colocar o valor na venda do produto
                            [] venda não aceita mask CNPJ
                        ";
            
        }

        private void openForm(Form f)
        {
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
        private void menuBtnFuncionario_Click(object sender, EventArgs e)
        {
                
            FormCreateEmployee f = new FormCreateEmployee();
            openForm(f);
        }


        private void menuBtnClient_Click(object sender, EventArgs e)
        {
            FormCreateClient f = new FormCreateClient();
            openForm(f);
        }

        private void menuBtnProvider_Click(object sender, EventArgs e)
        {
            FormCreateProvider f = new FormCreateProvider();
            openForm(f); ;
        }

        private void menuBtnProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct f = new FormCreateProduct();
            openForm(f);
        }

        private void menuBtnProductCategory_Click(object sender, EventArgs e)
        {
            FormCreateProductCategory f = new FormCreateProductCategory();
            openForm(f);
        }

        private void menuBtnProductBrand_Click(object sender, EventArgs e)
        {
            FormCreateProductBrand f = new FormCreateProductBrand();
            openForm(f);
        }
        private void menuBtnExpense_Click(object sender, EventArgs e)
        {
            FormCreateExpense f = new FormCreateExpense();
            openForm(f);
        }

        private void menuBtnExpenseType_Click(object sender, EventArgs e)
        {
            FormCreateExpenseType f = new FormCreateExpenseType();
            openForm(f);
        }

        private void menuBtnParameterization_Click(object sender, EventArgs e)
        {
            FormParameterization f = new FormParameterization();
            openForm(f);
        }

        private void menuBtnEfetuarVenda_Click(object sender, EventArgs e)
        {
            FormVenda f = new FormVenda();
            //f.WindowState = FormWindowState.Maximized;
            //f.FormBorderStyle = FormBorderStyle.None;
            openForm(f);
        }
    }
}

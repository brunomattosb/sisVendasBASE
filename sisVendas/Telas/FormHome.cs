using sisVendas.Controllers;
using sisVendas.Models;
using sisVendas.Screens.Create;
using sisVendas.Screens.Sale;
using sisVendas.Telas;
using sisVendas.Telas.Caixa;
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
        Employee funcLogado;

        private ctrlCaixa controlCaixa = new ctrlCaixa();
       
        private Caixa caixaSelecionado = null;

        public FormHome()
        {
            InitializeComponent();

            
            

            lembretes();
        }

        public bool validaLogin()
        {
            FormLogin f = new FormLogin();
            f.ShowDialog();

            funcLogado = f.retornaFuncionario();

            if (funcLogado == null)
            {
                return false;
                
            }
            else
            {
                
                lblNomeFuncLogado.Text = funcLogado.Name;
                return true;
            }
            
        }
        public void lembretes()
        {
            richTextBox1.Text = @"Performance:

                            Fazer:
                            [] Adicionar controle de estoque ao realizar uma venda
                            [] Não deixar excluir uma categoria e uma marca que esteja em uso.
                            [] Adicionar id_vendedor no realizar venda
                            [] 
                            [] Não deixar vender fiado para não clientes
                            [] beetween não funciona na busca de parcelas a receber e na busca de vendas
                            [] fazer o contas a receber e inserir ao realizar a venda
                            [] colocar foreignkey idfuncionario no caixa  e no transacao caixa
                            [] Erro ao fechar o form login no esc, solução colocar um try catch no Program.cs
                        ";
            
        }

        #region OpenForm
        
        private void openForm(Form f)
        {
            f.MaximizeBox = false;
            f.MinimizeBox = false;
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
            if(lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Caixa fechado!");
            }
            else
            {
                FormVenda f = new FormVenda(caixaSelecionado.Id);
                //f.WindowState = FormWindowState.Maximized;
                //f.FormBorderStyle = FormBorderStyle.None;
                openForm(f);
            }

            
        }
        private void menuBtnAbrirFecharCaixa_Click(object sender, EventArgs e)
        {
            FormAbrirFecharCaixa f = new FormAbrirFecharCaixa(funcLogado.Id);
            openForm(f);

            caixaSelecionado = f.retornaCaixa();

            alterarLabel();
        }
        #endregion

        private void FormHome_Load(object sender, EventArgs e)
        {
            if(validaLogin())
            {
                // Se o login for true, busca o caixa logado aberto.
                buscarCaixaAberto(funcLogado.Id);
            }
            else
            {
                Close();
            }
        }
        private void buscarCaixaAberto(int cod)
        {

            caixaSelecionado = controlCaixa.buscarCaixaAberto(cod);

            alterarLabel();
        }
        private void alterarLabel()
        {
            if (caixaSelecionado == null)
            {
                lblCaixaStatus.Text = "FECHADO.";
                lblCaixaStatus.ForeColor = Color.Red;
            }
            else
            {
                lblCaixaStatus.Text = "ABERTO.";
                lblCaixaStatus.ForeColor = Color.Green;
            }
        }

        private void menuBtnQuitarPagamento_Click(object sender, EventArgs e)
        {
            

            if (lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Caixa fechado!");
            }
            else
            {
                FormContasAReceber f = new FormContasAReceber(caixaSelecionado.Id);
                openForm(f);
            }
        }
    }
}

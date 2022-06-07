using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using sisVendas.Screens.Create;
using sisVendas.Screens.Sale;
using sisVendas.Telas;
using sisVendas.Telas.Caixa;
using sisVendas.Telas.Compra;
using sisVendas.Telas.Promocao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sisVendas
{
    public partial class FormHome : Form
    {
        Funcionario funcLogado;

        private ctrlCaixa controlCaixa = new ctrlCaixa();
       
        private Caixa caixaSelecionado = null;

        public FormHome()
        {
            InitializeComponent();

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
                lblNomeFuncLogado.Text = funcLogado.Nome;
                this.WindowState = FormWindowState.Maximized;
                return true;
            }
            
        }

        #region OpenForm
        
        
        private void menuBtnFuncionario_Click(object sender, EventArgs e)
        {
                
            FormCriarFuncionario f = new FormCriarFuncionario();
            f.ShowDialog();
        }


        private void menuBtnClient_Click(object sender, EventArgs e)
        {
            FormCriarCliente f = new FormCriarCliente();
            f.ShowDialog();
        }

        private void menuBtnProvider_Click(object sender, EventArgs e)
        {
            FormCreiarFornecedor f = new FormCreiarFornecedor();
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

        private void menuBtnEfetuarVenda_Click(object sender, EventArgs e)
        {
            if(lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormVenda f = new FormVenda(caixaSelecionado.Id, caixaSelecionado.IdFunc);
                f.WindowState = FormWindowState.Maximized;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowDialog();
            }            
        }
        private void menuBtnAbrirFecharCaixa_Click(object sender, EventArgs e)
        {
            FormAbrirFecharCaixa f = new FormAbrirFecharCaixa(funcLogado.Id);
            f.ShowDialog();

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
        private void buscarCaixaAberto(int idFunc)
        {

            caixaSelecionado = controlCaixa.buscarCaixaAberto(idFunc);

            alterarLabel();
        }
        private void alterarLabel()
        {

            if(caixaSelecionado == null)
            {
                lblCaixaStatus.Text = "FECHADO.";
                lblCaixaStatus.ForeColor = Color.Red;
            }
            else
            {
                if (caixaSelecionado.Dtfechamento != null) // caixa FECHADO
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
        }

        private void menuBtnLancarDespesa_Click(object sender, EventArgs e)
        {
            

            if (lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                FormLancarDespesas f = new FormLancarDespesas(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnLancarCompra_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormLancarCompra f = new FormLancarCompra(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }


        private void menuBtnQuitarRecebimento_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormContasAReceber f = new FormContasAReceber(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnQuitarPagamento_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormContasAPagar f = new FormContasAPagar(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnRegistrarPromocao_Click(object sender, EventArgs e)
        {

            FormRegistrarPromocao f = new FormRegistrarPromocao(funcLogado.Id);
            f.ShowDialog();

        }


    }
}


using NFe.Utils;
using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas
{
    public partial class FormLogin : Form
    {
        private ctrlFuncionario controlFunc = new ctrlFuncionario();
        private ctrlBanco controlBanco = new ctrlBanco();
        private Funcionario funcAtual;
        private string dir_img;
        public FormLogin(string dir_img)
        {
            InitializeComponent();
            this.dir_img = dir_img;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEntrar.PerformClick();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
           Close();
        }

        public void msgErro()
        {
            funcAtual = null;
            MessageBox.Show("Usuário ou Senha invalido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            tbUsuario.Text = tbSenha.Text = "";
            tbUsuario.Focus();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (tbUsuario.Text.Count() > 0)
            {
                Funcionario emp = controlFunc.BuscarFuncionarioPorUsuario(tbUsuario.Text);
                if (emp != null)
                {
                    if (tbSenha.Text == emp.Senha)
                    {
                        funcAtual = emp;
                        Close();
                    }
                    else
                    {
                        msgErro();
                    }
                }
                else
                {

                    msgErro();
                }
            }
            else
            {
                msgErro();
            }

        }
        public Funcionario retornaFuncionario()
        {
            return funcAtual;
        }
        private void verificarSeExisteBanco()
        {
            //Desenvolvimento
           //if (!File.Exists(@"C:\Users\Bruno\Documents\sisVendas\sisVendas\DataBase\dbSis.mdf"))

            //Producao
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf"))
            {
                //Caso não exista
                // criar um DB
                if (MessageBox.Show("O Banco de Dados não foi encontrado! \n Deseja criar um novo ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    controlBanco.CriarDB();
                }
            }
            
            // apagar
            funcAtual = controlFunc.BuscarFuncionarioPorUsuario("admin");
            Close();
            //apagar até aqui
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBoxLogo.Image = Image.FromFile(dir_img);
                
            }
            catch
            {
                Alerta.notificacao( "Alerta!", "Imagem não encontrada!", Alerta.enmType.Warning);
            }
            verificarSeExisteBanco();

            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string target = "https://www.instagram.com/automacoesbrasil/";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show("Erro ao abrir o Instagram! "+noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show("Erro ao abrir o Instagram! " + other.Message);
            }
        }

    }
}

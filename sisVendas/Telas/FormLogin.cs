using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas
{
    public partial class FormLogin : Form
    {
        private ctrlEmployee controlFunc = new ctrlEmployee();
        private Employee funcAtual;
        public FormLogin()
        {
            InitializeComponent();
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
            if(tbUsuario.Text.Count() > 0)
            {
                Employee emp = controlFunc.buscarFuncPeloUsername(tbUsuario.Text);
                if (emp != null)
                {
                    if (tbSenha.Text == emp.Password)
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
        public Employee retornaFuncionario()
        {
            return funcAtual;
        }

    }
}

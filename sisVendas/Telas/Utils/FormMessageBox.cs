using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Utils
{
    public partial class FormMessageBox : Form
    {
        private string resposta  = "-1";
        public FormMessageBox()
        {
            InitializeComponent();

        }
        public FormMessageBox(string pergunta) : this()
        {
            lblPergunta.Text = pergunta;

        }
        public FormMessageBox(string pergunta, string resposta) : this()
        {
            lblPergunta.Text = pergunta;
            tbResposta.Text = resposta;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    resposta = "-1";
                    Close();
                    break;
                case Keys.Enter:
                    resposta = tbResposta.Text;
                    Close();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            resposta = tbResposta.Text;
            Close();
        }
        public string retornaMsg()
        {
            if (resposta != "")
                return resposta;
            return null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

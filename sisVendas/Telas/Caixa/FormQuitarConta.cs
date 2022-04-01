using sisVendas.Controllers;
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

namespace sisVendas.Telas.Caixa
{
    public partial class FormQuitarConta : Form
    {
        private int idParcela;
        private double ValorParcela;
        private int idCaixa;
        private int idVenda;

        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();
        public FormQuitarConta()
        {
            InitializeComponent();
        }

        public FormQuitarConta(double valor, int idParcela, int idCaixa, int idVenda) :this()
        {
            this.ValorParcela = valor;
            this.idParcela = idParcela;
            this.idCaixa = idCaixa;
            this.idVenda = idVenda;
            lblValor.Text = "R$ "+valor;
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
        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            string text = tbValor.Text.Replace("R$", "");
            if (text.Count() > 0)
                if (double.TryParse(text, out double res))
                    tbValor.Text = String.Format("{0:c}", res);
                else
                {
                    tbValor.Text = "";
                    Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
                }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(double.TryParse(tbValor.Text.Replace("R$ ",""), out double valorPago))
            {
                if(cbbTipo.SelectedIndex != -1)
                {
                    if(valorPago > 0)
                    {
                        if (valorPago < ValorParcela)
                        {
                            controlParcelas.quitarParcelaParcial(idParcela, ValorParcela, valorPago, idCaixa, idVenda, cbbTipo.Text);//, cbbTipo.Text, );
                        }
                        else if (valorPago == ValorParcela)
                        {
                            controlParcelas.quitarParcela(idParcela, cbbTipo.Text, idCaixa);
                        }
                        else
                        {
                            tbValor.Text = "R$ " + ValorParcela;
                            MessageBox.Show("Valor maior que a divida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro no valor");
                    }
                }
                else
                {
                    MessageBox.Show("Tipo não selecionado");
                }
            }
            else
            {
                MessageBox.Show("Erro no valor");
            }
        }

    }
}
// dtpagamento vai ser hoje
// valor caso seja parcial
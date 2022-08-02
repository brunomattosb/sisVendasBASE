using sisVendas.Controllers;
using sisVendas.Funcoes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormQuitarContaReceber : Form
    {
        private int idParcela;
        private double ValorParcela;
        private int idCaixa;
        private int idVenda;

        private bool res = false;

        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();
        public FormQuitarContaReceber()
        {
            InitializeComponent();
        }

        public FormQuitarContaReceber(double valor, int idParcela, int idCaixa, int idVenda) :this()
        {
            this.ValorParcela = valor;
            this.idParcela = idParcela;
            this.idCaixa = idCaixa;
            this.idVenda = idVenda;
            lblValor.Text =
            tbValor.Text =
                valor.ToString("C");
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
                    tbValor.Text = "R$ 0,00";
                    Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
                }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbValor.Text.Replace("R$ ", ""), out double valorPago))
            {
                if (cbbTipo.SelectedIndex != -1)
                {

                    if (valorPago > 0)
                    {
                        if (valorPago <= ValorParcela)
                        {
                            controlParcelas.quitarParcela(idParcela, ValorParcela, valorPago, idCaixa, idVenda, cbbTipo.Text);//, cbbTipo.Text, );
                            res = true;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Valor pago deve ser menor que valor cobrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor deve ser maior que zero");
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
        public bool alterou()
        {
            return res;
        }

        private void tbValor_Click(object sender, EventArgs e)
        {
            if(tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
            }
        }
    }
}
// dtpagamento vai ser hoje
// valor caso seja parcial
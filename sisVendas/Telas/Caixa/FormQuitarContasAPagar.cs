using sisVendas.Controllers;
using sisVendas.Funcoes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormQuitarContasAPagar : Form
    {
        private int idParcela;
        private double ValorParcela;
        private int idCaixa;
        private int idVenda;
        private string despesa;
        private double valor;

        private bool res = false;
        private ctrlParcelasCompra controlParcelas = new ctrlParcelasCompra();

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
        public FormQuitarContasAPagar()
        {
            InitializeComponent();
        }
        public FormQuitarContasAPagar(double valor, int idParcela, int idCaixa, int idVenda, string despesa) : this()
        {
            this.ValorParcela = valor;
            this.idParcela = idParcela;
            this.idCaixa = idCaixa;
            this.idVenda = idVenda;
            this.despesa = despesa;
            this.valor = valor;
            tbValor.Text = valor.ToString("C");
            cbbTipo.SelectedIndex = 0;
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
        public bool alterou()
        {
            return res;
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (double.TryParse(tbValor.Text.Replace("R$ ", ""), out double valorPago))
            {
                if (cbbTipo.SelectedIndex != -1)
                {

                    controlParcelas.quitarParcela(idParcela, ValorParcela, valorPago, idCaixa, idVenda, cbbTipo.Text, despesa);//, cbbTipo.Text, );
                    res = true;
                    Close();
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

        private void tbValor_Click(object sender, EventArgs e)
        {
            if (tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
            }
        }
    }
}

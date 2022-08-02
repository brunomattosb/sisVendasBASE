using sisVendas.Funcoes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Compra
{
    public partial class FormParcelasCompra : Form
    {
        DataTable dttParcelas;
        private double totalCompra;
        private double totalPago = 0;
        private bool ativo;

        public FormParcelasCompra()
        {
            InitializeComponent();
            dgvParcelas.DataSource = dttParcelas;
            dtpData.Value = DateTime.Now;
            cbbTipo.SelectedIndex = 0;
            dgvParcelas.Columns["valor"].DefaultCellStyle.Format = "C";
        }
        public FormParcelasCompra(double total, DataTable dttParcelas, bool ativo) : this()
        {
            this.dttParcelas = dttParcelas;
            this.totalCompra = total;
            this.ativo = ativo;

            lblValor.Text = total.ToString("C");

            if (dttParcelas.Rows.Count != 0)
            {
                foreach (DataRow parcela in dttParcelas.Rows)
                {
                    totalPago = totalPago + double.Parse(parcela["valor"] + "");
                    tbTotalOffset.Text = totalPago.ToString("C");

                    tbSubtotalOffset.Text = (totalCompra - totalPago).ToString("C");
                    tbValor.Text = "";
                }
                dgvParcelas.DataSource = dttParcelas;

            }
            if (!ativo)
            {
                tbValor.Enabled = cbbTipo.Enabled = btnAdd.Enabled = btnRemover.Enabled = false;
            }
            tbValor.Focus();
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
        public DataTable getDttParcelas()
        {
            return dttParcelas;
        }

        private void dgvParcelas_DoubleClick(object sender, EventArgs e)
        {
            if (ativo)
            {
                if (dgvParcelas.CurrentRow != null)
                {
                    btnRemover.Enabled = true;
                }
                else
                {
                    btnRemover.Enabled = false;
                }
            }
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
                    Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
                }
        }
        public void inserir(double valor, string tipo, DateTime data)
        {
            totalPago = totalPago + valor;

            DataRow linha = dttParcelas.NewRow();

            linha["tipo_pagamento"] = cbbTipo.Text;
            linha["valor"] = Convert.ToDouble(valor);
            linha["data"] = data;

            dttParcelas.Rows.Add(linha);

            tbTotalOffset.Text = totalPago.ToString("C");
            tbSubtotalOffset.Text = (totalCompra - totalPago).ToString("C");
            tbValor.Text = "";

            dgvParcelas.DataSource = dttParcelas;
            tbValor.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            
            if (isOk)
            {
                if (tbValor.Text.Count() > 0)
                {
                    string text = tbValor.Text.Replace("R$", "");

                    double.TryParse(text, out double valor);

                    if (valor != 0 && totalPago + valor <= totalCompra)
                    {
                        inserir(valor, cbbTipo.Text, dtpData.Value);
                    }
                    else
                    {
                        Alerta.notificacao("Alerta!", "Valor a ser pago maior que saldo devedor e diferente de zero", Alerta.enmType.Warning);
                    }
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a parcela selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                double valor = double.Parse(dgvParcelas.Rows[dgvParcelas.CurrentRow.Index].Cells[2].Value.ToString());
                totalPago = totalPago - valor;

                tbTotalOffset.Text = totalPago.ToString("C");
                tbSubtotalOffset.Text = (totalCompra - totalPago).ToString("C");

                dttParcelas.Rows.RemoveAt(dgvParcelas.CurrentRow.Index);
                btnRemover.Enabled = false;

                tbValor.Focus();
            }
        }

        private void tbValor_Click(object sender, EventArgs e)
        {
            if(tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
            }
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTipo.SelectedIndex == 3)
            {
                dtpData.Enabled = true;
            }
            else
            {
                dtpData.Value = DateTime.Now;
                dtpData.Enabled = false;
            }
        }

        private void dgvParcelas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnRemover.Enabled = false;
        }
    }
}

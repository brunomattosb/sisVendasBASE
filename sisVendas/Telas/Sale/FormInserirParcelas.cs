using sisVendas.Funcoes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    partial class FormInserirParcelas : Form
    {
        private double totalVenda;
        private double totalPago = 0;
        DataTable dtParcelas;
        private bool ativo;
        private double saldo;
        public FormInserirParcelas()
        {
            InitializeComponent();

            dgvParcelas.DataSource = dtParcelas;

            cbbTipo.SelectedIndex = 0;
            dgvParcelas.Columns["valor"].DefaultCellStyle.Format = "C";
        }
        public FormInserirParcelas(double value, DataTable lparcelas, bool ativo, double saldo):this()
        {
            lblValor.Text = value.ToString("C");
            this.totalVenda = Math.Round(value, 2);
            this.ativo = ativo;
            this.saldo = saldo;

            this.dtParcelas = lparcelas;

            if (lparcelas.Rows.Count != 0)
            {
                foreach (DataRow parcela in dtParcelas.Rows)
                {
                    totalPago = totalPago + double.Parse(parcela["valor"] + "");
                    tbTotalOffset.Text = totalPago.ToString("C");

                    tbSubtotalOffset.Text = (totalVenda - totalPago).ToString("C");
                    tbValor.Text = "";
                }
                dgvParcelas.DataSource = dtParcelas;
                
            }
            if(!ativo)
            {
                btnAdd.Enabled =
                btnAdd.Enabled =
                tbValor.Enabled =
                cbbTipo.Enabled = false;
            }

            lblSaldo.Text = saldo.ToString("C");
            if (saldo > 0)
            {
                cbbTipo.Items.Add("Saldo");
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
        public void inserir(double valor, string tipo, DateTime data)
        {
            totalPago = totalPago + valor;

            DataRow linha = dtParcelas.NewRow();

            linha["tipo_pagamento"] = cbbTipo.Text;
            linha["valor"] = Convert.ToDouble(valor);
            linha["data"] = data;

            dtParcelas.Rows.Add(linha);

            tbTotalOffset.Text =totalPago.ToString("C");
            tbSubtotalOffset.Text = (totalVenda - totalPago).ToString("C");
            tbValor.Text = "R$ 0,00";

            dgvParcelas.DataSource = dtParcelas;
            tbValor.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            if(isOk)
            {
                if (tbValor.Text.Count() > 0)
                {
                    string text = tbValor.Text.Replace("R$", "");

                    double.TryParse(text, out double valor);
;                    if (valor != 0 && totalPago + valor <= totalVenda)
                    {
                        inserir(valor, cbbTipo.Text, dtpData.Value.Date);
                    }
                    else
                    {
                        Alerta.notificacao("Alerta!", "Valor a ser pago maior que saldo devedor", Alerta.enmType.Warning);
                    }
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
            if(text.Count()>0)
                if (double.TryParse(text, out double res))
                    tbValor.Text = String.Format("{0:c}", res);
                else
                {
                    tbValor.Text = "";
                    Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
                }
        }
        public DataTable getLparcela()
        {
            return dtParcelas;
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

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir a parcela selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                double valor = double.Parse(dgvParcelas.Rows[dgvParcelas.CurrentRow.Index].Cells[2].Value.ToString());
                totalPago = totalPago - valor;

                tbTotalOffset.Text = totalPago.ToString("C");
                tbSubtotalOffset.Text =  (totalVenda - totalPago).ToString("C");

                dtParcelas.Rows.RemoveAt(dgvParcelas.CurrentRow.Index);
                btnRemover.Enabled = false;

                tbValor.Focus();
            }

        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTipo.Text == "Fiado")
            {
                
                lblData.Enabled = dtpData.Enabled = true;
            }
            else
            {
                dtpData.Value = DateTime.Now.Date;
                lblData.Enabled = dtpData.Enabled = false;
            }
        }

        private void dgvParcelas_CurrentCellChanged(object sender, EventArgs e)
        {
            //btnRemover.Enabled = false;
        }

        private void tbValor_Enter(object sender, EventArgs e)
        {
            if(tbValor.Text == "R$ 0,00")
            {
                tbValor.Text = "";
            }
        }

        private void dgvParcelas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnRemover.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}

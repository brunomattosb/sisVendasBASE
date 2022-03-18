using sisVendas.Functions;
using sisVendas.Models;
using sisVendas.Notificacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    partial class FormSimularVenda : Form
    {
        private double totalVenda;
        private double totalPago = 0;
        DataTable dtParcelas;
        public FormSimularVenda()
        {
            InitializeComponent();

            

            //dtParcelas.PrimaryKey = new DataColumn[] { dtProducts.Columns["name"] };
            dgvParcelas.DataSource = dtParcelas;

            cbbTipo.SelectedIndex = 0;
            tbValor.Focus();
        }
        public FormSimularVenda(double value, DataTable lparcelas):this()
        {
            lblValor.Text = "R$ " + value;
            this.totalVenda = value;

            this.dtParcelas = lparcelas;

            if (lparcelas.Rows.Count != 0)
            {
                foreach (DataRow parcela in dtParcelas.Rows)
                {
                    totalPago = totalPago + double.Parse(parcela["valor"] + "");
                    tbTotalOffset.Text = "R$: " + totalPago;

                    tbSubtotalOffset.Text = "R$: " + (totalVenda - totalPago) + "";
                    tbValor.Text = "";
                }
                dgvParcelas.DataSource = dtParcelas;
                tbValor.Focus();
            }
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
        public void inserir(double valor, string tipo, string data)
        {
            totalPago = totalPago + valor;

            DataRow linha = dtParcelas.NewRow();

            linha["tipo"] = cbbTipo.Text;
            linha["valor"] = Convert.ToDouble(valor);
            linha["data"] = data;

            dtParcelas.Rows.Add(linha);

            tbTotalOffset.Text = "R$: " + totalPago.ToString();
            tbSubtotalOffset.Text = "R$: " + (totalVenda - totalPago) + "";
            tbValor.Text = "";

            dgvParcelas.DataSource = dtParcelas;
            tbValor.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isOk = true;

            DateTime dateValue = new DateTime();
            // Validando data de nascimento
            if (Function.replaceAll(mtbData.Text).Length > 0) //caso tenha dado
            {
                if (!DateTime.TryParseExact(mtbData.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out dateValue))
                {
                    Function.Alert("Erro!", "Data inválida.", popupClient.enmType.Error);
                    isOk = false;
                }
            }
            else
            {
                dateValue = DateTime.MaxValue;
            }

            if(isOk)
            {
                if (tbValor.Text.Count() > 0)
                {
                    string text = tbValor.Text.Replace("R$", "");

                    double.TryParse(text, out double valor);

                    if (valor != 0 && totalPago + valor <= totalVenda)
                    {
                        inserir(valor, cbbTipo.Text, mtbData.Text);
                    }
                    else
                    {
                        Function.Alert("Alerta!", "Valor a ser pago maior que saldo devedor e diferente de zero", popupClient.enmType.Warning);
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
                    Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
                }
        }
        public DataTable getLparcela()
        {
            return dtParcelas;
        }

        private void dgvParcelas_DoubleClick(object sender, EventArgs e)
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

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja excluir a parcela selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                double valor = double.Parse(dgvParcelas.Rows[dgvParcelas.CurrentRow.Index].Cells[0].Value.ToString());

                totalPago = totalPago - valor;

                tbTotalOffset.Text = "R$: " + totalPago.ToString();
                tbSubtotalOffset.Text = "R$: " + (totalVenda - totalPago) + "";

                dtParcelas.Rows.RemoveAt(dgvParcelas.CurrentRow.Index);
                btnRemover.Enabled = false;

                tbValor.Focus();
            }

        }

        private void mtbData_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbData.Text).Length == 0)
                mtbData.Select(0, 0);
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTipo.Text == "Fiado")
            {
                
                lblData.Enabled = mtbData.Enabled = true;
            }
            else
            {
                mtbData.Text = DateTime.Now.Date.ToString();
                lblData.Enabled = mtbData.Enabled = false;
            }
        }
    }
}

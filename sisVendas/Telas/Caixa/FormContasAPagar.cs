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
    public partial class FormContasAPagar : Form
    {
        ctrlDespesa controlDespesa = new ctrlDespesa();
        ctrlParcelasCompra controlParcelas = new ctrlParcelasCompra();
        DataTable dttDespesas = new DataTable();
        string despesa = "ContaAPagar";

        int idCaixa;
        public FormContasAPagar()
        {
            InitializeComponent();
            
            btnBuscar.PerformClick();
        }
        public FormContasAPagar(int idCaixa):this()
        {
            this.idCaixa = idCaixa;
            dgv_despesas.Columns["valor"].DefaultCellStyle.Format = "C";
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
        public void updateDGV(string filtro)
        {
            if (cbParcelasCompra.Checked)
            {
                dttDespesas = controlParcelas.buscarParcelasAPagar(filtro); 
            }
            else
            {
                dttDespesas = controlDespesa.buscarDespesasAPagar(filtro); 
            }
            dgv_despesas.DataSource = dttDespesas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if (dtpInicio.Value.Date > dtpFim.Value.Date)
            {
                Function.Alert("Alerta!", "Data Inicio maior que data Fim", popupClient.enmType.Warning);
            }

            if (cbParcelasCompra.Checked)
            {
                if (cbAberto.Checked)
                {
                    filtro = "parcela_status = 'DEVE'";
                }
                if (cbQuitada.Checked)
                {
                    if (filtro != "")
                    {
                        filtro = "(" + filtro + " OR ";
                        filtro = filtro + "parcela_status = 'PAGO')";
                    }
                    else
                    {
                        filtro = filtro + "parcela_status = 'PAGO'";
                    }
                }
                if (tbFornNome.Text.Count() > 0)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "tbFornNome like '%" + tbFornNome.Text + "%'";
                }
                if (cbPesquisarPorPeriodo.Checked)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "parcela_dataPagamento BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";

                }
               
                despesa = "ContaAPagar";
            }
            else
            {
                if (cbAberto.Checked)
                {
                    filtro = "desp_status = 'DEVE'";
                }
                if (cbQuitada.Checked)
                {
                    if (filtro != "")
                    {
                        filtro = "(" + filtro + " OR ";
                        filtro = filtro + "desp_status = 'PAGO')";
                    }
                    else
                    {
                        filtro = filtro + "desp_status = 'PAGO'";
                    }
                }
                if (cbPesquisarPorPeriodo.Checked)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "desp_dataReferencia BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }

                despesa = "Despesa";
            }
            Console.WriteLine(filtro);
            updateDGV(filtro);
        }

        private void cbParcelasCompra_Click_1(object sender, EventArgs e)
        {
            cbDespesas.Checked = false;
            cbParcelasCompra.Checked = true;
            tbFornNome.Visible = lblFornecedor.Visible = true;
            btnBuscar.PerformClick();
        }

        private void cbDespesas_Click(object sender, EventArgs e)
        {
            cbDespesas.Checked = true;
            cbParcelasCompra.Checked = false;
            tbFornNome.Visible = lblFornecedor.Visible = false;
            btnBuscar.PerformClick();
        }

        private void dgv_despesas_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_despesas.SelectedRows.Count == 1)
            {

                //activeForm();
                DataGridViewCellCollection linha = dgv_despesas.Rows[dgv_despesas.CurrentRow.Index].Cells;

                if (linha[3].Value.ToString() == "DEVE")
                {
                                                                            //(double valor, int idParcela, int idCaixa, int idVenda, string despesa) : this()
                    FormQuitarContasAPagar f = new FormQuitarContasAPagar(double.Parse(linha[6].Value.ToString()), int.Parse(linha[0].Value.ToString()), idCaixa, int.Parse(linha[7].Value.ToString()), despesa);
                    f.ShowDialog();

                    if (f.alterou())
                        btnBuscar.PerformClick();
                }
                else
                {
                    //MessageBox.Show(idCaixa + "");
                    //MessageBox.Show("idCaixaDaParcela");

                    if (int.Parse(linha[5].Value.ToString()) == idCaixa)
                    {
                        if (MessageBox.Show("Deseja estornar a parcela selecionada?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            // ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();

                            //controlParcelas.onerarParcela(int.Parse(linha[0].Value.ToString()));
                            //

                            if (cbParcelasCompra.Checked)
                            {
                                //onerar parcelas
                                controlParcelas.estornarParcela(int.Parse(linha[0].Value.ToString()));
                            }
                            else
                            {
                                //onerar despesas
                                controlDespesa.estornarDespesa(int.Parse(linha[0].Value.ToString()));
                            }
                            btnBuscar.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parcela não quitada no caixa atual.", "Alerta!", MessageBoxButtons.OK);
                    }
                }

            }
        }
    }
}

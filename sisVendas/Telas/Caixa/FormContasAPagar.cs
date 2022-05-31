using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Functions;
using sisVendas.Notificacao;
using System;
using System.Data;
using System.Linq;
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
        private string getFiltro()
        {
            string filtro = "";



            if (cbParcelasCompra.Checked)
            {
                if (cbAberto.Checked)
                {
                    filtro = "parcela_dataPagamento is null";
                }
                if (cbQuitada.Checked)
                {
                    if (filtro != "")
                    {
                        filtro = "";
                    }
                    else
                    {
                        filtro = filtro + "parcela_dataPagamento is not null";
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
                    if (dtpInicio.Value.Date > dtpFim.Value.Date)
                    {
                        Function.Alert("Alerta!", "Data Inicio maior que data Fim", popupClient.enmType.Warning);
                    }

                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "parcela_dataVencimento BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";

                }

                despesa = "ContaAPagar";
            }
            else
            {
                if (cbAberto.Checked)
                {
                    filtro = "desp_dataPagamento is null";
                }
                if (cbQuitada.Checked)
                {
                    if (filtro != "")
                    {
                        filtro = "";
                    }
                    else
                    {
                        filtro = filtro + "desp_dataPagamento is not null";
                    }
                }
                if (cbPesquisarPorPeriodo.Checked)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "desp_dataVencimento BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }

                despesa = "Despesa";
            }
            return filtro;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            updateDGV(getFiltro());
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
            DataGridViewCellCollection linha = dgv_despesas.Rows[dgv_despesas.CurrentRow.Index].Cells;

            /*0 idParcela 
            1 dtPagamento
            2 dtVencimento
            3 Tipo
            4 idCaixa
            5 valor
            6 idCompra
            7 desc*/
            
            if (dgv_despesas.SelectedRows.Count == 1)
            {
                if (linha[1].Value.ToString() == "")
                {                                                
                    FormQuitarContasAPagar f = new FormQuitarContasAPagar(double.Parse(linha[5].Value.ToString()),
                                                    int.Parse(linha[0].Value.ToString()), idCaixa, int.Parse(linha[6].Value.ToString()), despesa);
                    f.ShowDialog();

                    if (f.alterou())
                        btnBuscar.PerformClick();
                }
                else
                {
                    
                    if (int.Parse(linha[4].Value.ToString()) == idCaixa)
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
                        MessageBox.Show("Parcela não quitada no caixa atual.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void FormContasAPagar_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dt;
            
            if (cbParcelasCompra.Checked)
            {
                dt = controlParcelas.buscarParaRelatorio(getFiltro());
                float[] largurasColunas = { 1f, 1f, 1f, 1f };
                if (dttDespesas.Rows.Count > 0) // se existir pessoas
                {

                    Relatorios.gerarRelatorio($"RelatórioSisVendas.ContasAPagr.pdf", "Contas a Pagar!", dt, largurasColunas);
                }
            }
            else
            {
                dt = controlDespesa.buscarParaRelatorio(getFiltro());
                float[] largurasColunas = { 1.5f, 1f, 1f, 1f, 1f, 1f };
                if (dttDespesas.Rows.Count > 0) // se existir pessoas
                {

                    Relatorios.gerarRelatorio($"RelatórioSisVendas.ContasAPagr.pdf", "Contas a Pagar!", dt, largurasColunas);
                }
            }
                       
            
        }
    }
}

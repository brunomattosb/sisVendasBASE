using sisVendas.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormConsultarAnteriores : Form
    {
        private ctrlFuncionario controlFunc = new ctrlFuncionario();
        private ctrlCaixa controlCaixa = new ctrlCaixa();
        private ctrlTransacaoCaixa controlTransacao = new ctrlTransacaoCaixa();
        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();
        private ctrlDespesa controlDespesas = new ctrlDespesa();
        private ctrlParcelasCompra controlParcelasCompra = new ctrlParcelasCompra();

        private DataTable dttCaixa;
        private DataTable dttItensCaixa = new DataTable();

        private double saldoCaixaAnterior = 0.00;
        private double saldoCaixa = 0.00;
        private double total_sangria = 0.00;
        private double total_aporte = 0.00;
        private double total_despesa = 0.00;
        private double total_credito = 0.00;
        private double total_debido = 0.00;
        private double total_dinheiro = 0.00;
        private double total_cancelamento = 0.00;
        public FormConsultarAnteriores()
        {
            InitializeComponent();

            updateCbb();
            updateDGV("");
            dttItensCaixa.Columns.Add("descricao");
            dttItensCaixa.Columns.Add("tipo");
            dttItensCaixa.Columns.Add("formaPagamento");
            dttItensCaixa.Columns.Add("data", typeof(DateTime));
            dttItensCaixa.Columns.Add("valor", typeof(double));

            dgvTransacoes.Columns["valor"].DefaultCellStyle.Format = "C";
        }
        public void updateCbb()
        {

            cbbFuncionario.DataSource = controlFunc.BuscarParaComboBox();
            cbbFuncionario.DisplayMember = "func_nome";
            cbbFuncionario.ValueMember = "func_id";
            cbbFuncionario.SelectedIndex = -1;

        }
        public void updateDGV(string filtro)
        {

            this.dttCaixa = controlCaixa.Buscar(filtro);
            dgvCaixa.DataSource = dttCaixa;

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

        private void cbPesquisarPorPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            
            dtpData.Enabled = cbPesquisarPorPeriodo.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";

            if (cbPesquisarPorPeriodo.Checked)
            {
                filtro = "CAST(caixa.caixa_dtAbertura AS date) = '" + dtpData.Value.ToString("yyyy-MM-dd")+"'";
            }
            if(cbbFuncionario.SelectedIndex > -1)
            {
                if(filtro == "")
                {
                    filtro = "caixa_idFunc = " + Convert.ToInt32(cbbFuncionario.SelectedValue);
                }
                else
                {
                    filtro = filtro + " AND " + "caixa_idFunc = " + Convert.ToInt32(cbbFuncionario.SelectedValue);
                }
            }
            updateDGV(filtro);
        }

        private void dgvCaixa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCaixa.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection linha = dgvCaixa.Rows[dgvCaixa.CurrentRow.Index].Cells;

                tbAbertura.Text = linha[2].Value.ToString();
                tbFechamento.Text = linha[3].Value.ToString();

                buscarCaixaSelecionado(int.Parse(linha[0].Value.ToString()));

            }
        }
        private void buscarCaixaSelecionado(int idCaixa)
        {
            
            DataTable dttTransacao;
            dttTransacao = controlTransacao.buscarPorIdCaixa(idCaixa);
            DataTable dttParcelasVenda;
            dttParcelasVenda = controlParcelasVenda.buscarParcelasPorIdCaixa(idCaixa);
            DataTable dttDespesas;
            dttDespesas = controlDespesas.BuscarPorIdCaixa(idCaixa);
            DataTable dttParcelasCompra;
            dttParcelasCompra = controlParcelasCompra.buscarParcelasPorIdCaixa(idCaixa);


            total_sangria = total_aporte = total_despesa = total_credito = total_debido = total_dinheiro = 0;

            dttItensCaixa.Rows.Clear();

            foreach (DataRow dr in dttTransacao.Rows)
            {
                string descricao = dr["transacao_descricao"].ToString();
                double.TryParse(dr["transacao_valor"].ToString(), out double valor);

                insereItensDttCaixa(dr["transacao_tipo"].ToString(), descricao, DateTime.Parse(dr["transacao_criado_em"].ToString()), "Dinheiro", valor);

                if (descricao == "Sangria")
                {
                    total_sangria = total_sangria + valor;
                }
                else if (descricao == "Aporte")
                {
                    total_aporte = total_aporte + valor;
                }
                else
                {
                    total_cancelamento = total_aporte + valor;
                }

            }

            foreach (DataRow dr in dttDespesas.Rows)
            {
                double.TryParse(dr["desp_valor"].ToString(), out double Valor);
                insereItensDttCaixa("*", "Desp. " + dr["desp_descricao"],
                            DateTime.Parse(dr["desp_dataReferencia"].ToString()), dr["desp_formaPagamento"].ToString(), Valor);

                total_despesa = total_despesa + Valor;
            }

            foreach (DataRow dr in dttParcelasVenda.Rows)
            {
                //DataRow linha = dttItensCaixa.NewRow();

                if (dr["tipo"].ToString() != "F") // para não pegar os fiados
                {
                    double.TryParse(dr["valor"].ToString(), out double Valor);

                    string formaPgto = "";

                    if (dr["tipo"].ToString() == "D")
                    {
                        formaPgto = "Débito";
                        total_debido = total_debido + Valor;
                    }
                    else if (dr["tipo"].ToString() == "C")
                    {
                        formaPgto = "Crédito";
                        total_credito = total_credito + Valor;

                    }
                    else if (dr["tipo"].ToString() == "M")
                    {
                        formaPgto = "Dinheiro";
                        total_dinheiro = total_dinheiro + Valor;
                    }

                    insereItensDttCaixa("*", "Venda realizada N°: " + dr["idVenda"], DateTime.Parse(dr["data"].ToString()), formaPgto, Valor);

                }
            }

            foreach (DataRow dr in dttParcelasCompra.Rows)
            {

                if (dr["tipo"].ToString() != "F") // para não pegar os fiados
                {
                    double.TryParse(dr["valor"].ToString(), out double Valor);

                    string formaPgto = "";

                    if (dr["tipo"].ToString() == "D")
                    {
                        formaPgto = "Débito";

                    }
                    else if (dr["tipo"].ToString() == "C")
                    {
                        formaPgto = "Crédito";

                    }
                    else if (dr["tipo"].ToString() == "M")
                    {
                        formaPgto = "Dinheiro";
                    }
                    total_despesa = total_despesa + Valor;
                    insereItensDttCaixa("*", "Comrpa realizada N°: " + dr["idCompra"], DateTime.Parse(dr["data"].ToString()), formaPgto, Valor);

                }
            }

            dgvTransacoes.DataSource = dttItensCaixa;
            preencherResumo();
        }
        private void insereItensDttCaixa(string tipo, string descricao, DateTime data, string formaPagamento, double valor)
        {
            DataRow linha = dttItensCaixa.NewRow();

            linha["tipo"] = tipo;
            linha["descricao"] = descricao;
            linha["data"] = data;
            linha["formaPagamento"] = formaPagamento;
            linha["valor"] = valor;

            dttItensCaixa.Rows.Add(linha);
        }
        private void preencherResumo()
        {

            lblResumoCartao.Text = "Total: " + (total_credito + total_debido).ToString("C");
            lblResumoCredito.Text = "Crédito: " + total_credito.ToString("C");
            lblResumoDebito.Text = "Débito: " + total_debido.ToString("C");

            lblResumoDinheiro.Text = total_dinheiro.ToString("C");

            lblResumoAporte.Text = "Aporte: " + total_aporte.ToString("C");
            lblResumoSangria.Text = "Sangria: " + total_sangria.ToString("C");

            lblResumoDespesas.Text = total_despesa.ToString("C");
            lblTotalCancelamento.Text = "Cancelamento: " + total_sangria.ToString("C");

            saldoCaixa = saldoCaixaAnterior + total_credito + total_debido + total_aporte - total_sangria - total_despesa + total_dinheiro;

            tbEntrada.Text = (total_credito + total_debido + total_aporte + total_dinheiro).ToString("C");
            tbSaida.Text = (total_sangria + total_despesa).ToString("C");

        }
    }
}

using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Notificacao;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormAbrirFecharCaixa : Form
    {
        private ctrlCaixa controlCaixa = new ctrlCaixa();
        private ctrlTransacaoCaixa controlTransacao = new ctrlTransacaoCaixa();
        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();
        private ctrlDespesa controlDespesas = new ctrlDespesa();
        private ctrlParcelasCompra controlParcelasCompra = new ctrlParcelasCompra();

        private Models.Caixa caixaSelecionado = null;

        private DataTable dttItensCaixa = new DataTable();

        private int idFuncionario;

        private double saldoCaixaAnterior = 0.00;
        private double saldoCaixa = 0.00;

        private double total_sangria = 0.00;
        private double total_aporte = 0.00;

        private double total_despesa_credito = 0.00;
        private double total_despesa_debito = 0.00;
        private double total_despesa_dinheiro = 0.00;
        
        private double total_vendas_credito = 0.00;
        private double total_vendas_debido = 0.00;
        private double total_vendas_dinheiro = 0.00;
       
        private double total_cancelamento = 0.00;

        private double total_compras_dinheiro = 0.00;
        private double total_compras_credito = 0.00;
        private double total_compras_debito = 0.00;

        public FormAbrirFecharCaixa()
        {
            InitializeComponent();
            
            dttItensCaixa.Columns.Add("descricao");
            dttItensCaixa.Columns.Add("tipo");
            dttItensCaixa.Columns.Add("formaPagamento");
            dttItensCaixa.Columns.Add("data", typeof(DateTime));
            dttItensCaixa.Columns.Add("valor", typeof(double));

            dgvTransacoes.Columns["valor"].DefaultCellStyle.Format = "C";
        }
        public FormAbrirFecharCaixa(int idFunc) : this()
        {
            this.idFuncionario = idFunc;
            buscarCaixaAberto(idFuncionario);
        }
        
       
        private void buscarCaixaAberto(int cod)
        {
            caixaSelecionado = controlCaixa.buscarCaixaAberto(cod);

            tbEntrada.Text = tbSaida.Text = tbSaldo.Text = "R$ 0,00";
            if (caixaSelecionado == null || caixaSelecionado.Dtfechamento != null)
            {
                // PRIMEIRO CAIXA DO FUNCIONARIO // caixa fechado
                gbAbrirFechar.Text = "Abrir Caixa";
                lblEntrada.Text = "Suprimentos:";
                lblSaida.Text = "Sangria:";
                lblSaldo.Text = "Saldo:";

                btnAbrirFechar.Text = "Abrir Caixa";

                tbEntrada.Enabled = tbSaida.Enabled = true;
                
                
                gbAporte.Enabled = false;

                if (caixaSelecionado == null)
                    saldoCaixaAnterior = 0;
                else
                    saldoCaixaAnterior = caixaSelecionado.SaldoAnterior + caixaSelecionado.Entradas - caixaSelecionado.Saidas;

                lblValorDiaAnterior.Text = saldoCaixaAnterior.ToString("C");
                lblDiaAnterior.Text = "Saldo Caixa Anterior:";

            }
            else // caixa aberto!
            {
                gbAbrirFechar.Text = "Fechar Caixa";
                lblEntrada.Text = "Entradas:";
                lblSaida.Text = "Saidas:";
                lblSaldo.Text = "Saldo Atual:";

                btnAbrirFechar.Text = "Fechar Caixa";

                tbEntrada.Enabled =
                tbSaida.Enabled = false;
                lblDiaAnterior.Text = "Saldo Inicial:";

                gbAporte.Enabled = true;

                saldoCaixaAnterior = caixaSelecionado.SaldoAnterior;

                buscarCaixaSelecionado(caixaSelecionado.Id);
            }
            
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            if(caixaSelecionado == null || caixaSelecionado.Dtfechamento != null) //abrir
            {
                double.TryParse(tbSaida.Text.Replace("R$ ", ""), out double sangria);
                double.TryParse(tbEntrada.Text.Replace("R$ ", ""), out double suprimentos);

                if (controlCaixa.AbrirCaixa(idFuncionario, saldoCaixaAnterior))
                {
                    buscarCaixaAberto(idFuncionario);

                    if (suprimentos != 0)
                        controlTransacao.salvarTransacao(caixaSelecionado.Id, "Aporte", '*', suprimentos);
                    if (sangria != 0)
                        controlTransacao.salvarTransacao(caixaSelecionado.Id, "Sangria", '*', sangria);

                    buscarCaixaSelecionado(caixaSelecionado.Id);
                }
            }
            else // fechar caixa
            {
                double entradas = total_aporte +  total_vendas_dinheiro;
                double saidas = total_sangria + total_compras_dinheiro + total_despesa_dinheiro;

                controlCaixa.FecharCaixa(caixaSelecionado.Id, entradas, saidas);

                dttItensCaixa.Rows.Clear();

                tbEntrada.Text = tbSaida.Text = tbSaldo.Text = "R$ 0,00";

                buscarCaixaAberto(idFuncionario);
            }
            //tbSaldo.Text = tbEntrada.Text = tbSaida.Text = "R$ 0,00";
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


            total_sangria = total_aporte =
            total_despesa_dinheiro =total_despesa_credito = total_despesa_debito =
            total_compras_dinheiro = total_compras_credito = total_compras_debito =
            total_vendas_credito = total_vendas_debido = total_vendas_dinheiro = 0;

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
                    total_cancelamento = total_cancelamento + valor;
                }
                
            }

            foreach (DataRow dr in dttDespesas.Rows)
            {
                double.TryParse(dr["desp_valor"].ToString(), out double Valor);
                if (dr["desp_formaPagamento"].ToString() != "Fiado")
                {
                    if (dr["desp_formaPagamento"].ToString() == "Dinheiro")
                    {
                        insereItensDttCaixa("*", "Desp. " + dr["desp_descricao"],
                                    DateTime.Parse(dr["desp_dataReferencia"].ToString()), dr["desp_formaPagamento"].ToString(), Valor);
                        total_despesa_dinheiro = total_despesa_dinheiro + Valor;
                    }
                    else if (dr["desp_formaPagamento"].ToString() == "Crédito")
                    {
                        total_despesa_credito = total_despesa_credito + Valor;
                    }
                    else if (dr["desp_formaPagamento"].ToString() == "Débito")
                    {
                        total_despesa_debito = total_despesa_debito + Valor;
                    }

                }
                    
            }
            
            foreach (DataRow dr in dttParcelasVenda.Rows)
            {

                if (dr["tipo"].ToString() != "F")
                {
                    double.TryParse(dr["valor"].ToString(), out double Valor);

                    string formaPgto = "";

                    if (dr["tipo"].ToString() == "D")
                    {
                        formaPgto = "Débito";
                        total_vendas_debido = total_vendas_debido + Valor;
                    }
                    else if (dr["tipo"].ToString() == "C")
                    {
                        formaPgto = "Crédito";
                        total_vendas_credito = total_vendas_credito + Valor;
                    }
                    else if (dr["tipo"].ToString() == "M")
                    {
                        formaPgto = "Dinheiro";
                        total_vendas_dinheiro = total_vendas_dinheiro + Valor;
                        insereItensDttCaixa("*", "Venda realizada N°: " + dr["idVenda"], DateTime.Parse(dr["data"].ToString()), formaPgto, Valor);
                    }
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
                        total_compras_debito = total_compras_debito + Valor;
                    }
                    else if (dr["tipo"].ToString() == "C")
                    {
                        formaPgto = "Crédito";
                        total_compras_credito = total_compras_credito + Valor;
                    }
                    else if (dr["tipo"].ToString() == "M")
                    {
                        formaPgto = "Dinheiro";
                        total_compras_dinheiro = total_compras_dinheiro + Valor;
                        insereItensDttCaixa("*", "Comrpa realizada N°: " + dr["idCompra"], DateTime.Parse(dr["data"].ToString()), formaPgto, Valor);
                    }
                }
            }

            dgvTransacoes.DataSource = dttItensCaixa;
            preencherResumo();
        }
        private void preencherResumo()
        {
            // vendas
            lblResumoVendasTotal.Text = (total_vendas_credito + total_vendas_debido).ToString("C");
            lblResumoVendasCredito.Text =  total_vendas_credito.ToString("C");
            lblResumoVendasDebito.Text = total_vendas_debido.ToString("C");
            lblResumoVendasDinheiro.Text = total_vendas_dinheiro.ToString("C");

            //aporte/sangria
            lblResumoAporte.Text =  total_aporte.ToString("C");
            lblResumoSangria.Text = total_sangria.ToString("C");

            //despesas
            lblResumoDespesasDebito.Text = total_despesa_debito.ToString("C");
            lblResumoDespesasCredito.Text = total_despesa_credito.ToString("C");
            lblResumoDespesasDinheiro.Text = total_despesa_dinheiro.ToString("C");

            //compras
            lblResumoComprasDebito.Text = total_compras_debito.ToString("C");
            lblResumoComprasCredito.Text = total_compras_credito.ToString("C");
            lblResumoComprasDinheiro.Text = total_compras_dinheiro.ToString("C");

            //cancelado
            lblTotalCancelamento.Text = total_cancelamento.ToString("C");

            saldoCaixa = saldoCaixaAnterior +   total_aporte - total_sangria - total_despesa_dinheiro + total_vendas_dinheiro - total_vendas_dinheiro;

            tbEntrada.Text = (total_vendas_dinheiro + total_aporte ).ToString("C");
            tbSaida.Text = (total_sangria + total_despesa_dinheiro + total_compras_dinheiro).ToString("C");

            lblValorDiaAnterior.Text = saldoCaixaAnterior.ToString("C");
            tbSaldo.Text = saldoCaixa.ToString("C");
        }
        private void tbSuprimentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbSangria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbSuprimentos_Leave(object sender, EventArgs e)
        {
            string text = tbEntrada.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbEntrada.Text = String.Format("{0:c}", res);
            }
            else
            {
                tbEntrada.Text = "R$ 0,00";
            }
        }

        private void tbSangria_Leave(object sender, EventArgs e)
        {
            string text = tbSaida.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbSaida.Text = String.Format("{0:c}", res);
                if (res > saldoCaixaAnterior)
                {
                    tbSaida.Text = "R$ 0,00";
                    Function.Alert("Erro!", "Sangria maior que saldo anterior.", popupClient.enmType.Error);
                }
            }
            else
            {
                tbSaida.Text = "R$ 0,00";
            }
        }

        public Models.Caixa retornaCaixa()
        {
            return caixaSelecionado;
        }

        private void cbSangria_Click(object sender, EventArgs e)
        {
            cbSangria.Checked = true;
            lblSangriaAporte.Text = "Sangria:";
            cbAporte.Checked = false;
        }

        private void cbAporte_Click(object sender, EventArgs e)
        {
            cbSangria.Checked = false;
            lblSangriaAporte.Text = "Aporte:";
            cbAporte.Checked = true;
        }

        private void btnSangriaAporte_Click(object sender, EventArgs e)
        {
            double.TryParse(tbSangriaAporte.Text.Replace("R$", ""), out double valor);
            bool isOk = true;
            string descricao = "";
            char tipo = 'D';

            if (valor > 0)
            {
                if (cbSangria.Checked)
                {
                    if (valor <= saldoCaixa)
                    {
                        descricao = "Sangria";
                        tipo = '*';
                    }
                    else
                    {
                        MessageBox.Show("O valor da Sangria deve ser menor ou igual ao total do caixa!", "Saldo insuficiente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isOk = false;
                    }
                }
                else
                {
                    descricao = "Aporte";
                    tipo = '*';
                }
                if (isOk)
                {
                    if (controlTransacao.salvarTransacao(caixaSelecionado.Id, descricao, tipo, valor))
                    {
                        buscarCaixaSelecionado(caixaSelecionado.Id);
                        cbSangria.Checked = true;
                        cbAporte.Checked = false;
                        tbSangriaAporte.Text = "R$ 0,00";
                    }
                }
            }
            else
            {
                MessageBox.Show("O valor deve ser maior que zero!", "Valor incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbSangriaAporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbSangriaAporte_Leave(object sender, EventArgs e)
        {
            string text = tbSangriaAporte.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbSangriaAporte.Text = String.Format("{0:c}", res);
            }
            else
            {
                tbSangriaAporte.Text = "R$ 0,00";
            }
        }

        private void calculaSaldoAbrirCaixa()
        {
            double.TryParse(tbEntrada.Text.Replace("R$ ", ""), out double entrada);
            double.TryParse(tbSaida.Text.Replace("R$ ", ""), out double saida);

            saldoCaixa = saldoCaixaAnterior + entrada - saida;
            tbSaldo.Text = saldoCaixa.ToString("C");
        }

        private void tbEntrada_TextChanged(object sender, EventArgs e)
        {
            calculaSaldoAbrirCaixa();
        }

        private void tbSaida_TextChanged(object sender, EventArgs e)
        {
            calculaSaldoAbrirCaixa();
        }

        private void tbEntrada_Click(object sender, EventArgs e)
        {
            if(tbEntrada.Text == "R$ 0,00")
            {
                tbEntrada.Text = "";
            }
        }

        private void tbSaida_Click(object sender, EventArgs e)
        {

            if (tbSaida.Text == "R$ 0,00")
            {
                tbSaida.Text = "";
            }
        }

        private void tbSangriaAporte_Click(object sender, EventArgs e)
        {
            if(tbSangriaAporte.Text == "R$ 0,00")
            {
                tbSangriaAporte.Text = "";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm");
        }
        private void ConsularCaixas()
        {
            Form f = new FormConsultarAnteriores();
            f.ShowDialog();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F1:
                    ConsularCaixas();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

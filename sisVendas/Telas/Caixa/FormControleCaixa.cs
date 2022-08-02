using sisVendas.Controllers;
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
    public partial class FormControleCaixa : Form
    {

        private ctrlCaixa controlCaixa = new ctrlCaixa();
        private ctrlTransacaoCaixa controlTransacao = new ctrlTransacaoCaixa();
        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();
        private ctrlDespesa controlDespesas = new ctrlDespesa();
        private ctrlParcelasCompra controlParcelasCompra = new ctrlParcelasCompra();

        private int idFuncionario;
        private DataTable dttItensCaixa = new DataTable();
        private Models.Caixa caixaSelecionado = null;

        private double saldoCaixaAnterior = 0.00;
        private double saldoCaixa = 0.00;

        private double total_sangria = 0.00;
        private double total_aporte = 0.00;
        private double total_despesa_dinheiro = 0.00;
        private double total_vendas_dinheiro = 0.00;
        private double total_compras_dinheiro = 0.00;
        public FormControleCaixa()
        {
            InitializeComponent();
        }
        public FormControleCaixa(int idFunc) : this()
        {
            this.idFuncionario = idFunc;
            buscarCaixaAberto(idFuncionario);
        }
        private void resetaForm()
        {
            saldoCaixaAnterior =
            saldoCaixa =
            total_sangria =
            total_aporte =
            total_despesa_dinheiro =
            total_vendas_dinheiro =
            total_compras_dinheiro = 0.00;
            cbSangria.Checked = true;
            cbAporte.Checked = false;

            dttItensCaixa.Rows.Clear();
        }
        private void CaixaFechado()
        {
            gbAbrirFecha.Text = "Abrir Caixa";
            lblEntrada.Text = "Suprimentos:";
            lblSaida.Text = "Sangria:";
            lblSaldo.Text = "Saldo:";

            btnAbrirFechar.Text = "Abrir Caixa";
            lblDiaAnterior.Text = "Saldo Caixa Anterior:";
            tbEntrada.Enabled = tbSaida.Enabled = true;

            gbAporte.Enabled = false;

            if (caixaSelecionado != null) //se achou um caixa
                saldoCaixaAnterior = caixaSelecionado.SaldoAnterior + caixaSelecionado.Entradas - caixaSelecionado.Saidas;
            lblValorDiaAnterior.Text = saldoCaixaAnterior.ToString("C");
        }
        private void CaixaAberto()
        {
            gbAbrirFecha.Text = "Fechar Caixa";
            lblEntrada.Text = "Entradas:";
            lblSaida.Text = "Saidas:";
            lblSaldo.Text = "Saldo Atual:";

            btnAbrirFechar.Text = "Fechar Caixa";

            tbEntrada.Enabled =
            tbSaida.Enabled = false;
            lblDiaAnterior.Text = "Saldo Inicial:";

            gbAporte.Enabled = true;

            saldoCaixaAnterior = caixaSelecionado.SaldoAnterior;

            buscarTransacoesCaixaSelecionado(caixaSelecionado.Id);
        }
        private void buscarCaixaAberto(int idFuncionario)
        {
            caixaSelecionado = controlCaixa.buscarCaixaAberto(idFuncionario);

            if (caixaSelecionado == null || caixaSelecionado.Dtfechamento != null)
            {
                // PRIMEIRO CAIXA OU CAIXA FECHADO
                CaixaFechado();                
            }
            else // caixa aberto!
            {
                CaixaAberto();
            }

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
        private void buscarTransacoesCaixaSelecionado(int idCaixa)
        {
            resetaForm();
            DataTable dttTransacao;
            dttTransacao = controlTransacao.BuscarTransacoesPorIdCaixa(idCaixa);
            DataTable dttParcelasVenda;
            dttParcelasVenda = controlParcelasVenda.BuscarParcelasAVistaPorIdCaixa(idCaixa);
            //DataTable dttDespesas;
            //dttDespesas = controlDespesas.BuscarPorIdCaixa(idCaixa);
            DataTable dttParcelasCompra;
            dttParcelasCompra = controlParcelasCompra.BuscarParcelasAVistaPorIdCaixa(idCaixa);


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
                

            }

            //foreach (DataRow dr in dttDespesas.Rows)
            //{
            //    double.TryParse(dr["desp_valor"].ToString(), out double Valor);
            //    if (dr["desp_formaPagamento"].ToString() != "Fiado")
            //    {
            //        if (dr["desp_formaPagamento"].ToString() == "Dinheiro")
            //        {
            //            insereItensDttCaixa("*", "Desp. " + dr["desp_descricao"],
            //                        DateTime.Parse(dr["desp_dataReferencia"].ToString()), dr["desp_formaPagamento"].ToString(), Valor);
            //            total_despesa_dinheiro = total_despesa_dinheiro + Valor;
            //        }
            //        else if (dr["desp_formaPagamento"].ToString() == "Crédito")
            //        {
            //            total_despesa_credito = total_despesa_credito + Valor;
            //        }
            //        else if (dr["desp_formaPagamento"].ToString() == "Débito")
            //        {
            //            total_despesa_debito = total_despesa_debito + Valor;
            //        }
            //    }
            //}

            foreach (DataRow dr in dttParcelasVenda.Rows)
            {
                double.TryParse(dr["valor"].ToString(), out double Valor);
                total_vendas_dinheiro = total_vendas_dinheiro + Valor;
                insereItensDttCaixa("*", "Venda realizada N°: " + dr["idVenda"], DateTime.Parse(dr["data"].ToString()), "Dinheiro", Valor);
                
            }

            foreach (DataRow dr in dttParcelasCompra.Rows)
            {

                if (dr["tipo"].ToString() != "F") // para não pegar os fiados
                {
                    double.TryParse(dr["valor"].ToString(), out double Valor);

                    total_compras_dinheiro = total_compras_dinheiro + Valor;
                    insereItensDttCaixa("*", "Comrpa realizada N°: " + dr["idCompra"], DateTime.Parse(dr["data"].ToString()), "Dinheiro", Valor);
                    
                }
            }

            //dgvTransacoes.DataSource = dttItensCaixa;
            //preencherResumo();
        }

        private void btnAbrirFechar_Click(object sender, EventArgs e)
        {
            if (caixaSelecionado == null || caixaSelecionado.Dtfechamento != null) //abrir
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

                    //buscarCaixaSelecionado(caixaSelecionado.Id);
                }
            }
            else // fechar caixa
            {
                double entradas = total_aporte + total_vendas_dinheiro;
                double saidas = total_sangria + total_compras_dinheiro + total_despesa_dinheiro;

                controlCaixa.FecharCaixa(caixaSelecionado.Id, entradas, saidas);

                dttItensCaixa.Rows.Clear();

                tbEntrada.Text = tbSaida.Text = tbSaldo.Text = "R$ 0,00";

                buscarCaixaAberto(idFuncionario);
            }
        }
    }
}

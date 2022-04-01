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
using sisVendas.Models;
using System.Threading.Tasks;
using sisVendas.Persistence;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormAbrirFecharCaixa : Form
    {
        private double saldoAnterior = 0;

        private ctrlCaixa controlCaixa = new ctrlCaixa();
        private ctrlTransacaoCaixa controlTransacao = new ctrlTransacaoCaixa();
        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();

        private Models.Caixa caixaSelecionado = null;

        private DataTable dttCaixa;
        private DataTable dttItensCaixa = new DataTable();


        private int idFuncionario;
        private double entradas = 0;
        private double saidas = 0;

        public FormAbrirFecharCaixa()
        {
            InitializeComponent();

            dttItensCaixa.Columns.Add("descricao");
            dttItensCaixa.Columns.Add("tipo");

            dttItensCaixa.Columns.Add("formaPagamento");
            

            dttItensCaixa.Columns.Add("data", typeof(DateTime));
            dttItensCaixa.Columns.Add("valor", typeof(double));


        }
        public FormAbrirFecharCaixa(int idFunc) : this()
        {
            this.idFuncionario = idFunc;

            buscarCaixaAberto(idFuncionario);

            //apagar
            buscarCaixa(idFuncionario);
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
       
        private void buscarCaixaAberto(int cod)
        {
            caixaSelecionado = controlCaixa.buscarCaixaAberto(cod);
            
            if (caixaSelecionado == null)
            {
                groupAbrir.Enabled = true;
                groupFechar.Enabled = false;

                //buscar saldo anterior
                saldoAnterior = controlCaixa.buscarSaldoCaixaAnterior(cod);
                lblDiaAnterior.Text = "R$ "+saldoAnterior.ToString();

            }
            else
            {
                buscarTransacaoCaixa(caixaSelecionado.Id);

                groupAbrir.Enabled = false;
                groupFechar.Enabled = true;
            }


            //apagar
            buscarCaixa(idFuncionario);
        }

        private void buscarCaixa(int filtro)
        {
            dttCaixa = controlCaixa.buscarCaixa(filtro);
            dgvCaixa.DataSource = dttCaixa;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy") +" "+ DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {

            string suprimentos = tbSuprimentos.Text.Replace("R$ ", "");
            string sangria = tbSangria.Text.Replace("R$ ", "");
            


            if (suprimentos != "" && sangria != "")
            {
                MessageBox.Show("O caixa sera aberto!");

                if (controlCaixa.AbrirCaixa(idFuncionario, saldoAnterior, suprimentos, sangria))
                {
                    MessageBox.Show("Sucesso ao abrir o caixa!");

                    

                    buscarCaixaAberto(idFuncionario);
                    if (double.TryParse(suprimentos, out double suprimentosDouble))
                    {
                        if (suprimentosDouble != 0)
                            controlTransacao.salvarTransacao(caixaSelecionado.Id, "Suprimento", 'D', suprimentosDouble);
                    }
                    if (double.TryParse(sangria, out double sangriaDouble))
                    {
                        if (sangriaDouble != 0)
                            controlTransacao.salvarTransacao(caixaSelecionado.Id, "Sangria", 'C', sangriaDouble);
                    }
                    //
                    buscarTransacaoCaixa(caixaSelecionado.Id);

                }
                
            }

        }
        private void buscarTransacaoCaixa( int idCaixa)
        {
            DataTable dttTransacao;
            dttTransacao = controlTransacao.buscarPorFuncCaixa(idCaixa);
            DataTable dttParcelasVenda;
            dttParcelasVenda = controlParcelasVenda.buscarParcelasPorIdCaixa(idCaixa);

            

            foreach (DataRow dr in dttTransacao.Rows)
            {
                DataRow linha = dttItensCaixa.NewRow();

                linha["tipo"] = dr["transacao_tipo"];
                linha["descricao"] = dr["transacao_descricao"];
                linha["data"] = dr["transacao_criado_em"];
                linha["formaPagamento"] = "Dinheiro";
                linha["valor"] = dr["transacao_valor"];

                dttItensCaixa.Rows.Add(linha);
            }

            foreach(DataRow dr in dttParcelasVenda.Rows)
            {
                DataRow linha = dttItensCaixa.NewRow();


                if(dr["tipo"].ToString() != "F") // para não pegar os fiados
                {
                    linha["tipo"] = "D";
                    linha["descricao"] = "Venda realizada";
                    linha["data"] = dr["data"];
                    linha["valor"] = dr["valor"];

                    if (dr["tipo"].ToString() == "D")
                    {
                        linha["formaPagamento"] = "Débito";
                    }
                    else if (dr["tipo"].ToString() == "C")
                    {
                        linha["formaPagamento"] = "Crédito";
                    }
                    else if (dr["tipo"].ToString() == "M")
                    {
                        linha["formaPagamento"] = "Dinheiro";
                    }

                    //dtParcelas.Columns.Add("id", typeof(int));
                    //dtParcelas.Columns.Add("idCaixa", typeof(int));
                    //dtParcelas.Columns.Add("idVenda", typeof(int));
                    //dtParcelas.Columns.Add("valor", typeof(double));
                    //dtParcelas.Columns.Add("status");
                    //dtParcelas.Columns.Add("");
                    //dtParcelas.Columns.Add("", typeof(DateTime));
                    dttItensCaixa.Rows.Add(linha);
                }
            }
            dgvTransacoes.DataSource = dttItensCaixa;
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
            string text = tbSuprimentos.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
                tbSuprimentos.Text = String.Format("{0:c}", res);
            else
            {
                tbSuprimentos.Text = "R$ 0";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }

        private void tbSangria_Leave(object sender, EventArgs e)
        {
            string text = tbSangria.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbSangria.Text = String.Format("{0:c}", res);
                if (res > saldoAnterior)
                {
                    tbSangria.Text = "R$ 0";
                    Function.Alert("Erro!", "Sangria maior que saldo anterior.", popupClient.enmType.Error);
                }
            }
            else
            {
                tbSangria.Text = "R$ 0";
                Function.Alert("Erro!", "Valor incorreto", popupClient.enmType.Error);
            }
        }


        private void btn_fechar_Click(object sender, EventArgs e)
        {
            controlCaixa.FecharCaixa(caixaSelecionado.Id,entradas, saidas);
            buscarCaixaAberto(idFuncionario);

            dttItensCaixa.Rows.Clear();
        }

        public Models.Caixa retornaCaixa()
        {
            return caixaSelecionado;
        }
    }
}

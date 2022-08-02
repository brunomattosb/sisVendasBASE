using sisVendas.Controllers;
using sisVendas.Funcoes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Caixa
{
    public partial class FormContasAReceber : Form
    {

        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();
        private int idCaixa;

        public FormContasAReceber()
        {
            InitializeComponent();

            dgv_parcelas.Columns["parcela_valor"].DefaultCellStyle.Format = "C";
            UpdateDGV("");
        }
        private void UpdateDGV(string filtro)
        {

            dgv_parcelas.DataSource = controlParcelasVenda.buscarParcelasEmAberto(filtro);
        }

        public FormContasAReceber(int idCaixa):this()
        {
            this.idCaixa = idCaixa;
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
        private string getFiltro()
        {
            string filtro = "";

            if (cbAberto.Checked)
            {
                filtro = "parcela_dataPagamento is null";
            }
            if (cbQuitada.Checked)
            {
                if (filtro != "")
                {
                    filtro = "(" + filtro + " OR ";
                    filtro = filtro + "parcela_dataPagamento is not null)";
                }
                else
                {
                    filtro = filtro + "parcela_dataPagamento is not null";
                }
            }

            string cpf = Function.replaceAll(mtbCpf.Text);
            if (cpf.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_cpf_cnpj like '" + cpf + "%'";
            }

            if (tbName.Text.Length > 0)
            {
                if (filtro != "")
                    filtro = filtro + " AND ";
                filtro = filtro + "cli_nome like '%" + tbName.Text + "%'";
            }

            if (cbPesquisarPorPeriodo.Checked)
            {
                if (dtpInicio.Value.Date <= dtpFim.Value.Date)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "venda_criado_em BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }
                else
                {
                    Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
                }
            }
            return filtro;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            UpdateDGV(getFiltro());
        }

        private void dgv_parcelas_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_parcelas.SelectedRows.Count == 1)
            {

                //activeForm();
                DataGridViewCellCollection linha = dgv_parcelas.Rows[dgv_parcelas.CurrentRow.Index].Cells;

                /*
                    0     parcela_id
                    1     idCaixa
                    2     idVenda
                    3     Valor
                    4     dtPagamento
                    5     criado_em / Data venda
                    6     nome
                    7     cpf
                    8     cancelada
                    9     dtVencimento
                */

                if (linha[4].Value.ToString() == "") // é null, não foi pago!
                {
                    FormQuitarContaReceber f = new FormQuitarContaReceber(double.Parse(linha[3].Value.ToString()),
                                                     int.Parse(linha[0].Value.ToString()), idCaixa, int.Parse(linha[2].Value.ToString()));
                    f.ShowDialog();

                    if (f.alterou())
                        btnBuscar.PerformClick();
                }
                else
                {
                    if (int.Parse(linha[1].Value.ToString()) == idCaixa)
                    {
                        if (MessageBox.Show("Deseja estornar a parcela selecionada?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();
                            controlParcelas.onerarParcela(int.Parse(linha[0].Value.ToString()));

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

       private void mtbCpf_Click(object sender, EventArgs e)
       {
           if (Function.replaceAll(mtbCpf.Text).Length == 0)
               mtbCpf.Select(0, 0);
       }


        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                int count = Function.replaceAll(mtbCpf.Text).Count();
                changeCpfCnpj(count);
            }
        }

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpf.Text).Count() == 10)
            {
                changeCpfCnpj(Function.replaceAll(mtbCpf.Text).Count());
            }
        }
        public void changeCpfCnpj(int qtde)
        {
            if (mtbCpf.Mask != "000.000.000-00" && qtde < 11)
            {
                mtbCpf.Mask = "000.000.000-00";

                mtbCpf.Select(qtde, 0);
                lblCpf.Text = "CPF:";

            }
            else if (qtde >= 11)
            {

                int pos = mtbCpf.Text.Count();
                mtbCpf.Mask = "00.000.000/0000-00";
                mtbCpf.Select(pos, 0);

                lblCpf.Text = "CNPJ:";

            }

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable dtContasReceber = controlParcelasVenda.buscarParcelasFormulario(getFiltro());
            if (dtContasReceber.Rows.Count > 0) // se existir pessoas
            {
                float[] largurasColunas = { 1.5f, 1f, 1f, 1f, 1f, 1f };
                Relatorios.gerarRelatorio($"RelatórioSisVendas.ContasAReceber.pdf", "Contas A Receber!", dtContasReceber, largurasColunas);
            }
        }
    }
}


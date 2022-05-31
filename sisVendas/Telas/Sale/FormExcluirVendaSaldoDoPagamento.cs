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

namespace sisVendas.Telas.Sale
{
    public partial class FormExcluirVendaSaldoDoPagamento : Form
    {
        private int idVenda;
        private int idCliente;
        private int idCaixa;
        private DataTable dttProduto;
        private ctrlCliente controlCliente = new ctrlCliente();
        private ctrlTransacaoCaixa controlTransacaoCaixa = new ctrlTransacaoCaixa();

        private double somaParcelasPagas = 0;

        private ctrlVenda controlVenda = new ctrlVenda();
        public FormExcluirVendaSaldoDoPagamento()
        {
            InitializeComponent();
        }
        public FormExcluirVendaSaldoDoPagamento(int idVenda, int idCliente, DataTable dttProduto, DataTable dttParcela, int idCaixa) : this()
        {
            this.idVenda = idVenda;
            this.idCliente = idCliente; 
            this.dttProduto = dttProduto;
            this.idCaixa = idCaixa;


            foreach (DataRow parc in dttParcela.Rows)
            {
                if (parc["tipo_pagamento"].ToString() != "Fiado")
                    somaParcelasPagas = somaParcelasPagas + double.Parse(parc["valor"].ToString());

            }
            if(somaParcelasPagas == 0)
            {
                cbAddSaldo.Visible =
                cbbRetirarCaixa.Visible = false;
            }
            lblValor.Text = somaParcelasPagas.ToString("C");
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool res = false;
            if (MessageBox.Show("Confirmar exclusão ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                res = controlVenda.removerVenda(idVenda, dttProduto);
            }

            if (res && somaParcelasPagas > 0)
            {
                if (cbAddSaldo.Checked) // adicionar saldo
                {
                    res = controlCliente.adicionarSaldo(idCliente, somaParcelasPagas);
                }
                else //adicionar transacao no caixa
                {
                    res = controlTransacaoCaixa.salvarTransacao(idCaixa, "Venda cancelada!", '*', somaParcelasPagas);
                }
                
            }
            MessageBox.Show("Venda excluida!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

        }

        private void cbAddSaldo_Click(object sender, EventArgs e)
        {
            cbbRetirarCaixa.Checked = false;
            cbAddSaldo.Checked = true;
        }

        private void cbbRetirarCaixa_Click(object sender, EventArgs e)
        {
            cbAddSaldo.Checked = false;
            cbbRetirarCaixa.Checked = true;
        }
    }
}


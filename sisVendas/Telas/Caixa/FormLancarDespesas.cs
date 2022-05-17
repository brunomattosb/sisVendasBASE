using sisVendas.Controllers;
using sisVendas.Functions;
using sisVendas.Models;
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
    public partial class FormLancarDespesas : Form
    {
        private DataTable dttTipos = new DataTable();
		private ctrlDespesaTipo controlTiposDespesa = new ctrlDespesaTipo();
		private ctrlDespesa controlDespesa = new ctrlDespesa();

		private int caixaid;
		public FormLancarDespesas()
		{
			InitializeComponent();

			dtpData.Value = dtpInicio.Value = dtpFim.Value = DateTime.Now;

			dttTipos = controlTiposDespesa.BuscarDespesaTipo("");

			cbbTiposDespesas.DataSource = dttTipos;
			cbbTiposDespesas.DisplayMember = "desp_tipo_nome";
			cbbTiposDespesas.ValueMember = "desp_tipo_id";
			cbbTiposDespesas.SelectedIndex = -1;

			cbbFiltroTipo.DataSource = dttTipos.Copy();
			cbbFiltroTipo.DisplayMember = "desp_tipo_nome";
			cbbFiltroTipo.ValueMember = "desp_tipo_id";
			cbbFiltroTipo.SelectedIndex = -1;

			dgv_despesa.Columns["desp_valor"].DefaultCellStyle.Format =
			dgv_despesa.Columns["desp_desconto"].DefaultCellStyle.Format = "C";
		}
		public FormLancarDespesas(int caixaid) :this()
		{
			this.caixaid = caixaid;
			updateDgv("");
			neutralForm();
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
		public void cleanForm()
		{
			tbDescricao.Text = tbCod.Text = "";
			cbbTiposDespesas.SelectedIndex = -1;
			tbDesconto.Text = tbValor.Text = "R$ 0,00";
			cbbTipoPagamento.SelectedIndex = -1;

			dtpData.Value =
			dtpPagamento.Value = DateTime.Now;
		}
		public void neutralForm()
		{
			
			cleanForm();
			tbDescricao.Enabled =
			tbValor.Enabled =
			dtpData.Enabled =
			cbbTipoPagamento.Enabled =
			cbbTiposDespesas.Enabled = false;

			btnNew.Enabled = true;
			btnRemove.Enabled =
			btnSave.Enabled =
			tbDesconto.Enabled =
			btnCancel.Enabled = false;

			btnNew.Focus();
		}
		public void clearColorLabens()
        {
			lblCod.ForeColor = 
			lblData.ForeColor =
			lblTipo.ForeColor =
			lblValor.ForeColor =
			lblFormaPagamento.ForeColor =
			lblValorFinal.ForeColor = Color.Black;

		}
		public void activeForm()
		{
			cleanForm();
			clearColorLabens();
			tbDescricao.Enabled =
			tbValor.Enabled =
			cbbTiposDespesas.Enabled =
			cbbTipoPagamento.Enabled =
			dtpData.Enabled = true;
			
			btnNew.Enabled =
			btnRemove.Enabled = false;

			btnSave.Enabled =
			tbDesconto.Enabled =
			dtpData.Enabled =
			btnCancel.Enabled = true;

			cbbTiposDespesas.SelectedIndex = 0;
			cbbTipoPagamento.SelectedIndex = 0;

			lblValorFinal.Text = "R$ 0,00";
		}
		
		private void btnNew_Click(object sender, EventArgs e)
        {
            activeForm();
			cbbTiposDespesas.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
        {
            neutralForm();
        }
		public void updateDgv(string filtro)
		{
			dgv_despesa.DataSource = controlDespesa.Buscar(filtro);
		}


		private void resetColor()
        {
			lblValor.ForeColor = lblDesconto.ForeColor = lblTipo.ForeColor = Color.Black;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool isOk = true;
			resetColor();
			double.TryParse(tbDesconto.Text.Replace("R$ ", ""), out double desconto);
			double.TryParse(tbValor.Text.Replace("R$", ""), out double valor);

			string status = "DEVE";
			if (valor <= 0)
			{
				isOk = false;
				lblValor.ForeColor = Color.Red;
			}


			if (desconto > valor)
			{
				isOk = false;
				lblDesconto.ForeColor = Color.Red;
				Function.Alert("Alerta!", "Valor de desconto maior que valor da despesa.", popupClient.enmType.Info);
			}

			if (valor - desconto == 0)
			{
				isOk = false;
				lblValor.ForeColor = Color.Red;
				lblDesconto.ForeColor = Color.Red;
				Function.Alert("Alerta!", "Valor total deve ser maior que zero.", popupClient.enmType.Info);
			}

			if (cbbTipoPagamento.SelectedIndex != -1)
			{
				if (cbbTipoPagamento.SelectedIndex != 3) // a pagar
				{
					dtpPagamento.Value = DateTime.Now;
					status = "PAGO";
				}
            }
            else // -1
            {
				isOk = false;
				lblFormaPagamento.ForeColor = Color.Red;

			}

			if (isOk)
			{
				if (controlDespesa.SalvarDespesa(

					tbCod.Text,
					tbDescricao.Text,
					valor,
					int.Parse(cbbTiposDespesas.SelectedValue.ToString()),
					caixaid,
					desconto,
					dtpData.Value,
					cbbTipoPagamento.Text,
					dtpPagamento.Value,
					status
					))
				{

					Function.Alert("Sucesso!", "Despesa salva.", popupClient.enmType.Success);

					btnBuscar.PerformClick();
					activeForm();
					cbbTiposDespesas.Focus();
				}
			}
		}

		private void tbBaseSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
			{
				e.Handled = true;
			}
		}

        private void tbBaseSalary_Leave(object sender, EventArgs e)
        {
			
			string text = tbValor.Text.Replace("R$", "");
			if (double.TryParse(text, out double res))
            {
				tbValor.Text = String.Format("{0:c}", res);
				calculaTotal();
			}
			else
			{
				tbValor.Text = "R$ 0,00";
			}
		}

		private void calculaTotal()
        {
			if (Double.TryParse(tbDesconto.Text.Replace("R$ ", ""), out double desconto))
				if (Double.TryParse(tbValor.Text.Replace("R$ ", ""), out double valor))
					lblValorFinal.Text = (valor - desconto).ToString("C");
		}
        private void tbDesconto_Leave(object sender, EventArgs e)
        {
			string text = tbDesconto.Text.Replace("R$ ", "");
			if (double.TryParse(text, out double res))
			{
				tbDesconto.Text = String.Format("{0:c}", res);
				calculaTotal();
			}
			else
			{
				tbDesconto.Text = "R$ 0,00";
			}
		}



        private void tbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
			{
				e.Handled = true;
			}
		}

        private void tbValor_Enter(object sender, EventArgs e)
        {
			if (tbValor.Text == "R$ 0,00")
			{
				tbValor.Text = "";
			}
		}

        private void tbDesconto_Enter(object sender, EventArgs e)
        {
			if (tbDesconto.Text == "R$ 0,00")
			{
				tbDesconto.Text = "";
			}
		}

        private void btnRemove_Click(object sender, EventArgs e)
        {
			
			string idDesp = tbCod.Text;
            if (idDesp != "")
            {
                if (MessageBox.Show("Deseja excluir a despesa selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (controlDespesa.RemoverDespesa(idDesp) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Function.Alert("Sucesso!", "Despesa excluida.", popupClient.enmType.Success);
                    }
                    else
                    {
                        Function.Alert("Erro!", "Erro ao excluir despesa.", popupClient.enmType.Error);

                    }
                }
            }
            else
            {
				MessageBox.Show("Selecione a despesa", "Atenção", MessageBoxButtons.OK);
			}
		}
		private void fillForm(Despesa desp)
		{

			tbCod.Text = desp.Id+"";
			tbDescricao.Text = desp.Descricao;
			cbbTiposDespesas.SelectedValue = desp.IdTipo;
			
			tbValor.Text = desp.Valor.ToString("C");
			dtpData.Value = desp.DataReferencia;
			tbDesconto.Text = desp.Desconto.ToString("C");

			dtpData.Enabled =
			cbbTiposDespesas.Enabled =
			tbValor.Enabled =
			tbDesconto.Enabled =
			tbDescricao .Enabled =
			btnRemove.Enabled =
			cbbTipoPagamento.Enabled =
			btnSave.Enabled = (desp.IdCaixa == caixaid);
			lblValorFinal.Text = (desp.Valor - desp.Desconto).ToString("C");
			cbbTipoPagamento.Text = desp.Forma_pagamento;
			dtpPagamento.Value = desp.DataPagamento;
		}
		private void dgv_despesa_DoubleClick(object sender, EventArgs e)
        {
		
			if (dgv_despesa.SelectedRows.Count == 1)
			{
				activeForm();
				DataGridViewCellCollection linha = dgv_despesa.Rows[dgv_despesa.CurrentRow.Index].Cells;

				Despesa desp = new Despesa();
				
				desp.Id = int.Parse(linha[0].Value.ToString());
				desp.Descricao = linha[1].Value.ToString();
				desp.IdTipo= Convert.ToInt32(linha[2].Value);
				desp.IdCaixa = int.Parse(linha[3].Value.ToString()); // idcaixa
				desp.DataPagamento = DateTime.Parse(linha[4].Value.ToString());
				double.TryParse(linha[5].Value.ToString(), out double valor);
				
				desp.DataReferencia = DateTime.Parse(linha[6].Value.ToString());
				double.TryParse(linha[7].Value.ToString(), out double desconto);
				desp.Desconto = desconto;
				desp.Valor = valor + desconto;
				desp.Forma_pagamento= linha[8].Value.ToString();
				desp.Status = linha[9].Value.ToString();

				fillForm(desp);
			}
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			
			string filtro = "";

			if (cbbFiltroEmAberto.Checked)
			{
				filtro = "desp_status = 'DEVE'";
			}
			if (cbbFiltroPago.Checked)
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

			if (cbCaixaAtual.Checked) // mostrar somente caixa atual
			{
				if (filtro != "")
					filtro = filtro + " AND ";
				filtro = "desp_idCaixa = "+caixaid;
				
			}

			if (tbDescFiltro.Text.Length > 0)
			{
				if (filtro != "")
					filtro = filtro + " AND ";
				filtro = filtro + "desp_descricao like '%" + tbDescFiltro.Text + "%'";
			}

			if (cbbFiltroTipo.SelectedIndex != -1)
			{
				if (filtro != "")
					filtro = filtro + " AND ";
				filtro = filtro + "desp_idTipo = " + cbbFiltroTipo.SelectedValue;
			}

            if (cbPesquisarPorPeriodo.Checked)
            {
				if (dtpInicio.Value.Date <= dtpFim.Value.Date)
				{
					if (filtro != "")
						filtro = filtro + " AND ";
					filtro = filtro + "desp_dataReferencia BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
				}
				else
				{
					Function.Alert("Alerta!", "Data final maior que data inicial", popupClient.enmType.Warning);
				}
			}
			


			updateDgv(filtro);
			cbbFiltroTipo.SelectedIndex = -1;
		}

        private void cbbTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(cbbTipoPagamento.SelectedIndex == 3)
            {
				dtpPagamento.Enabled = true;
				lblPagamentoReferencia.Text = "Data de Vencimento";
            }
            else
            {
				dtpPagamento.Enabled = false;
				lblPagamentoReferencia.Text = "Data de Pagamento";
				dtpPagamento.Value = DateTime.Now;
			}

		}
    }
}

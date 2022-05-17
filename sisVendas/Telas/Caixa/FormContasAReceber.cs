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
    public partial class FormContasAReceber : Form
    {

        private ctrlParcelasVenda controlParcelasVenda = new ctrlParcelasVenda();
        private int idCaixa;

        public FormContasAReceber()
        {
            InitializeComponent();

            dgv_parcelas.Columns["valor"].DefaultCellStyle.Format = "C";
            btnBuscar.PerformClick();
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";

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
                filtro = filtro + "cli_nome like '%" + tbName.Text+"%'";
            }

            if(cbPesquisarPorPeriodo.Checked)
            {
                if (dtpInicio.Value.Date <= dtpFim.Value.Date)
                {
                    if (filtro != "")
                        filtro = filtro + " AND ";
                    filtro = filtro + "venda_criado_em BETWEEN '" + dtpInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }
                else
                {
                    Function.Alert("Alerta!", "Data Inicio maior que data Fim", popupClient.enmType.Warning);
                }
            }

            UpdateDGV(filtro);
            Console.WriteLine(filtro);
        }

        private void dgv_parcelas_DoubleClick(object sender, EventArgs e)
        {
            
           if (dgv_parcelas.SelectedRows.Count == 1)
           {

               //activeForm();
              DataGridViewCellCollection linha = dgv_parcelas.Rows[dgv_parcelas.CurrentRow.Index].Cells;

               if (linha[8].Value.ToString() == "DEVE")
               {
                   FormQuitarContaReceber f = new FormQuitarContaReceber(double.Parse(linha[3].Value.ToString()), int.Parse(linha[0].Value.ToString()), idCaixa, int.Parse(linha[2].Value.ToString()));
                   f.ShowDialog();

                   if (f.alterou())
                       btnBuscar.PerformClick();
               }
               else
               {
                   MessageBox.Show(idCaixa + "");
                   if(int.Parse(linha[1].Value.ToString()) == idCaixa)
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
                       MessageBox.Show("Parcela não quitada no caixa atual.", "Alerta!", MessageBoxButtons.OK);
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
            //MessageBox.Show(qtde + "");
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
    }
}


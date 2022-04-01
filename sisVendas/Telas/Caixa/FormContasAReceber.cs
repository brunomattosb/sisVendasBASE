using sisVendas.Controllers;
using sisVendas.Functions;
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

            dgv_parcelas.DataSource = controlParcelasVenda.buscarParcelasEmAberto("");
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

           if(Function.replaceAll(mtbCpf.Text).Length == 11)
           {
               filtro = filtro + " AND cli_cpf_cnpj = '" + mtbCpf.Text.Replace(",", "").Replace("-", "")+"'";
           }
           if (tbName.Text.Length > 0)
           {
               filtro = filtro + " AND cli_name like '%" + tbName.Text+"%'";
           }
           if (DateTime.TryParse(mtbDtInicio.Text, out DateTime ini) && DateTime.TryParse(mtbDtFim.Text, out DateTime fim))
           {
               if (ini <= fim)
               {

                   filtro = filtro + " AND venda_criado_em BETWEEN '" + ini.Date.ToString() + "' AND '" + fim.Date.ToString()+"'";
                }
                else
                {
                    MessageBox.Show("inicio menor que o final");
                }
           }

            Console.WriteLine(filtro);

            dgv_parcelas.DataSource = controlParcelasVenda.buscarParcelasEmAberto(filtro);
        }

        private void dgv_parcelas_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_parcelas.SelectedRows.Count == 1)
            {
                //activeForm();
                DataGridViewCellCollection linha = dgv_parcelas.Rows[dgv_parcelas.CurrentRow.Index].Cells;


                //MessageBox.Show(linha[0].Value.ToString()); //id
                //MessageBox.Show(linha[1].Value.ToString()); //idcaixa
                //MessageBox.Show(linha[2].Value.ToString()); //idvenda
                //MessageBox.Show(linha[3].Value.ToString()); //valor
                //MessageBox.Show(linha[4].Value.ToString()); //dtvenda
                //MessageBox.Show(linha[5].Value.ToString()); //dtpagamento
                //MessageBox.Show(linha[6].Value.ToString()); //cpf
                //.Show(linha[7].Value.ToString()); //nome

                
                FormQuitarConta f = new FormQuitarConta(double.Parse(linha[3].Value.ToString()), int.Parse(linha[0].Value.ToString()), idCaixa, int.Parse(linha[2].Value.ToString()));
                f.ShowDialog();

            }
        }
    }
}


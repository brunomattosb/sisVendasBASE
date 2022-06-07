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

namespace sisVendas.Telas.Promocao
{
    public partial class FormBuscarPromocao : Form
    {
        ctrlPromocao controlPromocao = new ctrlPromocao();
        ctrlItensPromocao controlItensPromocao = new ctrlItensPromocao();

        DataTable dttPromocao = new DataTable();
        public FormBuscarPromocao()
        {
            InitializeComponent();

            atualizarDGV();
            //dgv_venda.Columns["desconto"].DefaultCellStyle.Format = "C";
        }

        private void atualizarDGV()
        {
            dttPromocao = controlPromocao.Buscar("");
            dgv_promocao.DataSource = dttPromocao;

            dgv_promocao.ClearSelection();
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

        private void FormBuscarPromocao_Load(object sender, EventArgs e)
        {
            dgv_promocao.ClearSelection();
        }

        private void selecionarPromocao()
        {
            if (DateTime.Parse(dgv_promocao.Rows[dgv_promocao.CurrentRow.Index].Cells[3].Value.ToString()) >= DateTime.Now)
            {
                btnFinalizarPromo.Enabled = true;
            }
            else
            {
                btnFinalizarPromo.Enabled = false;
            }

            if (dgv_promocao.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgv_promocao.Rows[dgv_promocao.CurrentRow.Index].Cells[0].Value.ToString());

                dgv_produtos.DataSource = controlItensPromocao.buscarItens(id);
            }
        }
        private void dgv_promocao_Click(object sender, EventArgs e)
        {
            selecionarPromocao();
        }

        private void btnFinalizarPromo_Click(object sender, EventArgs e)
        {

            
            
            if (MessageBox.Show("Deseja finalizar a promoção selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                controlPromocao.finalizarPromocao(int.Parse(dgv_promocao.Rows[dgv_promocao.CurrentRow.Index].Cells[0].Value.ToString()));
                atualizarDGV();
                btnFinalizarPromo.Enabled = false;
            }

        }

        private void dgv_promocao_SelectionChanged(object sender, EventArgs e)
        {
            selecionarPromocao();
        }
    }
}

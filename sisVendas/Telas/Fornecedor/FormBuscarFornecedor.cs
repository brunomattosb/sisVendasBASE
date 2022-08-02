using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Telas.Fornecedor
{
    public partial class FormBuscarFornecedor : Form
    {
        private ctrlFornecedor controlFornecedor = new ctrlFornecedor();
        private DataRow fornecedorSelecionado;
        private DataTable dttFornecedor;

        public FormBuscarFornecedor()
        {
            InitializeComponent();

            //dgv_fornecedor.Columns["cli_balance"].DefaultCellStyle.Format = "C";
            updateDgv("");
            tbSearth.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    selecionarFornecedor();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void updateDgv(string filtro)
        {
            //dttFornecedor = controlFornecedor.buscarFornecedorResumido(filtro);
            //dgv_fornecedor.DataSource = dttFornecedor;

        }

        private void tbSearth_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearth.Text);
        }

        private void dgv_fornecedor_DoubleClick(object sender, EventArgs e)
        {
            selecionarFornecedor();
        }
        public void selecionarFornecedor()
        {
            if (dgv_fornecedor.CurrentRow != null)
            {
                fornecedorSelecionado = dttFornecedor.Rows[dgv_fornecedor.CurrentRow.Index];
                Close();
            }
        }
        public Models.Fornecedor returnFornecedor()
        {
            if (fornecedorSelecionado != null)
            {
                Models.Fornecedor forn = new Models.Fornecedor();

                forn.Id = int.Parse(fornecedorSelecionado[0].ToString());
                forn.Nome = fornecedorSelecionado[2].ToString();
                forn.Cpf_cnpj = fornecedorSelecionado[1].ToString();
                forn.Nome_fantasia = fornecedorSelecionado[3].ToString();

                return forn;
            }
            else
            {
                return null;
            }

        }

    }
}

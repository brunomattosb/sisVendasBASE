using sisVendas.Controllers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Promocao
{
    public partial class FormRegistrarPromocao : Form
    {
        int idFunc;

        DataTable dttProduto = new DataTable();
        DataTable dttProdutosPromocao = new DataTable();

        ctrlProduct controlProduto = new ctrlProduct();
        ctrlPromocao controlPromocao = new ctrlPromocao();

        public FormRegistrarPromocao()
        {
            InitializeComponent();

            //Produtos da promoção
            dttProdutosPromocao.TableName = "produtosPromo";
            dttProdutosPromocao.Columns.Add("prod_nome");
            dttProdutosPromocao.Columns.Add("prod_id");
            dttProdutosPromocao.Columns.Add("prod_estoque", typeof(double));
            dttProdutosPromocao.Columns.Add("prod_valor", typeof(double));
            dttProdutosPromocao.Columns.Add("prod_valor_original", typeof(double));

            dgv_ProdutosSelecionados.DataSource = dttProdutosPromocao;

            dgv_ProdutosSelecionados.Columns["prod_valor_promo"].DefaultCellStyle.Format = "C";
            dgv_ProdutosSelecionados.Columns["prod_estoque_promo"].DefaultCellStyle.Format = "F";
            dgv_ProdutosSelecionados.Columns["prod_valor_original_promo"].DefaultCellStyle.Format = "C";

            //Produtos cadastrados

            dttProduto = atualizarDGV();
            dgv_produtos.DataSource = dttProduto;


            dgv_produtos.Columns["prod_valor"].DefaultCellStyle.Format = "C";
            dgv_produtos.Columns["prod_estoque"].DefaultCellStyle.Format = "F";
        }
        private DataTable atualizarDGV()
        {

            //return controlProduto.buscarParaPromocao();
            return new DataTable();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F1:
                    abrirFormBuscarPromocao();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public FormRegistrarPromocao(int idFunc) : this()
        {

            this.idFunc = idFunc;
        }

        private void tbValorUn_Click(object sender, EventArgs e)
        {
            if (tbValorUn.Text == "R$ 0,00")
            {
                tbValorUn.Text = "";
            }
        }

        private void tbValorDesconto_Leave(object sender, EventArgs e)
        {
            string text = tbValorDesconto.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbValorDesconto.Text = String.Format("{0:c}", res);
            }
            else
            {
                tbValorDesconto.Text = "R$ 0,00";
            }
        }

        private void tbValorDesconto_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbValorDesconto.Text == "R$ 0,00")
            {
                tbValorDesconto.Text = "";
            }
        }

        private void tbValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbPorcentagemDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }
        private void tbValorUn_Leave(object sender, EventArgs e)
        {
            string text = tbValorUn.Text.Replace("R$ ", "");
            if (double.TryParse(text, out double res))
            {
                tbValorUn.Text = String.Format("{0:C}", res);
            }
            else
            {
                tbValorUn.Text = "0,00%";
                //Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
            }
        }
        private void tbPorcentagemDesconto_Leave(object sender, EventArgs e)
        {
            string text = tbPorcentagemDesconto.Text.Replace("%", "");
            if (double.TryParse(text, out double res))
            {
                if (res < 100)
                    tbPorcentagemDesconto.Text = String.Format("{0:f}", res) + "%";
                else
                {
                    tbPorcentagemDesconto.Text = "0,00%";
                    MessageBox.Show("O desconto não pode ser de 100%");
                }
            }
            else
            {
                tbPorcentagemDesconto.Text = "0,00%";
                //Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
            }
        }

        private void tbPorcentagemDesconto_Click(object sender, EventArgs e)
        {
            if (tbPorcentagemDesconto.Text == "0,00%")
            {
                tbPorcentagemDesconto.Text = "";
            }
        }

        private void setPropriedadesProduto()
        {
            if (dgv_produtos.SelectedRows.Count == 1)
            {
                string estoque = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[1].Value.ToString();
                string nome = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[2].Value.ToString();
                string valor = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[3].Value.ToString();

                tbEstoque.Text = estoque;
                tbNomeProduto.Text = nome;
                tbValorUn.Text = "R$ " + valor;
            }
        }
        private void limparProduto()
        {
            tbEstoque.Text = "";
            tbNomeProduto.Text = "";
            tbValorUn.Text = "R$ 0,00";
        }
        private void dgv_produtos_SelectionChanged(object sender, EventArgs e)
        {
            setPropriedadesProduto();
        }
        private void adicionarProdutoAPromocao(string id, string estoque, string nome, string valorOriginal, string valorPromo)
        {
            DataRow linha = dttProdutosPromocao.NewRow();

            linha["prod_nome"] = nome;
            linha["prod_id"] = int.Parse(id);
            linha["prod_estoque"] = double.Parse(estoque);
            linha["prod_valor"] = double.Parse(valorPromo.Replace("R$ ", ""));
            linha["prod_valor_original"] = double.Parse(valorOriginal.Replace("R$ ", ""));

            dttProdutosPromocao.Rows.Add(linha);
        }
        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.SelectedRows.Count > 0)
            {
                string id = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[0].Value.ToString(); 
                string estoque = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[1].Value.ToString();
                string nome = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[2].Value.ToString();
                string valorOriginal = dgv_produtos.Rows[dgv_produtos.CurrentRow.Index].Cells[3].Value.ToString();
                adicionarProdutoAPromocao(id, estoque, nome, valorOriginal, tbValorUn.Text);

                var results = dttProduto.AsEnumerable().Where(x => x.Field<string>("prod_id") == id).
                    Select(s => s);
                dttProduto.Rows.Remove(results.First());
            }
        }

        private void cbbPorcentagem_Click(object sender, EventArgs e)
        {
            cbbValor.Checked = false;
            cbbPorcentagem.Checked = true;

            tbValorDesconto.Enabled = false;
            tbPorcentagemDesconto.Enabled = true;

            tbValorDesconto.Text = "R$ 0,00";
        }

        private void cbbValor_Click(object sender, EventArgs e)
        {
            cbbValor.Checked = true;
            cbbPorcentagem.Checked = false;
            tbValorDesconto.Enabled = true;
            tbPorcentagemDesconto.Enabled = false;
            tbPorcentagemDesconto.Text = "0,00%";
        }

        private void tbValorUn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void dgv_produtos_Click(object sender, EventArgs e)
        {
            setPropriedadesProduto();
        }
        private void adicionarProduto(string id, string estoque, string nome, string valorOriginal)
        {
            DataRow linha = dttProduto.NewRow();

            linha["prod_nome"] = nome;
            linha["prod_id"] = int.Parse(id);
            linha["prod_estoque"] = double.Parse(estoque);
            linha["prod_valor"] = double.Parse(valorOriginal.Replace("R$ ", ""));

            dttProduto.Rows.Add(linha);
        }
        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgv_ProdutosSelecionados.SelectedRows.Count > 0)
            {
               
                string id = dgv_ProdutosSelecionados.Rows[dgv_ProdutosSelecionados.CurrentRow.Index].Cells[1].Value.ToString();
                string estoque = dgv_ProdutosSelecionados.Rows[dgv_ProdutosSelecionados.CurrentRow.Index].Cells[2].Value.ToString();
                string nome = dgv_ProdutosSelecionados.Rows[dgv_ProdutosSelecionados.CurrentRow.Index].Cells[0].Value.ToString();
                string valorOriginal = dgv_ProdutosSelecionados.Rows[dgv_ProdutosSelecionados.CurrentRow.Index].Cells[4].Value.ToString();

                adicionarProduto(id, estoque, nome, valorOriginal);

                var results = dttProdutosPromocao.AsEnumerable().Where(x => x.Field<string>("prod_id") == id).
                    Select(s => s);
                dttProdutosPromocao.Rows.Remove(results.First());
            }

        }

        private void btnInserirTodos_Click(object sender, EventArgs e)
        {
            string id;
            string estoque;
            string nome;
            string valorOriginal;
            
            foreach (DataRow row in dttProduto.Rows)
            {
                id = row[0].ToString();
                estoque = row[1].ToString();
                nome = row[2].ToString();
                valorOriginal = row[3].ToString();

                adicionarProdutoAPromocao(id, estoque, nome, valorOriginal, valorOriginal);
            }
            dttProduto.Rows.Clear();
        }

        private void btnRemoverTodos_Click(object sender, EventArgs e)
        {
            string id;
            string estoque;
            string nome;
            string valorOriginal;

            foreach (DataRow row in dttProdutosPromocao.Rows)
            {
                id = row[1].ToString();
                estoque = row[2].ToString();
                nome = row[0].ToString();
                valorOriginal = row[4].ToString();
  


                adicionarProduto(id, estoque, nome, valorOriginal);
            }
            dttProdutosPromocao.Rows.Clear();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            double valorOriginal;

            if (cbbPorcentagem.Checked)
            {
                double p = double.Parse(tbPorcentagemDesconto.Text.Replace("%", ""));
                for (int i = 0; i < dttProdutosPromocao.Rows.Count; i++)
                {
                    valorOriginal = double.Parse(dttProdutosPromocao.Rows[i][3].ToString());

                    dttProdutosPromocao.Rows[i][3] = valorOriginal -((p / 100)*valorOriginal);
                }
            }
            else
            {
                double v = double.Parse(tbValorDesconto.Text.Replace("R$ ", ""));
                for (int i = 0; i < dttProdutosPromocao.Rows.Count; i++)
                {
                    valorOriginal = double.Parse(dttProdutosPromocao.Rows[i][3].ToString());
                    dttProdutosPromocao.Rows[i][3] = valorOriginal - v;
                }
            }
            
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if (dtpInicio.Value.Date > dtpFim.Value.Date)
            {
                isOk = false;
                MessageBox.Show("Data de inicial deve ser menor que data final");
            }

            if (dttProdutosPromocao.Rows.Count == 0)
            {
                isOk = false;
                MessageBox.Show("A promoção deve ter pelo menos 1 item");
            }
            if (tbNomePromo.Text.Length == 0)
            {
                isOk = false;
                MessageBox.Show("Informe o nome da promoção");
            }

            if (isOk)
            {
                controlPromocao.SalvarPromocao(dttProdutosPromocao, tbNomePromo.Text, dtpInicio.Value.Date, DateTime.Parse(dtpFim.Value.ToString("yyyy-MM-dd") + " 23:59:59"), idFunc);
                limparForm();
            }
        }
        private void limparForm()
        {
            tbNomePromo.Text = "";
            dttProdutosPromocao.Rows.Clear();
            dttProduto = atualizarDGV();
            limparProduto();
            dgv_produtos.DataSource = dttProduto;
        }
        private void abrirFormBuscarPromocao()
        {
            FormBuscarPromocao f = new FormBuscarPromocao();
            f.ShowDialog();

            limparForm();

        }

        private void FormRegistrarPromocao_Load(object sender, EventArgs e)
        {

        }
    }
}

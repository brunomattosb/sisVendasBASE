using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Functions;
using sisVendas.Models;

using sisVendas.Persistence;
using sisVendas.Screens.Product;
using sisVendas.Telas.Fornecedor;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Telas.Compra
{
    public partial class FormLancarCompra : Form
    {

        private Produto produtoSelecionado = null;
        private Models.Fornecedor fornecedorSelecionado = null;

        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlFornecedor controlProvider = new ctrlFornecedor();
        private ctrlCompra controlCompra = new ctrlCompra();

        private double totalCompra = 0;
        private double totalDesconto = 0;
        private double subtotalCompra = 0;
        private double totalPago = 0;
        private int idCaixa;
        private Models.Compra compraSelecionada = null;

        DataTable dttParcela = new DataTable();
        DataTable dttProduto = new DataTable();
        public FormLancarCompra()
        {
            InitializeComponent();
            initDataGridView();
            tbDesconto.Text = tbValorUn.Text = tbValorTotal.Text = 0.ToString("C");
        }
        public FormLancarCompra(int idCaixa) : this()
        {
            this.idCaixa = idCaixa;
        }
        public void initDataGridView()
        {
            dttProduto.TableName = "products";

            dttProduto.Columns.Add("prod_nome");
            dttProduto.Columns.Add("iten_idProduto");
            dttProduto.Columns.Add("iten_quantidade", typeof(double));
            dttProduto.Columns.Add("prod_un");
            dttProduto.Columns.Add("iten_valor", typeof(double));
            dttProduto.Columns.Add("total", typeof(double));


            //dttProduto.PrimaryKey = new DataColumn[] { dttProduto.Columns["name"] };
            dgvProducts.DataSource = dttProduto;
            dgvProducts.Columns["total"].DefaultCellStyle.Format = "C";
            dgvProducts.Columns["iten_valor"].DefaultCellStyle.Format = "C";

            dttParcela.TableName = "parcelas";
            dttParcela.Columns.Add("valor", typeof(double));
            dttParcela.Columns.Add("tipo_pagamento");
            dttParcela.Columns.Add("data");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    if(compraSelecionada == null)
                        formFornecedor();
                    break;
                case Keys.F2:
                    if (compraSelecionada == null)
                        formProduto();
                    break;
                case Keys.F4:
                    resetarForm();
                    break;
                case Keys.F5:
                    formBuscarCompra();
                    break;
                case Keys.F6:
                    cancelarCompra();
                    break;
                case Keys.F10:
                    formInserirParcelas();
                    break;
                case Keys.F12:
                    if (compraSelecionada == null) 
                        formFinalizarCompra();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void formProduto()
        {
            FormBuscarProduto f = new FormBuscarProduto();
            f.ShowDialog();

            produtoSelecionado = f.returnProduto();

            if (produtoSelecionado != null)
            {
                preencheProduto(produtoSelecionado);
            }
            else
            {
                resetarProduto();
            }
            tbAmount.Focus();
        }
        public void formFornecedor()
        {
            FormBuscarFornecedor f = new FormBuscarFornecedor();
            f.ShowDialog();

            Models.Fornecedor fornecedor = f.returnFornecedor();

            if (fornecedor != null)
            {
                fornecedorSelecionado = fornecedor;

                preencherFornecedor(fornecedorSelecionado);
            }
            tbCodProduct.Focus();
        }
        public void formInserirParcelas()
        {
            FormParcelasCompra f = new FormParcelasCompra(totalCompra-totalDesconto, dttParcela, compraSelecionada == null);
            f.ShowDialog();

            dttParcela = f.getDttParcelas();

            totalPago = 0;
            foreach (DataRow parcela in dttParcela.Rows)
            {
                totalPago += double.Parse(parcela["valor"] + "");
            }
            subtotalCompra = totalCompra - totalPago - totalDesconto;
            lblTotal.Text = totalCompra.ToString("C"); ;
            lblSubtotal.Text = subtotalCompra.ToString("C");
        }
        public void preencherFornecedor(Models.Fornecedor fornecedor)
        {
            alterarCpfCnpj(fornecedor.Cpf_cnpj.Count());

            mtbCpfFornecedor.Text = fornecedor.Cpf_cnpj;
            tbNomeFornecedor.Text = fornecedor.Nome;
            
            //lblWarningCpf.Visible = false;
        }
        public void alterarCpfCnpj(int qtde)
        {
            if (mtbCpfFornecedor.Mask != "000.000.000-00" && qtde <= 11)
            {
                mtbCpfFornecedor.Mask = "000.000.000-00";

                //mtbCpfClient.Select(qtde, 0);
                lblCpf.Text = "*CPF:";
            }
            else if (mtbCpfFornecedor.Mask != "00.000.000/0000-00" && qtde > 11)
            {
                int pos = mtbCpfFornecedor.Text.Count();
                mtbCpfFornecedor.Mask = "00.000.000/0000-00";
                //mtbCpfClient.Select(pos, 0);

                lblCpf.Text = "*CNPJ:";
            }

        }
        public void formFinalizarCompra()
        {
            bool isOk = true;

            string cpf = Function.replaceAll(mtbCpfFornecedor.Text);

            if (fornecedorSelecionado == null)
            {
                isOk = false;
                MessageBox.Show("Fornecedor não selecionado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //verificar se existe produtos
            if (dttProduto.Rows.Count == 0)
            {
                isOk = false;
                MessageBox.Show("Não existe produtos cadastrados!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //verificar se foi quitado
                

                if (totalPago != (totalCompra - totalDesconto))
                {
                    isOk = false;
                    MessageBox.Show("Lance as parcelas antes de finalizar a compra!", "Não foi quitado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if(tbChaveNF.Text.Length < 20)
            {
                isOk = false;
                MessageBox.Show("Confira a chave da NF!", "Chave incorreta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isOk)
            {
                if (compraSelecionada == null)
                {

                    isOk = controlCompra.SalvarCompra(dttParcela, dttProduto, fornecedorSelecionado.Id, totalDesconto, tbChaveNF.Text,dtpDtCompra.Value , idCaixa);
                    

                    if (isOk)
                    {
                        Alerta.notificacao("Sucesso!", "Compra finalizada!", Alerta.enmType.Success);

                        resetarForm();
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Não foi possivel gravar a compra!", Alerta.enmType.Error);
                    }
                }
                
            }
            else
            {
                Alerta.notificacao("Erro!", "Não foi possivel gravar a compra!", Alerta.enmType.Error);
            }

        }
        public void resetarForm()
        {
            gbNf.Enabled = true;
            dttParcela.Rows.Clear();
            dttProduto.Rows.Clear();
            totalCompra = 0;
            totalDesconto = 0;
            subtotalCompra = 0;
            totalPago = 0;

            mtbCpfFornecedor.Mask = "000.000.000-00";
            produtoSelecionado = null;
            fornecedorSelecionado = null;
            compraSelecionada = null;
            tbAmount.Text = "1";
            tbNomeFornecedor.Text = tbNameProduct.Text = tbCodProduct.Text = mtbCpfFornecedor.Text = tbChaveNF.Text = "";
            dtpDtCompra.Value = DateTime.Now;
            lblTotal.Text = lblSubtotal.Text = tbDesconto.Text = "R$ 0,00";

            gbProduto.Enabled = gbCliente.Enabled = true;

            btnPesquisarForn.Visible =
            btnPesquisarProd.Visible =
            btnFinalizar.Visible = true;

            mtbCpfFornecedor.Focus();
        }
        private void preencheProduto(Produto prod)
        {

            tbNameProduct.Text = prod.Nome;
            tbCodProduct.Text = prod.Id.ToString();
            tbValorUn.Text = prod.Valor.ToString("C");

            alterarValorTotalProduto();
        }
        public void alterarValorTotalProduto()
        {

            if (produtoSelecionado != null)
            {
                if (double.TryParse(tbAmount.Text.Replace("R$ ", ""), out double qtde))
                {
                    double.TryParse(tbValorUn.Text.Replace("R$ ", ""), out double valor);
                    tbValorTotal.Text = (qtde * valor).ToString("C");
                }
            }
        }
        private void resetarProduto()
        {
            produtoSelecionado = null;

            tbNameProduct.Text = "";
            tbAmount.Text = "1";
            tbValorTotal.Text = tbValorUn.Text = "";
            tbCodProduct.Text = tbNameProduct.Text = "";
            tbCodProduct.Focus();
        }

        private void mtbCpfClient_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfFornecedor.Text).Length == 0)
                mtbCpfFornecedor.Select(0, 0);
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            alterarValorTotalProduto();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //ENTER
            {
                adicionarProduto(tbAmount.Text, tbValorUn.Text.Replace("R$ ",""));
                dgvProducts.ClearSelection();
            }
            /*else if (e.KeyChar == (char)45) // [MENOS]
            {
                removerProduto();
                dgvProducts.ClearSelection();
            }*/
        }
        private void adicionarProduto(string amount, string value)
        {

            if (double.TryParse(amount, out double quanitdade))
            {
                if (double.TryParse(value, out double valor))
                {
                    if (produtoSelecionado != null)
                    {
                        adicionarProdutoDataTable(quanitdade, valor, produtoSelecionado);
                        resetarProduto();
                    }
                }
                else
                {
                    Alerta.notificacao("Atenção!", "Valor inválida!", Alerta.enmType.Warning);
                }
            }
            else
            {
                Alerta.notificacao("Atenção!", "Quantidade inválida!", Alerta.enmType.Warning);
            }
        }
        private void adicionarProdutoDataTable(double amount, double valor,Produto prod)
        {
            //string prod_name = prod.Nome;

            //DataRow row = dttProduto.Rows.Find(prod_name);

            //int index = dttProduto.Rows.IndexOf(row);

            //if (row == null) // se não tiver vai inserir
            //{
            DataRow linha = dttProduto.NewRow();
            //dttProduto.Columns.Add("name");

            linha["prod_nome"] = prod.Nome;
            linha["iten_quantidade"] = amount;
            linha["iten_valor"] = valor;
            linha["total"] = (valor * amount);
            linha["prod_un"] = prod.Un;
            linha["iten_idProduto"] = prod.Id;

            dttProduto.Rows.Add(linha);
            dgvProducts.DataSource = dttProduto;
            //}
            /*else //caso ja exista no dt
            {
                double vTotal = Convert.ToDouble(dttProduto.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));

                dttProduto.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) + Convert.ToDouble(amount);
                dttProduto.Rows[index]["valueTotal"] = vTotal.ToString("C");
            }*/



            //atualizar total

            totalCompra= totalCompra + (Convert.ToDouble(valor) * Convert.ToDouble(amount));

            subtotalCompra = totalCompra - totalPago - totalDesconto;

            lblTotal.Text = totalCompra.ToString("C"); ;
            lblSubtotal.Text = subtotalCompra.ToString("C");
            //posicionar ultima linha
            dgvProducts.FirstDisplayedScrollingRowIndex = dgvProducts.RowCount - 1;
        }

        /*
        private void removerProduto()
        {
            if (produtoSelecionado != null && Convert.ToDouble(tbAmount.Text) != 0)
            {
                removerProdutoDataTable(produtoSelecionado);
                resetarProduto();
            }
        }
        private void removerProdutoDataTable(Produto prod)
        {
            DataRow row = dttProduto.Rows.Find(prod.Nome);
            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                Alerta.notificacao("Atenção!", "Não é possivel remover um produto que não está na compra!", Alerta.enmType.Warning);
            }
            else //caso ja exista no dt
            {

                if (Convert.ToDouble(tbAmount.Text) <= Convert.ToDouble(row["amount"]))
                {
                    double vTotal = Convert.ToDouble(dttProduto.Rows[index]["amount"]) * Convert.ToDouble(row["valueun"].ToString().Replace("R$", ""));
                    dttProduto.Rows[index]["amount"] = Convert.ToDouble(row["amount"]) - Convert.ToDouble(tbAmount.Text);
                    dttProduto.Rows[index]["valueTotal"] = vTotal.ToString("C");

                    //alterar totais
                    totalCompra = totalCompra - (Convert.ToDouble(produtoSelecionado.Valor) * Convert.ToDouble(tbAmount.Text));
                    subtotalCompra = totalCompra - totalPago - totalDesconto;
                    lblSubtotal.Text = "R$ " + (totalCompra - totalDesconto - totalPago);
                    lblTotal.Text = totalCompra.ToString("C");

                    //caso quantidade seja zero
                    if (Convert.ToDouble(dttProduto.Rows[index]["amount"]) == 0)
                    {
                        dttProduto.Rows[index].Delete();
                    }
                }
                else
                    Alerta.notificacao("Atenção!", "Não é possivel deixar a quantidade negativa!", Alerta.enmType.Warning);
            }


        }*/

        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            if (tbCodProduct.Text.Count() > 0)
            {
                string[] divisao = tbCodProduct.Text.Split('*');
                string strIdProd, quantidade;

                try
                {
                    quantidade = divisao[0];
                    strIdProd = divisao[1];
                }
                catch (Exception)
                {
                    quantidade = "1";
                    strIdProd = divisao[0];
                }
                tbAmount.Text = quantidade;

                Produto prod = buscarProduto(strIdProd);

                if (prod != null)
                {
                    produtoSelecionado = prod;
                    preencheProduto(prod);
                }
                else
                {
                    Alerta.notificacao("Atenção!", "Código de produto inexistente ou não informado!", Alerta.enmType.Warning);

                    resetarProduto();

                    tbCodProduct.Focus();
                    produtoSelecionado = null;
                }
            }
            else
            {
                tbNameProduct.Text = "";
                produtoSelecionado = null;
            }
        }
        private Produto buscarProduto(string cod)
        {

            if (cod.Count() != 0)
            {
                Produto prod = controlProduct.buscarProdutoPorCod(cod);

                return prod;

            }
            return null;

        }

        private void tbValorUn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13) //ENTER
            {
                adicionarProduto(tbAmount.Text, tbValorUn.Text.Replace("R$ ", ""));
                dgvProducts.ClearSelection();
            }
            /*else if (e.KeyChar == (char)45) // [MENOS]
            {
                removerProduto();
                dgvProducts.ClearSelection();
            }*/
        }

        private void tbValorUn_Leave(object sender, EventArgs e)
        {
            string text = tbValorUn.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
            {
                tbValorUn.Text = String.Format("{0:c}", res);
                alterarValorTotalProduto();
            }
            else
            {
                tbValorUn.Text = "R$ 0,00";
                //Alerta.notificacao("Erro!", "Valor incorreto", Alerta.enmType.Error);
            }
        }

        private void tbDesconto_Leave(object sender, EventArgs e)
        {
            
            string text = tbDesconto.Text.Replace("R$ ", "");
            
            if (double.TryParse(text, out double res))
            {
                tbDesconto.Text = String.Format("{0:c}", res);

                totalDesconto = res;

                subtotalCompra = totalCompra - totalPago - totalDesconto;

                lblTotal.Text = totalCompra.ToString("C"); ;
                lblSubtotal.Text = subtotalCompra.ToString("C");
            }
            else
            {
                tbDesconto.Text = "R$ 0,00";
            }
            totalDesconto = res;
        }

        private void mtbCpfFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Back)
            {
                if (mtbCpfFornecedor.Mask == "00.000.000/0000-00")
                {
                    mtbCpfFornecedor.Text = "";

                    alterarCpfCnpj(11);
                    resetaFornecedor();

                }
                else if (fornecedorSelecionado != null)
                {
                    resetaFornecedor();
                }
            }*/
        }
        public void resetaFornecedor()
        {
            tbNomeFornecedor.Text = "";
            fornecedorSelecionado = null;

        }
        private void mtbCpfFornecedor_Leave(object sender, EventArgs e)
        {
            string cpf = mtbCpfFornecedor.Text;

 
            if (verificarSeFornecedorExiste(cpf))
            {
                preencherFornecedor(fornecedorSelecionado);
                tbCodProduct.Focus();
            }

        }
        private bool verificarSeFornecedorExiste(string cpf)
        {

            cpf = Function.replaceAll(cpf);
            int countCpf = cpf.Count();
            
            if (countCpf == 11 || countCpf == 14)
            {

                fornecedorSelecionado = controlProvider.buscarForneceodrPorCpfCnpj(cpf);
                if (fornecedorSelecionado != null)
                {
                        
                    //lblWarningCpf.Visible = false;
                    return true;
                }
                //lblWarningCpf.Text = "** CPF não encontrado! será inserido um novo cliente com o CFP e o NOME informado! **";

                
                //else
                //{
                    //lblWarningCpf.Text = "** CPF incorreto **";
                //}

            }
            else if (countCpf == 0)
            {
                //lblWarningCpf.Visible = false;
                return false;
            }
            else
            {
                //lblWarningCpf.Text = "** CPF incorreto **";
            }

            tbNomeFornecedor.Text = "";
            fornecedorSelecionado = null;
            //lblWarningCpf.Visible = true;
            return false;


        }
        public void formBuscarCompra()
        {

            FormBuscarCompra f = new FormBuscarCompra();
            f.ShowDialog();

            int idCompra = f.retornaCompra();
            resetarForm();

            if (idCompra != 0)
            {

                compraSelecionada = controlCompra.buscarCompra(idCompra);
                totalDesconto = compraSelecionada.Desconto;

                dttParcela.Rows.Clear();
                foreach (DataRow prod in compraSelecionada.DttParcelas.Rows)
                {
                    DataRow parcela = dttParcela.NewRow();

                    parcela["tipo_pagamento"] = prod["tipo_pagamento"].ToString();
                    parcela["valor"] = double.Parse(prod["valor"].ToString().Replace("R$ ",""));
                    parcela["data"] = prod["dataVencimento"].ToString();


                    dttParcela.Rows.Add(parcela);
                }

                foreach (DataRow prod in compraSelecionada.DttItens.Rows)
                {
                    produtoSelecionado = buscarProduto(prod["iten_idProduto"].ToString());
                    adicionarProduto(prod["iten_quantidade"].ToString(), prod["iten_valor"].ToString());
                }

                fornecedorSelecionado = controlProvider.buscarForneceodrPorCod(compraSelecionada.Id_fornecedor);
                tbNomeFornecedor.Text = fornecedorSelecionado.Nome;
                mtbCpfFornecedor.Text = fornecedorSelecionado.Cpf_cnpj;
                tbDesconto.Text = compraSelecionada.Desconto.ToString("C");
                tbChaveNF.Text = compraSelecionada.Chave;
                dtpDtCompra.Text = compraSelecionada.Data.Date.ToString();


                if (compraSelecionada.Cancelada) // se venda cancelada
                {
                    //lblCancelada.Visible = true;
                    btnCancelarCompra.Text = "F6 - Restaurar Compra";
                }
                else
                {
                    //lblCancelada.Visible = false;
                    btnCancelarCompra.Text = "F6 - Cancela Compra";

                    
                }
                btnPesquisarForn.Visible =
                btnPesquisarProd.Visible =
                btnFinalizar.Visible = false;

                gbNf.Enabled = false;
            }
        }
        private void cancelarCompra()
        {
            //MessageBox.Show("IDCAIXA " + idCaixa);
            if (compraSelecionada != null)
            {
                //inserir idCaixa na compra e comparar com o caixa atual
                if (compraSelecionada.Id_caixa == idCaixa)
                {
                    if (compraSelecionada.Cancelada) // venda cancelada
                    {
                        if (MessageBox.Show("Deseja restaurar a compra selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            controlCompra.restabelecerCompra(compraSelecionada.Id, dttProduto);
                            resetarForm();
                            Alerta.notificacao("Sucesso!", "compra restaurada!", Alerta.enmType.Success);
                        }
                    }
                    else 
                    {
                        if (MessageBox.Show("Deseja excluir a compra selecionada ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            controlCompra.removerCompra(compraSelecionada.Id, dttProduto);
                            resetarForm();
                            Alerta.notificacao("Sucesso!", "compra removida!", Alerta.enmType.Success);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Para que a compra possa ser excluida, ela deve pertencer ao caixa atual!", "Compra não pertence ao caixa atual!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                MessageBox.Show("Selecione a compra para continuar!", "Compra não selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbValorUn_Click(object sender, EventArgs e)
        {
            if(tbValorUn.Text == "R$ 0,00")
            {
                tbValorUn.Text = "";
            }
        }

        private void tbValorTotal_Click(object sender, EventArgs e)
        {
            if (tbValorTotal.Text == "R$ 0,00")
            {
                tbValorTotal.Text = "";
            }
        }

        private void tbDesconto_Click(object sender, EventArgs e)
        {
            if (tbDesconto.Text == "R$ 0,00")
            {
                tbDesconto.Text = "";
            }
        }

        private void mtbCpfFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                int count = Function.replaceAll(mtbCpfFornecedor.Text).Count();
                changeCpfCnpj(count);
            }
        }

        private void mtbCpfFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfFornecedor.Text).Count() == 10)
            {
                changeCpfCnpj(Function.replaceAll(mtbCpfFornecedor.Text).Count());
            }
        }
        public void changeCpfCnpj(int qtde)
        {
            if (mtbCpfFornecedor.Mask != "000.000.000-00" && qtde < 11)
            {
                mtbCpfFornecedor.Mask = "000.000.000-00";

                mtbCpfFornecedor.Select(qtde, 0);
                lblCpf.Text = "*CPF:";

            }
            else if (qtde >= 11)
            {
                int pos = mtbCpfFornecedor.Text.Count();
                mtbCpfFornecedor.Mask = "00.000.000/0000-00";
                mtbCpfFornecedor.Select(pos, 0);

                lblCpf.Text = "*CNPJ:";
            }

        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {

            if (compraSelecionada == null && dgvProducts.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Deseja excluir o item selecionado?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //achar a POS
                    int pos = dgvProducts.CurrentRow.Index;
                    
                    //atualizar totais
                    totalCompra = totalCompra - double.Parse(Function.replaceAll(dgvProducts[5, pos].Value.ToString()));
                    subtotalCompra = totalCompra - totalPago - totalDesconto;
                    lblTotal.Text = totalCompra.ToString("C"); ;
                    lblSubtotal.Text = subtotalCompra.ToString("C");

                    //Remover
                    dgvProducts.Rows.RemoveAt(pos);
                    

                }

            }
        }
    }
}

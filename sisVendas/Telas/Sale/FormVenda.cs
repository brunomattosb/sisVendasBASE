using DFe.Classes.Flags;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Servicos.Retorno;
using NFe.Utils.Excecoes;
using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using sisVendas.Screens.Client;
using sisVendas.Screens.Product;
using sisVendas.Telas.Sale;
using sisVendas.Telas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sisVendas.Screens.Sale
{
    public partial class FormVenda : Form
    {
        private Cliente clienteSelecionado = null;
        private Produto produtoSelecionado = null;
        private Vendas vendaSelecionada = null;

        private int id_caixa;
        private int id_funcionario;

        DataTable dttParcela = new DataTable();
        DataTable dttProduto = new DataTable();

        ConfiguracaoApp _config = new ConfiguracaoApp();

        private ctrlCliente controlCliente = new ctrlCliente();
        private ctrlNFCe controlNFCe = new ctrlNFCe();
        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlVenda controlVenda = new ctrlVenda();
        private ctrlItensVenda controlItensVenda = new ctrlItensVenda();

        private double totalVenda = 0;
        private double totalDesconto = 0;
        private double subtotalVenda = 0;
        private double totalPago = 0;
        private double troco = 10;
        private double txEntrega = 0;


        private List<Produto> lProduto = new List<Produto>();
        private char xmlString;

        public FormVenda()
        {
            InitializeComponent();
            _config.CfgServico.DiretorioSchemas = @"C:\Users\Bruno\Documents\sisVendas\Schemas.Nfe";
            iniciarDGV();
        }
        public FormVenda(int idCaixa, int idFunc) : this()
        {
            this.id_caixa = idCaixa;
            this.id_funcionario = idFunc;
        }
        public void iniciarDGV()
        {
            dttProduto.TableName = "produtos";
            dttProduto.Columns.Add("nome");
            dttProduto.Columns.Add("codigo");
            dttProduto.Columns.Add("quantidade", typeof(double));
            dttProduto.Columns.Add("un");
            dttProduto.Columns.Add("valor_un");
            dttProduto.Columns.Add("valor_total");
            dttProduto.Columns.Add("ncm");
            dttProduto.Columns.Add("cod_barras");
            dttProduto.Columns.Add("cfop_fora");
            dttProduto.Columns.Add("cfop_dentro");

            dttProduto.PrimaryKey = new DataColumn[] { dttProduto.Columns["codigo"] };
            dgvProducts.DataSource = dttProduto;

            dttParcela.TableName = "parcelas";
            dttParcela.Columns.Add("valor", typeof(double));
            dttParcela.Columns.Add("tipo_pagamento");
            dttParcela.Columns.Add("data", typeof(DateTime));
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.F1:
                    if (vendaSelecionada == null)
                        formCliente();
                    break;
                case Keys.F2:
                    if (vendaSelecionada == null)
                        formProduto();
                    break;
                case Keys.F4:
                    resetarForm();
                    break;

                case Keys.F5:
                    formBuscarVenda();
                    break;
                case Keys.F6:
                    CancelarVenda();
                    break;

                case Keys.F9:
                    formCompensarParcela();
                    break;
                case Keys.F11:
                    if (vendaSelecionada == null)
                        formDesconto();
                    break;
                case Keys.F12:
                    if (vendaSelecionada == null)
                        finalizarVenda();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void formCliente()
        {
            FormBuscarCliente f = new FormBuscarCliente();
            f.ShowDialog();

            Cliente cli = f.returnClient();

            if (cli != null)
            {
                clienteSelecionado = cli;

                preencherCliente(clienteSelecionado);
            }
            mtbCpfClient.Focus();
        }
        public void preencherCliente(Cliente cli)
        {

            alterarCpfCnpj(cli.Cpf_cnpj.Count());

            tbNameClient.Text = cli.Nome;
            mtbCpfClient.Text = cli.Cpf_cnpj;
            tbNameClient.Enabled = false;
            lblWarningCpf.Visible = false;
        }
        public void alterarCpfCnpj(int qtde)
        {
            if (mtbCpfClient.Mask != "000.000.000-00" && qtde <= 11)
            {
                mtbCpfClient.Mask = "000.000.000-00";

                lblCpf.Text = "CPF:";
            }
            else if (mtbCpfClient.Mask != "00.000.000/0000-00" && qtde > 11)
            {
                int pos = mtbCpfClient.Text.Count();
                mtbCpfClient.Mask = "00.000.000/0000-00";

                lblCpf.Text = "CNPJ:";
            }
        }
        private void mtbCpfClient_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(mtbCpfClient.Text).Length == 0)
                mtbCpfClient.Select(0, 0);
        }
        private void mtbCpfClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (mtbCpfClient.Mask == "00.000.000/0000-00")
                {
                    mtbCpfClient.Text = "";

                    alterarCpfCnpj(11);
                    resetaCliente();

                }
                else if (clienteSelecionado != null)
                {
                    resetaCliente();
                }
            }
        }
        private void mtbCpfClient_Leave(object sender, EventArgs e)
        {
            string cpf = mtbCpfClient.Text;


            if (verificarSeClienteExiste(cpf))
            {
                tbNameClient.Enabled = false;
                tbCodProduct.Focus();
            }
        }
        private bool verificarSeClienteExiste(string cpf)
        {

            cpf = Function.replaceAll(cpf);

            if (cpf.Count() == 11)
            {
                if ((Function.isCpfValid(mtbCpfClient.Text)))
                {
                    clienteSelecionado = controlCliente.buscarClientePorCpf(cpf);

                    if (clienteSelecionado != null)
                    {
                        preencherCliente(clienteSelecionado);
                        lblWarningCpf.Visible = false;
                        return true;
                    }
                    lblWarningCpf.Text = "** CPF não encontrado! será inserido um novo cliente com o CFP e o NOME informado! **";

                }
                else
                {
                    lblWarningCpf.Text = "** CPF incorreto **";
                }
            }
            else if (cpf.Count() > 11)
            {
                return true;
            }
            else if (cpf.Count() == 0)
            {
                lblWarningCpf.Visible = false;
                return false;
            }
            else
            {
                lblWarningCpf.Text = "** CPF incorreto **";
            }

            tbNameClient.Text = "";
            clienteSelecionado = null;
            lblWarningCpf.Visible = true;
            return false;
        }
        public void resetaCliente()
        {

            tbNameClient.Enabled = true;
            tbNameClient.Text = "";
            clienteSelecionado = null;

        }
        public void resetarForm()
        {
            dttParcela.Rows.Clear();
            dttProduto.Rows.Clear();

            totalVenda = 0;
            totalDesconto = 0;
            subtotalVenda = 0;
            totalPago = 0;

            mtbCpfClient.Mask = "000.000.000-00";

            produtoSelecionado = null;
            clienteSelecionado = null;
            vendaSelecionada = null;

            tbAmount.Text = "1";

            tbNameClient.Text =
            tbNameProduct.Text =
            tbCodProduct.Text =
            mtbCpfClient.Text = "";

            lblDesconto.Visible =
            lblCancelada.Visible =
            lblTextDesconto.Visible = false;
            lblTotal.Text = lblSubtotal.Text = "R$ 0,00";

            gbProduto.Enabled =
            gbCliente.Enabled = true;

            mtbCpfClient.Focus();

            btnPesquisarCliente.Visible =
            btnPesquisarProduto.Visible =
            btnFinalizarVenda.Visible =
            btnDesconto.Visible = true;
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
                    tbValorTotal.Text = (qtde * produtoSelecionado.Valor).ToString("C");
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
            eventoKeyPressParaAdicionarOuRemoverProduto(e);
        }
        private void eventoKeyPressParaAdicionarOuRemoverProduto(KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) // ENTER
            {
                adicionarProduto(tbAmount.Text);
                dgvProducts.ClearSelection();
                tbCodProduct.Focus();
            }
            else if (e.KeyChar == (char)45) // [MENOS]
            {
                e.Handled = true;
                removerProduto(tbAmount.Text);
                dgvProducts.ClearSelection();
                tbCodProduct.Focus();
                
            }
            

        }
        private void removerProduto(string strQtde)
        {
            string codigoProd = verificarStringCodigo(tbCodProduct.Text, strQtde);

            if (double.TryParse(tbAmount.Text, out double qtde))
            {
                removerProdutoDataTable(qtde, codigoProd);
                resetarProduto();

            }
            else
            {
                Alerta.notificacao("Atenção!", "Quantidade inválida!", Alerta.enmType.Warning);
            }
        }
        private void removerProdutoDataTable(double qtde, string codProd)
        {
            DataRow row = dttProduto.Rows.Find(codProd);
            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                Alerta.notificacao("Erro!", "Não é possivel remover um produto que não está na compra!", Alerta.enmType.Warning);
            }
            else //caso exista no dt
            {
                double qtdeInserido = Convert.ToDouble(row["quantidade"]);
                double valorProduto = Convert.ToDouble(row["valor_un"].ToString().Replace("R$ ", ""));
                if (qtde <= qtdeInserido)
                {

                    dttProduto.Rows[index]["quantidade"] = qtdeInserido - qtde;
                    dttProduto.Rows[index]["valor_total"] = ((qtdeInserido - qtde) * valorProduto).ToString("C");

                    //alterar totais
                    totalVenda = totalVenda - valorProduto * qtde;
                    subtotalVenda = totalVenda - totalPago - totalDesconto;
                    lblSubtotal.Text = (totalVenda - totalDesconto - totalPago).ToString("C");
                    lblTotal.Text = totalVenda.ToString("C");

                    //caso quantidade seja zero
                    if (qtde == qtdeInserido)
                    {
                        dttProduto.Rows[index].Delete();
                    }

                }
                else
                    Alerta.notificacao("Erro!", "Não é possivel deixar a quantidade negativa!", Alerta.enmType.Warning);
            }
        }
        private void adicionarProduto(string strQtde)
        {
            //0 - cod;
            //1 - qtde
            string codigoProd = verificarStringCodigo(tbCodProduct.Text, strQtde);
            if(produtoSelecionado == null)
                verificarSeProdutoExiste(codigoProd);

            if (double.TryParse(tbAmount.Text, out double qtde) && qtde > 0)
            {

                //MessageBox.Show(qtde + "Quanditdade");
                //MessageBox.Show(codigoProd + "Codigo");

                if (produtoSelecionado != null)
                {
                    adicionarProdutoDataTable(qtde, produtoSelecionado);
                    resetarProduto();
                }
            }
            else
            {
                Alerta.notificacao("Atenção!", "Quantidade inválida!", Alerta.enmType.Warning);
            }
        }
        private void adicionarProdutoDataTable(double quantidade, Produto prod)
        {
            DataRow row = dttProduto.Rows.Find(prod.Id);
            int index = dttProduto.Rows.IndexOf(row);

            if (row == null) // se não tiver vai inserir
            {
                quantidade = Math.Round(quantidade, 3);
                DataRow linha = dttProduto.NewRow();

                linha["nome"] = prod.Nome;
                linha["quantidade"] = quantidade;
                linha["valor_un"] = prod.Valor.ToString("C");
                linha["valor_total"] = (prod.Valor * quantidade).ToString("C");
                linha["un"] = prod.Un;
                linha["codigo"] = prod.Id;
                linha["ncm"] = prod.Ncm;
                linha["cod_barras"] = prod.Codigo_barras;
                linha["cfop_dentro"] = prod.Cfop_venda_dentro_estado;
                linha["cfop_fora"] = prod.Cfop_venda_fora_estado;

                dttProduto.Rows.Add(linha);
                //dgvProducts.DataSource = dttProduto;
            }
            else //caso ja exista no dt
            {
                double vTotal = (Convert.ToDouble(dttProduto.Rows[index]["quantidade"]) + quantidade) * Convert.ToDouble(row["valor_un"].ToString().Replace("R$", ""));

                dttProduto.Rows[index]["quantidade"] = Convert.ToDouble(row["quantidade"]) + Convert.ToDouble(quantidade);
                dttProduto.Rows[index]["valor_total"] = vTotal.ToString("C");
            }


            //atualizar total
            totalVenda = totalVenda + (Convert.ToDouble(prod.Valor) * Convert.ToDouble(quantidade));

            subtotalVenda = totalVenda - totalPago - totalDesconto;

            lblTotal.Text = totalVenda.ToString("C"); ;
            lblSubtotal.Text = subtotalVenda.ToString("C");

            //posicionar ultima linha
            dgvProducts.FirstDisplayedScrollingRowIndex = dgvProducts.RowCount - 1;

            tbCodProduct.Focus();
        }
        private void tbCodProduct_Leave(object sender, EventArgs e)
        {
            string codigoProd = verificarStringCodigo(tbCodProduct.Text, tbAmount.Text);
            verificarSeProdutoExiste(codigoProd);
        }
        private void verificarSeProdutoExiste(string cod)
        {
            Produto prod = null;

            if (cod != "0")
            {
                prod = controlProduct.buscarProdutoPorCodigo(cod);

                if (prod != null)
                {
                    produtoSelecionado = prod;
                    preencheProduto(prod);
                }
                else
                {
                    resetarProduto();
                    produtoSelecionado = null;

                }
            }
        }
        private string verificarStringCodigo(string strCodigoProduto, string strQtde)
        {
            string tbCodigoProdutoString = tbCodProduct.Text;
            string CodProd = "0";
            string Qtde;

            if (tbCodigoProdutoString.Count() > 0)
            {
                string[] divisao = tbCodigoProdutoString.Split('*');

                try
                {
                    Qtde = divisao[0];
                    CodProd = divisao[1];
                }
                catch (Exception)
                {
                    Qtde = strQtde;
                    CodProd = divisao[0];
                }
                tbAmount.Text = Qtde;
            }
            else
            {
                resetarProduto();
                produtoSelecionado = null;
            }
            return CodProd;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(clienteSelecionado == null)
                MessageBox.Show("Cliente é NULL!");
            else
                MessageBox.Show("Cliente NÃO é NULL!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado == null)
                MessageBox.Show("Produto é NULL!");
            else
                MessageBox.Show("Produto NÃO é NULL!");
        }
        private void tbCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventoKeyPressParaAdicionarOuRemoverProduto(e);
        }
        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                resetarProduto();
                tbCodProduct.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[1].Value.ToString();
                tbAmount.Text = dgvProducts.Rows[dgvProducts.CurrentRow.Index].Cells[2].Value.ToString();
                tbCodProduct.Focus();
            }
        }
        public void finalizarVenda()
        {
            bool isOk = true;
            bool isFiado = false;
            int idVenda = 0;

            //tirar o foco do mtbCPF para realizar a busca do cliente caso esteja focado
            tbAmount.Focus();

            string cpf = Function.replaceAll(mtbCpfClient.Text);

            if (clienteSelecionado == null)
            {
                //verificar se tem fiano
                foreach (DataRow parcela in dttParcela.Rows)
                {
                    if (parcela["tipo_pagamento"].ToString() == "Fiado")
                    {
                        isFiado = true;
                    }
                }
                
                if (isFiado)
                {
                    isOk = false;
                    MessageBox.Show("Existem parcelas \"FIADO\", para continuar a venda informe o CPF do cliente.");
                }
                else
                {
                    if (Function.isCpfValid(cpf))
                    {
                        if (MessageBox.Show("Cliente não cadastrado na base de dados, deseja inserir ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (tbNameClient.Text.Count() > 0)
                            {
                                if (controlCliente.SalvarClieteEmBranco("0", tbNameClient.Text, cpf))
                                {

                                    if (verificarSeClienteExiste(cpf))
                                    {
                                        MessageBox.Show("Cliente salvo OK");
                                    }
                                    else
                                    {
                                        isOk = false;
                                        MessageBox.Show("Erro ao salvar CLiente.");
                                    }
                                }
                                else
                                {
                                    isOk = false;
                                    MessageBox.Show("Erro ao salvar Cliente");

                                }
                            }
                            else
                            {
                                isOk = false;
                                MessageBox.Show("Preencha o nome do cliente para salvar");
                            }

                        }
                    }
                    else
                    {
                        if (cpf.Count() > 0)
                        {
                            MessageBox.Show("CPF do cliente não é valido");
                            isOk = false;
                        }
                    }
                }

            }

            //verificar se existe produtos
            if (dttProduto.Rows.Count == 0)
            {
                isOk = false;
                MessageBox.Show("Não existe produtos cadastrados!");
            }
            else
            {
                //verificar se foi quitado
                if (subtotalVenda != 0)
                {
                    isOk = false;
                    MessageBox.Show("Não foi quitado!");
                }
            }

            
            if (isOk)
            {
                RetornoNFeAutorizacao retorno = null;
                //emitir a NFCe
                try
                {
                    EmitirNFCe emitirNFe = new EmitirNFCe();
                    //definir que vai ser gerado uma NFCe
                    _config.CfgServico.ModeloDocumento = ModeloDocumento.NFCe;
                    //Tipo de emisso, mudar para contingecia
                    _config.CfgServico.tpEmis = TipoEmissao.teNormal;
                    int lote = 1;
                    int numero = 0;

                    FormMessageBox formNumero = new FormMessageBox("Digite o numero da NFCe", (int.Parse(controlNFCe.buscarNumeroUltimaNFCe()) + 1).ToString());
                    formNumero.ShowDialog();
                        
                    int.TryParse(formNumero.retornaMsg(), out numero);



                    FormMessageBox formLote = new FormMessageBox("Digite o numero do lote", "1");
                    formLote.ShowDialog();

                    int.TryParse(formLote.retornaMsg(), out lote);


                    if (lote != -1 && numero != -1)
                    {
                        if (MessageBox.Show("Deseja finalizar a venda e emitir a NFCe?", "Finalizar venda?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //gerar a NFCe
                            retorno = emitirNFe.gerarNFCe(clienteSelecionado, dttParcela, dttProduto, numero, lote, totalDesconto, txEntrega, troco);

                            if (retorno.Retorno.protNFe != null)
                            {

                                switch (retorno.Retorno.protNFe.infProt.cStat)
                                {
                                    //AUTORIZADA
                                    
                                        

                                    case 100:
                                        Alerta.notificacao("Sucesso!", string.Format("Venda salva!\nStatus: {0} - NFCe: {1}", retorno.Retorno.protNFe.infProt.cStat, retorno.Retorno.protNFe.infProt.xMotivo), Alerta.enmType.Success);
                                        

                                        controlNFCe.SalvarNFCe(retorno.Retorno.protNFe.infProt.chNFe, retorno.Retorno.protNFe.infProt.cStat.ToString()
                                                   , retorno.Retorno.protNFe.infProt.nProt, "", retorno.Retorno.protNFe.infProt.xMotivo,
                                                   numero, lote, retorno.XmlProc, retorno.Dir_xml);

                                        idVenda = controlVenda.SalvarVenda(clienteSelecionado == null ? 0 : clienteSelecionado.Id,
                                                   dttParcela, dttProduto, totalDesconto, id_caixa, id_funcionario, numero);

                                        
                                        resetarForm();

                                        break;
                                    // CASO DENEGADO
                                    case 110:
                                    case 150:
                                    case 205:
                                    case 301:
                                    case 303:
                                        Alerta.notificacao("Venda DENEGADA!", string.Format("Venda denegada!\nStatus: {0} - NFCe: {1}", retorno.Retorno.protNFe.infProt.cStat, retorno.Retorno.protNFe.infProt.xMotivo), Alerta.enmType.Error);

                                        controlNFCe.SalvarNFCe(retorno.Retorno.protNFe.infProt.chNFe, retorno.Retorno.protNFe.infProt.cStat.ToString()
                                                   , retorno.Retorno.protNFe.infProt.nProt, "", retorno.Retorno.protNFe.infProt.xMotivo,
                                                   numero, lote, retorno.XmlProc, retorno.Dir_xml);

                                        break;
                                    case 204:
                                        Clipboard.SetText(retorno.Retorno.protNFe.infProt.nProt.ToString());
                                        MessageBox.Show(string.Format("Ocorreu o seguinte erro na tentativa de autorização nda NFC-e\nStatus: {0} - NFCe: {1}\n\nPara gerar a NFC-e.\nO numero do protocolo foi adicionado no seu Ctrl+C", retorno.Retorno.protNFe.infProt.cStat, retorno.Retorno.protNFe.infProt.xMotivo), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    default:
                                        //NFe REJEITADA
                                        MessageBox.Show(string.Format("Ocorreu o seguinte erro na tentativa de autorização nda NFC-e\nStatus: {0} - NFCe: {1}\n\nPara gerar a NFC-e.", retorno.Retorno.protNFe.infProt.cStat, retorno.Retorno.protNFe.infProt.xMotivo), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numero ou Lote da NFCe invalido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ComunicacaoException ex)
                {
                    //Faça o tratamento de contingência OffLine aqui.
                    Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error); MessageBox.Show(ex.Message);
                }
                catch (ValidacaoSchemaException ex)
                {
                    Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error); MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(ex.Message))
                        Alerta.notificacao("Erro!", ex.Message + "\n" + ex.StackTrace + "\n" + ex.Source, Alerta.enmType.Error);
                }

                
            }
            else
            {
                Alerta.notificacao("Erro!", "Não foi possivel gravar a venda!", Alerta.enmType.Error);
            }
        }
        

        /*
        private string SalvarArquivoXmlLotEnv(string nomeArquivo, string xmlString)
        {
            if (!_cFgServico.SalvarXmlServicos) return null;
            var dir = string.IsNullOrEmpty(_cFgServico.DiretorioSalvarXml) ? _path : _cFgServico.DiretorioSalvarXml;
            var filename = Path.Combine(dir, nomeArquivo);
            var stw = new StreamWriter(filename);
            stw.WriteLine(xmlString);
            stw.Close();
            return filename;
        }*/
        public void inserirDesconto(double desconto)
        {

            totalDesconto = desconto;
            if (desconto != 0)
            {
                lblDesconto.Visible = lblTextDesconto.Visible = true;
                lblDesconto.Text = desconto.ToString("C"); ;
            }
            else
            {
                lblDesconto.Visible = lblTextDesconto.Visible = false;
            }

            subtotalVenda = totalVenda - totalPago - desconto;
            lblSubtotal.Text = (totalVenda - desconto - totalPago).ToString("C");
        }
        public void formDesconto()
        {
            FormDesconto f = new FormDesconto(totalVenda);
            f.ShowDialog();

            inserirDesconto(f.getDesconto());
        }
        public void formCompensarParcela()
        {
            double saldo = 0;
            if (clienteSelecionado != null)
                saldo = clienteSelecionado.Saldo;

            FormInserirParcelas f = new FormInserirParcelas(totalVenda - totalDesconto, dttParcela, vendaSelecionada == null, saldo);
            f.ShowDialog();

            this.dttParcela = f.getLparcela();

            calcularParcelas(dttParcela);
        }
        private void calcularParcelas(DataTable dtParcelas)
        {

            totalPago = 0;
            foreach (DataRow parcela in dtParcelas.Rows)
            {
                totalPago += double.Parse(parcela["valor"] + "");
            }

            subtotalVenda = totalVenda - totalPago - totalDesconto;
            lblSubtotal.Text = subtotalVenda.ToString("C");
        }
        private void CancelarVenda()
        {
            //if (vendaSelecionada != null)
            //{
            //    int vendaSelecionadaIdCaixa = controlVenda.verificarMesmoCaixa(vendaSelecionada.Id);
            //    if (vendaSelecionadaIdCaixa == idCaixa)
            //    {
            //        if (MessageBox.Show("Deseja excluir a compra selecionada ?\n\nAo confirmar a exclusão, não será possivel restaurar a compra!", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        {
            //            if (controlVenda.exclusaoFisicaDaVeda(vendaSelecionada.Id, dttProduto))
            //            {
            //                resetarForm();
            //            }
            //        }
            //        // exclusao TOTAL da venda
            //        // remover do banco de dados
            //    }
            //    else
            //    {
            //        //MessageBox.Show("A venda não foi realizada no caixa atual!", "Não é possivel excluir a venda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //FormExcluirVendaSaldoDoPagamento f = new FormExcluirVendaSaldoDoPagamento();
            //        //f.ShowDialog();
            //    }

            //}
            //else
            //{

            //    MessageBox.Show("Selecione uma venda para continuar!", "Venda não selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
        public void formBuscarVenda()
        {

            FormBuscarVenda f = new FormBuscarVenda();
            f.ShowDialog();

            int idVenda = f.retornaVenda();

            if (idVenda != 0)
            {
                resetarForm();
                btnPesquisarCliente.Visible =
                btnPesquisarProduto.Visible =
                btnFinalizarVenda.Visible =
                btnDesconto.Visible = false;

                vendaSelecionada = controlVenda.buscarVendaPorCod(idVenda);

                if (vendaSelecionada.ItensVenda.Rows.Count > 0)
                {
                    produtoSelecionado = new Produto();
                    for (int i = 0; i < vendaSelecionada.ItensVenda.Rows.Count; i++)
                    {
                        produtoSelecionado.Valor = Convert.ToDouble(vendaSelecionada.ItensVenda.Rows[i]["iten_valor"]);
                        produtoSelecionado.Nome = vendaSelecionada.ItensVenda.Rows[i]["prod_nome"].ToString();
                        produtoSelecionado.Un = vendaSelecionada.ItensVenda.Rows[i]["prod_un"].ToString();
                        produtoSelecionado.Id = int.Parse(vendaSelecionada.ItensVenda.Rows[i]["iten_idProduto"].ToString());
                        int qtde = Convert.ToInt32(vendaSelecionada.ItensVenda.Rows[i]["iten_quantidade"]);

                        adicionarProdutoDataTable(qtde, produtoSelecionado);

                    }
                }
                foreach (DataRow parc in vendaSelecionada.ParcelasVenda.Rows)
                {
                    DataRow linha = dttParcela.NewRow();

                    char tipoPg = char.Parse(parc["tipo"].ToString());
                    if (tipoPg == 'F')
                        linha["tipo_pagamento"] = "Fiado";
                    else if (tipoPg == 'M')
                        linha["tipo_pagamento"] = "Dinheiro";
                    else if (tipoPg == 'D')
                        linha["tipo_pagamento"] = "Débito";
                    else if (tipoPg == 'S')
                        linha["tipo_pagamento"] = "Saldo";
                    else
                        linha["tipo_pagamento"] = "Crédito";

                    linha["valor"] = double.Parse(parc["valor"].ToString());
                    linha["data"] = DateTime.Parse(parc["data"].ToString());
                    dttParcela.Rows.Add(linha);
                }

                calcularParcelas(dttParcela);

                inserirDesconto(vendaSelecionada.Desconto);

                if (totalDesconto != 0)
                {
                    lblDesconto.Visible = lblTextDesconto.Visible = true;
                    lblDesconto.Text = totalDesconto.ToString("C"); ;
                }
                else
                {
                    lblDesconto.Visible = lblTextDesconto.Visible = false;
                }
                subtotalVenda = totalVenda - totalPago - totalDesconto;
                lblSubtotal.Text = (totalVenda - totalDesconto - totalPago).ToString("C"); ;

                gbProduto.Enabled = gbCliente.Enabled = false;

                int idCLient = vendaSelecionada.Id_cliente;

                if (idCLient != 0)
                {
                    clienteSelecionado = controlCliente.buscarClientePorId(idCLient);
                    tbNameClient.Text = clienteSelecionado.Nome;
                    alterarCpfCnpj(clienteSelecionado.Cpf_cnpj.Count());
                    mtbCpfClient.Text = clienteSelecionado.Cpf_cnpj;
                }

                if (vendaSelecionada.Venda_cancelada) // se venda cancelada
                {
                    btnCancelarVenda.Visible = false;
                    lblCancelada.Visible = true;
                    //btnCancelarVenda.Text = "F6 - Restaurar Venda";
                }
                else
                {
                    btnCancelarVenda.Visible = true;
                    lblCancelada.Visible = false;
                    //btnCancelarVenda.Text = "F6 - Cancela Venda";
                }
            }
        }

        private void timer_sale_Tick_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

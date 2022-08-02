using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GenCode128;
using DFe.Utils;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;

namespace sisVendas.Screens.Create
{
    public partial class FormCreateProduct : Form
    {
        private ctrlProduct controlProduct = new ctrlProduct();
        private ctrlProdutoMarca controlProdBrand = new ctrlProdutoMarca();
        private ctrlProdutoCategoria controlProdCategory = new ctrlProdutoCategoria();

        private DataTable dttMarca;
        private DataTable dttCategoria;

        private ConfiguracaoApp _config = new ConfiguracaoApp();
        public FormCreateProduct()
        {
            InitializeComponent();

            CarregarImpressoras();
            CarregandoComboBox();

            neutralForm();

            dgv_produto.Columns["prod_valor"].DefaultCellStyle.Format = "C";
            dgv_produto.Columns["prod_estoque"].DefaultCellStyle.Format = "N2";

            //Exitando que o f4 execute o evento dropDown do combobox
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(KeyF4Down);
            
            updateDgv("");

        }
        public void updateDgv(string filtro)
        {
            dgv_produto.DataSource = controlProduct.buscarProdutosParaDGV(filtro);
        }
        void KeyF4Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    if (btnSalvar.Enabled)
                    {
                        
                        btnSalvar.PerformClick();
                    }
                    break;
                case Keys.F1:
                    if (btnNovo.Enabled)
                        btnNovo.PerformClick();
                    break;
                case Keys.F2:
                    if (btnExcluir.Enabled)
                        btnExcluir.PerformClick();
                    break;
                case Keys.F4:
                    if (btnCancel.Enabled)
                        btnCancel.PerformClick();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void clearForm()
        {
            tbCod.Text =
            tbCodBarras.Text =
            tbName.Text =
            tbComplemento.Text =
            tbLocalizacao.Text =
            tbNcm.Text =
            tbCest.Text =
            tbComplemento.Text = "";

            mtbValor.Text = "R$ 0,00";
            tbEstoque.Text =
            tbEstoqueMin.Text = "0,00";

            cbAtivo.Checked = true;
            cbBalancaAtiva.Checked = false;

            //Marca/Categoria/Unidade
            if (dttMarca.Rows.Count > 0)
                cbbMarca.SelectedIndex = 0;
            if (dttCategoria.Rows.Count > 0)
                cbbCategory.SelectedIndex = 0;
            cbbUn.SelectedIndex = 4;
            //Origem/ST/GrupoT
            cbbSituacaoTrib.SelectedIndex = 0;
            cbbOrigem.SelectedIndex = 0;
            cbbGrupoTributacao.SelectedIndex = 0;
            //CFOP
            tbCfopVendaDentro.Text = "5102";
            tbCfopVendaFora.Text = "6102";
            tbCfopEntradaDentro.Text = "1102";
            tbCfopEntradaFora.Text = "2102";

            //ICMS
            tbAliquotaIcms.Text = "0,00%";
        }
        public void neutralForm()
        {
            clearForm();

            tbCodBarras.Enabled =
            tbName.Enabled =
            mtbValor.Enabled =
            tbEstoque.Enabled =
            tbEstoqueMin.Enabled =
            tbComplemento.Enabled =
            tbLocalizacao.Enabled =
            tbNcm.Enabled =
            tbCest.Enabled =
            cbAtivo.Enabled =
            cbBalancaAtiva.Enabled =
            tbComplemento.Enabled =
            cbbCategory.Enabled =
            cbbMarca.Enabled =
            cbbSituacaoTrib.Enabled =
            cbbOrigem.Enabled =
            cbbGrupoTributacao.Enabled =
            tbCfopVendaDentro.Enabled =
            tbCfopVendaFora.Enabled =
            tbCfopEntradaDentro.Enabled =
            tbCfopEntradaFora.Enabled =
            cbbUn.Enabled =
            tbAliquotaIcms.Enabled = false;


            btnNovo.Enabled = true;
            btnSalvar.Enabled =
            btnCancel.Enabled =
            btnExcluir.Enabled =
            btnGerarCodBarras.Enabled =
            btnImprimirCodBarras.Enabled = false;
        }

        private void CarregandoComboBox()
        {
            //Carregar Origem com descrição
            foreach (OrigemMercadoria status in EnumParaLista.EnumToList<OrigemMercadoria>())
            {
                this.cbbOrigem.Items.Add(status.GetDescription());
            }
            

            //Carregar SituaçãoTrib com descrição
            foreach (Csticms status in EnumParaLista.EnumToList<Csticms>())
            {
                this.cbbSituacaoTrib.Items.Add(status.GetDescription());
            }
            
            //Carregar GrupoTrib com descrição
            foreach (Csosnicms status in EnumParaLista.EnumToList<Csosnicms>())
            {
                this.cbbGrupoTributacao.Items.Add(status.GetDescription());
            }
            

            //ComboBox MARCA
            dttMarca = controlProdBrand.buscar("");
            cbbMarca.DataSource = dttMarca;
            cbbMarca.DisplayMember = "prod_marca_nome";
            cbbMarca.ValueMember = "prod_marca_id";
            

            //ComboBox PRODUTO
            dttCategoria = controlProdCategory.Buscar("");
            cbbCategory.DataSource = dttCategoria;
            cbbCategory.DisplayMember = "prod_categoria_nome";
            cbbCategory.ValueMember = "prod_categoria_id";
            
        }
        private void CarregarImpressoras()
        {
            //Buscar impressoras instaladas
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbbImpressora.Items.Add(impressora);
            }
            //importar Config
            if (_config.ImpressoraCodBarras.NomeImpressora == "")
            {
                if (cbbImpressora.Items.Count > 0)
                    cbbImpressora.SelectedIndex = 0;
            }else
            {
                cbbImpressora.Text = _config.ImpressoraCodBarras.NomeImpressora;
            }
            numericCodBarrasX.Value = _config.ImpressoraCodBarras.XCodigo;
            numericCodBarrasY.Value = _config.ImpressoraCodBarras.YCodigo;
            numericTextoX.Value = _config.ImpressoraCodBarras.XTexto;
            numericTextoY.Value = _config.ImpressoraCodBarras.YTexto;
            try
            {
                numericAltura.Value = _config.ImpressoraCodBarras.Altura;
            }
            catch { }
        }
        private void btnGerarCodBarras_Click(object sender, EventArgs e)
        {
            try
            {
                btnImprimirCodBarras.Enabled = true;
                Image codigoBarras = Code128Rendering.MakeBarcodeImage(tbCodBarras.Text, int.Parse(numericAltura.Value.ToString()), true);

                picCodBarras.Image = codigoBarras;

            }catch(Exception err)
            {
                Alerta.notificacao("Erro!", err.Message, Alerta.enmType.Error);
            }

        }

        private void btnImprimirCodBarras_Click(object sender, EventArgs e)
        {
            using (var pd = new System.Drawing.Printing.PrintDocument())
            {

                pd.PrinterSettings.PrinterName = cbbImpressora.SelectedItem.ToString();
                pd.PrintPage += printDocument1_PrintPage;
                pd.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var g = e.Graphics)
            {
                using (var fonte = new Font("Courier New", 16))
                {
                    g.DrawImage(this.picCodBarras.Image, int.Parse(numericCodBarrasX.Value.ToString()), int.Parse(numericCodBarrasY.Value.ToString()));

                    var caption = tbCodBarras.Text;
                    g.DrawString(caption, fonte, Brushes.Black, int.Parse(numericTextoX.Value.ToString()), int.Parse(numericTextoY.Value.ToString()) );
                    

                }
            }
        }

        private void resetaCor()
        {
            lblNcm.ForeColor = 
            lblCfop.ForeColor = 
            lblCodBarras.ForeColor =
            lblCod.ForeColor =
            lblNome.ForeColor =
            lblMarca.ForeColor =
            lblUn.ForeColor =
            lblCategoria.ForeColor =
            lblValue.ForeColor =
            lblCfopVendaDentro.ForeColor =
            lblCfopVendaFora.ForeColor =
            lblCfopEntradaDentro.ForeColor =
            lblCfopEntradaFora.ForeColor = Color.Black;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            bool isOk = true;
            resetaCor();

            if (tbNcm.Text.Count() == 0)
            {
                lblNcm.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCest.Text.Count() == 0)
            {
                lblCfop.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCodBarras.Text.Count() == 0)
            {
                lblCodBarras.ForeColor = Color.Red;
                isOk = false;
            }

            if (tbName.Text.Count() == 0)
            {
                lblNome.ForeColor = Color.Red;
                isOk = false;
            }

            if (cbbMarca.SelectedIndex == -1)
            {
                lblMarca.ForeColor = Color.Red;
                isOk = false;
            }
            if (cbbUn.SelectedIndex == -1)
            {
                lblUn.ForeColor = Color.Red;
                isOk = false;
            }
            if (cbbCategory.SelectedIndex == -1)
            {
                lblCategoria.ForeColor = Color.Red;
                isOk = false;
            }
            if (mtbValor.Text.ToString().Replace("R$", "").Count() == 0)
            {
                lblValue.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCfopVendaDentro.Text.Length == 0)
            {
                lblCfopVendaDentro.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCfopVendaFora.Text.Length == 0)
            {
                lblCfopVendaFora.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCfopEntradaDentro.Text.Length == 0)
            {
                lblCfopEntradaDentro.ForeColor = Color.Red;
                isOk = false;
            }
            if (tbCfopEntradaFora.Text.Length == 0)
            {
                lblCfopEntradaFora.ForeColor = Color.Red;
                isOk = false;
            }

            if (isOk)
            {
                
                 if (!controlProduct.verificarSeCodigoDeBarrasExiste(tbCodBarras.Text, tbCod.Text) )
                 {
                        if (controlProduct.Salvar(
                                            tbCod.Text,
                                            tbCodBarras.Text,
                                            tbName.Text,
                                            mtbValor.Text,
                                            cbbMarca.SelectedValue.ToString(),
                                            cbbCategory.SelectedValue.ToString(),
                                            cbbUn.Text,
                                            tbComplemento.Text,
                                            tbEstoque.Text,
                                            tbEstoqueMin.Text,
                                            tbLocalizacao.Text,
                                            cbAtivo.Checked,
                                            cbBalancaAtiva.Checked,
                                            tbNcm.Text,
                                            tbCest.Text,
                                            cbbOrigem.SelectedItem,
                                            cbbSituacaoTrib.SelectedItem,
                                            cbbGrupoTributacao.SelectedItem,
                                            tbCfopVendaDentro.Text,
                                            tbCfopVendaFora.Text,
                                            tbCfopEntradaDentro.Text,
                                            tbCfopEntradaFora.Text,
                                            tbAliquotaIcms.Text
                                            ))
                        {

                                Alerta.notificacao("Sucesso!", "Produto salvo.", Alerta.enmType.Success);
                                updateDgv("");
                        neutralForm();
                        tbCodBarras.Focus();
                        }
                 }
                 else
                 {
                     Alerta.notificacao("Erro!", "Código se barras ja cadastrado!" , Alerta.enmType.Error);
                 }                
            }
            else
            {
                Alerta.notificacao("Erro!", "Preencha os campos obrigatórios!", Alerta.enmType.Error);
            }

        }

        private void tbAliquotaIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbAliquotaIcms_Leave(object sender, EventArgs e)
        {
            string text = tbAliquotaIcms.Text.Replace("%", "");
            if (double.TryParse(text, out double res))
            {
                tbAliquotaIcms.Text = String.Format("{0:f}", res) + "%";
            }
            else
            {
                tbAliquotaIcms.Text = "0,00%";
            }
        }

        private void tbAliquotaIcms_Click(object sender, EventArgs e)
        {
            if(tbAliquotaIcms.Text == "0,00%")
            {
                tbAliquotaIcms.Text = "";
            }
        }

        private void mtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void mtbValor_Leave(object sender, EventArgs e)
        {
            string text = mtbValor.Text.Replace("R$", "");
            if (double.TryParse(text, out double res))
                mtbValor.Text = String.Format("{0:c}", res);
            else
            {
                mtbValor.Text = "R$ 0,00";
            }
        }

        private void mtbValor_Enter(object sender, EventArgs e)
        {
            if (mtbValor.Text == "R$ 0,00")
            {
                mtbValor.Text = "";
            }
        }

        private void tbLocalizacao_TextChanged(object sender, EventArgs e)
        {
            lblLenghtLocalizacao.Text = tbLocalizacao.Text.Length + "/50";
        }

        private void tbEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void tbEstoque_Leave(object sender, EventArgs e)
        {
            string text = tbEstoque.Text;
            if (double.TryParse(text, out double res))
                tbEstoque.Text = String.Format("{0:f}", res);
            else
            {
                tbEstoque.Text = "0,00";
            }
        }

        private void tbEstoqueMin_Leave(object sender, EventArgs e)
        {
            string text = tbEstoqueMin.Text;
            if (double.TryParse(text, out double res))
                tbEstoqueMin.Text = String.Format("{0:f}", res);
            else
            {
                tbEstoqueMin.Text = "0,00";
            }
        }

        public void activeForm()
        {

            tbCodBarras.Enabled =
            tbName.Enabled =
            mtbValor.Enabled =
            tbEstoque.Enabled =
            tbEstoqueMin.Enabled =
            tbComplemento.Enabled =
            tbLocalizacao.Enabled =
            tbNcm.Enabled =
            tbCest.Enabled =
            cbAtivo.Enabled =
            cbBalancaAtiva.Enabled =
            tbComplemento.Enabled =
            cbbCategory.Enabled =
            cbbMarca.Enabled =
            cbbSituacaoTrib.Enabled =
            cbbOrigem.Enabled =
            cbbGrupoTributacao.Enabled =
            tbCfopVendaDentro.Enabled =
            tbCfopVendaFora.Enabled =
            tbCfopEntradaDentro.Enabled =
            tbCfopEntradaFora.Enabled =
            cbbUn.Enabled =
            tbAliquotaIcms.Enabled = true;


            btnNovo.Enabled =
            btnImprimirCodBarras.Enabled =
            btnExcluir.Enabled = false;
            btnSalvar.Enabled =
            btnCancel.Enabled =
            btnGerarCodBarras.Enabled = true;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            activeForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            neutralForm();
        }

        private void btnFehar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbComplemento_TextChanged_1(object sender, EventArgs e)
        {
            lblLenghtDescricao.Text = tbComplemento.Text.Length + "/200";
        }

        private void keypressApenasNumeros(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void tbNcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void tbCest_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void tbCfopVendaDentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void tbCfopEntradaDentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void tbCfopVendaFora_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void tbCfopEntradaFora_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypressApenasNumeros(e);
        }

        private void preencherForm(Produto prod)
        {
            tbCod.Text = prod.Id.ToString();
            tbCodBarras.Text = prod.Codigo_barras;
            tbName.Text = prod.Nome;
            mtbValor.Text = prod.Valor.ToString("C");
            cbbUn.Text = prod.Un;
            tbComplemento.Text = prod.Complemento;
            tbEstoque.Text = prod.Estoque.ToString("F");
            tbEstoqueMin.Text = prod.Estoque_min.ToString("F");
            tbLocalizacao.Text = prod.Localizacao;
            cbAtivo.Checked = prod.Ativo;
            cbBalancaAtiva.Checked = prod.Balanca;
            tbNcm.Text = prod.Ncm;
            tbCest.Text = prod.Cest;
            tbCfopVendaDentro.Text = prod.Cfop_venda_dentro_estado.ToString();
            tbCfopVendaFora.Text = prod.Cfop_venda_fora_estado.ToString();
            tbCfopEntradaDentro.Text = prod.Cfop_compra_dentro_estado.ToString();
            tbCfopEntradaFora.Text = prod.Cfop_compra_fora_estado.ToString();
            tbAliquotaIcms.Text = prod.Aliq_icms.ToString("F");
            cbbCategory.SelectedValue = prod.Categoria.Id;
            cbbMarca.SelectedValue = prod.Marca.Id;

            cbbOrigem.SelectedItem = prod.Origem.GetDescription();
            cbbSituacaoTrib.SelectedItem = prod.Situacao_tributaria.GetDescription();
            cbbGrupoTributacao.SelectedItem = prod.Grupo_tributacao.GetDescription();

        }
        private void dgv_produto_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_produto.SelectedRows.Count == 1)
            {
                activeForm();
               
                Produto prod = controlProduct.buscarProdutoPorCodigo(dgv_produto.Rows[dgv_produto.CurrentRow.Index].Cells[0].Value.ToString());
                preencherForm(prod);
                tbCod.Enabled = false;
                btnExcluir.Enabled = true;
            }
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            updateDgv(tbSearch.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCod.Text != "")
            {
                if (MessageBox.Show("Deseja excluir o cliente selecionado ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string cod = tbCod.Text;

                    if (controlProduct.RemoverProduto(tbCod.Text) == true)
                    {
                        updateDgv("");

                        neutralForm();
                        Alerta.notificacao("Sucesso!", "Cliente excluido.", Alerta.enmType.Success);
                    }
                    else
                    {
                        Alerta.notificacao("Erro!", "Erro ao excluir cliente.", Alerta.enmType.Error);

                    }
                }
            }
            else
                MessageBox.Show("Selecione o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


/*
//Buscando pela descrição
OrigemMercadoria statusByDescription =
EnumParaLista.GetEnumByDescription<OrigemMercadoria>(
this.cbbOrigem.SelectedItem.ToString());
            


//OrigemMercadoria status = (OrigemMercadoria)Enum.Parse(typeof(OrigemMercadoria), statusByDescription.ToString());
//MessageBox.Show(status.ToString());

//cbbOrigem.Text = OrigemMercadoria.OmNacionalConteudoImportacaoSuperior70.GetDescription();
            
//Buscando pela descrição
//OrigemMercadoria statusByDescription =
//EnumParaLista.GetEnumByDescription<OrigemMercadoria>(
//this.cbbOrigem.SelectedItem.ToString());
 */

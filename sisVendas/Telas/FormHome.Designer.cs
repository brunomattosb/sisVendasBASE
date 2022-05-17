namespace sisVendas
{
    partial class FormHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnProductBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnExpenseType = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnEfetuarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnRelatorioVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnTrocaDevoluc = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnAbrirFecharCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLancarDespesa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnQuitarRecebimento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnRelatorioCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnQuitarPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLancarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.promoçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnRegistrarPromocao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnParameterization = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCaixaStatus = new System.Windows.Forms.Label();
            this.lblNomeFuncLogado = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.promoçãoToolStripMenuItem,
            this.menuBtnParameterization});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Menu";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnFuncionario,
            this.menuBtnClient,
            this.menuBtnProvider,
            this.menuBtnProduct,
            this.menuBtnProductCategory,
            this.menuBtnProductBrand,
            this.menuBtnExpenseType});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuBtnFuncionario
            // 
            this.menuBtnFuncionario.Name = "menuBtnFuncionario";
            this.menuBtnFuncionario.Size = new System.Drawing.Size(180, 22);
            this.menuBtnFuncionario.Text = "Funcionário";
            this.menuBtnFuncionario.Click += new System.EventHandler(this.menuBtnFuncionario_Click);
            // 
            // menuBtnClient
            // 
            this.menuBtnClient.Name = "menuBtnClient";
            this.menuBtnClient.Size = new System.Drawing.Size(180, 22);
            this.menuBtnClient.Text = "Cliente";
            this.menuBtnClient.Click += new System.EventHandler(this.menuBtnClient_Click);
            // 
            // menuBtnProvider
            // 
            this.menuBtnProvider.Name = "menuBtnProvider";
            this.menuBtnProvider.Size = new System.Drawing.Size(180, 22);
            this.menuBtnProvider.Text = "Fornecedor";
            this.menuBtnProvider.Click += new System.EventHandler(this.menuBtnProvider_Click);
            // 
            // menuBtnProduct
            // 
            this.menuBtnProduct.Name = "menuBtnProduct";
            this.menuBtnProduct.Size = new System.Drawing.Size(180, 22);
            this.menuBtnProduct.Text = "Produto";
            this.menuBtnProduct.Click += new System.EventHandler(this.menuBtnProduct_Click);
            // 
            // menuBtnProductCategory
            // 
            this.menuBtnProductCategory.Name = "menuBtnProductCategory";
            this.menuBtnProductCategory.Size = new System.Drawing.Size(180, 22);
            this.menuBtnProductCategory.Text = "Produto Categoria";
            this.menuBtnProductCategory.Click += new System.EventHandler(this.menuBtnProductCategory_Click);
            // 
            // menuBtnProductBrand
            // 
            this.menuBtnProductBrand.Name = "menuBtnProductBrand";
            this.menuBtnProductBrand.Size = new System.Drawing.Size(180, 22);
            this.menuBtnProductBrand.Text = "Produto Marca";
            this.menuBtnProductBrand.Click += new System.EventHandler(this.menuBtnProductBrand_Click);
            // 
            // menuBtnExpenseType
            // 
            this.menuBtnExpenseType.Name = "menuBtnExpenseType";
            this.menuBtnExpenseType.Size = new System.Drawing.Size(180, 22);
            this.menuBtnExpenseType.Text = "Tipo Despesa";
            this.menuBtnExpenseType.Click += new System.EventHandler(this.menuBtnExpenseType_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnEfetuarVenda,
            this.menuBtnRelatorioVenda,
            this.menuBtnTrocaDevoluc});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendaToolStripMenuItem.Text = "Vendas";
            // 
            // menuBtnEfetuarVenda
            // 
            this.menuBtnEfetuarVenda.Name = "menuBtnEfetuarVenda";
            this.menuBtnEfetuarVenda.Size = new System.Drawing.Size(180, 22);
            this.menuBtnEfetuarVenda.Text = "Efetuar Venda";
            this.menuBtnEfetuarVenda.Click += new System.EventHandler(this.menuBtnEfetuarVenda_Click);
            // 
            // menuBtnRelatorioVenda
            // 
            this.menuBtnRelatorioVenda.Enabled = false;
            this.menuBtnRelatorioVenda.Name = "menuBtnRelatorioVenda";
            this.menuBtnRelatorioVenda.Size = new System.Drawing.Size(180, 22);
            this.menuBtnRelatorioVenda.Text = "Relatório";
            // 
            // menuBtnTrocaDevoluc
            // 
            this.menuBtnTrocaDevoluc.Enabled = false;
            this.menuBtnTrocaDevoluc.Name = "menuBtnTrocaDevoluc";
            this.menuBtnTrocaDevoluc.Size = new System.Drawing.Size(180, 22);
            this.menuBtnTrocaDevoluc.Text = "Troca/Devolução";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnAbrirFecharCaixa,
            this.menuBtnLancarDespesa,
            this.menuBtnQuitarRecebimento,
            this.menuBtnRelatorioCaixa,
            this.menuBtnQuitarPagamento});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // menuBtnAbrirFecharCaixa
            // 
            this.menuBtnAbrirFecharCaixa.Name = "menuBtnAbrirFecharCaixa";
            this.menuBtnAbrirFecharCaixa.Size = new System.Drawing.Size(201, 22);
            this.menuBtnAbrirFecharCaixa.Text = "Abrir/Fechar";
            this.menuBtnAbrirFecharCaixa.Click += new System.EventHandler(this.menuBtnAbrirFecharCaixa_Click);
            // 
            // menuBtnLancarDespesa
            // 
            this.menuBtnLancarDespesa.Name = "menuBtnLancarDespesa";
            this.menuBtnLancarDespesa.Size = new System.Drawing.Size(201, 22);
            this.menuBtnLancarDespesa.Text = "Lançar Despesas";
            this.menuBtnLancarDespesa.Click += new System.EventHandler(this.menuBtnLancarDespesa_Click);
            // 
            // menuBtnQuitarRecebimento
            // 
            this.menuBtnQuitarRecebimento.Name = "menuBtnQuitarRecebimento";
            this.menuBtnQuitarRecebimento.Size = new System.Drawing.Size(201, 22);
            this.menuBtnQuitarRecebimento.Text = "Quitar Contas a Receber";
            this.menuBtnQuitarRecebimento.Click += new System.EventHandler(this.menuBtnQuitarRecebimento_Click);
            // 
            // menuBtnRelatorioCaixa
            // 
            this.menuBtnRelatorioCaixa.Enabled = false;
            this.menuBtnRelatorioCaixa.Name = "menuBtnRelatorioCaixa";
            this.menuBtnRelatorioCaixa.Size = new System.Drawing.Size(201, 22);
            this.menuBtnRelatorioCaixa.Text = "Relatório";
            // 
            // menuBtnQuitarPagamento
            // 
            this.menuBtnQuitarPagamento.Name = "menuBtnQuitarPagamento";
            this.menuBtnQuitarPagamento.Size = new System.Drawing.Size(201, 22);
            this.menuBtnQuitarPagamento.Text = "Quitar Contas a Pagar";
            this.menuBtnQuitarPagamento.Click += new System.EventHandler(this.menuBtnQuitarPagamento_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnLancarCompra});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // menuBtnLancarCompra
            // 
            this.menuBtnLancarCompra.Name = "menuBtnLancarCompra";
            this.menuBtnLancarCompra.Size = new System.Drawing.Size(155, 22);
            this.menuBtnLancarCompra.Text = "Lançar Compra";
            this.menuBtnLancarCompra.Click += new System.EventHandler(this.menuBtnLancarCompra_Click);
            // 
            // promoçãoToolStripMenuItem
            // 
            this.promoçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnRegistrarPromocao});
            this.promoçãoToolStripMenuItem.Name = "promoçãoToolStripMenuItem";
            this.promoçãoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.promoçãoToolStripMenuItem.Text = "Promoção";
            // 
            // menuBtnRegistrarPromocao
            // 
            this.menuBtnRegistrarPromocao.Enabled = false;
            this.menuBtnRegistrarPromocao.Name = "menuBtnRegistrarPromocao";
            this.menuBtnRegistrarPromocao.Size = new System.Drawing.Size(180, 22);
            this.menuBtnRegistrarPromocao.Text = "Registrar Promoção";
            this.menuBtnRegistrarPromocao.Click += new System.EventHandler(this.menuBtnRegistrarPromocao_Click);
            // 
            // menuBtnParameterization
            // 
            this.menuBtnParameterization.Enabled = false;
            this.menuBtnParameterization.Name = "menuBtnParameterization";
            this.menuBtnParameterization.Size = new System.Drawing.Size(100, 20);
            this.menuBtnParameterization.Text = "Parametrização";
            this.menuBtnParameterization.Click += new System.EventHandler(this.menuBtnParameterization_Click);
            // 
            // lblCaixaStatus
            // 
            this.lblCaixaStatus.AutoSize = true;
            this.lblCaixaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCaixaStatus.Location = new System.Drawing.Point(599, 66);
            this.lblCaixaStatus.Name = "lblCaixaStatus";
            this.lblCaixaStatus.Size = new System.Drawing.Size(164, 33);
            this.lblCaixaStatus.TabIndex = 3;
            this.lblCaixaStatus.Text = "FECHADO";
            // 
            // lblNomeFuncLogado
            // 
            this.lblNomeFuncLogado.AutoSize = true;
            this.lblNomeFuncLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncLogado.Location = new System.Drawing.Point(601, 41);
            this.lblNomeFuncLogado.Name = "lblNomeFuncLogado";
            this.lblNomeFuncLogado.Size = new System.Drawing.Size(13, 20);
            this.lblNomeFuncLogado.TabIndex = 4;
            this.lblNomeFuncLogado.Text = ".";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.lblNomeFuncLogado);
            this.Controls.Add(this.lblCaixaStatus);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agro França";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuBtnClient;
        private System.Windows.Forms.ToolStripMenuItem menuBtnProvider;
        private System.Windows.Forms.ToolStripMenuItem menuBtnProduct;
        private System.Windows.Forms.ToolStripMenuItem menuBtnProductCategory;
        private System.Windows.Forms.ToolStripMenuItem menuBtnProductBrand;
        private System.Windows.Forms.ToolStripMenuItem menuBtnExpenseType;
        private System.Windows.Forms.ToolStripMenuItem menuBtnParameterization;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnEfetuarVenda;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRelatorioVenda;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnAbrirFecharCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLancarDespesa;
        private System.Windows.Forms.ToolStripMenuItem menuBtnTrocaDevoluc;
        private System.Windows.Forms.ToolStripMenuItem menuBtnQuitarRecebimento;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLancarCompra;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRelatorioCaixa;
        private System.Windows.Forms.ToolStripMenuItem promoçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRegistrarPromocao;
        private System.Windows.Forms.Label lblCaixaStatus;
        private System.Windows.Forms.Label lblNomeFuncLogado;
        private System.Windows.Forms.ToolStripMenuItem menuBtnQuitarPagamento;
    }
}


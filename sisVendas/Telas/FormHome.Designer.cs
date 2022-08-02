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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblValorAReceber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGerarXml = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(1004, 24);
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
            this.menuBtnFuncionario.Size = new System.Drawing.Size(171, 22);
            this.menuBtnFuncionario.Text = "Funcionário";
            this.menuBtnFuncionario.Click += new System.EventHandler(this.menuBtnFuncionario_Click);
            // 
            // menuBtnClient
            // 
            this.menuBtnClient.Name = "menuBtnClient";
            this.menuBtnClient.Size = new System.Drawing.Size(171, 22);
            this.menuBtnClient.Text = "Cliente";
            this.menuBtnClient.Click += new System.EventHandler(this.menuBtnClient_Click);
            // 
            // menuBtnProvider
            // 
            this.menuBtnProvider.Name = "menuBtnProvider";
            this.menuBtnProvider.Size = new System.Drawing.Size(171, 22);
            this.menuBtnProvider.Text = "Fornecedor";
            this.menuBtnProvider.Click += new System.EventHandler(this.menuBtnProvider_Click);
            // 
            // menuBtnProduct
            // 
            this.menuBtnProduct.Name = "menuBtnProduct";
            this.menuBtnProduct.Size = new System.Drawing.Size(171, 22);
            this.menuBtnProduct.Text = "Produto";
            this.menuBtnProduct.Click += new System.EventHandler(this.menuBtnProduct_Click);
            // 
            // menuBtnProductCategory
            // 
            this.menuBtnProductCategory.Name = "menuBtnProductCategory";
            this.menuBtnProductCategory.Size = new System.Drawing.Size(171, 22);
            this.menuBtnProductCategory.Text = "Produto Categoria";
            this.menuBtnProductCategory.Click += new System.EventHandler(this.menuBtnProductCategory_Click);
            // 
            // menuBtnProductBrand
            // 
            this.menuBtnProductBrand.Name = "menuBtnProductBrand";
            this.menuBtnProductBrand.Size = new System.Drawing.Size(171, 22);
            this.menuBtnProductBrand.Text = "Produto Marca";
            this.menuBtnProductBrand.Click += new System.EventHandler(this.menuBtnProductBrand_Click);
            // 
            // menuBtnExpenseType
            // 
            this.menuBtnExpenseType.Name = "menuBtnExpenseType";
            this.menuBtnExpenseType.Size = new System.Drawing.Size(171, 22);
            this.menuBtnExpenseType.Text = "Tipo Despesa";
            this.menuBtnExpenseType.Click += new System.EventHandler(this.menuBtnExpenseType_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnEfetuarVenda});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendaToolStripMenuItem.Text = "Vendas";
            // 
            // menuBtnEfetuarVenda
            // 
            this.menuBtnEfetuarVenda.Name = "menuBtnEfetuarVenda";
            this.menuBtnEfetuarVenda.Size = new System.Drawing.Size(146, 22);
            this.menuBtnEfetuarVenda.Text = "Efetuar Venda";
            this.menuBtnEfetuarVenda.Click += new System.EventHandler(this.menuBtnEfetuarVenda_Click);
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
            this.menuBtnAbrirFecharCaixa.Enabled = false;
            this.menuBtnAbrirFecharCaixa.Name = "menuBtnAbrirFecharCaixa";
            this.menuBtnAbrirFecharCaixa.Size = new System.Drawing.Size(201, 22);
            this.menuBtnAbrirFecharCaixa.Text = "Abrir/Fechar";
            this.menuBtnAbrirFecharCaixa.Click += new System.EventHandler(this.menuBtnAbrirFecharCaixa_Click);
            // 
            // menuBtnLancarDespesa
            // 
            this.menuBtnLancarDespesa.Enabled = false;
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
            this.menuBtnQuitarPagamento.Enabled = false;
            this.menuBtnQuitarPagamento.Name = "menuBtnQuitarPagamento";
            this.menuBtnQuitarPagamento.Size = new System.Drawing.Size(201, 22);
            this.menuBtnQuitarPagamento.Text = "Quitar Contas a Pagar";
            this.menuBtnQuitarPagamento.Click += new System.EventHandler(this.menuBtnQuitarPagamento_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnLancarCompra});
            this.comprasToolStripMenuItem.Enabled = false;
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
            this.promoçãoToolStripMenuItem.Enabled = false;
            this.promoçãoToolStripMenuItem.Name = "promoçãoToolStripMenuItem";
            this.promoçãoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.promoçãoToolStripMenuItem.Text = "Promoção";
            // 
            // menuBtnRegistrarPromocao
            // 
            this.menuBtnRegistrarPromocao.Name = "menuBtnRegistrarPromocao";
            this.menuBtnRegistrarPromocao.Size = new System.Drawing.Size(178, 22);
            this.menuBtnRegistrarPromocao.Text = "Registrar Promoção";
            this.menuBtnRegistrarPromocao.Click += new System.EventHandler(this.menuBtnRegistrarPromocao_Click);
            // 
            // menuBtnParameterization
            // 
            this.menuBtnParameterization.Name = "menuBtnParameterization";
            this.menuBtnParameterization.Size = new System.Drawing.Size(100, 20);
            this.menuBtnParameterization.Text = "Parametrização";
            this.menuBtnParameterization.Click += new System.EventHandler(this.menuBtnParameterization_Click);
            // 
            // lblCaixaStatus
            // 
            this.lblCaixaStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaixaStatus.AutoSize = true;
            this.lblCaixaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCaixaStatus.Location = new System.Drawing.Point(75, 267);
            this.lblCaixaStatus.Name = "lblCaixaStatus";
            this.lblCaixaStatus.Size = new System.Drawing.Size(164, 33);
            this.lblCaixaStatus.TabIndex = 3;
            this.lblCaixaStatus.Text = "FECHADO";
            // 
            // lblNomeFuncLogado
            // 
            this.lblNomeFuncLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeFuncLogado.AutoSize = true;
            this.lblNomeFuncLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncLogado.Location = new System.Drawing.Point(30, 54);
            this.lblNomeFuncLogado.Name = "lblNomeFuncLogado";
            this.lblNomeFuncLogado.Size = new System.Drawing.Size(13, 20);
            this.lblNomeFuncLogado.TabIndex = 4;
            this.lblNomeFuncLogado.Text = ".";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCaixaStatus);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblNomeFuncLogado);
            this.panel3.Location = new System.Drawing.Point(685, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 325);
            this.panel3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 55);
            this.label6.TabIndex = 6;
            this.label6.Text = "Caixa:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuário:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 325);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.lblValorAPagar);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(351, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 130);
            this.panel5.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(157, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.AutoSize = true;
            this.lblValorAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagar.Location = new System.Drawing.Point(17, 64);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(116, 33);
            this.lblValorAPagar.TabIndex = 1;
            this.lblValorAPagar.Text = "R$ 0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pagar Hoje";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblValorAReceber);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(18, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 130);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(157, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblValorAReceber
            // 
            this.lblValorAReceber.AutoSize = true;
            this.lblValorAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAReceber.Location = new System.Drawing.Point(17, 64);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(116, 33);
            this.lblValorAReceber.TabIndex = 1;
            this.lblValorAReceber.Text = "R$ 0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Receber Hoje";
            // 
            // btnGerarXml
            // 
            this.btnGerarXml.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarXml.Location = new System.Drawing.Point(453, 398);
            this.btnGerarXml.Name = "btnGerarXml";
            this.btnGerarXml.Size = new System.Drawing.Size(102, 23);
            this.btnGerarXml.TabIndex = 10;
            this.btnGerarXml.Text = "Gerar Boleto";
            this.btnGerarXml.UseVisualStyleBackColor = true;
            this.btnGerarXml.Click += new System.EventHandler(this.btnGerarXml_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(577, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Emitir NFCe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(30, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "NFC-e FastReport";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGerarXml);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agro França";
            this.Activated += new System.EventHandler(this.FormHome_Activated);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnAbrirFecharCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLancarDespesa;
        private System.Windows.Forms.ToolStripMenuItem menuBtnQuitarRecebimento;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLancarCompra;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRelatorioCaixa;
        private System.Windows.Forms.ToolStripMenuItem promoçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnRegistrarPromocao;
        private System.Windows.Forms.Label lblCaixaStatus;
        private System.Windows.Forms.Label lblNomeFuncLogado;
        private System.Windows.Forms.ToolStripMenuItem menuBtnQuitarPagamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblValorAReceber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGerarXml;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


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
            this.menuBtnExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnExpenseType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnParameterization = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnEfetuarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendaToolStripMenuItem,
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
            this.menuBtnExpense,
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
            // menuBtnExpense
            // 
            this.menuBtnExpense.Enabled = false;
            this.menuBtnExpense.Name = "menuBtnExpense";
            this.menuBtnExpense.Size = new System.Drawing.Size(180, 22);
            this.menuBtnExpense.Text = "Despesa";
            this.menuBtnExpense.Click += new System.EventHandler(this.menuBtnExpense_Click);
            // 
            // menuBtnExpenseType
            // 
            this.menuBtnExpenseType.Name = "menuBtnExpenseType";
            this.menuBtnExpenseType.Size = new System.Drawing.Size(180, 22);
            this.menuBtnExpenseType.Text = "Tipo Despesa";
            this.menuBtnExpenseType.Click += new System.EventHandler(this.menuBtnExpenseType_Click);
            // 
            // menuBtnParameterization
            // 
            this.menuBtnParameterization.Enabled = false;
            this.menuBtnParameterization.Name = "menuBtnParameterization";
            this.menuBtnParameterization.Size = new System.Drawing.Size(100, 20);
            this.menuBtnParameterization.Text = "Parametrização";
            this.menuBtnParameterization.Click += new System.EventHandler(this.menuBtnParameterization_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnEfetuarVenda,
            this.relatórioToolStripMenuItem});
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
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Enabled = false;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormHome";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem menuBtnExpense;
        private System.Windows.Forms.ToolStripMenuItem menuBtnExpenseType;
        private System.Windows.Forms.ToolStripMenuItem menuBtnParameterization;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnEfetuarVenda;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
    }
}


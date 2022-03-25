namespace sisVendas.Screens.Create
{
    partial class FormCreateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.cbbUn = new System.Windows.Forms.ComboBox();
            this.lblUn = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.tbComplemento = new System.Windows.Forms.RichTextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mtbValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_complement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(30, 16);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(323, 42);
            this.lblFuncionario.TabIndex = 3;
            this.lblFuncionario.Text = "Cadastrar Produto";
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(37, 359);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(336, 57);
            this.GbpPesquisa.TabIndex = 5;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(6, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCad.Controls.Add(this.cbbUn);
            this.gbCad.Controls.Add(this.lblUn);
            this.gbCad.Controls.Add(this.cbbCategory);
            this.gbCad.Controls.Add(this.tbComplemento);
            this.gbCad.Controls.Add(this.lblComplemento);
            this.gbCad.Controls.Add(this.lblMarca);
            this.gbCad.Controls.Add(this.mtbValue);
            this.gbCad.Controls.Add(this.lblValue);
            this.gbCad.Controls.Add(this.cbbBrand);
            this.gbCad.Controls.Add(this.tableLayoutPanel1);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.tbCod);
            this.gbCad.Controls.Add(this.lblCategoria);
            this.gbCad.Controls.Add(this.lblEstoque);
            this.gbCad.Controls.Add(this.tbInventory);
            this.gbCad.Controls.Add(this.tbName);
            this.gbCad.Controls.Add(this.lblNome);
            this.gbCad.Location = new System.Drawing.Point(36, 70);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(694, 280);
            this.gbCad.TabIndex = 4;
            this.gbCad.TabStop = false;
            // 
            // cbbUn
            // 
            this.cbbUn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUn.FormattingEnabled = true;
            this.cbbUn.Items.AddRange(new object[] {
            "CX",
            "FD",
            "KG",
            "MT",
            "UN"});
            this.cbbUn.Location = new System.Drawing.Point(477, 90);
            this.cbbUn.MaxLength = 2;
            this.cbbUn.Name = "cbbUn";
            this.cbbUn.Size = new System.Drawing.Size(183, 21);
            this.cbbUn.TabIndex = 45;
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Location = new System.Drawing.Point(474, 74);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(51, 13);
            this.lblUn.TabIndex = 44;
            this.lblUn.Text = "*Unidade";
            // 
            // cbbCategory
            // 
            this.cbbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(272, 90);
            this.cbbCategory.MaxLength = 2;
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(199, 21);
            this.cbbCategory.TabIndex = 43;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(37, 160);
            this.tbComplemento.MaxLength = 149;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(627, 60);
            this.tbComplemento.TabIndex = 42;
            this.tbComplemento.Text = "";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(36, 144);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 41;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(64, 74);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(41, 13);
            this.lblMarca.TabIndex = 40;
            this.lblMarca.Text = "*Marca";
            // 
            // mtbValue
            // 
            this.mtbValue.Location = new System.Drawing.Point(537, 131);
            this.mtbValue.MaxLength = 10;
            this.mtbValue.Name = "mtbValue";
            this.mtbValue.Size = new System.Drawing.Size(124, 20);
            this.mtbValue.TabIndex = 13;
            this.mtbValue.Text = "0,00";
            this.mtbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbValue_KeyPress);
            this.mtbValue.Leave += new System.EventHandler(this.mtbValue_Leave);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(535, 117);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(38, 13);
            this.lblValue.TabIndex = 29;
            this.lblValue.Text = "*Valor:";
            // 
            // cbbBrand
            // 
            this.cbbBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(67, 90);
            this.cbbBrand.MaxLength = 2;
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(199, 21);
            this.cbbBrand.TabIndex = 39;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(34, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(190, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(503, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(346, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(34, 27);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(47, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "*Código:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(37, 43);
            this.tbCod.MaxLength = 39;
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(119, 20);
            this.tbCod.TabIndex = 1;
            this.tbCod.Leave += new System.EventHandler(this.tbCod_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(269, 74);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(59, 13);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "*Categoria:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(535, 27);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(53, 13);
            this.lblEstoque.TabIndex = 11;
            this.lblEstoque.Text = "*Estoque:";
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(536, 43);
            this.tbInventory.MaxLength = 10;
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(124, 20);
            this.tbInventory.TabIndex = 8;
            this.tbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInventory_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 43);
            this.tbName.MaxLength = 39;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(368, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(159, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "*Nome:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_product, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 422);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 222);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.prod_un,
            this.prod_name,
            this.prod_created_at,
            this.prod_complement,
            this.prod_inventory,
            this.prod_brand,
            this.prod_value,
            this.prod_category});
            this.dgv_product.Location = new System.Drawing.Point(3, 3);
            this.dgv_product.MultiSelect = false;
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(699, 216);
            this.dgv_product.TabIndex = 0;
            this.dgv_product.DoubleClick += new System.EventHandler(this.dgv_productCategory_DoubleClick);
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "Código";
            this.prod_id.MinimumWidth = 150;
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Width = 150;
            // 
            // prod_un
            // 
            this.prod_un.DataPropertyName = "prod_un";
            this.prod_un.HeaderText = "Unidade";
            this.prod_un.Name = "prod_un";
            this.prod_un.ReadOnly = true;
            // 
            // prod_name
            // 
            this.prod_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_name.DataPropertyName = "prod_name";
            this.prod_name.HeaderText = "Nome";
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            // 
            // prod_created_at
            // 
            this.prod_created_at.DataPropertyName = "prod_created_at";
            this.prod_created_at.HeaderText = "Cadastro";
            this.prod_created_at.Name = "prod_created_at";
            this.prod_created_at.ReadOnly = true;
            this.prod_created_at.Visible = false;
            // 
            // prod_complement
            // 
            this.prod_complement.DataPropertyName = "prod_complement";
            this.prod_complement.HeaderText = "Complemento";
            this.prod_complement.Name = "prod_complement";
            this.prod_complement.ReadOnly = true;
            this.prod_complement.Visible = false;
            // 
            // prod_inventory
            // 
            this.prod_inventory.DataPropertyName = "prod_inventory";
            this.prod_inventory.HeaderText = "Estoque";
            this.prod_inventory.Name = "prod_inventory";
            this.prod_inventory.ReadOnly = true;
            // 
            // prod_brand
            // 
            this.prod_brand.DataPropertyName = "prod_brand";
            this.prod_brand.HeaderText = "Marca";
            this.prod_brand.Name = "prod_brand";
            this.prod_brand.ReadOnly = true;
            this.prod_brand.Visible = false;
            // 
            // prod_value
            // 
            this.prod_value.DataPropertyName = "prod_value";
            this.prod_value.HeaderText = "Valor";
            this.prod_value.Name = "prod_value";
            this.prod_value.ReadOnly = true;
            // 
            // prod_category
            // 
            this.prod_category.DataPropertyName = "prod_category";
            this.prod_category.HeaderText = "Categoria";
            this.prod_category.Name = "prod_category";
            this.prod_category.ReadOnly = true;
            this.prod_category.Visible = false;
            // 
            // FormCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormCreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateProduct";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox mtbValue;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.RichTextBox tbComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.ComboBox cbbUn;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_un;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_complement;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
    }
}
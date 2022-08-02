namespace sisVendas.Screens.Create
{
    partial class FormCreateProductCategory
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
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgv_ProductCategory = new System.Windows.Forms.DataGridView();
            this.prod_categoria_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_categoria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_categoria_criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.GbpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductCategory)).BeginInit();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(13, 139);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(353, 57);
            this.GbpPesquisa.TabIndex = 14;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(20, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(327, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgv_ProductCategory
            // 
            this.dgv_ProductCategory.AllowUserToAddRows = false;
            this.dgv_ProductCategory.AllowUserToDeleteRows = false;
            this.dgv_ProductCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_categoria_nome,
            this.prod_categoria_id,
            this.prod_categoria_criado_em});
            this.dgv_ProductCategory.Location = new System.Drawing.Point(13, 202);
            this.dgv_ProductCategory.MultiSelect = false;
            this.dgv_ProductCategory.Name = "dgv_ProductCategory";
            this.dgv_ProductCategory.ReadOnly = true;
            this.dgv_ProductCategory.RowHeadersVisible = false;
            this.dgv_ProductCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductCategory.Size = new System.Drawing.Size(583, 206);
            this.dgv_ProductCategory.TabIndex = 0;
            this.dgv_ProductCategory.DoubleClick += new System.EventHandler(this.dgv_ProductCategory_DoubleClick);
            // 
            // prod_categoria_nome
            // 
            this.prod_categoria_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_categoria_nome.DataPropertyName = "prod_categoria_nome";
            this.prod_categoria_nome.HeaderText = "Nome";
            this.prod_categoria_nome.Name = "prod_categoria_nome";
            this.prod_categoria_nome.ReadOnly = true;
            // 
            // prod_categoria_id
            // 
            this.prod_categoria_id.DataPropertyName = "prod_categoria_id";
            this.prod_categoria_id.HeaderText = "Código";
            this.prod_categoria_id.Name = "prod_categoria_id";
            this.prod_categoria_id.ReadOnly = true;
            this.prod_categoria_id.Visible = false;
            // 
            // prod_categoria_criado_em
            // 
            this.prod_categoria_criado_em.DataPropertyName = "prod_categoria_criado_em";
            this.prod_categoria_criado_em.HeaderText = "CreatedAt";
            this.prod_categoria_criado_em.Name = "prod_categoria_criado_em";
            this.prod_categoria_criado_em.ReadOnly = true;
            this.prod_categoria_criado_em.Visible = false;
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCad.Controls.Add(this.lblName);
            this.gbCad.Controls.Add(this.tableLayoutPanel1);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.tbId);
            this.gbCad.Controls.Add(this.tbName);
            this.gbCad.Location = new System.Drawing.Point(13, 12);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(583, 121);
            this.gbCad.TabIndex = 15;
            this.gbCad.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(93, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "*Categoria:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 35);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(6, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 24);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "[F1] - Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(286, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "[F4] - Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(428, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "[F12] - Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(146, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "[F2] - Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(14, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(14, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(73, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(93, 32);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(484, 20);
            this.tbName.TabIndex = 4;
            // 
            // FormCreateProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 420);
            this.Controls.Add(this.dgv_ProductCategory);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.GbpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(724, 612);
            this.Name = "FormCreateProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Cadastrar categoria de produto";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductCategory)).EndInit();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgv_ProductCategory;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_categoria_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_categoria_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_categoria_criado_em;
    }
}
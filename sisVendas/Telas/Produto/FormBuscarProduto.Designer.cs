namespace sisVendas.Screens.Product
{
    partial class FormBuscarProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearth = new System.Windows.Forms.TextBox();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro:";
            // 
            // tbSearth
            // 
            this.tbSearth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearth.Location = new System.Drawing.Point(16, 40);
            this.tbSearth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(946, 31);
            this.tbSearth.TabIndex = 4;
            this.tbSearth.TextChanged += new System.EventHandler(this.tbSearth_TextChanged);
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
            this.prod_nome,
            this.prod_criado_em,
            this.prod_complemento,
            this.prod_estoque,
            this.prod_marca,
            this.prod_valor,
            this.prod_un,
            this.prod_categoria});
            this.dgv_product.Location = new System.Drawing.Point(16, 83);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgv_product.MultiSelect = false;
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(946, 375);
            this.dgv_product.TabIndex = 6;
            this.dgv_product.DoubleClick += new System.EventHandler(this.dgv_product_DoubleClick);
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "Código";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            // 
            // prod_nome
            // 
            this.prod_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_nome.DataPropertyName = "prod_nome";
            this.prod_nome.HeaderText = "Nome";
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            // 
            // prod_criado_em
            // 
            this.prod_criado_em.DataPropertyName = "prod_criado_em";
            this.prod_criado_em.HeaderText = "Cadastro";
            this.prod_criado_em.Name = "prod_criado_em";
            this.prod_criado_em.ReadOnly = true;
            this.prod_criado_em.Visible = false;
            // 
            // prod_complemento
            // 
            this.prod_complemento.DataPropertyName = "prod_complemento";
            this.prod_complemento.HeaderText = "Complemento";
            this.prod_complemento.Name = "prod_complemento";
            this.prod_complemento.ReadOnly = true;
            this.prod_complemento.Visible = false;
            // 
            // prod_estoque
            // 
            this.prod_estoque.DataPropertyName = "prod_estoque";
            this.prod_estoque.HeaderText = "Estoque";
            this.prod_estoque.Name = "prod_estoque";
            this.prod_estoque.ReadOnly = true;
            // 
            // prod_marca
            // 
            this.prod_marca.DataPropertyName = "prod_marca";
            this.prod_marca.HeaderText = "Marca";
            this.prod_marca.Name = "prod_marca";
            this.prod_marca.ReadOnly = true;
            this.prod_marca.Visible = false;
            // 
            // prod_valor
            // 
            this.prod_valor.DataPropertyName = "prod_valor";
            this.prod_valor.HeaderText = "Valor";
            this.prod_valor.MinimumWidth = 150;
            this.prod_valor.Name = "prod_valor";
            this.prod_valor.ReadOnly = true;
            this.prod_valor.Width = 150;
            // 
            // prod_un
            // 
            this.prod_un.DataPropertyName = "prod_un";
            this.prod_un.HeaderText = "UN";
            this.prod_un.MinimumWidth = 100;
            this.prod_un.Name = "prod_un";
            this.prod_un.ReadOnly = true;
            // 
            // prod_categoria
            // 
            this.prod_categoria.DataPropertyName = "prod_categoria";
            this.prod_categoria.HeaderText = "Categoria";
            this.prod_categoria.Name = "prod_categoria";
            this.prod_categoria.ReadOnly = true;
            this.prod_categoria.Visible = false;
            // 
            // FormBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 473);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormBuscarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_criado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_un;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_categoria;
    }
}
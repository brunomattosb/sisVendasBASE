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
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_complement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro:";
            // 
            // tbSearth
            // 
            this.tbSearth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearth.Location = new System.Drawing.Point(178, 25);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(391, 20);
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
            this.prod_name,
            this.prod_created_at,
            this.prod_complement,
            this.prod_inventory,
            this.prod_brand,
            this.prod_value,
            this.prod_category});
            this.dgv_product.Location = new System.Drawing.Point(12, 51);
            this.dgv_product.MultiSelect = false;
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(776, 387);
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
            // FormSearthProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Name = "FormSearthProduct";
            this.Text = "FormSearthProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_complement;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
    }
}
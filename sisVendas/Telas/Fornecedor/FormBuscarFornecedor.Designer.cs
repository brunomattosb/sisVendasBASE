namespace sisVendas.Telas.Fornecedor
{
    partial class FormBuscarFornecedor
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
            this.tbSearth = new System.Windows.Forms.TextBox();
            this.dgv_fornecedor = new System.Windows.Forms.DataGridView();
            this.prov_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_fantazy_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearth
            // 
            this.tbSearth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearth.Location = new System.Drawing.Point(12, 35);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(391, 20);
            this.tbSearth.TabIndex = 4;
            this.tbSearth.TextChanged += new System.EventHandler(this.tbSearth_TextChanged);
            // 
            // dgv_fornecedor
            // 
            this.dgv_fornecedor.AllowUserToAddRows = false;
            this.dgv_fornecedor.AllowUserToDeleteRows = false;
            this.dgv_fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prov_id,
            this.prov_cpf_cnpj,
            this.prov_name,
            this.prov_fantazy_name});
            this.dgv_fornecedor.Location = new System.Drawing.Point(12, 61);
            this.dgv_fornecedor.MultiSelect = false;
            this.dgv_fornecedor.Name = "dgv_fornecedor";
            this.dgv_fornecedor.ReadOnly = true;
            this.dgv_fornecedor.RowHeadersVisible = false;
            this.dgv_fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fornecedor.Size = new System.Drawing.Size(776, 373);
            this.dgv_fornecedor.TabIndex = 5;
            this.dgv_fornecedor.DoubleClick += new System.EventHandler(this.dgv_fornecedor_DoubleClick);
            // 
            // prov_id
            // 
            this.prov_id.DataPropertyName = "forn_id";
            this.prov_id.HeaderText = "ID";
            this.prov_id.MinimumWidth = 50;
            this.prov_id.Name = "prov_id";
            this.prov_id.ReadOnly = true;
            this.prov_id.Width = 50;
            // 
            // prov_cpf_cnpj
            // 
            this.prov_cpf_cnpj.DataPropertyName = "forn_cpf_cnpj";
            this.prov_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.prov_cpf_cnpj.MinimumWidth = 150;
            this.prov_cpf_cnpj.Name = "prov_cpf_cnpj";
            this.prov_cpf_cnpj.ReadOnly = true;
            this.prov_cpf_cnpj.Width = 150;
            // 
            // prov_name
            // 
            this.prov_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prov_name.DataPropertyName = "forn_nome";
            this.prov_name.HeaderText = "Nome";
            this.prov_name.Name = "prov_name";
            this.prov_name.ReadOnly = true;
            // 
            // prov_fantazy_name
            // 
            this.prov_fantazy_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prov_fantazy_name.DataPropertyName = "forn_nome_fantasia";
            this.prov_fantazy_name.HeaderText = "Nome Fantasia";
            this.prov_fantazy_name.Name = "prov_fantazy_name";
            this.prov_fantazy_name.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro:";
            // 
            // FormBuscarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Controls.Add(this.dgv_fornecedor);
            this.Name = "FormBuscarFornecedor";
            this.Text = "Buscar Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.DataGridView dgv_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_fantazy_name;
        private System.Windows.Forms.Label label1;
    }
}
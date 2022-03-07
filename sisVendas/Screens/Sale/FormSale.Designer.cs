namespace sisVendas.Screens.Sale
{
    partial class gbProduto
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
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelTitleVendas = new System.Windows.Forms.Panel();
            this.timer_sale = new System.Windows.Forms.Timer(this.components);
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearth = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_complement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitleVendas.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(27, 39);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = ".";
            // 
            // panelTitleVendas
            // 
            this.panelTitleVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(152)))));
            this.panelTitleVendas.Controls.Add(this.lblDate);
            this.panelTitleVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleVendas.Location = new System.Drawing.Point(0, 0);
            this.panelTitleVendas.Name = "panelTitleVendas";
            this.panelTitleVendas.Size = new System.Drawing.Size(1008, 93);
            this.panelTitleVendas.TabIndex = 2;
            // 
            // timer_sale
            // 
            this.timer_sale.Enabled = true;
            this.timer_sale.Interval = 1000;
            this.timer_sale.Tick += new System.EventHandler(this.timer_sale_Tick);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbName);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.mtbCpf);
            this.gbCliente.Controls.Add(this.lblCpf);
            this.gbCliente.Location = new System.Drawing.Point(12, 99);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(447, 75);
            this.gbCliente.TabIndex = 3;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 42);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(316, 20);
            this.tbName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(7, 42);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(112, 20);
            this.mtbCpf.TabIndex = 3;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(5, 28);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "*CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSearth);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 431);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 80);
            this.textBox3.MaxLength = 49;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Quantidade:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 35);
            this.textBox2.MaxLength = 49;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 20);
            this.textBox2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Produto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.MaxLength = 49;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Buscar:";
            // 
            // tbSearth
            // 
            this.tbSearth.Location = new System.Drawing.Point(59, 122);
            this.tbSearth.MaxLength = 49;
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(308, 20);
            this.tbSearth.TabIndex = 44;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_product, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 277);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.prod_name,
            this.prod_id,
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
            this.dgv_product.Size = new System.Drawing.Size(429, 271);
            this.dgv_product.TabIndex = 1;
            // 
            // prod_name
            // 
            this.prod_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_name.DataPropertyName = "prod_name";
            this.prod_name.HeaderText = "Nome";
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "Código";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Visible = false;
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
            this.prod_inventory.Visible = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.panelTitleVendas);
            this.Name = "gbProduto";
            this.Text = "Sale";
            this.panelTitleVendas.ResumeLayout(false);
            this.panelTitleVendas.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelTitleVendas;
        private System.Windows.Forms.Timer timer_sale;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_complement;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
    }
}
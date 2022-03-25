namespace sisVendas.Screens.Sale
{
    partial class FormInserirParcelas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbTotalOffset = new System.Windows.Forms.TextBox();
            this.tbSubtotalOffset = new System.Windows.Forms.TextBox();
            this.lblSubtotalOffset = new System.Windows.Forms.Label();
            this.lblTotalOffset = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.mtbData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTipo);
            this.groupBox1.Controls.Add(this.dgvParcelas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Controls.Add(this.tbTotalOffset);
            this.groupBox2.Controls.Add(this.tbSubtotalOffset);
            this.groupBox2.Controls.Add(this.lblSubtotalOffset);
            this.groupBox2.Controls.Add(this.lblTotalOffset);
            this.groupBox2.Location = new System.Drawing.Point(463, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Cobrado:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(34, 48);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(76, 42);
            this.lblValor.TabIndex = 59;
            this.lblValor.Text = "R$ ";
            // 
            // tbTotalOffset
            // 
            this.tbTotalOffset.Enabled = false;
            this.tbTotalOffset.Location = new System.Drawing.Point(78, 159);
            this.tbTotalOffset.Name = "tbTotalOffset";
            this.tbTotalOffset.Size = new System.Drawing.Size(187, 31);
            this.tbTotalOffset.TabIndex = 70;
            // 
            // tbSubtotalOffset
            // 
            this.tbSubtotalOffset.Enabled = false;
            this.tbSubtotalOffset.Location = new System.Drawing.Point(78, 222);
            this.tbSubtotalOffset.Name = "tbSubtotalOffset";
            this.tbSubtotalOffset.Size = new System.Drawing.Size(187, 31);
            this.tbSubtotalOffset.TabIndex = 71;
            // 
            // lblSubtotalOffset
            // 
            this.lblSubtotalOffset.AutoSize = true;
            this.lblSubtotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalOffset.Location = new System.Drawing.Point(78, 199);
            this.lblSubtotalOffset.Name = "lblSubtotalOffset";
            this.lblSubtotalOffset.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotalOffset.TabIndex = 69;
            this.lblSubtotalOffset.Text = "Subtotal:";
            // 
            // lblTotalOffset
            // 
            this.lblTotalOffset.AutoSize = true;
            this.lblTotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOffset.Location = new System.Drawing.Point(75, 136);
            this.lblTotalOffset.Name = "lblTotalOffset";
            this.lblTotalOffset.Size = new System.Drawing.Size(89, 20);
            this.lblTotalOffset.TabIndex = 67;
            this.lblTotalOffset.Text = "Total Pago:";
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(688, 452);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(109, 34);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(698, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 62);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Enabled = false;
            this.lblData.Location = new System.Drawing.Point(235, 191);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 25);
            this.lblData.TabIndex = 66;
            this.lblData.Text = "Data:";
            // 
            // mtbData
            // 
            this.mtbData.Enabled = false;
            this.mtbData.Location = new System.Drawing.Point(240, 217);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(138, 31);
            this.mtbData.TabIndex = 3;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.Click += new System.EventHandler(this.mtbData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tipo:";
            // 
            // cbbTipo
            // 
            this.cbbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "Fiado"});
            this.cbbTipo.Location = new System.Drawing.Point(240, 127);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(138, 33);
            this.cbbTipo.TabIndex = 2;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.cbbTipo_SelectedIndexChanged);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.status,
            this.idVenda,
            this.tipo_pagamento,
            this.data});
            this.dgvParcelas.Location = new System.Drawing.Point(12, 329);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(664, 184);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.DoubleClick += new System.EventHandler(this.dgvParcelas_DoubleClick);
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // idVenda
            // 
            this.idVenda.DataPropertyName = "idVenda";
            this.idVenda.HeaderText = "idVenda";
            this.idVenda.Name = "idVenda";
            this.idVenda.ReadOnly = true;
            this.idVenda.Visible = false;
            // 
            // tipo_pagamento
            // 
            this.tipo_pagamento.DataPropertyName = "tipo_pagamento";
            this.tipo_pagamento.HeaderText = "Tipo";
            this.tipo_pagamento.MinimumWidth = 150;
            this.tipo_pagamento.Name = "tipo_pagamento";
            this.tipo_pagamento.ReadOnly = true;
            this.tipo_pagamento.Width = 150;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 200;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Valor:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(77, 127);
            this.tbValor.MaxLength = 9;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(138, 31);
            this.tbValor.TabIndex = 1;
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // FormInserirParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 543);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInserirParcelas";
            this.Text = "FormSimulateSale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox tbSubtotalOffset;
        private System.Windows.Forms.Label lblTotalOffset;
        private System.Windows.Forms.TextBox tbTotalOffset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSubtotalOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
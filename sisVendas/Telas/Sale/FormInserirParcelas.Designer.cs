﻿namespace sisVendas.Screens.Sale
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
            this.gbFormPrincipal = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbTotalOffset = new System.Windows.Forms.TextBox();
            this.tbSubtotalOffset = new System.Windows.Forms.TextBox();
            this.lblSubtotalOffset = new System.Windows.Forms.Label();
            this.lblTotalOffset = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
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
            this.gbFormPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFormPrincipal
            // 
            this.gbFormPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFormPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.gbFormPrincipal.Controls.Add(this.lblSaldo);
            this.gbFormPrincipal.Controls.Add(this.label3);
            this.gbFormPrincipal.Controls.Add(this.dtpData);
            this.gbFormPrincipal.Controls.Add(this.groupBox2);
            this.gbFormPrincipal.Controls.Add(this.btnRemover);
            this.gbFormPrincipal.Controls.Add(this.btnAdd);
            this.gbFormPrincipal.Controls.Add(this.lblData);
            this.gbFormPrincipal.Controls.Add(this.label2);
            this.gbFormPrincipal.Controls.Add(this.cbbTipo);
            this.gbFormPrincipal.Controls.Add(this.dgvParcelas);
            this.gbFormPrincipal.Controls.Add(this.label1);
            this.gbFormPrincipal.Controls.Add(this.tbValor);
            this.gbFormPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbFormPrincipal.Name = "gbFormPrincipal";
            this.gbFormPrincipal.Size = new System.Drawing.Size(642, 467);
            this.gbFormPrincipal.TabIndex = 0;
            this.gbFormPrincipal.TabStop = false;
            this.gbFormPrincipal.Text = "Venda";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(521, 70);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(87, 25);
            this.lblSaldo.TabIndex = 69;
            this.lblSaldo.Text = "R$ 0,00";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Saldo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(341, 64);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(165, 31);
            this.dtpData.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Controls.Add(this.tbTotalOffset);
            this.groupBox2.Controls.Add(this.tbSubtotalOffset);
            this.groupBox2.Controls.Add(this.lblSubtotalOffset);
            this.groupBox2.Controls.Add(this.lblTotalOffset);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 171);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Cobrado:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(186, 35);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(76, 42);
            this.lblValor.TabIndex = 59;
            this.lblValor.Text = "R$ ";
            // 
            // tbTotalOffset
            // 
            this.tbTotalOffset.Enabled = false;
            this.tbTotalOffset.Location = new System.Drawing.Point(8, 121);
            this.tbTotalOffset.Name = "tbTotalOffset";
            this.tbTotalOffset.Size = new System.Drawing.Size(179, 31);
            this.tbTotalOffset.TabIndex = 0;
            this.tbTotalOffset.Text = "R$ 0,00";
            // 
            // tbSubtotalOffset
            // 
            this.tbSubtotalOffset.Enabled = false;
            this.tbSubtotalOffset.Location = new System.Drawing.Point(292, 121);
            this.tbSubtotalOffset.Name = "tbSubtotalOffset";
            this.tbSubtotalOffset.Size = new System.Drawing.Size(178, 31);
            this.tbSubtotalOffset.TabIndex = 1;
            this.tbSubtotalOffset.Text = "R$ 0,00";
            // 
            // lblSubtotalOffset
            // 
            this.lblSubtotalOffset.AutoSize = true;
            this.lblSubtotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalOffset.Location = new System.Drawing.Point(288, 98);
            this.lblSubtotalOffset.Name = "lblSubtotalOffset";
            this.lblSubtotalOffset.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotalOffset.TabIndex = 69;
            this.lblSubtotalOffset.Text = "Subtotal:";
            // 
            // lblTotalOffset
            // 
            this.lblTotalOffset.AutoSize = true;
            this.lblTotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOffset.Location = new System.Drawing.Point(4, 98);
            this.lblTotalOffset.Name = "lblTotalOffset";
            this.lblTotalOffset.Size = new System.Drawing.Size(89, 20);
            this.lblTotalOffset.TabIndex = 67;
            this.lblTotalOffset.Text = "Total Pago:";
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(511, 219);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 34);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 62);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Enabled = false;
            this.lblData.Location = new System.Drawing.Point(336, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(131, 25);
            this.lblData.TabIndex = 66;
            this.lblData.Text = "Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 36);
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
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "Fiado"});
            this.cbbTipo.Location = new System.Drawing.Point(172, 62);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(154, 33);
            this.cbbTipo.TabIndex = 1;
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
            this.dgvParcelas.Location = new System.Drawing.Point(6, 278);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(630, 183);
            this.dgvParcelas.TabIndex = 5;
            this.dgvParcelas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParcelas_CellEnter);
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
            this.data.HeaderText = "Vencimento";
            this.data.MinimumWidth = 200;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Valor:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(12, 64);
            this.tbValor.MaxLength = 9;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(145, 31);
            this.tbValor.TabIndex = 0;
            this.tbValor.Text = "R$ 0,00";
            this.tbValor.Enter += new System.EventHandler(this.tbValor_Enter);
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // FormInserirParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 491);
            this.Controls.Add(this.gbFormPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormInserirParcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Lançar parcelas na venda";
            this.gbFormPrincipal.ResumeLayout(false);
            this.gbFormPrincipal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox tbSubtotalOffset;
        private System.Windows.Forms.Label lblTotalOffset;
        private System.Windows.Forms.TextBox tbTotalOffset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSubtotalOffset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label3;
    }
}
namespace sisVendas.Telas.Compra
{
    partial class FormBuscarCompra
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cbbMN = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_compra = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbPesquisarPorPeriodo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.cbbMN);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1186, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(886, 144);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 37);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(968, 63);
            this.tbValor.Margin = new System.Windows.Forms.Padding(6);
            this.tbValor.MaxLength = 10;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(134, 31);
            this.tbValor.TabIndex = 56;
            this.tbValor.Text = "R$ 0,00";
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(963, 35);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(68, 25);
            this.lblSaldo.TabIndex = 57;
            this.lblSaldo.Text = "Valor:";
            // 
            // cbbMN
            // 
            this.cbbMN.FormattingEnabled = true;
            this.cbbMN.Items.AddRange(new object[] {
            "=",
            ">=",
            "<="});
            this.cbbMN.Location = new System.Drawing.Point(825, 63);
            this.cbbMN.Margin = new System.Windows.Forms.Padding(6);
            this.cbbMN.Name = "cbbMN";
            this.cbbMN.Size = new System.Drawing.Size(112, 33);
            this.cbbMN.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisarPorPeriodo);
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNascimento);
            this.groupBox2.Location = new System.Drawing.Point(371, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 126);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(176, 89);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(154, 31);
            this.dtpFim.TabIndex = 57;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(9, 89);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(154, 31);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(4, 61);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(68, 25);
            this.lblNascimento.TabIndex = 48;
            this.lblNascimento.Text = "Inicio:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 150);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(686, 31);
            this.tbName.TabIndex = 46;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(15, 63);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(6);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(220, 31);
            this.mtbCpf.TabIndex = 44;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(11, 36);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(60, 25);
            this.lblCpf.TabIndex = 45;
            this.lblCpf.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fornecedor:";
            // 
            // dgv_compra
            // 
            this.dgv_compra.AllowUserToAddRows = false;
            this.dgv_compra.AllowUserToDeleteRows = false;
            this.dgv_compra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idCaixa,
            this.cpf_cnpj,
            this.nome,
            this.total,
            this.desconto,
            this.criado_em,
            this.venda_cancelada});
            this.dgv_compra.Location = new System.Drawing.Point(17, 249);
            this.dgv_compra.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_compra.MultiSelect = false;
            this.dgv_compra.Name = "dgv_compra";
            this.dgv_compra.ReadOnly = true;
            this.dgv_compra.RowHeadersVisible = false;
            this.dgv_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_compra.Size = new System.Drawing.Size(1186, 536);
            this.dgv_compra.TabIndex = 8;
            this.dgv_compra.DoubleClick += new System.EventHandler(this.dgv_venda_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 120;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 120;
            // 
            // idCaixa
            // 
            this.idCaixa.DataPropertyName = "idCaixa";
            this.idCaixa.HeaderText = "idCaixa";
            this.idCaixa.Name = "idCaixa";
            this.idCaixa.ReadOnly = true;
            this.idCaixa.Visible = false;
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.DataPropertyName = "cpf_cnpj";
            this.cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cpf_cnpj.MinimumWidth = 200;
            this.cpf_cnpj.Name = "cpf_cnpj";
            this.cpf_cnpj.ReadOnly = true;
            this.cpf_cnpj.Width = 200;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 200;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // desconto
            // 
            this.desconto.DataPropertyName = "desconto";
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 150;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 150;
            // 
            // criado_em
            // 
            this.criado_em.DataPropertyName = "criado_em";
            this.criado_em.HeaderText = "Data";
            this.criado_em.MinimumWidth = 200;
            this.criado_em.Name = "criado_em";
            this.criado_em.ReadOnly = true;
            this.criado_em.Width = 200;
            // 
            // venda_cancelada
            // 
            this.venda_cancelada.DataPropertyName = "venda_cancelada";
            this.venda_cancelada.HeaderText = "Cancelada";
            this.venda_cancelada.MinimumWidth = 150;
            this.venda_cancelada.Name = "venda_cancelada";
            this.venda_cancelada.ReadOnly = true;
            this.venda_cancelada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.venda_cancelada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.venda_cancelada.Width = 150;
            // 
            // cbPesquisarPorPeriodo
            // 
            this.cbPesquisarPorPeriodo.AutoSize = true;
            this.cbPesquisarPorPeriodo.Location = new System.Drawing.Point(26, 30);
            this.cbPesquisarPorPeriodo.Name = "cbPesquisarPorPeriodo";
            this.cbPesquisarPorPeriodo.Size = new System.Drawing.Size(246, 29);
            this.cbPesquisarPorPeriodo.TabIndex = 58;
            this.cbPesquisarPorPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // FormBuscarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 817);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_compra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBuscarCompra";
            this.Text = "FormBuscarCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cbbMN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_compra;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn criado_em;
        private System.Windows.Forms.DataGridViewCheckBoxColumn venda_cancelada;
        private System.Windows.Forms.CheckBox cbPesquisarPorPeriodo;
    }
}
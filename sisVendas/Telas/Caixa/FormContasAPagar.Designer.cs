namespace sisVendas.Telas.Caixa
{
    partial class FormContasAPagar
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
            this.dgv_despesas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbDespesas = new System.Windows.Forms.CheckBox();
            this.cbParcelasCompra = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbQuitada = new System.Windows.Forms.CheckBox();
            this.cbAberto = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPesquisarPorPeriodo = new System.Windows.Forms.CheckBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbFornNome = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_despesas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_despesas
            // 
            this.dgv_despesas.AllowUserToAddRows = false;
            this.dgv_despesas.AllowUserToDeleteRows = false;
            this.dgv_despesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_despesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_despesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dtPagamento,
            this.dtVencimento,
            this.formaPagamento,
            this.caixaId,
            this.valor,
            this.idVenda,
            this.descricao});
            this.dgv_despesas.Location = new System.Drawing.Point(13, 233);
            this.dgv_despesas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_despesas.MultiSelect = false;
            this.dgv_despesas.Name = "dgv_despesas";
            this.dgv_despesas.ReadOnly = true;
            this.dgv_despesas.RowHeadersVisible = false;
            this.dgv_despesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_despesas.Size = new System.Drawing.Size(674, 244);
            this.dgv_despesas.TabIndex = 10;
            this.dgv_despesas.DoubleClick += new System.EventHandler(this.dgv_despesas_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dtPagamento
            // 
            this.dtPagamento.DataPropertyName = "dtPagamento";
            this.dtPagamento.HeaderText = "Pagamento";
            this.dtPagamento.MinimumWidth = 120;
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.ReadOnly = true;
            this.dtPagamento.Width = 120;
            // 
            // dtVencimento
            // 
            this.dtVencimento.DataPropertyName = "dtVencimento";
            this.dtVencimento.HeaderText = "Vencimento";
            this.dtVencimento.MinimumWidth = 120;
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.ReadOnly = true;
            this.dtVencimento.Width = 120;
            // 
            // formaPagamento
            // 
            this.formaPagamento.DataPropertyName = "formaPagamento";
            this.formaPagamento.HeaderText = "Forma Pgto";
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.ReadOnly = true;
            // 
            // caixaId
            // 
            this.caixaId.DataPropertyName = "caixaId";
            this.caixaId.HeaderText = "caixaId";
            this.caixaId.Name = "caixaId";
            this.caixaId.ReadOnly = true;
            this.caixaId.Visible = false;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 150;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 150;
            // 
            // idVenda
            // 
            this.idVenda.DataPropertyName = "idVenda";
            this.idVenda.HeaderText = "idVenda";
            this.idVenda.Name = "idVenda";
            this.idVenda.ReadOnly = true;
            this.idVenda.Visible = false;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarRelatorio);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbFornNome);
            this.groupBox1.Controls.Add(this.lblFornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(674, 201);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(539, 154);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(125, 35);
            this.btnGerarRelatorio.TabIndex = 64;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbDespesas);
            this.groupBox4.Controls.Add(this.cbParcelasCompra);
            this.groupBox4.Location = new System.Drawing.Point(7, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 111);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exibir: ";
            // 
            // cbDespesas
            // 
            this.cbDespesas.AutoSize = true;
            this.cbDespesas.Location = new System.Drawing.Point(8, 54);
            this.cbDespesas.Name = "cbDespesas";
            this.cbDespesas.Size = new System.Drawing.Size(94, 22);
            this.cbDespesas.TabIndex = 62;
            this.cbDespesas.Text = "Despesas";
            this.cbDespesas.UseVisualStyleBackColor = true;
            this.cbDespesas.Click += new System.EventHandler(this.cbDespesas_Click);
            // 
            // cbParcelasCompra
            // 
            this.cbParcelasCompra.AutoSize = true;
            this.cbParcelasCompra.Checked = true;
            this.cbParcelasCompra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbParcelasCompra.Location = new System.Drawing.Point(8, 26);
            this.cbParcelasCompra.Name = "cbParcelasCompra";
            this.cbParcelasCompra.Size = new System.Drawing.Size(143, 22);
            this.cbParcelasCompra.TabIndex = 61;
            this.cbParcelasCompra.Text = "Parcelas Compra";
            this.cbParcelasCompra.UseVisualStyleBackColor = true;
            this.cbParcelasCompra.Click += new System.EventHandler(this.cbParcelasCompra_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbQuitada);
            this.groupBox3.Controls.Add(this.cbAberto);
            this.groupBox3.Location = new System.Drawing.Point(536, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 76);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // cbQuitada
            // 
            this.cbQuitada.AutoSize = true;
            this.cbQuitada.Location = new System.Drawing.Point(20, 51);
            this.cbQuitada.Name = "cbQuitada";
            this.cbQuitada.Size = new System.Drawing.Size(86, 22);
            this.cbQuitada.TabIndex = 62;
            this.cbQuitada.Text = "Quitadas";
            this.cbQuitada.UseVisualStyleBackColor = true;
            // 
            // cbAberto
            // 
            this.cbAberto.AutoSize = true;
            this.cbAberto.Checked = true;
            this.cbAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAberto.Location = new System.Drawing.Point(20, 26);
            this.cbAberto.Name = "cbAberto";
            this.cbAberto.Size = new System.Drawing.Size(97, 22);
            this.cbAberto.TabIndex = 61;
            this.cbAberto.Text = "Em Aberto";
            this.cbAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisarPorPeriodo);
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(211, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 112);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vencimento";
            // 
            // cbPesquisarPorPeriodo
            // 
            this.cbPesquisarPorPeriodo.AutoSize = true;
            this.cbPesquisarPorPeriodo.Location = new System.Drawing.Point(19, 26);
            this.cbPesquisarPorPeriodo.Name = "cbPesquisarPorPeriodo";
            this.cbPesquisarPorPeriodo.Size = new System.Drawing.Size(177, 22);
            this.cbPesquisarPorPeriodo.TabIndex = 57;
            this.cbPesquisarPorPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(170, 72);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 24);
            this.dtpFim.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(19, 72);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 24);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Inicio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(539, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 35);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbFornNome
            // 
            this.tbFornNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFornNome.Location = new System.Drawing.Point(8, 165);
            this.tbFornNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbFornNome.MaxLength = 49;
            this.tbFornNome.Name = "tbFornNome";
            this.tbFornNome.Size = new System.Drawing.Size(484, 24);
            this.tbFornNome.TabIndex = 46;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(8, 143);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(89, 18);
            this.lblFornecedor.TabIndex = 49;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // FormContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 490);
            this.Controls.Add(this.dgv_despesas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormContasAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Contas a pagar";
            this.Load += new System.EventHandler(this.FormContasAPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_despesas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_despesas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbDespesas;
        private System.Windows.Forms.CheckBox cbParcelasCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbQuitada;
        private System.Windows.Forms.CheckBox cbAberto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbFornNome;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.CheckBox cbPesquisarPorPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}
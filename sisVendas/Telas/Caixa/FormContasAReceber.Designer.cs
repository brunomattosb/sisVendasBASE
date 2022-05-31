namespace sisVendas.Telas.Caixa
{
    partial class FormContasAReceber
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_cancelada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_idcaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_idVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(20, 136);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(475, 24);
            this.tbName.TabIndex = 46;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(20, 87);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(166, 24);
            this.mtbCpf.TabIndex = 44;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.TextChanged += new System.EventHandler(this.mtbCpf_TextChanged);
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(20, 65);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 18);
            this.lblCpf.TabIndex = 45;
            this.lblCpf.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nome:";
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_nome,
            this.parcela_id,
            this.cli_cpf_cnpj,
            this.venda_criado_em,
            this.parcela_valor,
            this.parcela_dataPagamento,
            this.parcela_dataVencimento,
            this.venda_cancelada,
            this.parcela_idcaixa,
            this.parcela_idVenda,
            this.parcela_tipo});
            this.dgv_parcelas.Location = new System.Drawing.Point(13, 195);
            this.dgv_parcelas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_parcelas.MultiSelect = false;
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.ReadOnly = true;
            this.dgv_parcelas.RowHeadersVisible = false;
            this.dgv_parcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_parcelas.Size = new System.Drawing.Size(900, 346);
            this.dgv_parcelas.TabIndex = 8;
            this.dgv_parcelas.DoubleClick += new System.EventHandler(this.dgv_parcelas_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarRelatorio);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(900, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbQuitada);
            this.groupBox3.Controls.Add(this.cbAberto);
            this.groupBox3.Location = new System.Drawing.Point(538, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 108);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // cbQuitada
            // 
            this.cbQuitada.AutoSize = true;
            this.cbQuitada.Location = new System.Drawing.Point(23, 66);
            this.cbQuitada.Name = "cbQuitada";
            this.cbQuitada.Size = new System.Drawing.Size(86, 22);
            this.cbQuitada.TabIndex = 62;
            this.cbQuitada.Text = "Quitadas";
            this.cbQuitada.UseVisualStyleBackColor = true;
            // 
            // cbAberto
            // 
            this.cbAberto.AutoSize = true;
            this.cbAberto.Location = new System.Drawing.Point(23, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(209, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 108);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data da Venda";
            // 
            // cbPesquisarPorPeriodo
            // 
            this.cbPesquisarPorPeriodo.AutoSize = true;
            this.cbPesquisarPorPeriodo.Location = new System.Drawing.Point(24, 23);
            this.cbPesquisarPorPeriodo.Name = "cbPesquisarPorPeriodo";
            this.cbPesquisarPorPeriodo.Size = new System.Drawing.Size(177, 22);
            this.cbPesquisarPorPeriodo.TabIndex = 57;
            this.cbPesquisarPorPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(175, 71);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 24);
            this.dtpFim.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(24, 71);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 24);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Inicio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(737, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 35);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(737, 81);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(125, 35);
            this.btnGerarRelatorio.TabIndex = 63;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Nome";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            // 
            // parcela_id
            // 
            this.parcela_id.DataPropertyName = "parcela_id";
            this.parcela_id.HeaderText = "ID";
            this.parcela_id.Name = "parcela_id";
            this.parcela_id.ReadOnly = true;
            this.parcela_id.Visible = false;
            // 
            // cli_cpf_cnpj
            // 
            this.cli_cpf_cnpj.DataPropertyName = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cli_cpf_cnpj.MinimumWidth = 150;
            this.cli_cpf_cnpj.Name = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.ReadOnly = true;
            this.cli_cpf_cnpj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_cpf_cnpj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cli_cpf_cnpj.Width = 150;
            // 
            // venda_criado_em
            // 
            this.venda_criado_em.DataPropertyName = "venda_criado_em";
            this.venda_criado_em.HeaderText = "Data Venda";
            this.venda_criado_em.MinimumWidth = 150;
            this.venda_criado_em.Name = "venda_criado_em";
            this.venda_criado_em.ReadOnly = true;
            this.venda_criado_em.Width = 150;
            // 
            // parcela_valor
            // 
            this.parcela_valor.DataPropertyName = "parcela_valor";
            this.parcela_valor.HeaderText = "Valor";
            this.parcela_valor.MinimumWidth = 150;
            this.parcela_valor.Name = "parcela_valor";
            this.parcela_valor.ReadOnly = true;
            this.parcela_valor.Width = 150;
            // 
            // parcela_dataPagamento
            // 
            this.parcela_dataPagamento.DataPropertyName = "parcela_dataPagamento";
            this.parcela_dataPagamento.HeaderText = "Data Pagamento";
            this.parcela_dataPagamento.MinimumWidth = 150;
            this.parcela_dataPagamento.Name = "parcela_dataPagamento";
            this.parcela_dataPagamento.ReadOnly = true;
            this.parcela_dataPagamento.Width = 150;
            // 
            // parcela_dataVencimento
            // 
            this.parcela_dataVencimento.DataPropertyName = "parcela_dataVencimento";
            this.parcela_dataVencimento.HeaderText = "Data Vencimento";
            this.parcela_dataVencimento.Name = "parcela_dataVencimento";
            this.parcela_dataVencimento.ReadOnly = true;
            // 
            // venda_cancelada
            // 
            this.venda_cancelada.DataPropertyName = "venda_cancelada";
            this.venda_cancelada.HeaderText = "venda_cancelada";
            this.venda_cancelada.Name = "venda_cancelada";
            this.venda_cancelada.ReadOnly = true;
            this.venda_cancelada.Visible = false;
            // 
            // parcela_idcaixa
            // 
            this.parcela_idcaixa.DataPropertyName = "parcela_idcaixa";
            this.parcela_idcaixa.HeaderText = "idCaixa";
            this.parcela_idcaixa.Name = "parcela_idcaixa";
            this.parcela_idcaixa.ReadOnly = true;
            this.parcela_idcaixa.Visible = false;
            // 
            // parcela_idVenda
            // 
            this.parcela_idVenda.DataPropertyName = "parcela_idVenda";
            this.parcela_idVenda.HeaderText = "idVenda";
            this.parcela_idVenda.Name = "parcela_idVenda";
            this.parcela_idVenda.ReadOnly = true;
            this.parcela_idVenda.Visible = false;
            // 
            // parcela_tipo
            // 
            this.parcela_tipo.DataPropertyName = "parcela_tipo";
            this.parcela_tipo.HeaderText = "Forma Pgmto";
            this.parcela_tipo.Name = "parcela_tipo";
            this.parcela_tipo.ReadOnly = true;
            // 
            // FormContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 554);
            this.Controls.Add(this.dgv_parcelas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAberto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbQuitada;
        private System.Windows.Forms.CheckBox cbPesquisarPorPeriodo;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_criado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn venda_cancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_idcaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_idVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_tipo;
    }
}
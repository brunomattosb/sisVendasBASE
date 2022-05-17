namespace sisVendas.Telas.Caixa
{
    partial class FormLancarDespesas
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_despesa = new System.Windows.Forms.DataGridView();
            this.desp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_idCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_dataReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTiposDespesas = new System.Windows.Forms.ComboBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.gbCod = new System.Windows.Forms.GroupBox();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.cbbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.lblPagamentoReferencia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescFiltro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbFiltroEmAberto = new System.Windows.Forms.CheckBox();
            this.cbbFiltroPago = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.cbCaixaAtual = new System.Windows.Forms.CheckBox();
            this.cbPesquisarPorPeriodo = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_despesa)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_despesa, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 475);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 252);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // dgv_despesa
            // 
            this.dgv_despesa.AllowUserToAddRows = false;
            this.dgv_despesa.AllowUserToDeleteRows = false;
            this.dgv_despesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_despesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_despesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desp_id,
            this.desp_idTipo,
            this.desp_descricao,
            this.desp_valor,
            this.desp_idCaixa,
            this.desp_desconto,
            this.desp_dataReferencia,
            this.desp_formaPagamento,
            this.desp_status,
            this.desp_dataPagamento});
            this.dgv_despesa.Location = new System.Drawing.Point(3, 3);
            this.dgv_despesa.MultiSelect = false;
            this.dgv_despesa.Name = "dgv_despesa";
            this.dgv_despesa.ReadOnly = true;
            this.dgv_despesa.RowHeadersVisible = false;
            this.dgv_despesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_despesa.Size = new System.Drawing.Size(750, 246);
            this.dgv_despesa.TabIndex = 3;
            this.dgv_despesa.DoubleClick += new System.EventHandler(this.dgv_despesa_DoubleClick);
            // 
            // desp_id
            // 
            this.desp_id.DataPropertyName = "desp_id";
            this.desp_id.HeaderText = "Id";
            this.desp_id.Name = "desp_id";
            this.desp_id.ReadOnly = true;
            this.desp_id.Visible = false;
            // 
            // desp_idTipo
            // 
            this.desp_idTipo.DataPropertyName = "desp_idTipo";
            this.desp_idTipo.HeaderText = "desp_idTipo";
            this.desp_idTipo.Name = "desp_idTipo";
            this.desp_idTipo.ReadOnly = true;
            this.desp_idTipo.Visible = false;
            // 
            // desp_descricao
            // 
            this.desp_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desp_descricao.DataPropertyName = "desp_descricao";
            this.desp_descricao.HeaderText = "Descrição";
            this.desp_descricao.Name = "desp_descricao";
            this.desp_descricao.ReadOnly = true;
            // 
            // desp_valor
            // 
            this.desp_valor.DataPropertyName = "desp_valor";
            this.desp_valor.HeaderText = "Valor";
            this.desp_valor.MinimumWidth = 100;
            this.desp_valor.Name = "desp_valor";
            this.desp_valor.ReadOnly = true;
            // 
            // desp_idCaixa
            // 
            this.desp_idCaixa.DataPropertyName = "desp_idCaixa";
            this.desp_idCaixa.HeaderText = "desp_idCaixa";
            this.desp_idCaixa.Name = "desp_idCaixa";
            this.desp_idCaixa.ReadOnly = true;
            this.desp_idCaixa.Visible = false;
            // 
            // desp_desconto
            // 
            this.desp_desconto.DataPropertyName = "desp_desconto";
            this.desp_desconto.HeaderText = "Desconto";
            this.desp_desconto.MinimumWidth = 100;
            this.desp_desconto.Name = "desp_desconto";
            this.desp_desconto.ReadOnly = true;
            // 
            // desp_dataReferencia
            // 
            this.desp_dataReferencia.DataPropertyName = "desp_dataReferencia";
            this.desp_dataReferencia.HeaderText = "Data Ref";
            this.desp_dataReferencia.MinimumWidth = 200;
            this.desp_dataReferencia.Name = "desp_dataReferencia";
            this.desp_dataReferencia.ReadOnly = true;
            this.desp_dataReferencia.Width = 200;
            // 
            // desp_formaPagamento
            // 
            this.desp_formaPagamento.DataPropertyName = "desp_formaPagamento";
            this.desp_formaPagamento.HeaderText = "Forma de Pagamento";
            this.desp_formaPagamento.Name = "desp_formaPagamento";
            this.desp_formaPagamento.ReadOnly = true;
            // 
            // desp_status
            // 
            this.desp_status.DataPropertyName = "desp_status";
            this.desp_status.HeaderText = "Status";
            this.desp_status.Name = "desp_status";
            this.desp_status.ReadOnly = true;
            this.desp_status.Visible = false;
            // 
            // desp_dataPagamento
            // 
            this.desp_dataPagamento.DataPropertyName = "desp_dataPagamento";
            this.desp_dataPagamento.HeaderText = "Data de Pagamento";
            this.desp_dataPagamento.Name = "desp_dataPagamento";
            this.desp_dataPagamento.ReadOnly = true;
            // 
            // cbbTiposDespesas
            // 
            this.cbbTiposDespesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTiposDespesas.FormattingEnabled = true;
            this.cbbTiposDespesas.Location = new System.Drawing.Point(239, 33);
            this.cbbTiposDespesas.Name = "cbbTiposDespesas";
            this.cbbTiposDespesas.Size = new System.Drawing.Size(138, 21);
            this.cbbTiposDespesas.TabIndex = 1;
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(59, 34);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(138, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(59, 19);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 246);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(34, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(190, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(503, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(346, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(236, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(49, 150);
            this.tbDescricao.MaxLength = 200;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(627, 71);
            this.tbDescricao.TabIndex = 5;
            this.tbDescricao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição: ";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(59, 87);
            this.tbValor.MaxLength = 10;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(138, 20);
            this.tbValor.TabIndex = 3;
            this.tbValor.Enter += new System.EventHandler(this.tbValor_Enter);
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseSalary_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbBaseSalary_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(59, 71);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor: ";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(239, 87);
            this.tbDesconto.MaxLength = 10;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(138, 20);
            this.tbDesconto.TabIndex = 4;
            this.tbDesconto.Enter += new System.EventHandler(this.tbDesconto_Enter);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            this.tbDesconto.Leave += new System.EventHandler(this.tbDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(236, 71);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(56, 13);
            this.lblDesconto.TabIndex = 33;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(402, 17);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 13);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "Data da Despesa:";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(562, 129);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(101, 18);
            this.lblValorFinal.TabIndex = 36;
            this.lblValorFinal.Text = "Valor: R$ 0,00";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(405, 33);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(138, 20);
            this.dtpData.TabIndex = 37;
            // 
            // gbCod
            // 
            this.gbCod.Controls.Add(this.dtpPagamento);
            this.gbCod.Controls.Add(this.lblFormaPagamento);
            this.gbCod.Controls.Add(this.cbbTipoPagamento);
            this.gbCod.Controls.Add(this.lblPagamentoReferencia);
            this.gbCod.Controls.Add(this.dtpData);
            this.gbCod.Controls.Add(this.lblData);
            this.gbCod.Controls.Add(this.lblDesconto);
            this.gbCod.Controls.Add(this.tbDesconto);
            this.gbCod.Controls.Add(this.lblValor);
            this.gbCod.Controls.Add(this.tbValor);
            this.gbCod.Controls.Add(this.lblTipo);
            this.gbCod.Controls.Add(this.lblCod);
            this.gbCod.Controls.Add(this.tbCod);
            this.gbCod.Controls.Add(this.cbbTiposDespesas);
            this.gbCod.Controls.Add(this.lblValorFinal);
            this.gbCod.Controls.Add(this.label2);
            this.gbCod.Controls.Add(this.tbDescricao);
            this.gbCod.Controls.Add(this.tableLayoutPanel1);
            this.gbCod.Location = new System.Drawing.Point(15, 17);
            this.gbCod.Name = "gbCod";
            this.gbCod.Size = new System.Drawing.Size(755, 308);
            this.gbCod.TabIndex = 0;
            this.gbCod.TabStop = false;
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamento.Location = new System.Drawing.Point(565, 88);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(138, 20);
            this.dtpPagamento.TabIndex = 43;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(402, 71);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPagamento.TabIndex = 41;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // cbbTipoPagamento
            // 
            this.cbbTipoPagamento.AutoCompleteCustomSource.AddRange(new string[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cbbTipoPagamento.FormattingEnabled = true;
            this.cbbTipoPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "À Pagar"});
            this.cbbTipoPagamento.Location = new System.Drawing.Point(405, 87);
            this.cbbTipoPagamento.Name = "cbbTipoPagamento";
            this.cbbTipoPagamento.Size = new System.Drawing.Size(138, 21);
            this.cbbTipoPagamento.TabIndex = 40;
            this.cbbTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cbbTipoPagamento_SelectedIndexChanged);
            // 
            // lblPagamentoReferencia
            // 
            this.lblPagamentoReferencia.AutoSize = true;
            this.lblPagamentoReferencia.Location = new System.Drawing.Point(562, 71);
            this.lblPagamentoReferencia.Name = "lblPagamentoReferencia";
            this.lblPagamentoReferencia.Size = new System.Drawing.Size(102, 13);
            this.lblPagamentoReferencia.TabIndex = 38;
            this.lblPagamentoReferencia.Text = "Data de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Descrição";
            // 
            // tbDescFiltro
            // 
            this.tbDescFiltro.Location = new System.Drawing.Point(12, 40);
            this.tbDescFiltro.Margin = new System.Windows.Forms.Padding(6);
            this.tbDescFiltro.MaxLength = 49;
            this.tbDescFiltro.Name = "tbDescFiltro";
            this.tbDescFiltro.Size = new System.Drawing.Size(255, 20);
            this.tbDescFiltro.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisarPorPeriodo);
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(276, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 83);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(175, 53);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 20);
            this.dtpFim.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(24, 53);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Inicio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(602, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 37);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbFiltroEmAberto);
            this.groupBox1.Controls.Add(this.cbbFiltroPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbFiltroTipo);
            this.groupBox1.Controls.Add(this.cbCaixaAtual);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbDescFiltro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 333);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(755, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cbbFiltroEmAberto
            // 
            this.cbbFiltroEmAberto.AutoSize = true;
            this.cbbFiltroEmAberto.Location = new System.Drawing.Point(686, 47);
            this.cbbFiltroEmAberto.Name = "cbbFiltroEmAberto";
            this.cbbFiltroEmAberto.Size = new System.Drawing.Size(75, 17);
            this.cbbFiltroEmAberto.TabIndex = 64;
            this.cbbFiltroEmAberto.Text = "Em Aberto";
            this.cbbFiltroEmAberto.UseVisualStyleBackColor = true;
            // 
            // cbbFiltroPago
            // 
            this.cbbFiltroPago.AutoSize = true;
            this.cbbFiltroPago.Location = new System.Drawing.Point(686, 24);
            this.cbbFiltroPago.Name = "cbbFiltroPago";
            this.cbbFiltroPago.Size = new System.Drawing.Size(51, 17);
            this.cbbFiltroPago.TabIndex = 63;
            this.cbbFiltroPago.Text = "Paga";
            this.cbbFiltroPago.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tipo:";
            // 
            // cbbFiltroTipo
            // 
            this.cbbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltroTipo.FormattingEnabled = true;
            this.cbbFiltroTipo.Items.AddRange(new object[] {
            ""});
            this.cbbFiltroTipo.Location = new System.Drawing.Point(12, 84);
            this.cbbFiltroTipo.Name = "cbbFiltroTipo";
            this.cbbFiltroTipo.Size = new System.Drawing.Size(255, 21);
            this.cbbFiltroTipo.TabIndex = 62;
            // 
            // cbCaixaAtual
            // 
            this.cbCaixaAtual.AutoSize = true;
            this.cbCaixaAtual.Location = new System.Drawing.Point(601, 23);
            this.cbCaixaAtual.Name = "cbCaixaAtual";
            this.cbCaixaAtual.Size = new System.Drawing.Size(79, 17);
            this.cbCaixaAtual.TabIndex = 60;
            this.cbCaixaAtual.Text = "Caixa Atual";
            this.cbCaixaAtual.UseVisualStyleBackColor = true;
            // 
            // cbPesquisarPorPeriodo
            // 
            this.cbPesquisarPorPeriodo.AutoSize = true;
            this.cbPesquisarPorPeriodo.Location = new System.Drawing.Point(21, 20);
            this.cbPesquisarPorPeriodo.Name = "cbPesquisarPorPeriodo";
            this.cbPesquisarPorPeriodo.Size = new System.Drawing.Size(132, 17);
            this.cbPesquisarPorPeriodo.TabIndex = 57;
            this.cbPesquisarPorPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // FormLancarDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(783, 739);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCod);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormLancarDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançar Despesa";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_despesa)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCod.ResumeLayout(false);
            this.gbCod.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_despesa;
        private System.Windows.Forms.ComboBox cbbTiposDespesas;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RichTextBox tbDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox gbCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCaixaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPagamentoReferencia;
        private System.Windows.Forms.ComboBox cbbFiltroTipo;
        private System.Windows.Forms.ComboBox cbbTipoPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.CheckBox cbbFiltroEmAberto;
        private System.Windows.Forms.CheckBox cbbFiltroPago;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_idCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_dataReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_formaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_dataPagamento;
        private System.Windows.Forms.CheckBox cbPesquisarPorPeriodo;
    }
}
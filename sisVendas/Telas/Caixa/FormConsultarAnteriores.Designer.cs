namespace sisVendas.Telas.Caixa
{
    partial class FormConsultarAnteriores
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResumoDinheiro = new System.Windows.Forms.Label();
            this.lvlTotalCancelamento = new System.Windows.Forms.GroupBox();
            this.lblTotalCancelamento = new System.Windows.Forms.Label();
            this.lblResumoDespesas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResumoDebito = new System.Windows.Forms.Label();
            this.lblResumoCredito = new System.Windows.Forms.Label();
            this.lblResumoCartao = new System.Windows.Forms.Label();
            this.lvl = new System.Windows.Forms.GroupBox();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_idFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_dtAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_dtFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_saldoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixa_saidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResumoSangria = new System.Windows.Forms.Label();
            this.lblResumoAporte = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbPesquisarPorPeriodo = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAbertura = new System.Windows.Forms.TextBox();
            this.tbFechamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox5.SuspendLayout();
            this.lvlTotalCancelamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblResumoDinheiro);
            this.groupBox5.Location = new System.Drawing.Point(717, 212);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(188, 94);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dinheiro";
            // 
            // lblResumoDinheiro
            // 
            this.lblResumoDinheiro.AutoSize = true;
            this.lblResumoDinheiro.Location = new System.Drawing.Point(6, 44);
            this.lblResumoDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDinheiro.Name = "lblResumoDinheiro";
            this.lblResumoDinheiro.Size = new System.Drawing.Size(45, 13);
            this.lblResumoDinheiro.TabIndex = 5;
            this.lblResumoDinheiro.Text = "R$ 0,00";
            // 
            // lvlTotalCancelamento
            // 
            this.lvlTotalCancelamento.Controls.Add(this.lblTotalCancelamento);
            this.lvlTotalCancelamento.Controls.Add(this.lblResumoDespesas);
            this.lvlTotalCancelamento.Location = new System.Drawing.Point(717, 483);
            this.lvlTotalCancelamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvlTotalCancelamento.Name = "lvlTotalCancelamento";
            this.lvlTotalCancelamento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvlTotalCancelamento.Size = new System.Drawing.Size(188, 113);
            this.lvlTotalCancelamento.TabIndex = 51;
            this.lvlTotalCancelamento.TabStop = false;
            this.lvlTotalCancelamento.Text = "Despesas: ";
            // 
            // lblTotalCancelamento
            // 
            this.lblTotalCancelamento.AutoSize = true;
            this.lblTotalCancelamento.Location = new System.Drawing.Point(6, 72);
            this.lblTotalCancelamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCancelamento.Name = "lblTotalCancelamento";
            this.lblTotalCancelamento.Size = new System.Drawing.Size(45, 13);
            this.lblTotalCancelamento.TabIndex = 6;
            this.lblTotalCancelamento.Text = "R$ 0,00";
            // 
            // lblResumoDespesas
            // 
            this.lblResumoDespesas.AutoSize = true;
            this.lblResumoDespesas.Location = new System.Drawing.Point(6, 38);
            this.lblResumoDespesas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDespesas.Name = "lblResumoDespesas";
            this.lblResumoDespesas.Size = new System.Drawing.Size(45, 13);
            this.lblResumoDespesas.TabIndex = 5;
            this.lblResumoDespesas.Text = "R$ 0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResumoDebito);
            this.groupBox1.Controls.Add(this.lblResumoCredito);
            this.groupBox1.Controls.Add(this.lblResumoCartao);
            this.groupBox1.Location = new System.Drawing.Point(717, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(188, 170);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartão:";
            // 
            // lblResumoDebito
            // 
            this.lblResumoDebito.AutoSize = true;
            this.lblResumoDebito.Location = new System.Drawing.Point(6, 84);
            this.lblResumoDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDebito.Name = "lblResumoDebito";
            this.lblResumoDebito.Size = new System.Drawing.Size(45, 13);
            this.lblResumoDebito.TabIndex = 2;
            this.lblResumoDebito.Text = "R$ 0,00";
            // 
            // lblResumoCredito
            // 
            this.lblResumoCredito.AutoSize = true;
            this.lblResumoCredito.Location = new System.Drawing.Point(6, 124);
            this.lblResumoCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoCredito.Name = "lblResumoCredito";
            this.lblResumoCredito.Size = new System.Drawing.Size(45, 13);
            this.lblResumoCredito.TabIndex = 1;
            this.lblResumoCredito.Text = "R$ 0,00";
            // 
            // lblResumoCartao
            // 
            this.lblResumoCartao.AutoSize = true;
            this.lblResumoCartao.Location = new System.Drawing.Point(6, 44);
            this.lblResumoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoCartao.Name = "lblResumoCartao";
            this.lblResumoCartao.Size = new System.Drawing.Size(45, 13);
            this.lblResumoCartao.TabIndex = 0;
            this.lblResumoCartao.Text = "R$ 0,00";
            // 
            // lvl
            // 
            this.lvl.Controls.Add(this.dgvTransacoes);
            this.lvl.Controls.Add(this.dgvCaixa);
            this.lvl.Location = new System.Drawing.Point(13, 266);
            this.lvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Name = "lvl";
            this.lvl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Size = new System.Drawing.Size(696, 331);
            this.lvl.TabIndex = 48;
            this.lvl.TabStop = false;
            this.lvl.Text = "Caixas";
            // 
            // dgvTransacoes
            // 
            this.dgvTransacoes.AllowUserToAddRows = false;
            this.dgvTransacoes.AllowUserToDeleteRows = false;
            this.dgvTransacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.tipo,
            this.formapagamento,
            this.valor,
            this.data});
            this.dgvTransacoes.Location = new System.Drawing.Point(10, 163);
            this.dgvTransacoes.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.RowHeadersVisible = false;
            this.dgvTransacoes.RowTemplate.Height = 25;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(675, 157);
            this.dgvTransacoes.TabIndex = 31;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 75;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 75;
            // 
            // formapagamento
            // 
            this.formapagamento.DataPropertyName = "formapagamento";
            this.formapagamento.HeaderText = "Forma Pgto";
            this.formapagamento.MinimumWidth = 150;
            this.formapagamento.Name = "formapagamento";
            this.formapagamento.ReadOnly = true;
            this.formapagamento.Width = 150;
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
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.MinimumWidth = 150;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.func_nome,
            this.caixa_id,
            this.caixa_idFunc,
            this.caixa_dtAbertura,
            this.caixa_dtFechamento,
            this.caixa_saldoAnterior,
            this.caixa_entradas,
            this.caixa_saidas});
            this.dgvCaixa.Location = new System.Drawing.Point(10, 24);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCaixa.MultiSelect = false;
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowHeadersVisible = false;
            this.dgvCaixa.RowTemplate.Height = 25;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(675, 121);
            this.dgvCaixa.TabIndex = 30;
            this.dgvCaixa.DoubleClick += new System.EventHandler(this.dgvCaixa_DoubleClick);
            // 
            // func_nome
            // 
            this.func_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Funcionário";
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
            // 
            // caixa_id
            // 
            this.caixa_id.DataPropertyName = "caixa_id";
            this.caixa_id.HeaderText = "caixa_id";
            this.caixa_id.Name = "caixa_id";
            this.caixa_id.ReadOnly = true;
            this.caixa_id.Visible = false;
            // 
            // caixa_idFunc
            // 
            this.caixa_idFunc.DataPropertyName = "caixa_idFunc";
            this.caixa_idFunc.HeaderText = "caixa_idFunc";
            this.caixa_idFunc.Name = "caixa_idFunc";
            this.caixa_idFunc.ReadOnly = true;
            this.caixa_idFunc.Visible = false;
            // 
            // caixa_dtAbertura
            // 
            this.caixa_dtAbertura.DataPropertyName = "caixa_dtAbertura";
            this.caixa_dtAbertura.HeaderText = "Abertura";
            this.caixa_dtAbertura.Name = "caixa_dtAbertura";
            this.caixa_dtAbertura.ReadOnly = true;
            // 
            // caixa_dtFechamento
            // 
            this.caixa_dtFechamento.DataPropertyName = "caixa_dtFechamento";
            this.caixa_dtFechamento.HeaderText = "Fechamento";
            this.caixa_dtFechamento.Name = "caixa_dtFechamento";
            this.caixa_dtFechamento.ReadOnly = true;
            // 
            // caixa_saldoAnterior
            // 
            this.caixa_saldoAnterior.DataPropertyName = "caixa_saldoAnterior";
            this.caixa_saldoAnterior.HeaderText = "Saldo Inicial";
            this.caixa_saldoAnterior.Name = "caixa_saldoAnterior";
            this.caixa_saldoAnterior.ReadOnly = true;
            // 
            // caixa_entradas
            // 
            this.caixa_entradas.DataPropertyName = "caixa_entradas";
            this.caixa_entradas.HeaderText = "Entradas";
            this.caixa_entradas.Name = "caixa_entradas";
            this.caixa_entradas.ReadOnly = true;
            // 
            // caixa_saidas
            // 
            this.caixa_saidas.DataPropertyName = "caixa_saidas";
            this.caixa_saidas.HeaderText = "Saidas";
            this.caixa_saidas.Name = "caixa_saidas";
            this.caixa_saidas.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResumoSangria);
            this.groupBox2.Controls.Add(this.lblResumoAporte);
            this.groupBox2.Location = new System.Drawing.Point(717, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(188, 139);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte/Sangria";
            // 
            // lblResumoSangria
            // 
            this.lblResumoSangria.AutoSize = true;
            this.lblResumoSangria.Location = new System.Drawing.Point(6, 95);
            this.lblResumoSangria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoSangria.Name = "lblResumoSangria";
            this.lblResumoSangria.Size = new System.Drawing.Size(45, 13);
            this.lblResumoSangria.TabIndex = 4;
            this.lblResumoSangria.Text = "R$ 0,00";
            // 
            // lblResumoAporte
            // 
            this.lblResumoAporte.AutoSize = true;
            this.lblResumoAporte.Location = new System.Drawing.Point(6, 43);
            this.lblResumoAporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoAporte.Name = "lblResumoAporte";
            this.lblResumoAporte.Size = new System.Drawing.Size(45, 13);
            this.lblResumoAporte.TabIndex = 3;
            this.lblResumoAporte.Text = "R$ 0,00";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(559, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 35);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbPesquisarPorPeriodo);
            this.groupBox7.Controls.Add(this.dtpData);
            this.groupBox7.Location = new System.Drawing.Point(10, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(204, 112);
            this.groupBox7.TabIndex = 60;
            this.groupBox7.TabStop = false;
            // 
            // cbPesquisarPorPeriodo
            // 
            this.cbPesquisarPorPeriodo.AutoSize = true;
            this.cbPesquisarPorPeriodo.Location = new System.Drawing.Point(24, 29);
            this.cbPesquisarPorPeriodo.Name = "cbPesquisarPorPeriodo";
            this.cbPesquisarPorPeriodo.Size = new System.Drawing.Size(156, 22);
            this.cbPesquisarPorPeriodo.TabIndex = 57;
            this.cbPesquisarPorPeriodo.Text = "Pesquisar Por Data";
            this.cbPesquisarPorPeriodo.UseVisualStyleBackColor = true;
            this.cbPesquisarPorPeriodo.CheckedChanged += new System.EventHandler(this.cbPesquisarPorPeriodo_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(24, 64);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 24);
            this.dtpData.TabIndex = 55;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(696, 243);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbSaida);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.tbEntrada);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.tbAbertura);
            this.groupBox6.Controls.Add(this.tbFechamento);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(10, 145);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(675, 91);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resumo";
            // 
            // tbSaida
            // 
            this.tbSaida.Enabled = false;
            this.tbSaida.Location = new System.Drawing.Point(531, 51);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(137, 24);
            this.tbSaida.TabIndex = 68;
            this.tbSaida.Text = "R$ 0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Saidas:";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Enabled = false;
            this.tbEntrada.Location = new System.Drawing.Point(356, 51);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(137, 24);
            this.tbEntrada.TabIndex = 66;
            this.tbEntrada.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Entradas:";
            // 
            // tbAbertura
            // 
            this.tbAbertura.Enabled = false;
            this.tbAbertura.Location = new System.Drawing.Point(6, 51);
            this.tbAbertura.Name = "tbAbertura";
            this.tbAbertura.Size = new System.Drawing.Size(137, 24);
            this.tbAbertura.TabIndex = 65;
            this.tbAbertura.Text = "R$ 0,00";
            // 
            // tbFechamento
            // 
            this.tbFechamento.Enabled = false;
            this.tbFechamento.Location = new System.Drawing.Point(181, 51);
            this.tbFechamento.Name = "tbFechamento";
            this.tbFechamento.Size = new System.Drawing.Size(137, 24);
            this.tbFechamento.TabIndex = 63;
            this.tbFechamento.Text = "R$ 0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Fechamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Abertura:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbFuncionario);
            this.groupBox4.Location = new System.Drawing.Point(255, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 112);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionário:";
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(6, 64);
            this.cbbFuncionario.MaxLength = 2;
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(260, 26);
            this.cbbFuncionario.TabIndex = 6;
            // 
            // FormConsultarAnteriores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lvlTotalCancelamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormConsultarAnteriores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Consultar caixas anteriores";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.lvlTotalCancelamento.ResumeLayout(false);
            this.lvlTotalCancelamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lvl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblResumoDinheiro;
        private System.Windows.Forms.GroupBox lvlTotalCancelamento;
        private System.Windows.Forms.Label lblResumoDespesas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResumoDebito;
        private System.Windows.Forms.Label lblResumoCredito;
        private System.Windows.Forms.Label lblResumoCartao;
        private System.Windows.Forms.GroupBox lvl;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResumoSangria;
        private System.Windows.Forms.Label lblResumoAporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbPesquisarPorPeriodo;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbAbertura;
        private System.Windows.Forms.TextBox tbFechamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_idFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_dtAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_dtFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_saldoAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixa_saidas;
        private System.Windows.Forms.DataGridView dgvTransacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Label lblTotalCancelamento;
    }
}
namespace sisVendas.Telas.Caixa
{
    partial class FormAbrirFecharCaixa
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
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.lvl = new System.Windows.Forms.GroupBox();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAbrirFechar = new System.Windows.Forms.GroupBox();
            this.lblDiaAnterior = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblValorDiaAnterior = new System.Windows.Forms.Label();
            this.btnAbrirFechar = new System.Windows.Forms.Button();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.gbAporte = new System.Windows.Forms.GroupBox();
            this.cbAporte = new System.Windows.Forms.CheckBox();
            this.cbSangria = new System.Windows.Forms.CheckBox();
            this.lblSangriaAporte = new System.Windows.Forms.Label();
            this.tbSangriaAporte = new System.Windows.Forms.TextBox();
            this.btnSangriaAporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResumoDebito = new System.Windows.Forms.Label();
            this.lblResumoCredito = new System.Windows.Forms.Label();
            this.lblResumoCartao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResumoSangria = new System.Windows.Forms.Label();
            this.lblResumoAporte = new System.Windows.Forms.Label();
            this.gngngn = new System.Windows.Forms.GroupBox();
            this.lblResumoDespesas = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResumoDinheiro = new System.Windows.Forms.Label();
            this.lvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            this.gbAbrirFechar.SuspendLayout();
            this.gbAporte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gngngn.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(12, 281);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(6);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(248, 31);
            this.tbSaldo.TabIndex = 5;
            this.tbSaldo.Text = "R$ 0,00";
            // 
            // lvl
            // 
            this.lvl.Controls.Add(this.dgvTransacoes);
            this.lvl.Location = new System.Drawing.Point(306, 15);
            this.lvl.Margin = new System.Windows.Forms.Padding(6);
            this.lvl.Name = "lvl";
            this.lvl.Padding = new System.Windows.Forms.Padding(6);
            this.lvl.Size = new System.Drawing.Size(927, 729);
            this.lvl.TabIndex = 25;
            this.lvl.TabStop = false;
            this.lvl.Text = "Transações";
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
            this.dgvTransacoes.Location = new System.Drawing.Point(14, 38);
            this.dgvTransacoes.Margin = new System.Windows.Forms.Padding(8);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.RowHeadersVisible = false;
            this.dgvTransacoes.RowTemplate.Height = 25;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(899, 677);
            this.dgvTransacoes.TabIndex = 30;
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
            // gbAbrirFechar
            // 
            this.gbAbrirFechar.Controls.Add(this.lblDiaAnterior);
            this.gbAbrirFechar.Controls.Add(this.lblSaldo);
            this.gbAbrirFechar.Controls.Add(this.tbSaldo);
            this.gbAbrirFechar.Controls.Add(this.lblEntrada);
            this.gbAbrirFechar.Controls.Add(this.tbEntrada);
            this.gbAbrirFechar.Controls.Add(this.lblSaida);
            this.gbAbrirFechar.Controls.Add(this.lblValorDiaAnterior);
            this.gbAbrirFechar.Controls.Add(this.btnAbrirFechar);
            this.gbAbrirFechar.Controls.Add(this.tbSaida);
            this.gbAbrirFechar.Location = new System.Drawing.Point(22, 68);
            this.gbAbrirFechar.Margin = new System.Windows.Forms.Padding(6);
            this.gbAbrirFechar.Name = "gbAbrirFechar";
            this.gbAbrirFechar.Padding = new System.Windows.Forms.Padding(6);
            this.gbAbrirFechar.Size = new System.Drawing.Size(272, 432);
            this.gbAbrirFechar.TabIndex = 23;
            this.gbAbrirFechar.TabStop = false;
            this.gbAbrirFechar.Text = "Abrir Caixa";
            // 
            // lblDiaAnterior
            // 
            this.lblDiaAnterior.AutoSize = true;
            this.lblDiaAnterior.Location = new System.Drawing.Point(7, 41);
            this.lblDiaAnterior.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaAnterior.Name = "lblDiaAnterior";
            this.lblDiaAnterior.Size = new System.Drawing.Size(209, 25);
            this.lblDiaAnterior.TabIndex = 35;
            this.lblDiaAnterior.Text = "Saldo Caixa Anterior";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 250);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 25);
            this.lblSaldo.TabIndex = 34;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 97);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(132, 25);
            this.lblEntrada.TabIndex = 33;
            this.lblEntrada.Text = "Suprimentos";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(12, 127);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(6);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(248, 31);
            this.tbEntrada.TabIndex = 32;
            this.tbEntrada.Text = "R$ 0,00";
            this.tbEntrada.Click += new System.EventHandler(this.tbEntrada_Click);
            this.tbEntrada.TextChanged += new System.EventHandler(this.tbEntrada_TextChanged);
            this.tbEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSuprimentos_KeyPress);
            this.tbEntrada.Leave += new System.EventHandler(this.tbSuprimentos_Leave);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(12, 174);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(86, 25);
            this.lblSaida.TabIndex = 31;
            this.lblSaida.Text = "Sangria";
            // 
            // lblValorDiaAnterior
            // 
            this.lblValorDiaAnterior.AutoSize = true;
            this.lblValorDiaAnterior.Location = new System.Drawing.Point(12, 66);
            this.lblValorDiaAnterior.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorDiaAnterior.Name = "lblValorDiaAnterior";
            this.lblValorDiaAnterior.Size = new System.Drawing.Size(87, 25);
            this.lblValorDiaAnterior.TabIndex = 30;
            this.lblValorDiaAnterior.Text = "R$ 0,00";
            // 
            // btnAbrirFechar
            // 
            this.btnAbrirFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFechar.Location = new System.Drawing.Point(12, 346);
            this.btnAbrirFechar.Margin = new System.Windows.Forms.Padding(8);
            this.btnAbrirFechar.Name = "btnAbrirFechar";
            this.btnAbrirFechar.Size = new System.Drawing.Size(248, 60);
            this.btnAbrirFechar.TabIndex = 27;
            this.btnAbrirFechar.Text = "Abrir Caixa";
            this.btnAbrirFechar.UseVisualStyleBackColor = true;
            this.btnAbrirFechar.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(12, 205);
            this.tbSaida.Margin = new System.Windows.Forms.Padding(6);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(248, 31);
            this.tbSaida.TabIndex = 5;
            this.tbSaida.Text = "R$ 0,00";
            this.tbSaida.Click += new System.EventHandler(this.tbSaida_Click);
            this.tbSaida.TextChanged += new System.EventHandler(this.tbSaida_TextChanged);
            this.tbSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSangria_KeyPress);
            this.tbSaida.Leave += new System.EventHandler(this.tbSangria_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(15, 9);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(26, 37);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = ".";
            // 
            // gbAporte
            // 
            this.gbAporte.Controls.Add(this.cbAporte);
            this.gbAporte.Controls.Add(this.cbSangria);
            this.gbAporte.Controls.Add(this.lblSangriaAporte);
            this.gbAporte.Controls.Add(this.tbSangriaAporte);
            this.gbAporte.Controls.Add(this.btnSangriaAporte);
            this.gbAporte.Location = new System.Drawing.Point(22, 512);
            this.gbAporte.Margin = new System.Windows.Forms.Padding(6);
            this.gbAporte.Name = "gbAporte";
            this.gbAporte.Padding = new System.Windows.Forms.Padding(6);
            this.gbAporte.Size = new System.Drawing.Size(272, 232);
            this.gbAporte.TabIndex = 41;
            this.gbAporte.TabStop = false;
            this.gbAporte.Text = "Aporte/Sangria";
            // 
            // cbAporte
            // 
            this.cbAporte.AutoSize = true;
            this.cbAporte.Location = new System.Drawing.Point(152, 47);
            this.cbAporte.Margin = new System.Windows.Forms.Padding(6);
            this.cbAporte.Name = "cbAporte";
            this.cbAporte.Size = new System.Drawing.Size(94, 29);
            this.cbAporte.TabIndex = 42;
            this.cbAporte.Text = "Aporte";
            this.cbAporte.UseVisualStyleBackColor = true;
            this.cbAporte.Click += new System.EventHandler(this.cbAporte_Click);
            // 
            // cbSangria
            // 
            this.cbSangria.AutoSize = true;
            this.cbSangria.Checked = true;
            this.cbSangria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSangria.Location = new System.Drawing.Point(21, 47);
            this.cbSangria.Margin = new System.Windows.Forms.Padding(6);
            this.cbSangria.Name = "cbSangria";
            this.cbSangria.Size = new System.Drawing.Size(105, 29);
            this.cbSangria.TabIndex = 41;
            this.cbSangria.Text = "Sangria";
            this.cbSangria.UseVisualStyleBackColor = true;
            this.cbSangria.Click += new System.EventHandler(this.cbSangria_Click);
            // 
            // lblSangriaAporte
            // 
            this.lblSangriaAporte.AutoSize = true;
            this.lblSangriaAporte.Location = new System.Drawing.Point(12, 77);
            this.lblSangriaAporte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSangriaAporte.Name = "lblSangriaAporte";
            this.lblSangriaAporte.Size = new System.Drawing.Size(98, 25);
            this.lblSangriaAporte.TabIndex = 39;
            this.lblSangriaAporte.Text = "Sangria: ";
            // 
            // tbSangriaAporte
            // 
            this.tbSangriaAporte.Location = new System.Drawing.Point(12, 108);
            this.tbSangriaAporte.Margin = new System.Windows.Forms.Padding(6);
            this.tbSangriaAporte.Name = "tbSangriaAporte";
            this.tbSangriaAporte.Size = new System.Drawing.Size(248, 31);
            this.tbSangriaAporte.TabIndex = 38;
            this.tbSangriaAporte.Text = "R$ 0,00";
            this.tbSangriaAporte.Click += new System.EventHandler(this.tbSangriaAporte_Click);
            this.tbSangriaAporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSangriaAporte_KeyPress);
            this.tbSangriaAporte.Leave += new System.EventHandler(this.tbSangriaAporte_Leave);
            // 
            // btnSangriaAporte
            // 
            this.btnSangriaAporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSangriaAporte.Location = new System.Drawing.Point(12, 153);
            this.btnSangriaAporte.Margin = new System.Windows.Forms.Padding(8);
            this.btnSangriaAporte.Name = "btnSangriaAporte";
            this.btnSangriaAporte.Size = new System.Drawing.Size(248, 60);
            this.btnSangriaAporte.TabIndex = 28;
            this.btnSangriaAporte.Text = "Realizar";
            this.btnSangriaAporte.UseVisualStyleBackColor = true;
            this.btnSangriaAporte.Click += new System.EventHandler(this.btnSangriaAporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResumoDebito);
            this.groupBox1.Controls.Add(this.lblResumoCredito);
            this.groupBox1.Controls.Add(this.lblResumoCartao);
            this.groupBox1.Location = new System.Drawing.Point(1245, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(250, 175);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartão:";
            // 
            // lblResumoDebito
            // 
            this.lblResumoDebito.AutoSize = true;
            this.lblResumoDebito.Location = new System.Drawing.Point(12, 82);
            this.lblResumoDebito.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoDebito.Name = "lblResumoDebito";
            this.lblResumoDebito.Size = new System.Drawing.Size(87, 25);
            this.lblResumoDebito.TabIndex = 2;
            this.lblResumoDebito.Text = "R$ 0,00";
            // 
            // lblResumoCredito
            // 
            this.lblResumoCredito.AutoSize = true;
            this.lblResumoCredito.Location = new System.Drawing.Point(12, 126);
            this.lblResumoCredito.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoCredito.Name = "lblResumoCredito";
            this.lblResumoCredito.Size = new System.Drawing.Size(87, 25);
            this.lblResumoCredito.TabIndex = 1;
            this.lblResumoCredito.Text = "R$ 0,00";
            // 
            // lblResumoCartao
            // 
            this.lblResumoCartao.AutoSize = true;
            this.lblResumoCartao.Location = new System.Drawing.Point(12, 41);
            this.lblResumoCartao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoCartao.Name = "lblResumoCartao";
            this.lblResumoCartao.Size = new System.Drawing.Size(87, 25);
            this.lblResumoCartao.TabIndex = 0;
            this.lblResumoCartao.Text = "R$ 0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResumoSangria);
            this.groupBox2.Controls.Add(this.lblResumoAporte);
            this.groupBox2.Location = new System.Drawing.Point(1245, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(250, 173);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte/Sangria";
            // 
            // lblResumoSangria
            // 
            this.lblResumoSangria.AutoSize = true;
            this.lblResumoSangria.Location = new System.Drawing.Point(9, 101);
            this.lblResumoSangria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoSangria.Name = "lblResumoSangria";
            this.lblResumoSangria.Size = new System.Drawing.Size(87, 25);
            this.lblResumoSangria.TabIndex = 4;
            this.lblResumoSangria.Text = "R$ 0,00";
            // 
            // lblResumoAporte
            // 
            this.lblResumoAporte.AutoSize = true;
            this.lblResumoAporte.Location = new System.Drawing.Point(9, 49);
            this.lblResumoAporte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoAporte.Name = "lblResumoAporte";
            this.lblResumoAporte.Size = new System.Drawing.Size(87, 25);
            this.lblResumoAporte.TabIndex = 3;
            this.lblResumoAporte.Text = "R$ 0,00";
            // 
            // gngngn
            // 
            this.gngngn.Controls.Add(this.lblResumoDespesas);
            this.gngngn.Location = new System.Drawing.Point(1245, 626);
            this.gngngn.Margin = new System.Windows.Forms.Padding(6);
            this.gngngn.Name = "gngngn";
            this.gngngn.Padding = new System.Windows.Forms.Padding(6);
            this.gngngn.Size = new System.Drawing.Size(250, 118);
            this.gngngn.TabIndex = 45;
            this.gngngn.TabStop = false;
            this.gngngn.Text = "Despesas: ";
            // 
            // lblResumoDespesas
            // 
            this.lblResumoDespesas.AutoSize = true;
            this.lblResumoDespesas.Location = new System.Drawing.Point(12, 62);
            this.lblResumoDespesas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoDespesas.Name = "lblResumoDespesas";
            this.lblResumoDespesas.Size = new System.Drawing.Size(87, 25);
            this.lblResumoDespesas.TabIndex = 5;
            this.lblResumoDespesas.Text = "R$ 0,00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblResumoDinheiro);
            this.groupBox5.Location = new System.Drawing.Point(1245, 237);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(250, 118);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dinheiro";
            // 
            // lblResumoDinheiro
            // 
            this.lblResumoDinheiro.AutoSize = true;
            this.lblResumoDinheiro.Location = new System.Drawing.Point(12, 62);
            this.lblResumoDinheiro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResumoDinheiro.Name = "lblResumoDinheiro";
            this.lblResumoDinheiro.Size = new System.Drawing.Size(87, 25);
            this.lblResumoDinheiro.TabIndex = 5;
            this.lblResumoDinheiro.Text = "R$ 0,00";
            // 
            // FormAbrirFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 770);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gngngn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAbrirFechar);
            this.Controls.Add(this.gbAporte);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAbrirFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.lvl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            this.gbAbrirFechar.ResumeLayout(false);
            this.gbAbrirFechar.PerformLayout();
            this.gbAporte.ResumeLayout(false);
            this.gbAporte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gngngn.ResumeLayout(false);
            this.gngngn.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.GroupBox lvl;
        private System.Windows.Forms.GroupBox gbAbrirFechar;
        private System.Windows.Forms.Button btnAbrirFechar;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblValorDiaAnterior;
        private System.Windows.Forms.DataGridView dgvTransacoes;
        private System.Windows.Forms.GroupBox gbAporte;
        private System.Windows.Forms.Label lblSangriaAporte;
        private System.Windows.Forms.TextBox tbSangriaAporte;
        private System.Windows.Forms.Button btnSangriaAporte;
        private System.Windows.Forms.CheckBox cbAporte;
        private System.Windows.Forms.CheckBox cbSangria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResumoDebito;
        private System.Windows.Forms.Label lblResumoCredito;
        private System.Windows.Forms.Label lblResumoCartao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gngngn;
        private System.Windows.Forms.Label lblResumoSangria;
        private System.Windows.Forms.Label lblResumoAporte;
        private System.Windows.Forms.Label lblResumoDespesas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblResumoDinheiro;
        private System.Windows.Forms.Label lblDiaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}
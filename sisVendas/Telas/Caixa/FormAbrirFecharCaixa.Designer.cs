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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblResumoComprasDinheiro = new System.Windows.Forms.Label();
            this.lblResumoComprasCredito = new System.Windows.Forms.Label();
            this.lblResumoComprasDebito = new System.Windows.Forms.Label();
            this.lblTotalCancelamento = new System.Windows.Forms.Label();
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
            this.lblResumoVendasDebito = new System.Windows.Forms.Label();
            this.lblResumoVendasCredito = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResumoSangria = new System.Windows.Forms.Label();
            this.lblResumoAporte = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResumoVendasDinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gngngn = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResumoDespesasDinheiro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResumoDespesasCredito = new System.Windows.Forms.Label();
            this.lblResumoDespesasDebito = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResumoVendasTotal = new System.Windows.Forms.Label();
            this.lvl.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            this.gbAbrirFechar.SuspendLayout();
            this.gbAporte.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gngngn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(6, 225);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(187, 26);
            this.tbSaldo.TabIndex = 5;
            this.tbSaldo.Text = "R$ 0,00";
            // 
            // lvl
            // 
            this.lvl.Controls.Add(this.groupBox6);
            this.lvl.Controls.Add(this.gngngn);
            this.lvl.Controls.Add(this.dgvTransacoes);
            this.lvl.Controls.Add(this.groupBox2);
            this.lvl.Location = new System.Drawing.Point(230, 9);
            this.lvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Name = "lvl";
            this.lvl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Size = new System.Drawing.Size(696, 587);
            this.lvl.TabIndex = 25;
            this.lvl.TabStop = false;
            this.lvl.Text = "Transações";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblResumoComprasDinheiro);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblResumoComprasCredito);
            this.groupBox4.Controls.Add(this.lblResumoComprasDebito);
            this.groupBox4.Location = new System.Drawing.Point(933, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(188, 230);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras:";
            // 
            // lblResumoComprasDinheiro
            // 
            this.lblResumoComprasDinheiro.AutoSize = true;
            this.lblResumoComprasDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoComprasDinheiro.Location = new System.Drawing.Point(8, 199);
            this.lblResumoComprasDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoComprasDinheiro.Name = "lblResumoComprasDinheiro";
            this.lblResumoComprasDinheiro.Size = new System.Drawing.Size(72, 20);
            this.lblResumoComprasDinheiro.TabIndex = 7;
            this.lblResumoComprasDinheiro.Text = "R$ 0,00";
            // 
            // lblResumoComprasCredito
            // 
            this.lblResumoComprasCredito.AutoSize = true;
            this.lblResumoComprasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoComprasCredito.Location = new System.Drawing.Point(8, 129);
            this.lblResumoComprasCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoComprasCredito.Name = "lblResumoComprasCredito";
            this.lblResumoComprasCredito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoComprasCredito.TabIndex = 6;
            this.lblResumoComprasCredito.Text = "R$ 0,00";
            // 
            // lblResumoComprasDebito
            // 
            this.lblResumoComprasDebito.AutoSize = true;
            this.lblResumoComprasDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoComprasDebito.Location = new System.Drawing.Point(8, 59);
            this.lblResumoComprasDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoComprasDebito.Name = "lblResumoComprasDebito";
            this.lblResumoComprasDebito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoComprasDebito.TabIndex = 5;
            this.lblResumoComprasDebito.Text = "R$ 0,00";
            // 
            // lblTotalCancelamento
            // 
            this.lblTotalCancelamento.AutoSize = true;
            this.lblTotalCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelamento.Location = new System.Drawing.Point(6, 44);
            this.lblTotalCancelamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCancelamento.Name = "lblTotalCancelamento";
            this.lblTotalCancelamento.Size = new System.Drawing.Size(72, 20);
            this.lblTotalCancelamento.TabIndex = 6;
            this.lblTotalCancelamento.Text = "R$ 0,00";
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
            this.dgvTransacoes.Location = new System.Drawing.Point(11, 30);
            this.dgvTransacoes.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.RowHeadersVisible = false;
            this.dgvTransacoes.RowTemplate.Height = 25;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(675, 369);
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
            this.gbAbrirFechar.Location = new System.Drawing.Point(13, 52);
            this.gbAbrirFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAbrirFechar.Name = "gbAbrirFechar";
            this.gbAbrirFechar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAbrirFechar.Size = new System.Drawing.Size(204, 356);
            this.gbAbrirFechar.TabIndex = 23;
            this.gbAbrirFechar.TabStop = false;
            this.gbAbrirFechar.Text = "Abrir Caixa";
            // 
            // lblDiaAnterior
            // 
            this.lblDiaAnterior.AutoSize = true;
            this.lblDiaAnterior.Location = new System.Drawing.Point(6, 32);
            this.lblDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaAnterior.Name = "lblDiaAnterior";
            this.lblDiaAnterior.Size = new System.Drawing.Size(153, 20);
            this.lblDiaAnterior.TabIndex = 35;
            this.lblDiaAnterior.Text = "Saldo Caixa Anterior";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(5, 200);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(50, 20);
            this.lblSaldo.TabIndex = 34;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(6, 76);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(99, 20);
            this.lblEntrada.TabIndex = 33;
            this.lblEntrada.Text = "Suprimentos";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(6, 101);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(187, 26);
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
            this.lblSaida.Location = new System.Drawing.Point(7, 140);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(64, 20);
            this.lblSaida.TabIndex = 31;
            this.lblSaida.Text = "Sangria";
            // 
            // lblValorDiaAnterior
            // 
            this.lblValorDiaAnterior.AutoSize = true;
            this.lblValorDiaAnterior.Location = new System.Drawing.Point(6, 52);
            this.lblValorDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDiaAnterior.Name = "lblValorDiaAnterior";
            this.lblValorDiaAnterior.Size = new System.Drawing.Size(65, 20);
            this.lblValorDiaAnterior.TabIndex = 30;
            this.lblValorDiaAnterior.Text = "R$ 0,00";
            // 
            // btnAbrirFechar
            // 
            this.btnAbrirFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFechar.Location = new System.Drawing.Point(6, 278);
            this.btnAbrirFechar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbrirFechar.Name = "btnAbrirFechar";
            this.btnAbrirFechar.Size = new System.Drawing.Size(187, 48);
            this.btnAbrirFechar.TabIndex = 27;
            this.btnAbrirFechar.Text = "Abrir Caixa";
            this.btnAbrirFechar.UseVisualStyleBackColor = true;
            this.btnAbrirFechar.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(6, 165);
            this.tbSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(187, 26);
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
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(13, 9);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(20, 29);
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
            this.gbAporte.Location = new System.Drawing.Point(13, 414);
            this.gbAporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAporte.Name = "gbAporte";
            this.gbAporte.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAporte.Size = new System.Drawing.Size(204, 181);
            this.gbAporte.TabIndex = 41;
            this.gbAporte.TabStop = false;
            this.gbAporte.Text = "Aporte/Sangria";
            // 
            // cbAporte
            // 
            this.cbAporte.AutoSize = true;
            this.cbAporte.Location = new System.Drawing.Point(114, 38);
            this.cbAporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAporte.Name = "cbAporte";
            this.cbAporte.Size = new System.Drawing.Size(76, 24);
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
            this.cbSangria.Location = new System.Drawing.Point(14, 38);
            this.cbSangria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSangria.Name = "cbSangria";
            this.cbSangria.Size = new System.Drawing.Size(83, 24);
            this.cbSangria.TabIndex = 41;
            this.cbSangria.Text = "Sangria";
            this.cbSangria.UseVisualStyleBackColor = true;
            this.cbSangria.Click += new System.EventHandler(this.cbSangria_Click);
            // 
            // lblSangriaAporte
            // 
            this.lblSangriaAporte.AutoSize = true;
            this.lblSangriaAporte.Location = new System.Drawing.Point(9, 61);
            this.lblSangriaAporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSangriaAporte.Name = "lblSangriaAporte";
            this.lblSangriaAporte.Size = new System.Drawing.Size(72, 20);
            this.lblSangriaAporte.TabIndex = 39;
            this.lblSangriaAporte.Text = "Sangria: ";
            // 
            // tbSangriaAporte
            // 
            this.tbSangriaAporte.Location = new System.Drawing.Point(9, 86);
            this.tbSangriaAporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSangriaAporte.Name = "tbSangriaAporte";
            this.tbSangriaAporte.Size = new System.Drawing.Size(187, 26);
            this.tbSangriaAporte.TabIndex = 38;
            this.tbSangriaAporte.Text = "R$ 0,00";
            this.tbSangriaAporte.Click += new System.EventHandler(this.tbSangriaAporte_Click);
            this.tbSangriaAporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSangriaAporte_KeyPress);
            this.tbSangriaAporte.Leave += new System.EventHandler(this.tbSangriaAporte_Leave);
            // 
            // btnSangriaAporte
            // 
            this.btnSangriaAporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSangriaAporte.Location = new System.Drawing.Point(9, 122);
            this.btnSangriaAporte.Margin = new System.Windows.Forms.Padding(6);
            this.btnSangriaAporte.Name = "btnSangriaAporte";
            this.btnSangriaAporte.Size = new System.Drawing.Size(186, 48);
            this.btnSangriaAporte.TabIndex = 28;
            this.btnSangriaAporte.Text = "Realizar";
            this.btnSangriaAporte.UseVisualStyleBackColor = true;
            this.btnSangriaAporte.Click += new System.EventHandler(this.btnSangriaAporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblResumoVendasTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblResumoVendasDebito);
            this.groupBox1.Controls.Add(this.lblResumoVendasCredito);
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(174, 230);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartão:";
            // 
            // lblResumoVendasDebito
            // 
            this.lblResumoVendasDebito.AutoSize = true;
            this.lblResumoVendasDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasDebito.Location = new System.Drawing.Point(7, 58);
            this.lblResumoVendasDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasDebito.Name = "lblResumoVendasDebito";
            this.lblResumoVendasDebito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoVendasDebito.TabIndex = 2;
            this.lblResumoVendasDebito.Text = "R$ 0,00";
            // 
            // lblResumoVendasCredito
            // 
            this.lblResumoVendasCredito.AutoSize = true;
            this.lblResumoVendasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasCredito.Location = new System.Drawing.Point(7, 126);
            this.lblResumoVendasCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasCredito.Name = "lblResumoVendasCredito";
            this.lblResumoVendasCredito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoVendasCredito.TabIndex = 1;
            this.lblResumoVendasCredito.Text = "R$ 0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblResumoSangria);
            this.groupBox2.Controls.Add(this.lblResumoAporte);
            this.groupBox2.Location = new System.Drawing.Point(29, 410);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(195, 165);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte/Sangria";
            // 
            // lblResumoSangria
            // 
            this.lblResumoSangria.AutoSize = true;
            this.lblResumoSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoSangria.Location = new System.Drawing.Point(8, 123);
            this.lblResumoSangria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoSangria.Name = "lblResumoSangria";
            this.lblResumoSangria.Size = new System.Drawing.Size(72, 20);
            this.lblResumoSangria.TabIndex = 4;
            this.lblResumoSangria.Text = "R$ 0,00";
            // 
            // lblResumoAporte
            // 
            this.lblResumoAporte.AutoSize = true;
            this.lblResumoAporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoAporte.Location = new System.Drawing.Point(8, 57);
            this.lblResumoAporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoAporte.Name = "lblResumoAporte";
            this.lblResumoAporte.Size = new System.Drawing.Size(72, 20);
            this.lblResumoAporte.TabIndex = 3;
            this.lblResumoAporte.Text = "R$ 0,00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblResumoVendasDinheiro);
            this.groupBox5.Location = new System.Drawing.Point(7, 267);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(174, 96);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dinheiro";
            // 
            // lblResumoVendasDinheiro
            // 
            this.lblResumoVendasDinheiro.AutoSize = true;
            this.lblResumoVendasDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasDinheiro.Location = new System.Drawing.Point(6, 41);
            this.lblResumoVendasDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasDinheiro.Name = "lblResumoVendasDinheiro";
            this.lblResumoVendasDinheiro.Size = new System.Drawing.Size(72, 20);
            this.lblResumoVendasDinheiro.TabIndex = 5;
            this.lblResumoVendasDinheiro.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "F1 - Consultar Caixas Anteriores.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(933, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 371);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalCancelamento);
            this.groupBox6.Location = new System.Drawing.Point(479, 448);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(188, 94);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cancelamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Débito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Crédito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Crédito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Débito";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Total:";
            // 
            // gngngn
            // 
            this.gngngn.Controls.Add(this.label5);
            this.gngngn.Controls.Add(this.lblResumoDespesasDinheiro);
            this.gngngn.Controls.Add(this.label6);
            this.gngngn.Controls.Add(this.label7);
            this.gngngn.Controls.Add(this.lblResumoDespesasCredito);
            this.gngngn.Controls.Add(this.lblResumoDespesasDebito);
            this.gngngn.Location = new System.Drawing.Point(254, 410);
            this.gngngn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gngngn.Name = "gngngn";
            this.gngngn.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gngngn.Size = new System.Drawing.Size(195, 165);
            this.gngngn.TabIndex = 47;
            this.gngngn.TabStop = false;
            this.gngngn.Text = "Despesas: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Crédito";
            // 
            // lblResumoDespesasDinheiro
            // 
            this.lblResumoDespesasDinheiro.AutoSize = true;
            this.lblResumoDespesasDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoDespesasDinheiro.Location = new System.Drawing.Point(8, 134);
            this.lblResumoDespesasDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDespesasDinheiro.Name = "lblResumoDespesasDinheiro";
            this.lblResumoDespesasDinheiro.Size = new System.Drawing.Size(72, 20);
            this.lblResumoDespesasDinheiro.TabIndex = 7;
            this.lblResumoDespesasDinheiro.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Débito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Total:";
            // 
            // lblResumoDespesasCredito
            // 
            this.lblResumoDespesasCredito.AutoSize = true;
            this.lblResumoDespesasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoDespesasCredito.Location = new System.Drawing.Point(8, 90);
            this.lblResumoDespesasCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDespesasCredito.Name = "lblResumoDespesasCredito";
            this.lblResumoDespesasCredito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoDespesasCredito.TabIndex = 6;
            this.lblResumoDespesasCredito.Text = "R$ 0,00";
            // 
            // lblResumoDespesasDebito
            // 
            this.lblResumoDespesasDebito.AutoSize = true;
            this.lblResumoDespesasDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoDespesasDebito.Location = new System.Drawing.Point(8, 46);
            this.lblResumoDespesasDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDespesasDebito.Name = "lblResumoDespesasDebito";
            this.lblResumoDespesasDebito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoDespesasDebito.TabIndex = 5;
            this.lblResumoDespesasDebito.Text = "R$ 0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "Sangria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Aporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total:";
            // 
            // lblResumoVendasTotal
            // 
            this.lblResumoVendasTotal.AutoSize = true;
            this.lblResumoVendasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasTotal.Location = new System.Drawing.Point(7, 194);
            this.lblResumoVendasTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasTotal.Name = "lblResumoVendasTotal";
            this.lblResumoVendasTotal.Size = new System.Drawing.Size(72, 20);
            this.lblResumoVendasTotal.TabIndex = 52;
            this.lblResumoVendasTotal.Text = "R$ 0,00";
            // 
            // FormAbrirFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 635);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.gbAbrirFechar);
            this.Controls.Add(this.gbAporte);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAbrirFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.lvl.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            this.gbAbrirFechar.ResumeLayout(false);
            this.gbAbrirFechar.PerformLayout();
            this.gbAporte.ResumeLayout(false);
            this.gbAporte.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gngngn.ResumeLayout(false);
            this.gngngn.PerformLayout();
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
        private System.Windows.Forms.Label lblResumoVendasDebito;
        private System.Windows.Forms.Label lblResumoVendasCredito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResumoSangria;
        private System.Windows.Forms.Label lblResumoAporte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblResumoVendasDinheiro;
        private System.Windows.Forms.Label lblDiaAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCancelamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblResumoComprasDinheiro;
        private System.Windows.Forms.Label lblResumoComprasCredito;
        private System.Windows.Forms.Label lblResumoComprasDebito;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gngngn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResumoDespesasDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResumoDespesasCredito;
        private System.Windows.Forms.Label lblResumoDespesasDebito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResumoVendasTotal;
    }
}
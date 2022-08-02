namespace sisVendas.Telas.Caixa
{
    partial class FormControleCaixa
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblResumoComprasDebito = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnAbrirFechar = new System.Windows.Forms.Button();
            this.gngngn = new System.Windows.Forms.GroupBox();
            this.lblResumoDespesasDebito = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbAporte = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblResumoSangria = new System.Windows.Forms.Label();
            this.lblResumoAporte = new System.Windows.Forms.Label();
            this.cbSangria = new System.Windows.Forms.CheckBox();
            this.lblSangriaAporte = new System.Windows.Forms.Label();
            this.tbSangriaAporte = new System.Windows.Forms.TextBox();
            this.btnSangriaAporte = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.GroupBox();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResumoVendasDinheiro = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.gbAporte = new System.Windows.Forms.GroupBox();
            this.gbAbrirFecha = new System.Windows.Forms.GroupBox();
            this.lblDiaAnterior = new System.Windows.Forms.Label();
            this.lblValorDiaAnterior = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.gngngn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbAporte.SuspendLayout();
            this.gbAbrirFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblResumoComprasDebito);
            this.groupBox4.Location = new System.Drawing.Point(933, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(186, 120);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras:";
            // 
            // lblResumoComprasDebito
            // 
            this.lblResumoComprasDebito.AutoSize = true;
            this.lblResumoComprasDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoComprasDebito.Location = new System.Drawing.Point(9, 52);
            this.lblResumoComprasDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoComprasDebito.Name = "lblResumoComprasDebito";
            this.lblResumoComprasDebito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoComprasDebito.TabIndex = 5;
            this.lblResumoComprasDebito.Text = "R$ 0,00";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(5, 200);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 34;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(6, 76);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(65, 13);
            this.lblEntrada.TabIndex = 33;
            this.lblEntrada.Text = "Suprimentos";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(6, 101);
            this.tbEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(187, 20);
            this.tbEntrada.TabIndex = 32;
            this.tbEntrada.Text = "R$ 0,00";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(7, 140);
            this.lblSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(43, 13);
            this.lblSaida.TabIndex = 31;
            this.lblSaida.Text = "Sangria";
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
            this.btnAbrirFechar.Click += new System.EventHandler(this.btnAbrirFechar_Click);
            // 
            // gngngn
            // 
            this.gngngn.Controls.Add(this.lblResumoDespesasDebito);
            this.gngngn.Location = new System.Drawing.Point(933, 290);
            this.gngngn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gngngn.Name = "gngngn";
            this.gngngn.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gngngn.Size = new System.Drawing.Size(186, 120);
            this.gngngn.TabIndex = 55;
            this.gngngn.TabStop = false;
            this.gngngn.Text = "Despesas: ";
            // 
            // lblResumoDespesasDebito
            // 
            this.lblResumoDespesasDebito.AutoSize = true;
            this.lblResumoDespesasDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoDespesasDebito.Location = new System.Drawing.Point(9, 54);
            this.lblResumoDespesasDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoDespesasDebito.Name = "lblResumoDespesasDebito";
            this.lblResumoDespesasDebito.Size = new System.Drawing.Size(72, 20);
            this.lblResumoDespesasDebito.TabIndex = 5;
            this.lblResumoDespesasDebito.Text = "R$ 0,00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // cbAporte
            // 
            this.cbAporte.AutoSize = true;
            this.cbAporte.Location = new System.Drawing.Point(114, 38);
            this.cbAporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAporte.Name = "cbAporte";
            this.cbAporte.Size = new System.Drawing.Size(57, 17);
            this.cbAporte.TabIndex = 42;
            this.cbAporte.Text = "Aporte";
            this.cbAporte.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblResumoSangria);
            this.groupBox2.Controls.Add(this.lblResumoAporte);
            this.groupBox2.Location = new System.Drawing.Point(934, 428);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(186, 165);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aporte/Sangria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Sangria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Aporte:";
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
            // cbSangria
            // 
            this.cbSangria.AutoSize = true;
            this.cbSangria.Checked = true;
            this.cbSangria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSangria.Location = new System.Drawing.Point(14, 38);
            this.cbSangria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSangria.Name = "cbSangria";
            this.cbSangria.Size = new System.Drawing.Size(62, 17);
            this.cbSangria.TabIndex = 41;
            this.cbSangria.Text = "Sangria";
            this.cbSangria.UseVisualStyleBackColor = true;
            // 
            // lblSangriaAporte
            // 
            this.lblSangriaAporte.AutoSize = true;
            this.lblSangriaAporte.Location = new System.Drawing.Point(9, 63);
            this.lblSangriaAporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSangriaAporte.Name = "lblSangriaAporte";
            this.lblSangriaAporte.Size = new System.Drawing.Size(49, 13);
            this.lblSangriaAporte.TabIndex = 39;
            this.lblSangriaAporte.Text = "Sangria: ";
            // 
            // tbSangriaAporte
            // 
            this.tbSangriaAporte.Location = new System.Drawing.Point(9, 86);
            this.tbSangriaAporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSangriaAporte.Name = "tbSangriaAporte";
            this.tbSangriaAporte.Size = new System.Drawing.Size(187, 20);
            this.tbSangriaAporte.TabIndex = 38;
            this.tbSangriaAporte.Text = "R$ 0,00";
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
            // 
            // lvl
            // 
            this.lvl.Controls.Add(this.dgvTransacoes);
            this.lvl.Controls.Add(this.label1);
            this.lvl.Location = new System.Drawing.Point(230, 9);
            this.lvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Name = "lvl";
            this.lvl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvl.Size = new System.Drawing.Size(696, 584);
            this.lvl.TabIndex = 50;
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
            this.dgvTransacoes.Location = new System.Drawing.Point(11, 30);
            this.dgvTransacoes.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.RowHeadersVisible = false;
            this.dgvTransacoes.RowTemplate.Height = 25;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(675, 496);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "F1 - Consultar Caixas Anteriores.";
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(6, 165);
            this.tbSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.Size = new System.Drawing.Size(187, 20);
            this.tbSaida.TabIndex = 5;
            this.tbSaida.Text = "R$ 0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResumoVendasDinheiro);
            this.groupBox3.Location = new System.Drawing.Point(933, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 120);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // lblResumoVendasDinheiro
            // 
            this.lblResumoVendasDinheiro.AutoSize = true;
            this.lblResumoVendasDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumoVendasDinheiro.Location = new System.Drawing.Point(9, 54);
            this.lblResumoVendasDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumoVendasDinheiro.Name = "lblResumoVendasDinheiro";
            this.lblResumoVendasDinheiro.Size = new System.Drawing.Size(72, 20);
            this.lblResumoVendasDinheiro.TabIndex = 5;
            this.lblResumoVendasDinheiro.Text = "R$ 0,00";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(6, 225);
            this.tbSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(187, 20);
            this.tbSaldo.TabIndex = 5;
            this.tbSaldo.Text = "R$ 0,00";
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
            this.gbAporte.Size = new System.Drawing.Size(204, 179);
            this.gbAporte.TabIndex = 52;
            this.gbAporte.TabStop = false;
            this.gbAporte.Text = "Aporte/Sangria";
            // 
            // gbAbrirFecha
            // 
            this.gbAbrirFecha.Controls.Add(this.lblDiaAnterior);
            this.gbAbrirFecha.Controls.Add(this.lblSaldo);
            this.gbAbrirFecha.Controls.Add(this.tbSaldo);
            this.gbAbrirFecha.Controls.Add(this.lblEntrada);
            this.gbAbrirFecha.Controls.Add(this.tbEntrada);
            this.gbAbrirFecha.Controls.Add(this.lblSaida);
            this.gbAbrirFecha.Controls.Add(this.lblValorDiaAnterior);
            this.gbAbrirFecha.Controls.Add(this.btnAbrirFechar);
            this.gbAbrirFecha.Controls.Add(this.tbSaida);
            this.gbAbrirFecha.Location = new System.Drawing.Point(13, 52);
            this.gbAbrirFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAbrirFecha.Name = "gbAbrirFecha";
            this.gbAbrirFecha.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAbrirFecha.Size = new System.Drawing.Size(204, 356);
            this.gbAbrirFecha.TabIndex = 49;
            this.gbAbrirFecha.TabStop = false;
            this.gbAbrirFecha.Text = "Abrir Caixa";
            // 
            // lblDiaAnterior
            // 
            this.lblDiaAnterior.AutoSize = true;
            this.lblDiaAnterior.Location = new System.Drawing.Point(6, 32);
            this.lblDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaAnterior.Name = "lblDiaAnterior";
            this.lblDiaAnterior.Size = new System.Drawing.Size(102, 13);
            this.lblDiaAnterior.TabIndex = 35;
            this.lblDiaAnterior.Text = "Saldo Caixa Anterior";
            // 
            // lblValorDiaAnterior
            // 
            this.lblValorDiaAnterior.AutoSize = true;
            this.lblValorDiaAnterior.Location = new System.Drawing.Point(6, 52);
            this.lblValorDiaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDiaAnterior.Name = "lblValorDiaAnterior";
            this.lblValorDiaAnterior.Size = new System.Drawing.Size(45, 13);
            this.lblValorDiaAnterior.TabIndex = 30;
            this.lblValorDiaAnterior.Text = "R$ 0,00";
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
            this.lblDate.TabIndex = 51;
            this.lblDate.Text = ".";
            // 
            // FormControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 599);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gngngn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbAbrirFecha);
            this.Controls.Add(this.gbAporte);
            this.Controls.Add(this.lblDate);
            this.Name = "FormControleCaixa";
            this.Text = "Automações Brasil - Caixa";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gngngn.ResumeLayout(false);
            this.gngngn.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lvl.ResumeLayout(false);
            this.lvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbAporte.ResumeLayout(false);
            this.gbAporte.PerformLayout();
            this.gbAbrirFecha.ResumeLayout(false);
            this.gbAbrirFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblResumoComprasDebito;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnAbrirFechar;
        private System.Windows.Forms.GroupBox gngngn;
        private System.Windows.Forms.Label lblResumoDespesasDebito;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbAporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblResumoSangria;
        private System.Windows.Forms.Label lblResumoAporte;
        private System.Windows.Forms.CheckBox cbSangria;
        private System.Windows.Forms.Label lblSangriaAporte;
        private System.Windows.Forms.TextBox tbSangriaAporte;
        private System.Windows.Forms.Button btnSangriaAporte;
        private System.Windows.Forms.GroupBox lvl;
        private System.Windows.Forms.DataGridView dgvTransacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResumoVendasDinheiro;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.GroupBox gbAporte;
        private System.Windows.Forms.GroupBox gbAbrirFecha;
        private System.Windows.Forms.Label lblValorDiaAnterior;
        private System.Windows.Forms.Label lblDiaAnterior;
        private System.Windows.Forms.Label lblDate;
    }
}
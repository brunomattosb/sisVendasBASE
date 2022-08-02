namespace sisVendas.Screens.Sale
{
    partial class FormVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelTitleVendas = new System.Windows.Forms.Panel();
            this.timer_sale = new System.Windows.Forms.Timer(this.components);
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_dentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_fora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbValorUn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWarningCpf = new System.Windows.Forms.Label();
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCpfClient = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.botaoF5 = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.botaoF12 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTextDesconto = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitleVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbProduto.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(26, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(27, 39);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = ".";
            // 
            // panelTitleVendas
            // 
            this.panelTitleVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(152)))));
            this.panelTitleVendas.Controls.Add(this.lblDate);
            this.panelTitleVendas.Location = new System.Drawing.Point(0, 0);
            this.panelTitleVendas.Name = "panelTitleVendas";
            this.panelTitleVendas.Size = new System.Drawing.Size(1232, 55);
            this.panelTitleVendas.TabIndex = 2;
            // 
            // timer_sale
            // 
            this.timer_sale.Enabled = true;
            this.timer_sale.Interval = 1000;
            this.timer_sale.Tick += new System.EventHandler(this.timer_sale_Tick_1);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 44;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.ncm,
            this.cod_barras,
            this.cfop_dentro,
            this.cfop_fora,
            this.name,
            this.amount,
            this.un,
            this.valueUn,
            this.valueTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(12, 454);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1208, 207);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // cod
            // 
            this.cod.DataPropertyName = "codigo";
            this.cod.HeaderText = "COD";
            this.cod.MinimumWidth = 150;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 150;
            // 
            // ncm
            // 
            this.ncm.DataPropertyName = "ncm";
            this.ncm.HeaderText = "ncm";
            this.ncm.Name = "ncm";
            this.ncm.ReadOnly = true;
            this.ncm.Visible = false;
            // 
            // cod_barras
            // 
            this.cod_barras.DataPropertyName = "cod_barras";
            this.cod_barras.HeaderText = "cod_barras";
            this.cod_barras.Name = "cod_barras";
            this.cod_barras.ReadOnly = true;
            this.cod_barras.Visible = false;
            // 
            // cfop_dentro
            // 
            this.cfop_dentro.DataPropertyName = "cfop_dentro";
            this.cfop_dentro.HeaderText = "cfop_dentro";
            this.cfop_dentro.Name = "cfop_dentro";
            this.cfop_dentro.ReadOnly = true;
            this.cfop_dentro.Visible = false;
            // 
            // cfop_fora
            // 
            this.cfop_fora.DataPropertyName = "cfop_fora";
            this.cfop_fora.HeaderText = "cfop_fora";
            this.cfop_fora.Name = "cfop_fora";
            this.cfop_fora.ReadOnly = true;
            this.cfop_fora.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "nome";
            this.name.HeaderText = "NOME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "quantidade";
            this.amount.HeaderText = "QTDE";
            this.amount.MinimumWidth = 100;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // un
            // 
            this.un.DataPropertyName = "un";
            this.un.HeaderText = "UN";
            this.un.MinimumWidth = 100;
            this.un.Name = "un";
            this.un.ReadOnly = true;
            // 
            // valueUn
            // 
            this.valueUn.DataPropertyName = "valor_un";
            this.valueUn.HeaderText = "VALOR UN";
            this.valueUn.MinimumWidth = 200;
            this.valueUn.Name = "valueUn";
            this.valueUn.ReadOnly = true;
            this.valueUn.Width = 200;
            // 
            // valueTotal
            // 
            this.valueTotal.DataPropertyName = "valor_total";
            this.valueTotal.HeaderText = "TOTAL";
            this.valueTotal.MinimumWidth = 200;
            this.valueTotal.Name = "valueTotal";
            this.valueTotal.ReadOnly = true;
            this.valueTotal.Width = 200;
            // 
            // gbProduto
            // 
            this.gbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProduto.BackColor = System.Drawing.Color.Transparent;
            this.gbProduto.Controls.Add(this.tbValorTotal);
            this.gbProduto.Controls.Add(this.label8);
            this.gbProduto.Controls.Add(this.tbValorUn);
            this.gbProduto.Controls.Add(this.label7);
            this.gbProduto.Controls.Add(this.tbAmount);
            this.gbProduto.Controls.Add(this.label5);
            this.gbProduto.Controls.Add(this.tbNameProduct);
            this.gbProduto.Controls.Add(this.label4);
            this.gbProduto.Controls.Add(this.tbCodProduct);
            this.gbProduto.Controls.Add(this.label3);
            this.gbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduto.Location = new System.Drawing.Point(19, 253);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(770, 195);
            this.gbProduto.TabIndex = 4;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Location = new System.Drawing.Point(511, 151);
            this.tbValorTotal.MaxLength = 8;
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(209, 31);
            this.tbValorTotal.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Valor Total:";
            // 
            // tbValorUn
            // 
            this.tbValorUn.Enabled = false;
            this.tbValorUn.Location = new System.Drawing.Point(243, 151);
            this.tbValorUn.MaxLength = 8;
            this.tbValorUn.Name = "tbValorUn";
            this.tbValorUn.Size = new System.Drawing.Size(209, 31);
            this.tbValorUn.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Valor UN:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(45, 151);
            this.tbAmount.MaxLength = 8;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(113, 31);
            this.tbAmount.TabIndex = 48;
            this.tbAmount.Text = "1";
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Qtde:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Enabled = false;
            this.tbNameProduct.Location = new System.Drawing.Point(219, 63);
            this.tbNameProduct.MaxLength = 49;
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(545, 31);
            this.tbNameProduct.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Produto:";
            // 
            // tbCodProduct
            // 
            this.tbCodProduct.Location = new System.Drawing.Point(14, 63);
            this.tbCodProduct.MaxLength = 39;
            this.tbCodProduct.Name = "tbCodProduct";
            this.tbCodProduct.Size = new System.Drawing.Size(199, 31);
            this.tbCodProduct.TabIndex = 44;
            this.tbCodProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodProduct_KeyPress);
            this.tbCodProduct.Leave += new System.EventHandler(this.tbCodProduct_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código:";
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.button2);
            this.gbCliente.Controls.Add(this.button1);
            this.gbCliente.Controls.Add(this.lblWarningCpf);
            this.gbCliente.Controls.Add(this.tbNameClient);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.mtbCpfClient);
            this.gbCliente.Controls.Add(this.lblCpf);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(19, 64);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(776, 169);
            this.gbCliente.TabIndex = 3;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 46;
            this.button2.Text = "Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 45;
            this.button1.Text = "Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWarningCpf
            // 
            this.lblWarningCpf.AutoSize = true;
            this.lblWarningCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblWarningCpf.ForeColor = System.Drawing.Color.Red;
            this.lblWarningCpf.Location = new System.Drawing.Point(9, 118);
            this.lblWarningCpf.Name = "lblWarningCpf";
            this.lblWarningCpf.Size = new System.Drawing.Size(18, 25);
            this.lblWarningCpf.TabIndex = 44;
            this.lblWarningCpf.Text = ".";
            this.lblWarningCpf.Visible = false;
            // 
            // tbNameClient
            // 
            this.tbNameClient.Location = new System.Drawing.Point(248, 69);
            this.tbNameClient.MaxLength = 49;
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(522, 31);
            this.tbNameClient.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome:";
            // 
            // mtbCpfClient
            // 
            this.mtbCpfClient.Location = new System.Drawing.Point(11, 69);
            this.mtbCpfClient.Mask = "000.000.000-00";
            this.mtbCpfClient.Name = "mtbCpfClient";
            this.mtbCpfClient.Size = new System.Drawing.Size(231, 31);
            this.mtbCpfClient.TabIndex = 3;
            this.mtbCpfClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpfClient.Click += new System.EventHandler(this.mtbCpfClient_Click);
            this.mtbCpfClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbCpfClient_KeyUp);
            this.mtbCpfClient.Leave += new System.EventHandler(this.mtbCpfClient_Leave);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(9, 41);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(68, 25);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "*CPF:";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(4, 4);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(1);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(233, 26);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.TabStop = false;
            this.btnPesquisarCliente.Text = "F1 - Pesquisar Cliente";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(4, 39);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(1);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(233, 26);
            this.btnPesquisarProduto.TabIndex = 15;
            this.btnPesquisarProduto.TabStop = false;
            this.btnPesquisarProduto.Text = "F2 - Pesquisa Produto";
            this.btnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(245, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 26);
            this.button5.TabIndex = 25;
            this.button5.TabStop = false;
            this.button5.Text = "F4 - Nova Venda";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // botaoF5
            // 
            this.botaoF5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoF5.BackColor = System.Drawing.Color.Transparent;
            this.botaoF5.FlatAppearance.BorderSize = 0;
            this.botaoF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF5.ForeColor = System.Drawing.Color.Black;
            this.botaoF5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF5.Location = new System.Drawing.Point(245, 39);
            this.botaoF5.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF5.Name = "botaoF5";
            this.botaoF5.Size = new System.Drawing.Size(233, 26);
            this.botaoF5.TabIndex = 14;
            this.botaoF5.Text = "F5 - Recuperar Venda";
            this.botaoF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF5.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarVenda.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVenda.Location = new System.Drawing.Point(486, 4);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(233, 26);
            this.btnCancelarVenda.TabIndex = 18;
            this.btnCancelarVenda.TabStop = false;
            this.btnCancelarVenda.Text = "F6 - Cancela Venda";
            this.btnCancelarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(486, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 26);
            this.button3.TabIndex = 24;
            this.button3.TabStop = false;
            this.button3.Text = "F9 - Compensar Parcelas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesconto.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconto.FlatAppearance.BorderSize = 0;
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconto.ForeColor = System.Drawing.Color.Black;
            this.btnDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconto.Location = new System.Drawing.Point(727, 4);
            this.btnDesconto.Margin = new System.Windows.Forms.Padding(1);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(233, 26);
            this.btnDesconto.TabIndex = 26;
            this.btnDesconto.TabStop = false;
            this.btnDesconto.Text = "F11 - Desconto";
            this.btnDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesconto.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVenda.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(727, 39);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(1);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(233, 26);
            this.btnFinalizarVenda.TabIndex = 23;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "F12 - Finalizar Venda";
            this.btnFinalizarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            // 
            // botaoF12
            // 
            this.botaoF12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoF12.BackColor = System.Drawing.Color.Transparent;
            this.botaoF12.FlatAppearance.BorderSize = 0;
            this.botaoF12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF12.ForeColor = System.Drawing.Color.Black;
            this.botaoF12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF12.Location = new System.Drawing.Point(969, 4);
            this.botaoF12.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF12.Name = "botaoF12";
            this.botaoF12.Size = new System.Drawing.Size(233, 26);
            this.botaoF12.TabIndex = 21;
            this.botaoF12.TabStop = false;
            this.botaoF12.Text = "[ESC] - Sair";
            this.botaoF12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF12.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(848, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 42);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 42);
            this.label1.TabIndex = 51;
            this.label1.Text = "SUBTOTAL";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(848, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 42);
            this.label6.TabIndex = 52;
            this.label6.Text = "TOTAL";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(848, 224);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(149, 42);
            this.lblSubtotal.TabIndex = 53;
            this.lblSubtotal.Text = "R$ 0,00";
            // 
            // lblTextDesconto
            // 
            this.lblTextDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextDesconto.AutoSize = true;
            this.lblTextDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextDesconto.Location = new System.Drawing.Point(848, 278);
            this.lblTextDesconto.Name = "lblTextDesconto";
            this.lblTextDesconto.Size = new System.Drawing.Size(230, 42);
            this.lblTextDesconto.TabIndex = 55;
            this.lblTextDesconto.Text = "DESCONTO";
            this.lblTextDesconto.Visible = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(848, 320);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(149, 42);
            this.lblDesconto.TabIndex = 54;
            this.lblDesconto.Text = "R$ 0,00";
            this.lblDesconto.Visible = false;
            // 
            // lblCancelada
            // 
            this.lblCancelada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelada.ForeColor = System.Drawing.Color.Red;
            this.lblCancelada.Location = new System.Drawing.Point(848, 388);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(247, 42);
            this.lblCancelada.TabIndex = 56;
            this.lblCancelada.Text = "CANCELADA";
            this.lblCancelada.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisarCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisarProduto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botaoF5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarVenda, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDesconto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFinalizarVenda, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.botaoF12, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 667);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 70);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCancelada);
            this.Controls.Add(this.lblTextDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelTitleVendas);
            this.MinimumSize = new System.Drawing.Size(1248, 726);
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisVendas Automações Brasil";
            this.panelTitleVendas.ResumeLayout(false);
            this.panelTitleVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelTitleVendas;
        private System.Windows.Forms.Timer timer_sale;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblWarningCpf;
        private System.Windows.Forms.TextBox tbNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCpfClient;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button botaoF5;
        private System.Windows.Forms.Button botaoF12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTextDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbValorUn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCancelada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_dentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_fora;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn un;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotal;
    }
}
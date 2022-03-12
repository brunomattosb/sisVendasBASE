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
            this.lblDate = new System.Windows.Forms.Label();
            this.panelTitleVendas = new System.Windows.Forms.Panel();
            this.timer_sale = new System.Windows.Forms.Timer(this.components);
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarningCpf = new System.Windows.Forms.Label();
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCpfClient = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.Bobina = new System.Windows.Forms.ListBox();
            this.PanelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.botaoF1 = new System.Windows.Forms.Button();
            this.botaoF6 = new System.Windows.Forms.Button();
            this.botaoF9 = new System.Windows.Forms.Button();
            this.botaoF5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botaoF8 = new System.Windows.Forms.Button();
            this.botaoF12 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panelTitleVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
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
            this.timer_sale.Tick += new System.EventHandler(this.timer_sale_Tick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cod,
            this.un,
            this.amount,
            this.valueUn,
            this.valueTotal});
            this.dgvProducts.Location = new System.Drawing.Point(19, 468);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(751, 288);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cod";
            this.cod.HeaderText = "Código";
            this.cod.MinimumWidth = 150;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 150;
            // 
            // un
            // 
            this.un.DataPropertyName = "un";
            this.un.HeaderText = "UN";
            this.un.MinimumWidth = 50;
            this.un.Name = "un";
            this.un.ReadOnly = true;
            this.un.Width = 50;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Quantidade";
            this.amount.MinimumWidth = 50;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 55;
            // 
            // valueUn
            // 
            this.valueUn.DataPropertyName = "valueUn";
            this.valueUn.HeaderText = "Valor UN";
            this.valueUn.MinimumWidth = 100;
            this.valueUn.Name = "valueUn";
            this.valueUn.ReadOnly = true;
            // 
            // valueTotal
            // 
            this.valueTotal.DataPropertyName = "valueTotal";
            this.valueTotal.HeaderText = "Total";
            this.valueTotal.MinimumWidth = 100;
            this.valueTotal.Name = "valueTotal";
            this.valueTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNameProduct);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbCodProduct);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(14, 151);
            this.tbAmount.MaxLength = 8;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(113, 31);
            this.tbAmount.TabIndex = 48;
            this.tbAmount.Text = "1";
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Qtde:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Enabled = false;
            this.tbNameProduct.Location = new System.Drawing.Point(195, 63);
            this.tbNameProduct.MaxLength = 49;
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(541, 31);
            this.tbNameProduct.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 35);
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
            this.tbCodProduct.Size = new System.Drawing.Size(173, 31);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblWarningCpf);
            this.groupBox1.Controls.Add(this.tbNameClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbCpfClient);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
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
            this.tbNameClient.Location = new System.Drawing.Point(195, 69);
            this.tbNameClient.MaxLength = 49;
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(541, 31);
            this.tbNameClient.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome:";
            // 
            // mtbCpfClient
            // 
            this.mtbCpfClient.Location = new System.Drawing.Point(11, 69);
            this.mtbCpfClient.Mask = "999.999.999-99";
            this.mtbCpfClient.Name = "mtbCpfClient";
            this.mtbCpfClient.Size = new System.Drawing.Size(176, 31);
            this.mtbCpfClient.TabIndex = 3;
            this.mtbCpfClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpfClient.Click += new System.EventHandler(this.mtbCpfClient_Click);
            this.mtbCpfClient.Enter += new System.EventHandler(this.mtbCpfClient_Enter);
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
            // Bobina
            // 
            this.Bobina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bobina.BackColor = System.Drawing.Color.LightYellow;
            this.Bobina.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Bobina.ForeColor = System.Drawing.Color.Black;
            this.Bobina.ItemHeight = 16;
            this.Bobina.Location = new System.Drawing.Point(795, 68);
            this.Bobina.Name = "Bobina";
            this.Bobina.Size = new System.Drawing.Size(422, 612);
            this.Bobina.TabIndex = 7;
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBotoes.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotoes.Controls.Add(this.botaoF1);
            this.PanelBotoes.Controls.Add(this.botaoF6);
            this.PanelBotoes.Controls.Add(this.botaoF9);
            this.PanelBotoes.Controls.Add(this.botaoF5);
            this.PanelBotoes.Controls.Add(this.button1);
            this.PanelBotoes.Controls.Add(this.button3);
            this.PanelBotoes.Controls.Add(this.button2);
            this.PanelBotoes.Controls.Add(this.botaoF8);
            this.PanelBotoes.Controls.Add(this.botaoF12);
            this.PanelBotoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBotoes.Location = new System.Drawing.Point(2, 770);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(1226, 62);
            this.PanelBotoes.TabIndex = 49;
            // 
            // botaoF1
            // 
            this.botaoF1.BackColor = System.Drawing.Color.Transparent;
            this.botaoF1.FlatAppearance.BorderSize = 0;
            this.botaoF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF1.ForeColor = System.Drawing.Color.Black;
            this.botaoF1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF1.Location = new System.Drawing.Point(1, 1);
            this.botaoF1.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF1.Name = "botaoF1";
            this.botaoF1.Size = new System.Drawing.Size(195, 26);
            this.botaoF1.TabIndex = 0;
            this.botaoF1.TabStop = false;
            this.botaoF1.Text = "F1 - Pesquisar Cliente";
            this.botaoF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF1.UseVisualStyleBackColor = false;
            // 
            // botaoF6
            // 
            this.botaoF6.BackColor = System.Drawing.Color.Transparent;
            this.botaoF6.FlatAppearance.BorderSize = 0;
            this.botaoF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF6.ForeColor = System.Drawing.Color.Black;
            this.botaoF6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF6.Location = new System.Drawing.Point(1, 29);
            this.botaoF6.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF6.Name = "botaoF6";
            this.botaoF6.Size = new System.Drawing.Size(195, 26);
            this.botaoF6.TabIndex = 15;
            this.botaoF6.TabStop = false;
            this.botaoF6.Text = "F2 - Pesquisa Produto";
            this.botaoF6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF6.UseVisualStyleBackColor = false;
            // 
            // botaoF9
            // 
            this.botaoF9.BackColor = System.Drawing.Color.Transparent;
            this.botaoF9.FlatAppearance.BorderSize = 0;
            this.botaoF9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF9.ForeColor = System.Drawing.Color.Black;
            this.botaoF9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF9.Location = new System.Drawing.Point(198, 1);
            this.botaoF9.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF9.Name = "botaoF9";
            this.botaoF9.Size = new System.Drawing.Size(195, 26);
            this.botaoF9.TabIndex = 18;
            this.botaoF9.TabStop = false;
            this.botaoF9.Text = " - Cancela Venda";
            this.botaoF9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF9.UseVisualStyleBackColor = false;
            // 
            // botaoF5
            // 
            this.botaoF5.BackColor = System.Drawing.Color.Transparent;
            this.botaoF5.FlatAppearance.BorderSize = 0;
            this.botaoF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF5.ForeColor = System.Drawing.Color.Black;
            this.botaoF5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF5.Location = new System.Drawing.Point(198, 29);
            this.botaoF5.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF5.Name = "botaoF5";
            this.botaoF5.Size = new System.Drawing.Size(195, 26);
            this.botaoF5.TabIndex = 14;
            this.botaoF5.TabStop = false;
            this.botaoF5.Text = " - Recuperar Venda";
            this.botaoF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(395, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 26);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "F9 - Calcular Troco";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(395, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 26);
            this.button3.TabIndex = 24;
            this.button3.TabStop = false;
            this.button3.Text = "F10 - Simular Venda";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(592, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 26);
            this.button2.TabIndex = 23;
            this.button2.TabStop = false;
            this.button2.Text = "F12 - Finalizar Venda";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // botaoF8
            // 
            this.botaoF8.BackColor = System.Drawing.Color.Transparent;
            this.botaoF8.FlatAppearance.BorderSize = 0;
            this.botaoF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF8.ForeColor = System.Drawing.Color.Black;
            this.botaoF8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF8.Location = new System.Drawing.Point(592, 29);
            this.botaoF8.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF8.Name = "botaoF8";
            this.botaoF8.Size = new System.Drawing.Size(195, 26);
            this.botaoF8.TabIndex = 17;
            this.botaoF8.TabStop = false;
            this.botaoF8.Text = " [-] Remover Item";
            this.botaoF8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF8.UseVisualStyleBackColor = false;
            // 
            // botaoF12
            // 
            this.botaoF12.BackColor = System.Drawing.Color.Transparent;
            this.botaoF12.FlatAppearance.BorderSize = 0;
            this.botaoF12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF12.ForeColor = System.Drawing.Color.Black;
            this.botaoF12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF12.Location = new System.Drawing.Point(789, 1);
            this.botaoF12.Margin = new System.Windows.Forms.Padding(1);
            this.botaoF12.Name = "botaoF12";
            this.botaoF12.Size = new System.Drawing.Size(195, 26);
            this.botaoF12.TabIndex = 21;
            this.botaoF12.TabStop = false;
            this.botaoF12.Text = "[ESC] - Sai do Caixa";
            this.botaoF12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoF12.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(825, 690);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 33);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total: R$ ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(906, 723);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 33);
            this.lblDiscount.TabIndex = 61;
            this.lblDiscount.Text = "R$";
            this.lblDiscount.Visible = false;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 844);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.PanelBotoes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bobina);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelTitleVendas);
            this.MinimumSize = new System.Drawing.Size(1248, 858);
            this.Name = "FormVenda";
            this.Text = "Sale";
            this.panelTitleVendas.ResumeLayout(false);
            this.panelTitleVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelTitleVendas;
        private System.Windows.Forms.Timer timer_sale;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarningCpf;
        private System.Windows.Forms.TextBox tbNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCpfClient;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodProduct;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox Bobina;
        private System.Windows.Forms.FlowLayoutPanel PanelBotoes;
        private System.Windows.Forms.Button botaoF1;
        private System.Windows.Forms.Button botaoF6;
        private System.Windows.Forms.Button botaoF8;
        private System.Windows.Forms.Button botaoF9;
        private System.Windows.Forms.Button botaoF5;
        private System.Windows.Forms.Button botaoF12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn un;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueTotal;
    }
}
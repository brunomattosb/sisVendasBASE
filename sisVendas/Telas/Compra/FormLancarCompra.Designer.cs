namespace sisVendas.Telas.Compra
{
    partial class FormLancarCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.iten_idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iten_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iten_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.gbNf = new System.Windows.Forms.GroupBox();
            this.dtpDtCompra = new System.Windows.Forms.DateTimePicker();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tbNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCpfFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.tbChaveNF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPesquisarForn = new System.Windows.Forms.Button();
            this.btnPesquisarProd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.botaoF12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbNf.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.PanelBotoes.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 44;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iten_idProduto,
            this.prod_nome,
            this.iten_quantidade,
            this.prod_un,
            this.iten_valor,
            this.total});
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(15, 404);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1112, 301);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // iten_idProduto
            // 
            this.iten_idProduto.DataPropertyName = "iten_idProduto";
            this.iten_idProduto.HeaderText = "COD";
            this.iten_idProduto.MinimumWidth = 150;
            this.iten_idProduto.Name = "iten_idProduto";
            this.iten_idProduto.ReadOnly = true;
            this.iten_idProduto.Width = 150;
            // 
            // prod_nome
            // 
            this.prod_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_nome.DataPropertyName = "prod_nome";
            this.prod_nome.HeaderText = "NOME";
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            // 
            // iten_quantidade
            // 
            this.iten_quantidade.DataPropertyName = "iten_quantidade";
            this.iten_quantidade.HeaderText = "QTDE";
            this.iten_quantidade.MinimumWidth = 100;
            this.iten_quantidade.Name = "iten_quantidade";
            this.iten_quantidade.ReadOnly = true;
            // 
            // prod_un
            // 
            this.prod_un.DataPropertyName = "prod_un";
            this.prod_un.HeaderText = "UN";
            this.prod_un.MinimumWidth = 100;
            this.prod_un.Name = "prod_un";
            this.prod_un.ReadOnly = true;
            // 
            // iten_valor
            // 
            this.iten_valor.DataPropertyName = "iten_valor";
            this.iten_valor.HeaderText = "VALOT UN";
            this.iten_valor.MinimumWidth = 200;
            this.iten_valor.Name = "iten_valor";
            this.iten_valor.ReadOnly = true;
            this.iten_valor.Width = 200;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "TOTAL";
            this.total.MinimumWidth = 200;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(8, 25);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(379, 42);
            this.lblFornecedor.TabIndex = 61;
            this.lblFornecedor.Text = "Cadastrar Nota Fiscal";
            // 
            // gbNf
            // 
            this.gbNf.Controls.Add(this.dtpDtCompra);
            this.gbNf.Controls.Add(this.tbDesconto);
            this.gbNf.Controls.Add(this.label9);
            this.gbNf.Controls.Add(this.label6);
            this.gbNf.Controls.Add(this.gbProduto);
            this.gbNf.Controls.Add(this.gbCliente);
            this.gbNf.Controls.Add(this.tbChaveNF);
            this.gbNf.Controls.Add(this.label1);
            this.gbNf.Location = new System.Drawing.Point(15, 74);
            this.gbNf.Name = "gbNf";
            this.gbNf.Size = new System.Drawing.Size(1112, 321);
            this.gbNf.TabIndex = 0;
            this.gbNf.TabStop = false;
            this.gbNf.Text = "Nota Fiscal";
            // 
            // dtpDtCompra
            // 
            this.dtpDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtCompra.Location = new System.Drawing.Point(722, 70);
            this.dtpDtCompra.Name = "dtpDtCompra";
            this.dtpDtCompra.Size = new System.Drawing.Size(164, 31);
            this.dtpDtCompra.TabIndex = 1;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(931, 70);
            this.tbDesconto.Margin = new System.Windows.Forms.Padding(6);
            this.tbDesconto.MaxLength = 8;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(155, 31);
            this.tbDesconto.TabIndex = 2;
            this.tbDesconto.Text = "R$ 0,00";
            this.tbDesconto.Click += new System.EventHandler(this.tbDesconto_Click);
            this.tbDesconto.Leave += new System.EventHandler(this.tbDesconto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(926, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Desconto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Data da Compra";
            // 
            // gbProduto
            // 
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
            this.gbProduto.Location = new System.Drawing.Point(474, 113);
            this.gbProduto.Margin = new System.Windows.Forms.Padding(6);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Padding = new System.Windows.Forms.Padding(6);
            this.gbProduto.Size = new System.Drawing.Size(624, 197);
            this.gbProduto.TabIndex = 61;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Location = new System.Drawing.Point(334, 151);
            this.tbValorTotal.Margin = new System.Windows.Forms.Padding(6);
            this.tbValorTotal.MaxLength = 8;
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(278, 31);
            this.tbValorTotal.TabIndex = 4;
            this.tbValorTotal.Text = "R$ 0,00";
            this.tbValorTotal.Click += new System.EventHandler(this.tbValorTotal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Valor Total:";
            // 
            // tbValorUn
            // 
            this.tbValorUn.Location = new System.Drawing.Point(134, 151);
            this.tbValorUn.Margin = new System.Windows.Forms.Padding(6);
            this.tbValorUn.MaxLength = 8;
            this.tbValorUn.Name = "tbValorUn";
            this.tbValorUn.Size = new System.Drawing.Size(188, 31);
            this.tbValorUn.TabIndex = 3;
            this.tbValorUn.Text = "R$ 0,00";
            this.tbValorUn.Click += new System.EventHandler(this.tbValorUn_Click);
            this.tbValorUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorUn_KeyPress);
            this.tbValorUn.Leave += new System.EventHandler(this.tbValorUn_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Valor UN:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(12, 151);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(6);
            this.tbAmount.MaxLength = 8;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(110, 31);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.Text = "1";
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Qtde:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Enabled = false;
            this.tbNameProduct.Location = new System.Drawing.Point(221, 71);
            this.tbNameProduct.Margin = new System.Windows.Forms.Padding(6);
            this.tbNameProduct.MaxLength = 49;
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(391, 31);
            this.tbNameProduct.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Produto:";
            // 
            // tbCodProduct
            // 
            this.tbCodProduct.Location = new System.Drawing.Point(12, 71);
            this.tbCodProduct.Margin = new System.Windows.Forms.Padding(6);
            this.tbCodProduct.MaxLength = 39;
            this.tbCodProduct.Name = "tbCodProduct";
            this.tbCodProduct.Size = new System.Drawing.Size(197, 31);
            this.tbCodProduct.TabIndex = 0;
            this.tbCodProduct.Leave += new System.EventHandler(this.tbCodProduct_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código:";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.tbNomeFornecedor);
            this.gbCliente.Controls.Add(this.label2);
            this.gbCliente.Controls.Add(this.mtbCpfFornecedor);
            this.gbCliente.Controls.Add(this.lblCpf);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(9, 113);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(6);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(6);
            this.gbCliente.Size = new System.Drawing.Size(453, 197);
            this.gbCliente.TabIndex = 60;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Fornecedor";
            // 
            // tbNomeFornecedor
            // 
            this.tbNomeFornecedor.Enabled = false;
            this.tbNomeFornecedor.Location = new System.Drawing.Point(12, 146);
            this.tbNomeFornecedor.Margin = new System.Windows.Forms.Padding(6);
            this.tbNomeFornecedor.MaxLength = 49;
            this.tbNomeFornecedor.Name = "tbNomeFornecedor";
            this.tbNomeFornecedor.Size = new System.Drawing.Size(429, 31);
            this.tbNomeFornecedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome:";
            // 
            // mtbCpfFornecedor
            // 
            this.mtbCpfFornecedor.Location = new System.Drawing.Point(12, 71);
            this.mtbCpfFornecedor.Margin = new System.Windows.Forms.Padding(6);
            this.mtbCpfFornecedor.Mask = "999.999.999-99";
            this.mtbCpfFornecedor.Name = "mtbCpfFornecedor";
            this.mtbCpfFornecedor.Size = new System.Drawing.Size(221, 31);
            this.mtbCpfFornecedor.TabIndex = 0;
            this.mtbCpfFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpfFornecedor.Click += new System.EventHandler(this.mtbCpfClient_Click);
            this.mtbCpfFornecedor.TextChanged += new System.EventHandler(this.mtbCpfFornecedor_TextChanged);
            this.mtbCpfFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpfFornecedor_KeyPress);
            this.mtbCpfFornecedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbCpfFornecedor_KeyUp);
            this.mtbCpfFornecedor.Leave += new System.EventHandler(this.mtbCpfFornecedor_Leave);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 39);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(68, 25);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "*CPF:";
            // 
            // tbChaveNF
            // 
            this.tbChaveNF.Location = new System.Drawing.Point(21, 70);
            this.tbChaveNF.Margin = new System.Windows.Forms.Padding(6);
            this.tbChaveNF.MaxLength = 55;
            this.tbChaveNF.Name = "tbChaveNF";
            this.tbChaveNF.Size = new System.Drawing.Size(661, 31);
            this.tbChaveNF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Chave de Acesso";
            // 
            // PanelBotoes
            // 
            this.PanelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBotoes.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotoes.Controls.Add(this.btnPesquisarForn);
            this.PanelBotoes.Controls.Add(this.btnPesquisarProd);
            this.PanelBotoes.Controls.Add(this.button4);
            this.PanelBotoes.Controls.Add(this.button3);
            this.PanelBotoes.Controls.Add(this.btnCancelarCompra);
            this.PanelBotoes.Controls.Add(this.button2);
            this.PanelBotoes.Controls.Add(this.btnFinalizar);
            this.PanelBotoes.Controls.Add(this.botaoF12);
            this.PanelBotoes.Controls.Add(this.button5);
            this.PanelBotoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBotoes.Location = new System.Drawing.Point(12, 746);
            this.PanelBotoes.Name = "PanelBotoes";
            this.PanelBotoes.Size = new System.Drawing.Size(1115, 57);
            this.PanelBotoes.TabIndex = 63;
            // 
            // btnPesquisarForn
            // 
            this.btnPesquisarForn.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarForn.FlatAppearance.BorderSize = 0;
            this.btnPesquisarForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarForn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarForn.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarForn.Location = new System.Drawing.Point(1, 1);
            this.btnPesquisarForn.Margin = new System.Windows.Forms.Padding(1);
            this.btnPesquisarForn.Name = "btnPesquisarForn";
            this.btnPesquisarForn.Size = new System.Drawing.Size(233, 26);
            this.btnPesquisarForn.TabIndex = 0;
            this.btnPesquisarForn.TabStop = false;
            this.btnPesquisarForn.Text = "F1 - Pesquisar Fornecedor";
            this.btnPesquisarForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarForn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarForn.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarProd.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProd.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProd.Location = new System.Drawing.Point(1, 29);
            this.btnPesquisarProd.Margin = new System.Windows.Forms.Padding(1);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(233, 26);
            this.btnPesquisarProd.TabIndex = 15;
            this.btnPesquisarProd.TabStop = false;
            this.btnPesquisarProd.Text = "F2 - Pesquisa Produto";
            this.btnPesquisarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarProd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(471, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 26);
            this.button2.TabIndex = 23;
            this.button2.TabStop = false;
            this.button2.Text = "F10 - Lançar Parcelas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(706, 1);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(233, 26);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.TabStop = false;
            this.btnFinalizar.Text = "F12 - Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // botaoF12
            // 
            this.botaoF12.BackColor = System.Drawing.Color.Transparent;
            this.botaoF12.FlatAppearance.BorderSize = 0;
            this.botaoF12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoF12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoF12.ForeColor = System.Drawing.Color.Black;
            this.botaoF12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoF12.Location = new System.Drawing.Point(706, 29);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(236, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 26);
            this.button3.TabIndex = 24;
            this.button3.TabStop = false;
            this.button3.Text = "F5 - Buscar Compra";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCompra.FlatAppearance.BorderSize = 0;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.Location = new System.Drawing.Point(471, 1);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(233, 26);
            this.btnCancelarCompra.TabIndex = 25;
            this.btnCancelarCompra.TabStop = false;
            this.btnCancelarCompra.Text = "F6 - Cancelar Compra";
            this.btnCancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(941, 1);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 26);
            this.button5.TabIndex = 26;
            this.button5.TabStop = false;
            this.button5.Text = "-";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(236, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 26);
            this.button4.TabIndex = 27;
            this.button4.TabStop = false;
            this.button4.Text = "F4- Nova Compra";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(947, 711);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(87, 25);
            this.lblSubtotal.TabIndex = 66;
            this.lblSubtotal.Text = "R$ 0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(644, 711);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 25);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 711);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 67;
            this.label11.Text = "TOTAL:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(819, 711);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "SUBTOTAL:";
            // 
            // FormLancarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 815);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.PanelBotoes);
            this.Controls.Add(this.gbNf);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLancarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbNf.ResumeLayout(false);
            this.gbNf.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.PanelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.GroupBox gbNf;
        private System.Windows.Forms.TextBox tbChaveNF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbValorUn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCpfFornecedor;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel PanelBotoes;
        private System.Windows.Forms.Button btnPesquisarProd;
        private System.Windows.Forms.Button botaoF12;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisarForn;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtpDtCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn iten_idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iten_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_un;
        private System.Windows.Forms.DataGridViewTextBoxColumn iten_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbNomeFornecedor;
    }
}
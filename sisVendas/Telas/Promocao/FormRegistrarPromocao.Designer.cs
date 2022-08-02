namespace sisVendas.Telas.Promocao
{
    partial class FormRegistrarPromocao
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValorUn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.btnInserirTodos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.dgv_ProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.prod_nome_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estoque_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_valor_original_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_valor_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomePromo = new System.Windows.Forms.TextBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPorcentagemDesconto = new System.Windows.Forms.TextBox();
            this.cbbValor = new System.Windows.Forms.CheckBox();
            this.tbValorDesconto = new System.Windows.Forms.TextBox();
            this.cbbPorcentagem = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Estoque";
            // 
            // tbEstoque
            // 
            this.tbEstoque.Enabled = false;
            this.tbEstoque.Location = new System.Drawing.Point(272, 75);
            this.tbEstoque.Margin = new System.Windows.Forms.Padding(6);
            this.tbEstoque.MaxLength = 8;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(93, 20);
            this.tbEstoque.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Valor UN:";
            // 
            // tbValorUn
            // 
            this.tbValorUn.Location = new System.Drawing.Point(272, 118);
            this.tbValorUn.Margin = new System.Windows.Forms.Padding(6);
            this.tbValorUn.MaxLength = 8;
            this.tbValorUn.Name = "tbValorUn";
            this.tbValorUn.Size = new System.Drawing.Size(93, 20);
            this.tbValorUn.TabIndex = 3;
            this.tbValorUn.Text = "R$ 0,00";
            this.tbValorUn.Click += new System.EventHandler(this.tbValorUn_Click);
            this.tbValorUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorUn_KeyPress);
            this.tbValorUn.Leave += new System.EventHandler(this.tbValorUn_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoverTodos);
            this.groupBox2.Controls.Add(this.btnInserirTodos);
            this.groupBox2.Location = new System.Drawing.Point(371, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 146);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Todos";
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Location = new System.Drawing.Point(21, 89);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(25, 25);
            this.btnRemoverTodos.TabIndex = 79;
            this.btnRemoverTodos.Text = "<-";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoverTodos_Click);
            // 
            // btnInserirTodos
            // 
            this.btnInserirTodos.Location = new System.Drawing.Point(21, 40);
            this.btnInserirTodos.Name = "btnInserirTodos";
            this.btnInserirTodos.Size = new System.Drawing.Size(25, 25);
            this.btnInserirTodos.TabIndex = 78;
            this.btnInserirTodos.Text = "->";
            this.btnInserirTodos.UseVisualStyleBackColor = true;
            this.btnInserirTodos.Click += new System.EventHandler(this.btnInserirTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverProduto);
            this.groupBox1.Controls.Add(this.btnInserirProduto);
            this.groupBox1.Location = new System.Drawing.Point(371, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 146);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionado";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(21, 89);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(25, 25);
            this.btnRemoverProduto.TabIndex = 79;
            this.btnRemoverProduto.Text = "<-";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(21, 40);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(25, 25);
            this.btnInserirProduto.TabIndex = 78;
            this.btnInserirProduto.Text = "->";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // dgv_ProdutosSelecionados
            // 
            this.dgv_ProdutosSelecionados.AllowUserToAddRows = false;
            this.dgv_ProdutosSelecionados.AllowUserToDeleteRows = false;
            this.dgv_ProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProdutosSelecionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_nome_promo,
            this.prod_estoque_promo,
            this.prod_id_promo,
            this.prod_valor_original_promo,
            this.prod_valor_promo});
            this.dgv_ProdutosSelecionados.Location = new System.Drawing.Point(448, 147);
            this.dgv_ProdutosSelecionados.MultiSelect = false;
            this.dgv_ProdutosSelecionados.Name = "dgv_ProdutosSelecionados";
            this.dgv_ProdutosSelecionados.ReadOnly = true;
            this.dgv_ProdutosSelecionados.RowHeadersVisible = false;
            this.dgv_ProdutosSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProdutosSelecionados.Size = new System.Drawing.Size(437, 313);
            this.dgv_ProdutosSelecionados.TabIndex = 92;
            // 
            // prod_nome_promo
            // 
            this.prod_nome_promo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_nome_promo.DataPropertyName = "prod_nome";
            this.prod_nome_promo.HeaderText = "Nome";
            this.prod_nome_promo.Name = "prod_nome_promo";
            this.prod_nome_promo.ReadOnly = true;
            // 
            // prod_estoque_promo
            // 
            this.prod_estoque_promo.DataPropertyName = "prod_estoque";
            this.prod_estoque_promo.HeaderText = "Estoque";
            this.prod_estoque_promo.MinimumWidth = 100;
            this.prod_estoque_promo.Name = "prod_estoque_promo";
            this.prod_estoque_promo.ReadOnly = true;
            // 
            // prod_id_promo
            // 
            this.prod_id_promo.DataPropertyName = "prod_id";
            this.prod_id_promo.HeaderText = "Cod";
            this.prod_id_promo.MinimumWidth = 75;
            this.prod_id_promo.Name = "prod_id_promo";
            this.prod_id_promo.ReadOnly = true;
            this.prod_id_promo.Visible = false;
            this.prod_id_promo.Width = 75;
            // 
            // prod_valor_original_promo
            // 
            this.prod_valor_original_promo.DataPropertyName = "prod_valor_original";
            this.prod_valor_original_promo.HeaderText = "Valor";
            this.prod_valor_original_promo.MinimumWidth = 100;
            this.prod_valor_original_promo.Name = "prod_valor_original_promo";
            this.prod_valor_original_promo.ReadOnly = true;
            // 
            // prod_valor_promo
            // 
            this.prod_valor_promo.DataPropertyName = "prod_valor";
            this.prod_valor_promo.HeaderText = "Valor com Desconto";
            this.prod_valor_promo.MinimumWidth = 100;
            this.prod_valor_promo.Name = "prod_valor_promo";
            this.prod_valor_promo.ReadOnly = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(810, 466);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 20);
            this.btnSalvar.TabIndex = 91;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_nome,
            this.prod_id,
            this.prod_estoque,
            this.prod_valor});
            this.dgv_produtos.Location = new System.Drawing.Point(9, 147);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(353, 313);
            this.dgv_produtos.TabIndex = 90;
            this.dgv_produtos.SelectionChanged += new System.EventHandler(this.dgv_produtos_SelectionChanged);
            this.dgv_produtos.Click += new System.EventHandler(this.dgv_produtos_Click);
            // 
            // prod_nome
            // 
            this.prod_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_nome.DataPropertyName = "prod_nome";
            this.prod_nome.HeaderText = "Nome";
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "Cod";
            this.prod_id.MinimumWidth = 100;
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Visible = false;
            // 
            // prod_estoque
            // 
            this.prod_estoque.DataPropertyName = "prod_estoque";
            this.prod_estoque.HeaderText = "Estoque";
            this.prod_estoque.MinimumWidth = 75;
            this.prod_estoque.Name = "prod_estoque";
            this.prod_estoque.ReadOnly = true;
            this.prod_estoque.Width = 75;
            // 
            // prod_valor
            // 
            this.prod_valor.DataPropertyName = "prod_valor";
            this.prod_valor.HeaderText = "Valor";
            this.prod_valor.MinimumWidth = 100;
            this.prod_valor.Name = "prod_valor";
            this.prod_valor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nome da Promoção";
            // 
            // tbNomePromo
            // 
            this.tbNomePromo.Location = new System.Drawing.Point(12, 30);
            this.tbNomePromo.MaxLength = 50;
            this.tbNomePromo.Name = "tbNomePromo";
            this.tbNomePromo.Size = new System.Drawing.Size(353, 20);
            this.tbNomePromo.TabIndex = 84;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(141, 75);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(97, 20);
            this.dtpFim.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Data Final";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(13, 75);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpInicio.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Data Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Produto";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Enabled = false;
            this.tbNomeProduto.Location = new System.Drawing.Point(13, 118);
            this.tbNomeProduto.MaxLength = 50;
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(225, 20);
            this.tbNomeProduto.TabIndex = 95;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPorcentagemDesconto);
            this.groupBox3.Controls.Add(this.cbbValor);
            this.groupBox3.Controls.Add(this.tbValorDesconto);
            this.groupBox3.Controls.Add(this.cbbPorcentagem);
            this.groupBox3.Location = new System.Drawing.Point(448, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 103);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desconto";
            // 
            // tbPorcentagemDesconto
            // 
            this.tbPorcentagemDesconto.Location = new System.Drawing.Point(54, 61);
            this.tbPorcentagemDesconto.Margin = new System.Windows.Forms.Padding(6);
            this.tbPorcentagemDesconto.MaxLength = 8;
            this.tbPorcentagemDesconto.Name = "tbPorcentagemDesconto";
            this.tbPorcentagemDesconto.Size = new System.Drawing.Size(93, 20);
            this.tbPorcentagemDesconto.TabIndex = 101;
            this.tbPorcentagemDesconto.Text = "0,00%";
            this.tbPorcentagemDesconto.Click += new System.EventHandler(this.tbPorcentagemDesconto_Click);
            this.tbPorcentagemDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPorcentagemDesconto_KeyPress);
            this.tbPorcentagemDesconto.Leave += new System.EventHandler(this.tbPorcentagemDesconto_Leave);
            // 
            // cbbValor
            // 
            this.cbbValor.AutoSize = true;
            this.cbbValor.Location = new System.Drawing.Point(209, 35);
            this.cbbValor.Name = "cbbValor";
            this.cbbValor.Size = new System.Drawing.Size(50, 17);
            this.cbbValor.TabIndex = 100;
            this.cbbValor.Text = "Valor";
            this.cbbValor.UseVisualStyleBackColor = true;
            this.cbbValor.Click += new System.EventHandler(this.cbbValor_Click);
            // 
            // tbValorDesconto
            // 
            this.tbValorDesconto.Enabled = false;
            this.tbValorDesconto.Location = new System.Drawing.Point(209, 61);
            this.tbValorDesconto.Margin = new System.Windows.Forms.Padding(6);
            this.tbValorDesconto.MaxLength = 8;
            this.tbValorDesconto.Name = "tbValorDesconto";
            this.tbValorDesconto.Size = new System.Drawing.Size(93, 20);
            this.tbValorDesconto.TabIndex = 98;
            this.tbValorDesconto.Text = "R$ 0,00";
            this.tbValorDesconto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbValorDesconto_MouseClick);
            this.tbValorDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorDesconto_KeyPress);
            this.tbValorDesconto.Leave += new System.EventHandler(this.tbValorDesconto_Leave);
            // 
            // cbbPorcentagem
            // 
            this.cbbPorcentagem.AutoSize = true;
            this.cbbPorcentagem.Checked = true;
            this.cbbPorcentagem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbbPorcentagem.Location = new System.Drawing.Point(54, 35);
            this.cbbPorcentagem.Name = "cbbPorcentagem";
            this.cbbPorcentagem.Size = new System.Drawing.Size(89, 17);
            this.cbbPorcentagem.TabIndex = 0;
            this.cbbPorcentagem.Text = "Porcentagem";
            this.cbbPorcentagem.UseVisualStyleBackColor = true;
            this.cbbPorcentagem.Click += new System.EventHandler(this.cbbPorcentagem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "Produtos Selecionados";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(810, 54);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 100;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "F1 - Consultar promoções.";
            // 
            // FormRegistrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 498);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValorUn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_ProdutosSelecionados);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomePromo);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistrarPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Cadastrar promoção";
            this.Load += new System.EventHandler(this.FormRegistrarPromocao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValorUn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoverTodos;
        private System.Windows.Forms.Button btnInserirTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.DataGridView dgv_ProdutosSelecionados;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomePromo;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_valor;
        private System.Windows.Forms.TextBox tbPorcentagemDesconto;
        private System.Windows.Forms.CheckBox cbbValor;
        private System.Windows.Forms.TextBox tbValorDesconto;
        private System.Windows.Forms.CheckBox cbbPorcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estoque_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_valor_original_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_valor_promo;
    }
}
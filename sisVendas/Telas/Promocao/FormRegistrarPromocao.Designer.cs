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
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.tbValorUn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomePromo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPromocao = new System.Windows.Forms.DataGridView();
            this.promo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocao)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduto
            // 
            this.gbProduto.BackColor = System.Drawing.Color.Transparent;
            this.gbProduto.Controls.Add(this.tbValorUn);
            this.gbProduto.Controls.Add(this.label7);
            this.gbProduto.Controls.Add(this.tbAmount);
            this.gbProduto.Controls.Add(this.label5);
            this.gbProduto.Controls.Add(this.tbNameProduct);
            this.gbProduto.Controls.Add(this.label4);
            this.gbProduto.Controls.Add(this.tbCodProduct);
            this.gbProduto.Controls.Add(this.label3);
            this.gbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduto.Location = new System.Drawing.Point(15, 66);
            this.gbProduto.Margin = new System.Windows.Forms.Padding(6);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Padding = new System.Windows.Forms.Padding(6);
            this.gbProduto.Size = new System.Drawing.Size(401, 130);
            this.gbProduto.TabIndex = 66;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // tbValorUn
            // 
            this.tbValorUn.Location = new System.Drawing.Point(122, 95);
            this.tbValorUn.Margin = new System.Windows.Forms.Padding(6);
            this.tbValorUn.MaxLength = 8;
            this.tbValorUn.Name = "tbValorUn";
            this.tbValorUn.Size = new System.Drawing.Size(93, 20);
            this.tbValorUn.TabIndex = 3;
            this.tbValorUn.Text = "R$ 0,00";
            this.tbValorUn.Click += new System.EventHandler(this.tbValorUn_Click);
            this.tbValorUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorUn_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Valor UN:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(9, 95);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(6);
            this.tbAmount.MaxLength = 8;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(73, 20);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.Text = "1";
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Qtde:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Enabled = false;
            this.tbNameProduct.Location = new System.Drawing.Point(122, 41);
            this.tbNameProduct.Margin = new System.Windows.Forms.Padding(6);
            this.tbNameProduct.MaxLength = 49;
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(266, 20);
            this.tbNameProduct.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Produto:";
            // 
            // tbCodProduct
            // 
            this.tbCodProduct.Location = new System.Drawing.Point(9, 41);
            this.tbCodProduct.Margin = new System.Windows.Forms.Padding(6);
            this.tbCodProduct.MaxLength = 39;
            this.tbCodProduct.Name = "tbCodProduct";
            this.tbCodProduct.Size = new System.Drawing.Size(86, 20);
            this.tbCodProduct.TabIndex = 0;
            this.tbCodProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodProduct_KeyPress);
            this.tbCodProduct.Leave += new System.EventHandler(this.tbCodProduct_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(15, 37);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpInicio.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Data Inicial";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(135, 37);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(97, 20);
            this.dtpFim.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Data Final";
            // 
            // tbNomePromo
            // 
            this.tbNomePromo.Location = new System.Drawing.Point(238, 37);
            this.tbNomePromo.MaxLength = 50;
            this.tbNomePromo.Name = "tbNomePromo";
            this.tbNomePromo.Size = new System.Drawing.Size(343, 20);
            this.tbNomePromo.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nome da Promoção";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cod,
            this.quantidade,
            this.valor});
            this.dgv_produtos.Location = new System.Drawing.Point(15, 205);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(401, 313);
            this.dgv_produtos.TabIndex = 72;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(328, 524);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 73;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 76;
            this.button3.Text = "Terminar Promoção";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cod";
            this.cod.HeaderText = "Cod";
            this.cod.MinimumWidth = 100;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 75;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 75;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 100;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // dgvPromocao
            // 
            this.dgvPromocao.AllowUserToAddRows = false;
            this.dgvPromocao.AllowUserToDeleteRows = false;
            this.dgvPromocao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.promo_id,
            this.promo_nome,
            this.promo_inicio,
            this.promo_fim,
            this.promo_criado_em});
            this.dgvPromocao.Location = new System.Drawing.Point(440, 205);
            this.dgvPromocao.MultiSelect = false;
            this.dgvPromocao.Name = "dgvPromocao";
            this.dgvPromocao.ReadOnly = true;
            this.dgvPromocao.RowHeadersVisible = false;
            this.dgvPromocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromocao.Size = new System.Drawing.Size(367, 313);
            this.dgvPromocao.TabIndex = 77;
            // 
            // promo_id
            // 
            this.promo_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.promo_id.DataPropertyName = "promo_id";
            this.promo_id.HeaderText = "Nome";
            this.promo_id.Name = "promo_id";
            this.promo_id.ReadOnly = true;
            // 
            // promo_nome
            // 
            this.promo_nome.DataPropertyName = "promo_nome";
            this.promo_nome.HeaderText = "Cod";
            this.promo_nome.MinimumWidth = 100;
            this.promo_nome.Name = "promo_nome";
            this.promo_nome.ReadOnly = true;
            // 
            // promo_inicio
            // 
            this.promo_inicio.DataPropertyName = "promo_inicio";
            this.promo_inicio.HeaderText = "Quantidade";
            this.promo_inicio.MinimumWidth = 75;
            this.promo_inicio.Name = "promo_inicio";
            this.promo_inicio.ReadOnly = true;
            this.promo_inicio.Width = 75;
            // 
            // promo_fim
            // 
            this.promo_fim.DataPropertyName = "promo_fim";
            this.promo_fim.HeaderText = "Valor";
            this.promo_fim.MinimumWidth = 100;
            this.promo_fim.Name = "promo_fim";
            this.promo_fim.ReadOnly = true;
            // 
            // promo_criado_em
            // 
            this.promo_criado_em.DataPropertyName = "promo_criado_em";
            this.promo_criado_em.HeaderText = "promo_criado_em";
            this.promo_criado_em.Name = "promo_criado_em";
            this.promo_criado_em.ReadOnly = true;
            // 
            // FormRegistrarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 565);
            this.Controls.Add(this.dgvPromocao);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomePromo);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label6);
            this.Name = "FormRegistrarPromocao";
            this.Text = "FormRegistrarPromocao";
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.TextBox tbValorUn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomePromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridView dgvPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_criado_em;
    }
}
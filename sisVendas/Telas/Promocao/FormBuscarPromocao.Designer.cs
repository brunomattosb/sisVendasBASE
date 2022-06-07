namespace sisVendas.Telas.Promocao
{
    partial class FormBuscarPromocao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPesquisarPeriodo = new System.Windows.Forms.CheckBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.iten_idPromocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iten_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_promocao = new System.Windows.Forms.DataGridView();
            this.promo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_idFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promo_criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFinalizarPromo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promocao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Em aberto";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Finalizadas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisarPeriodo);
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNascimento);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 87);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // cbPesquisarPeriodo
            // 
            this.cbPesquisarPeriodo.AutoSize = true;
            this.cbPesquisarPeriodo.Location = new System.Drawing.Point(24, 19);
            this.cbPesquisarPeriodo.Name = "cbPesquisarPeriodo";
            this.cbPesquisarPeriodo.Size = new System.Drawing.Size(132, 17);
            this.cbPesquisarPeriodo.TabIndex = 57;
            this.cbPesquisarPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPeriodo.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(195, 57);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(149, 20);
            this.dtpFim.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(24, 57);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(149, 20);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(21, 41);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(35, 13);
            this.lblNascimento.TabIndex = 48;
            this.lblNascimento.Text = "Inicio:";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iten_idPromocao,
            this.prod_nome,
            this.iten_valor});
            this.dgv_produtos.Location = new System.Drawing.Point(12, 271);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(622, 187);
            this.dgv_produtos.TabIndex = 91;
            // 
            // iten_idPromocao
            // 
            this.iten_idPromocao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iten_idPromocao.DataPropertyName = "iten_idPromocao";
            this.iten_idPromocao.HeaderText = "iten_idPromocao";
            this.iten_idPromocao.Name = "iten_idPromocao";
            this.iten_idPromocao.ReadOnly = true;
            this.iten_idPromocao.Visible = false;
            // 
            // prod_nome
            // 
            this.prod_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_nome.DataPropertyName = "prod_nome";
            this.prod_nome.HeaderText = "Nome";
            this.prod_nome.MinimumWidth = 100;
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            // 
            // iten_valor
            // 
            this.iten_valor.DataPropertyName = "iten_valor";
            this.iten_valor.HeaderText = "Valor";
            this.iten_valor.MinimumWidth = 150;
            this.iten_valor.Name = "iten_valor";
            this.iten_valor.ReadOnly = true;
            this.iten_valor.Width = 150;
            // 
            // dgv_promocao
            // 
            this.dgv_promocao.AllowUserToAddRows = false;
            this.dgv_promocao.AllowUserToDeleteRows = false;
            this.dgv_promocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_promocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.promo_id,
            this.promo_idFunc,
            this.promo_nome,
            this.promo_inicio,
            this.promo_fim,
            this.promo_criado_em});
            this.dgv_promocao.Location = new System.Drawing.Point(12, 105);
            this.dgv_promocao.MultiSelect = false;
            this.dgv_promocao.Name = "dgv_promocao";
            this.dgv_promocao.ReadOnly = true;
            this.dgv_promocao.RowHeadersVisible = false;
            this.dgv_promocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_promocao.Size = new System.Drawing.Size(622, 160);
            this.dgv_promocao.TabIndex = 92;
            this.dgv_promocao.SelectionChanged += new System.EventHandler(this.dgv_promocao_SelectionChanged);
            this.dgv_promocao.Click += new System.EventHandler(this.dgv_promocao_Click);
            // 
            // promo_id
            // 
            this.promo_id.DataPropertyName = "promo_id";
            this.promo_id.HeaderText = "promo_id";
            this.promo_id.Name = "promo_id";
            this.promo_id.ReadOnly = true;
            this.promo_id.Visible = false;
            // 
            // promo_idFunc
            // 
            this.promo_idFunc.DataPropertyName = "promo_idFunc";
            this.promo_idFunc.HeaderText = "ID Funcionário";
            this.promo_idFunc.MinimumWidth = 75;
            this.promo_idFunc.Name = "promo_idFunc";
            this.promo_idFunc.ReadOnly = true;
            this.promo_idFunc.Width = 75;
            // 
            // promo_nome
            // 
            this.promo_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.promo_nome.DataPropertyName = "promo_nome";
            this.promo_nome.HeaderText = "Nome";
            this.promo_nome.Name = "promo_nome";
            this.promo_nome.ReadOnly = true;
            // 
            // promo_inicio
            // 
            this.promo_inicio.DataPropertyName = "promo_inicio";
            this.promo_inicio.HeaderText = "Dt. Inicial";
            this.promo_inicio.MinimumWidth = 100;
            this.promo_inicio.Name = "promo_inicio";
            this.promo_inicio.ReadOnly = true;
            // 
            // promo_fim
            // 
            this.promo_fim.DataPropertyName = "promo_fim";
            this.promo_fim.HeaderText = "Dt. Final";
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
            this.promo_criado_em.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(559, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarPromo
            // 
            this.btnFinalizarPromo.Enabled = false;
            this.btnFinalizarPromo.Location = new System.Drawing.Point(559, 464);
            this.btnFinalizarPromo.Name = "btnFinalizarPromo";
            this.btnFinalizarPromo.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarPromo.TabIndex = 94;
            this.btnFinalizarPromo.Text = "Finalizar";
            this.btnFinalizarPromo.UseVisualStyleBackColor = true;
            this.btnFinalizarPromo.Click += new System.EventHandler(this.btnFinalizarPromo_Click);
            // 
            // FormBuscarPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 496);
            this.Controls.Add(this.btnFinalizarPromo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgv_promocao);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Promoção";
            this.Load += new System.EventHandler(this.FormBuscarPromocao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promocao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPesquisarPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridView dgv_promocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_idFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn promo_criado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn iten_idPromocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn iten_valor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFinalizarPromo;
    }
}
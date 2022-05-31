namespace sisVendas.Telas.Sale
{
    partial class FormBuscarVenda
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
            this.dgv_venda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venda_cancelada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.cbbMN = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPesquisarPeriodo = new System.Windows.Forms.CheckBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_venda
            // 
            this.dgv_venda.AllowUserToAddRows = false;
            this.dgv_venda.AllowUserToDeleteRows = false;
            this.dgv_venda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cpf_cnpj,
            this.nome,
            this.total,
            this.desconto,
            this.criado_em,
            this.venda_cancelada});
            this.dgv_venda.Location = new System.Drawing.Point(15, 219);
            this.dgv_venda.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_venda.MultiSelect = false;
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.ReadOnly = true;
            this.dgv_venda.RowHeadersVisible = false;
            this.dgv_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_venda.Size = new System.Drawing.Size(1085, 417);
            this.dgv_venda.TabIndex = 6;
            this.dgv_venda.DoubleClick += new System.EventHandler(this.dgv_venda_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 120;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 120;
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.DataPropertyName = "cpf_cnpj";
            this.cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cpf_cnpj.MinimumWidth = 180;
            this.cpf_cnpj.Name = "cpf_cnpj";
            this.cpf_cnpj.ReadOnly = true;
            this.cpf_cnpj.Width = 180;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 200;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // desconto
            // 
            this.desconto.DataPropertyName = "desconto";
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 150;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 150;
            // 
            // criado_em
            // 
            this.criado_em.DataPropertyName = "criado_em";
            this.criado_em.HeaderText = "Data";
            this.criado_em.MinimumWidth = 200;
            this.criado_em.Name = "criado_em";
            this.criado_em.ReadOnly = true;
            this.criado_em.Width = 200;
            // 
            // venda_cancelada
            // 
            this.venda_cancelada.DataPropertyName = "venda_cancelada";
            this.venda_cancelada.HeaderText = "Cancelada";
            this.venda_cancelada.MinimumWidth = 150;
            this.venda_cancelada.Name = "venda_cancelada";
            this.venda_cancelada.ReadOnly = true;
            this.venda_cancelada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.venda_cancelada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.venda_cancelada.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1085, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbValor);
            this.groupBox3.Controls.Add(this.cbbMN);
            this.groupBox3.Location = new System.Drawing.Point(671, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 167);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valor da Compra";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(9, 111);
            this.tbValor.Margin = new System.Windows.Forms.Padding(6);
            this.tbValor.MaxLength = 10;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(170, 31);
            this.tbValor.TabIndex = 56;
            this.tbValor.Text = "R$ 0,00";
            this.tbValor.Enter += new System.EventHandler(this.tbValor_Enter);
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // cbbMN
            // 
            this.cbbMN.FormattingEnabled = true;
            this.cbbMN.Items.AddRange(new object[] {
            "",
            "=",
            ">=",
            "<="});
            this.cbbMN.Location = new System.Drawing.Point(9, 33);
            this.cbbMN.Margin = new System.Windows.Forms.Padding(6);
            this.cbbMN.Name = "cbbMN";
            this.cbbMN.Size = new System.Drawing.Size(170, 33);
            this.cbbMN.TabIndex = 58;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(901, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 37);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisarPeriodo);
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNascimento);
            this.groupBox2.Location = new System.Drawing.Point(293, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 167);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // cbPesquisarPeriodo
            // 
            this.cbPesquisarPeriodo.AutoSize = true;
            this.cbPesquisarPeriodo.Location = new System.Drawing.Point(17, 43);
            this.cbPesquisarPeriodo.Name = "cbPesquisarPeriodo";
            this.cbPesquisarPeriodo.Size = new System.Drawing.Size(246, 29);
            this.cbPesquisarPeriodo.TabIndex = 57;
            this.cbPesquisarPeriodo.Text = "Pesquisar Por Período";
            this.cbPesquisarPeriodo.UseVisualStyleBackColor = true;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(188, 111);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(149, 31);
            this.dtpFim.TabIndex = 56;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(17, 111);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(149, 31);
            this.dtpInicio.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(17, 83);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(68, 25);
            this.lblNascimento.TabIndex = 48;
            this.lblNascimento.Text = "Inicio:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(17, 126);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 31);
            this.tbName.TabIndex = 46;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(17, 58);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(6);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(220, 31);
            this.mtbCpf.TabIndex = 44;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.TextChanged += new System.EventHandler(this.mtbCpf_TextChanged);
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 30);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(60, 25);
            this.lblCpf.TabIndex = 45;
            this.lblCpf.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Valor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(872, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 84);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relatório";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 62;
            this.button1.Text = "Gerar PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_venda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBuscarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.ComboBox cbbMN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.CheckBox cbPesquisarPeriodo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn criado_em;
        private System.Windows.Forms.DataGridViewCheckBoxColumn venda_cancelada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
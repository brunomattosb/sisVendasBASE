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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cbbMN = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbDtFim = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.desconto,
            this.total,
            this.criado_em,
            this.nome,
            this.cpf_cnpj});
            this.dgv_venda.Location = new System.Drawing.Point(15, 233);
            this.dgv_venda.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_venda.MultiSelect = false;
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.ReadOnly = true;
            this.dgv_venda.RowHeadersVisible = false;
            this.dgv_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_venda.Size = new System.Drawing.Size(1186, 536);
            this.dgv_venda.TabIndex = 6;
            this.dgv_venda.DoubleClick += new System.EventHandler(this.dgv_venda_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.cbbMN);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1186, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(886, 144);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 37);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(968, 63);
            this.tbValor.Margin = new System.Windows.Forms.Padding(6);
            this.tbValor.MaxLength = 10;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(134, 31);
            this.tbValor.TabIndex = 56;
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(963, 35);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(68, 25);
            this.lblSaldo.TabIndex = 57;
            this.lblSaldo.Text = "Valor:";
            // 
            // cbbMN
            // 
            this.cbbMN.FormattingEnabled = true;
            this.cbbMN.Items.AddRange(new object[] {
            "=",
            ">=",
            "<="});
            this.cbbMN.Location = new System.Drawing.Point(825, 63);
            this.cbbMN.Margin = new System.Windows.Forms.Padding(6);
            this.cbbMN.Name = "cbbMN";
            this.cbbMN.Size = new System.Drawing.Size(112, 33);
            this.cbbMN.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbDtFim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mtbDtInicio);
            this.groupBox2.Controls.Add(this.lblNascimento);
            this.groupBox2.Location = new System.Drawing.Point(371, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 126);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // mtbDtFim
            // 
            this.mtbDtFim.Location = new System.Drawing.Point(178, 71);
            this.mtbDtFim.Margin = new System.Windows.Forms.Padding(6);
            this.mtbDtFim.Mask = "00/00/0000";
            this.mtbDtFim.Name = "mtbDtFim";
            this.mtbDtFim.Size = new System.Drawing.Size(134, 31);
            this.mtbDtFim.TabIndex = 53;
            this.mtbDtFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDtFim.ValidatingType = typeof(System.DateTime);
            this.mtbDtFim.Click += new System.EventHandler(this.mtbDtFim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fim:";
            // 
            // mtbDtInicio
            // 
            this.mtbDtInicio.Location = new System.Drawing.Point(23, 71);
            this.mtbDtInicio.Margin = new System.Windows.Forms.Padding(6);
            this.mtbDtInicio.Mask = "00/00/0000";
            this.mtbDtInicio.Name = "mtbDtInicio";
            this.mtbDtInicio.Size = new System.Drawing.Size(134, 31);
            this.mtbDtInicio.TabIndex = 47;
            this.mtbDtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDtInicio.ValidatingType = typeof(System.DateTime);
            this.mtbDtInicio.Click += new System.EventHandler(this.mtbDtInicio_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(17, 43);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(68, 25);
            this.lblNascimento.TabIndex = 48;
            this.lblNascimento.Text = "Inicio:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 150);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(686, 31);
            this.tbName.TabIndex = 46;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(15, 63);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(6);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(220, 31);
            this.mtbCpf.TabIndex = 44;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(11, 36);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(60, 25);
            this.lblCpf.TabIndex = 45;
            this.lblCpf.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nome:";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 50;
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 200;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // criado_em
            // 
            this.criado_em.DataPropertyName = "criado_em";
            this.criado_em.HeaderText = "Data";
            this.criado_em.MinimumWidth = 150;
            this.criado_em.Name = "criado_em";
            this.criado_em.ReadOnly = true;
            this.criado_em.Width = 150;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.DataPropertyName = "cpf_cnpj";
            this.cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cpf_cnpj.MinimumWidth = 200;
            this.cpf_cnpj.Name = "cpf_cnpj";
            this.cpf_cnpj.ReadOnly = true;
            this.cpf_cnpj.Width = 200;
            // 
            // FormBuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 784);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_venda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBuscarVenda";
            this.Text = "FormBuscarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cbbMN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbDtFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDtInicio;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn criado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_cnpj;
    }
}
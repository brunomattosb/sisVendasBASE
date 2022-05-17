namespace sisVendas.Screens.Client
{
    partial class FormBuscarCliente
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
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome_fansasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_dt_aniversario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_nome,
            this.cli_rg_ie,
            this.cli_email,
            this.cli_nome_fansasia,
            this.cli_id,
            this.cli_cep,
            this.cli_endereco,
            this.cli_bairro,
            this.cli_cidade,
            this.cli_uf,
            this.cli_dt_aniversario,
            this.cli_telefone,
            this.cli_cpf_cnpj,
            this.cli_sexo,
            this.cli_saldo,
            this.cli_created_at});
            this.dgv_client.Location = new System.Drawing.Point(12, 69);
            this.dgv_client.MultiSelect = false;
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(776, 479);
            this.dgv_client.TabIndex = 3;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Nome";
            this.cli_nome.MinimumWidth = 320;
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cli_rg_ie
            // 
            this.cli_rg_ie.DataPropertyName = "cli_rg_ie";
            this.cli_rg_ie.HeaderText = "RG/IE";
            this.cli_rg_ie.Name = "cli_rg_ie";
            this.cli_rg_ie.ReadOnly = true;
            this.cli_rg_ie.Visible = false;
            // 
            // cli_email
            // 
            this.cli_email.DataPropertyName = "cli_email";
            this.cli_email.HeaderText = "Email";
            this.cli_email.Name = "cli_email";
            this.cli_email.ReadOnly = true;
            this.cli_email.Visible = false;
            // 
            // cli_nome_fansasia
            // 
            this.cli_nome_fansasia.DataPropertyName = "cli_nome_fansasia";
            this.cli_nome_fansasia.HeaderText = "Nome Fantasia";
            this.cli_nome_fansasia.Name = "cli_nome_fansasia";
            this.cli_nome_fansasia.ReadOnly = true;
            this.cli_nome_fansasia.Visible = false;
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // cli_cep
            // 
            this.cli_cep.DataPropertyName = "cli_cep";
            this.cli_cep.HeaderText = "CEP";
            this.cli_cep.Name = "cli_cep";
            this.cli_cep.ReadOnly = true;
            this.cli_cep.Visible = false;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataPropertyName = "cli_endereco";
            this.cli_endereco.HeaderText = "Endereço";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            this.cli_endereco.Visible = false;
            // 
            // cli_bairro
            // 
            this.cli_bairro.DataPropertyName = "cli_bairro";
            this.cli_bairro.HeaderText = "Bairro";
            this.cli_bairro.Name = "cli_bairro";
            this.cli_bairro.ReadOnly = true;
            this.cli_bairro.Visible = false;
            // 
            // cli_cidade
            // 
            this.cli_cidade.DataPropertyName = "cli_cidade";
            this.cli_cidade.HeaderText = "Cidade";
            this.cli_cidade.Name = "cli_cidade";
            this.cli_cidade.ReadOnly = true;
            this.cli_cidade.Visible = false;
            // 
            // cli_uf
            // 
            this.cli_uf.DataPropertyName = "cli_uf";
            this.cli_uf.HeaderText = "Estado";
            this.cli_uf.Name = "cli_uf";
            this.cli_uf.ReadOnly = true;
            this.cli_uf.Visible = false;
            // 
            // cli_dt_aniversario
            // 
            this.cli_dt_aniversario.DataPropertyName = "cli_dt_aniversario";
            this.cli_dt_aniversario.HeaderText = "Nascimento";
            this.cli_dt_aniversario.Name = "cli_dt_aniversario";
            this.cli_dt_aniversario.ReadOnly = true;
            this.cli_dt_aniversario.Visible = false;
            // 
            // cli_telefone
            // 
            this.cli_telefone.DataPropertyName = "cli_telefone";
            this.cli_telefone.DividerWidth = 2;
            this.cli_telefone.HeaderText = "Telefone";
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.ReadOnly = true;
            this.cli_telefone.Visible = false;
            // 
            // cli_cpf_cnpj
            // 
            this.cli_cpf_cnpj.DataPropertyName = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cli_cpf_cnpj.MinimumWidth = 200;
            this.cli_cpf_cnpj.Name = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.ReadOnly = true;
            this.cli_cpf_cnpj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_cpf_cnpj.Width = 200;
            // 
            // cli_sexo
            // 
            this.cli_sexo.DataPropertyName = "cli_sexo";
            this.cli_sexo.HeaderText = "Sexo";
            this.cli_sexo.Name = "cli_sexo";
            this.cli_sexo.ReadOnly = true;
            this.cli_sexo.Visible = false;
            // 
            // cli_saldo
            // 
            this.cli_saldo.DataPropertyName = "cli_saldo";
            this.cli_saldo.HeaderText = "Saldo";
            this.cli_saldo.MinimumWidth = 75;
            this.cli_saldo.Name = "cli_saldo";
            this.cli_saldo.ReadOnly = true;
            this.cli_saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_saldo.Width = 75;
            // 
            // cli_created_at
            // 
            this.cli_created_at.DataPropertyName = "cli_created_at";
            this.cli_created_at.HeaderText = "Cadastro";
            this.cli_created_at.MinimumWidth = 100;
            this.cli_created_at.Name = "cli_created_at";
            this.cli_created_at.ReadOnly = true;
            this.cli_created_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbSearth
            // 
            this.tbSearth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearth.Location = new System.Drawing.Point(12, 39);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(391, 24);
            this.tbSearth.TabIndex = 1;
            this.tbSearth.TextChanged += new System.EventHandler(this.tbSearth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Controls.Add(this.dgv_client);
            this.Name = "FormBuscarCliente";
            this.Text = "Buscar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg_ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome_fansasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_dt_aniversario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_created_at;
    }
}
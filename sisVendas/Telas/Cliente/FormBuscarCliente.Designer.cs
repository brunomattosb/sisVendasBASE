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
            this.cli_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_fantasy_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_zip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_birth_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cli_name,
            this.cli_rg_ie,
            this.cli_email,
            this.cli_fantasy_name,
            this.cli_id,
            this.cli_zip_code,
            this.cli_addres,
            this.cli_district,
            this.cli_city,
            this.cli_uf,
            this.cli_birth_at,
            this.cli_telephone,
            this.cli_cpf_cnpj,
            this.cli_sex,
            this.cli_balance,
            this.cli_created_at});
            this.dgv_client.Location = new System.Drawing.Point(12, 47);
            this.dgv_client.MultiSelect = false;
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(776, 391);
            this.dgv_client.TabIndex = 3;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // cli_name
            // 
            this.cli_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_name.DataPropertyName = "cli_name";
            this.cli_name.HeaderText = "Nome";
            this.cli_name.MinimumWidth = 320;
            this.cli_name.Name = "cli_name";
            this.cli_name.ReadOnly = true;
            this.cli_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // cli_fantasy_name
            // 
            this.cli_fantasy_name.DataPropertyName = "cli_fantasy_name";
            this.cli_fantasy_name.HeaderText = "Nome Fantasia";
            this.cli_fantasy_name.Name = "cli_fantasy_name";
            this.cli_fantasy_name.ReadOnly = true;
            this.cli_fantasy_name.Visible = false;
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // cli_zip_code
            // 
            this.cli_zip_code.DataPropertyName = "cli_zip_code";
            this.cli_zip_code.HeaderText = "CEP";
            this.cli_zip_code.Name = "cli_zip_code";
            this.cli_zip_code.ReadOnly = true;
            this.cli_zip_code.Visible = false;
            // 
            // cli_addres
            // 
            this.cli_addres.DataPropertyName = "cli_addres";
            this.cli_addres.HeaderText = "Endereço";
            this.cli_addres.Name = "cli_addres";
            this.cli_addres.ReadOnly = true;
            this.cli_addres.Visible = false;
            // 
            // cli_district
            // 
            this.cli_district.DataPropertyName = "cli_district";
            this.cli_district.HeaderText = "Bairro";
            this.cli_district.Name = "cli_district";
            this.cli_district.ReadOnly = true;
            this.cli_district.Visible = false;
            // 
            // cli_city
            // 
            this.cli_city.DataPropertyName = "cli_city";
            this.cli_city.HeaderText = "Cidade";
            this.cli_city.Name = "cli_city";
            this.cli_city.ReadOnly = true;
            this.cli_city.Visible = false;
            // 
            // cli_uf
            // 
            this.cli_uf.DataPropertyName = "cli_uf";
            this.cli_uf.HeaderText = "Estado";
            this.cli_uf.Name = "cli_uf";
            this.cli_uf.ReadOnly = true;
            this.cli_uf.Visible = false;
            // 
            // cli_birth_at
            // 
            this.cli_birth_at.DataPropertyName = "cli_birth_at";
            this.cli_birth_at.HeaderText = "Nascimento";
            this.cli_birth_at.Name = "cli_birth_at";
            this.cli_birth_at.ReadOnly = true;
            this.cli_birth_at.Visible = false;
            // 
            // cli_telephone
            // 
            this.cli_telephone.DataPropertyName = "cli_telephone";
            this.cli_telephone.DividerWidth = 2;
            this.cli_telephone.HeaderText = "Telefone";
            this.cli_telephone.Name = "cli_telephone";
            this.cli_telephone.ReadOnly = true;
            this.cli_telephone.Visible = false;
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
            // cli_sex
            // 
            this.cli_sex.DataPropertyName = "cli_sex";
            this.cli_sex.HeaderText = "Sexo";
            this.cli_sex.Name = "cli_sex";
            this.cli_sex.ReadOnly = true;
            this.cli_sex.Visible = false;
            // 
            // cli_balance
            // 
            this.cli_balance.DataPropertyName = "cli_balance";
            this.cli_balance.HeaderText = "Saldo";
            this.cli_balance.MinimumWidth = 75;
            this.cli_balance.Name = "cli_balance";
            this.cli_balance.ReadOnly = true;
            this.cli_balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_balance.Width = 75;
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
            this.tbSearth.Location = new System.Drawing.Point(178, 21);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(391, 20);
            this.tbSearth.TabIndex = 1;
            this.tbSearth.TextChanged += new System.EventHandler(this.tbSearth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // FormSearthClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Controls.Add(this.dgv_client);
            this.Name = "FormSearthClient";
            this.Text = "FormSearthClient";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg_ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_fantasy_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_zip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_addres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_birth_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_created_at;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.Label label1;
    }
}
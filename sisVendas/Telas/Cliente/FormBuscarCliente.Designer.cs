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
            this.tbSearth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cli_id,
            this.cli_nome,
            this.cli_cpf_cnpj,
            this.cli_telefone,
            this.cli_saldo});
            this.dgv_client.Location = new System.Drawing.Point(20, 61);
            this.dgv_client.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_client.MultiSelect = false;
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(948, 397);
            this.dgv_client.TabIndex = 3;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // tbSearth
            // 
            this.tbSearth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearth.Location = new System.Drawing.Point(83, 18);
            this.tbSearth.Margin = new System.Windows.Forms.Padding(6);
            this.tbSearth.Name = "tbSearth";
            this.tbSearth.Size = new System.Drawing.Size(880, 31);
            this.tbSearth.TabIndex = 1;
            this.tbSearth.TextChanged += new System.EventHandler(this.tbSearth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
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
            // cli_telefone
            // 
            this.cli_telefone.DataPropertyName = "cli_telefone";
            this.cli_telefone.DividerWidth = 2;
            this.cli_telefone.HeaderText = "Telefone";
            this.cli_telefone.MinimumWidth = 150;
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.ReadOnly = true;
            this.cli_telefone.Width = 150;
            // 
            // cli_saldo
            // 
            this.cli_saldo.DataPropertyName = "cli_saldo";
            this.cli_saldo.HeaderText = "Saldo";
            this.cli_saldo.MinimumWidth = 150;
            this.cli_saldo.Name = "cli_saldo";
            this.cli_saldo.ReadOnly = true;
            this.cli_saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_saldo.Width = 150;
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearth);
            this.Controls.Add(this.dgv_client);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.TextBox tbSearth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_saldo;
    }
}
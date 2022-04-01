namespace sisVendas.Telas.Caixa
{
    partial class FormAbrirFecharCaixa
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
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.lvl = new System.Windows.Forms.GroupBox();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.groupFechar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaldoFecharCaixa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEntradas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSaidas = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.groupAbrir = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSuprimentos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiaAnterior = new System.Windows.Forms.Label();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.tbSangria = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.groupFechar.SuspendLayout();
            this.groupAbrir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(36, 304);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(220, 20);
            this.tbSaldo.TabIndex = 5;
            this.tbSaldo.Text = "R$ 0";
            // 
            // lvl
            // 
            this.lvl.Controls.Add(this.dgvTransacoes);
            this.lvl.Location = new System.Drawing.Point(650, 13);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(549, 478);
            this.lvl.TabIndex = 25;
            this.lvl.TabStop = false;
            this.lvl.Text = "Transações";
            // 
            // dgvTransacoes
            // 
            this.dgvTransacoes.AllowUserToAddRows = false;
            this.dgvTransacoes.AllowUserToDeleteRows = false;
            this.dgvTransacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacoes.Location = new System.Drawing.Point(7, 20);
            this.dgvTransacoes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.RowHeadersVisible = false;
            this.dgvTransacoes.RowTemplate.Height = 25;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(535, 451);
            this.dgvTransacoes.TabIndex = 30;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(19, 524);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaixa.MultiSelect = false;
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowHeadersVisible = false;
            this.dgvCaixa.RowTemplate.Height = 25;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(1180, 212);
            this.dgvCaixa.TabIndex = 18;
            // 
            // groupFechar
            // 
            this.groupFechar.Controls.Add(this.label3);
            this.groupFechar.Controls.Add(this.tbSaldoFecharCaixa);
            this.groupFechar.Controls.Add(this.label7);
            this.groupFechar.Controls.Add(this.tbEntradas);
            this.groupFechar.Controls.Add(this.label8);
            this.groupFechar.Controls.Add(this.tbSaidas);
            this.groupFechar.Controls.Add(this.btn_fechar);
            this.groupFechar.Location = new System.Drawing.Point(339, 72);
            this.groupFechar.Name = "groupFechar";
            this.groupFechar.Size = new System.Drawing.Size(286, 419);
            this.groupFechar.TabIndex = 24;
            this.groupFechar.TabStop = false;
            this.groupFechar.Text = "Fechar Caixa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Saldo atual";
            // 
            // tbSaldoFecharCaixa
            // 
            this.tbSaldoFecharCaixa.Enabled = false;
            this.tbSaldoFecharCaixa.Location = new System.Drawing.Point(36, 309);
            this.tbSaldoFecharCaixa.Name = "tbSaldoFecharCaixa";
            this.tbSaldoFecharCaixa.Size = new System.Drawing.Size(220, 20);
            this.tbSaldoFecharCaixa.TabIndex = 35;
            this.tbSaldoFecharCaixa.Text = "R$ 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Entradas";
            // 
            // tbEntradas
            // 
            this.tbEntradas.Enabled = false;
            this.tbEntradas.Location = new System.Drawing.Point(32, 165);
            this.tbEntradas.Name = "tbEntradas";
            this.tbEntradas.Size = new System.Drawing.Size(216, 20);
            this.tbEntradas.TabIndex = 38;
            this.tbEntradas.Text = "R$ 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Saidas";
            // 
            // tbSaidas
            // 
            this.tbSaidas.Enabled = false;
            this.tbSaidas.Location = new System.Drawing.Point(33, 239);
            this.tbSaidas.Name = "tbSaidas";
            this.tbSaidas.Size = new System.Drawing.Size(216, 20);
            this.tbSaidas.TabIndex = 36;
            this.tbSaidas.Text = "R$ 0";
            // 
            // btn_fechar
            // 
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(36, 353);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(220, 31);
            this.btn_fechar.TabIndex = 28;
            this.btn_fechar.Text = "Fechar Caixa";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // groupAbrir
            // 
            this.groupAbrir.Controls.Add(this.label6);
            this.groupAbrir.Controls.Add(this.tbSaldo);
            this.groupAbrir.Controls.Add(this.label2);
            this.groupAbrir.Controls.Add(this.tbSuprimentos);
            this.groupAbrir.Controls.Add(this.label5);
            this.groupAbrir.Controls.Add(this.lblDiaAnterior);
            this.groupAbrir.Controls.Add(this.btn_abrir);
            this.groupAbrir.Controls.Add(this.tbSangria);
            this.groupAbrir.Location = new System.Drawing.Point(19, 72);
            this.groupAbrir.Name = "groupAbrir";
            this.groupAbrir.Size = new System.Drawing.Size(286, 419);
            this.groupAbrir.TabIndex = 23;
            this.groupAbrir.TabStop = false;
            this.groupAbrir.Text = "Abrir Caixa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Suprimentos";
            // 
            // tbSuprimentos
            // 
            this.tbSuprimentos.Location = new System.Drawing.Point(32, 160);
            this.tbSuprimentos.Name = "tbSuprimentos";
            this.tbSuprimentos.Size = new System.Drawing.Size(216, 20);
            this.tbSuprimentos.TabIndex = 32;
            this.tbSuprimentos.Text = "R$ 0";
            this.tbSuprimentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSuprimentos_KeyPress);
            this.tbSuprimentos.Leave += new System.EventHandler(this.tbSuprimentos_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sangria";
            // 
            // lblDiaAnterior
            // 
            this.lblDiaAnterior.AutoSize = true;
            this.lblDiaAnterior.Location = new System.Drawing.Point(29, 110);
            this.lblDiaAnterior.Name = "lblDiaAnterior";
            this.lblDiaAnterior.Size = new System.Drawing.Size(24, 13);
            this.lblDiaAnterior.TabIndex = 30;
            this.lblDiaAnterior.Text = "R$ ";
            // 
            // btn_abrir
            // 
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.Location = new System.Drawing.Point(36, 353);
            this.btn_abrir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(216, 31);
            this.btn_abrir.TabIndex = 27;
            this.btn_abrir.Text = "Abrir Caixa";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // tbSangria
            // 
            this.tbSangria.Location = new System.Drawing.Point(33, 234);
            this.tbSangria.Name = "tbSangria";
            this.tbSangria.Size = new System.Drawing.Size(216, 20);
            this.tbSangria.TabIndex = 5;
            this.tbSangria.Text = "R$ 0";
            this.tbSangria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSangria_KeyPress);
            this.tbSangria.Leave += new System.EventHandler(this.tbSangria_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(92, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(22, 31);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = ".";
            // 
            // FormAbrirFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 773);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.groupFechar);
            this.Controls.Add(this.groupAbrir);
            this.Controls.Add(this.lblDate);
            this.Name = "FormAbrirFecharCaixa";
            this.Text = "FormAbrirFecharCaixa";
            this.lvl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.groupFechar.ResumeLayout(false);
            this.groupFechar.PerformLayout();
            this.groupAbrir.ResumeLayout(false);
            this.groupAbrir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.GroupBox lvl;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.GroupBox groupFechar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.GroupBox groupAbrir;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.TextBox tbSangria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldoFecharCaixa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEntradas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSaidas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSuprimentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiaAnterior;
        private System.Windows.Forms.DataGridView dgvTransacoes;
    }
}
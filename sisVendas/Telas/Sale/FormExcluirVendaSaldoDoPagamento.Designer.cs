namespace sisVendas.Telas.Sale
{
    partial class FormExcluirVendaSaldoDoPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbAddSaldo = new System.Windows.Forms.CheckBox();
            this.cbbRetirarCaixa = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor total pago!";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 52);
            this.lblValor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(70, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar Venda!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAddSaldo
            // 
            this.cbAddSaldo.AutoSize = true;
            this.cbAddSaldo.Checked = true;
            this.cbAddSaldo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddSaldo.Location = new System.Drawing.Point(26, 133);
            this.cbAddSaldo.Name = "cbAddSaldo";
            this.cbAddSaldo.Size = new System.Drawing.Size(179, 29);
            this.cbAddSaldo.TabIndex = 4;
            this.cbAddSaldo.Text = "Adicionar saldo";
            this.cbAddSaldo.UseVisualStyleBackColor = true;
            this.cbAddSaldo.Click += new System.EventHandler(this.cbAddSaldo_Click);
            // 
            // cbbRetirarCaixa
            // 
            this.cbbRetirarCaixa.AutoSize = true;
            this.cbbRetirarCaixa.Location = new System.Drawing.Point(26, 195);
            this.cbbRetirarCaixa.Name = "cbbRetirarCaixa";
            this.cbbRetirarCaixa.Size = new System.Drawing.Size(235, 29);
            this.cbbRetirarCaixa.TabIndex = 5;
            this.cbbRetirarCaixa.Text = "Retirar do caixa atual";
            this.cbbRetirarCaixa.UseVisualStyleBackColor = true;
            this.cbbRetirarCaixa.Click += new System.EventHandler(this.cbbRetirarCaixa_Click);
            // 
            // FormExcluirVendaSaldoDoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 332);
            this.Controls.Add(this.cbbRetirarCaixa);
            this.Controls.Add(this.cbAddSaldo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "FormExcluirVendaSaldoDoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Cancelar venda selecionada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbAddSaldo;
        private System.Windows.Forms.CheckBox cbbRetirarCaixa;
    }
}
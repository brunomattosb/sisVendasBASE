namespace sisVendas.Screens.Sale
{
    partial class FormDesconto
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAppDiscount = new System.Windows.Forms.Button();
            this.tbValueDiscount = new System.Windows.Forms.TextBox();
            this.ccbPercent = new System.Windows.Forms.CheckBox();
            this.ccbMoney = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAppDiscount);
            this.groupBox3.Controls.Add(this.tbValueDiscount);
            this.groupBox3.Controls.Add(this.ccbPercent);
            this.groupBox3.Controls.Add(this.ccbMoney);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 183);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desconto";
            // 
            // btnAppDiscount
            // 
            this.btnAppDiscount.Location = new System.Drawing.Point(24, 138);
            this.btnAppDiscount.Name = "btnAppDiscount";
            this.btnAppDiscount.Size = new System.Drawing.Size(118, 36);
            this.btnAppDiscount.TabIndex = 60;
            this.btnAppDiscount.Text = "Aplicar";
            this.btnAppDiscount.UseVisualStyleBackColor = true;
            this.btnAppDiscount.Click += new System.EventHandler(this.btnAppDiscount_Click);
            // 
            // tbValueDiscount
            // 
            this.tbValueDiscount.Location = new System.Drawing.Point(11, 100);
            this.tbValueDiscount.Name = "tbValueDiscount";
            this.tbValueDiscount.Size = new System.Drawing.Size(145, 31);
            this.tbValueDiscount.TabIndex = 59;
            this.tbValueDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueDiscount_KeyPress);
            // 
            // ccbPercent
            // 
            this.ccbPercent.AutoSize = true;
            this.ccbPercent.Location = new System.Drawing.Point(11, 65);
            this.ccbPercent.Name = "ccbPercent";
            this.ccbPercent.Size = new System.Drawing.Size(87, 29);
            this.ccbPercent.TabIndex = 1;
            this.ccbPercent.Text = "Em %";
            this.ccbPercent.UseVisualStyleBackColor = true;
            this.ccbPercent.Click += new System.EventHandler(this.ccbPercent_Click);
            // 
            // ccbMoney
            // 
            this.ccbMoney.AutoSize = true;
            this.ccbMoney.Checked = true;
            this.ccbMoney.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbMoney.Location = new System.Drawing.Point(11, 30);
            this.ccbMoney.Name = "ccbMoney";
            this.ccbMoney.Size = new System.Drawing.Size(145, 29);
            this.ccbMoney.TabIndex = 0;
            this.ccbMoney.Text = "Em dinheiro";
            this.ccbMoney.UseVisualStyleBackColor = true;
            this.ccbMoney.Click += new System.EventHandler(this.ccbMoney_Click);
            // 
            // FormDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 207);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Desconto";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAppDiscount;
        private System.Windows.Forms.TextBox tbValueDiscount;
        private System.Windows.Forms.CheckBox ccbPercent;
        private System.Windows.Forms.CheckBox ccbMoney;
    }
}
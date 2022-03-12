namespace sisVendas.Screens.Sale
{
    partial class FormSimularVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbListOffsetValue = new System.Windows.Forms.ListBox();
            this.tbSubtotalOffset = new System.Windows.Forms.TextBox();
            this.lblTotalOffset = new System.Windows.Forms.Label();
            this.tbTotalOffset = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSubtotalOffset = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbListOffsetValue);
            this.groupBox1.Controls.Add(this.tbSubtotalOffset);
            this.groupBox1.Controls.Add(this.lblTotalOffset);
            this.groupBox1.Controls.Add(this.tbTotalOffset);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblSubtotalOffset);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 288);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Valor:";
            // 
            // lbListOffsetValue
            // 
            this.lbListOffsetValue.FormattingEnabled = true;
            this.lbListOffsetValue.ItemHeight = 25;
            this.lbListOffsetValue.Location = new System.Drawing.Point(7, 117);
            this.lbListOffsetValue.Name = "lbListOffsetValue";
            this.lbListOffsetValue.Size = new System.Drawing.Size(173, 154);
            this.lbListOffsetValue.TabIndex = 52;
            // 
            // tbSubtotalOffset
            // 
            this.tbSubtotalOffset.Enabled = false;
            this.tbSubtotalOffset.Location = new System.Drawing.Point(253, 221);
            this.tbSubtotalOffset.Name = "tbSubtotalOffset";
            this.tbSubtotalOffset.Size = new System.Drawing.Size(122, 31);
            this.tbSubtotalOffset.TabIndex = 58;
            // 
            // lblTotalOffset
            // 
            this.lblTotalOffset.AutoSize = true;
            this.lblTotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOffset.Location = new System.Drawing.Point(250, 136);
            this.lblTotalOffset.Name = "lblTotalOffset";
            this.lblTotalOffset.Size = new System.Drawing.Size(89, 20);
            this.lblTotalOffset.TabIndex = 51;
            this.lblTotalOffset.Text = "Total Pago:";
            // 
            // tbTotalOffset
            // 
            this.tbTotalOffset.Enabled = false;
            this.tbTotalOffset.Location = new System.Drawing.Point(253, 159);
            this.tbTotalOffset.Name = "tbTotalOffset";
            this.tbTotalOffset.Size = new System.Drawing.Size(122, 31);
            this.tbTotalOffset.TabIndex = 57;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSubtotalOffset
            // 
            this.lblSubtotalOffset.AutoSize = true;
            this.lblSubtotalOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalOffset.Location = new System.Drawing.Point(249, 198);
            this.lblSubtotalOffset.Name = "lblSubtotalOffset";
            this.lblSubtotalOffset.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotalOffset.TabIndex = 56;
            this.lblSubtotalOffset.Text = "Subtotal:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(186, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 45);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(7, 70);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(138, 31);
            this.tbValor.TabIndex = 55;
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            this.tbValor.Leave += new System.EventHandler(this.tbValor_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(171, 40);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(76, 42);
            this.lblValor.TabIndex = 59;
            this.lblValor.Text = "R$ ";
            // 
            // FormSimularVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 316);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSimularVenda";
            this.Text = "FormSimulateSale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbListOffsetValue;
        private System.Windows.Forms.TextBox tbSubtotalOffset;
        private System.Windows.Forms.Label lblTotalOffset;
        private System.Windows.Forms.TextBox tbTotalOffset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSubtotalOffset;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblValor;
    }
}
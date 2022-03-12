namespace sisVendas.Screens.Sale
{
    partial class FormCalcularTroco
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.lblThing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Valor cobrado:";
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(43, 59);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(152, 31);
            this.tbValue.TabIndex = 62;
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            this.tbValue.Leave += new System.EventHandler(this.tbValue_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Valor recebido:";
            // 
            // tbReceived
            // 
            this.tbReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceived.Location = new System.Drawing.Point(232, 59);
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.Size = new System.Drawing.Size(152, 31);
            this.tbReceived.TabIndex = 64;
            this.tbReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReceived_KeyPress);
            this.tbReceived.Leave += new System.EventHandler(this.tbReceived_Leave);
            // 
            // lblThing
            // 
            this.lblThing.AutoSize = true;
            this.lblThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThing.Location = new System.Drawing.Point(131, 145);
            this.lblThing.Name = "lblThing";
            this.lblThing.Size = new System.Drawing.Size(71, 31);
            this.lblThing.TabIndex = 65;
            this.lblThing.Text = "R$ 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 66;
            this.label3.Text = "TROCO: ";
            // 
            // FormCalcularTroco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Name = "FormCalcularTroco";
            this.Text = "FormThing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReceived;
        private System.Windows.Forms.Label lblThing;
        private System.Windows.Forms.Label label3;
    }
}
namespace sisVendas.Telas.Sale
{
    partial class FormBobina
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
            this.Bobina = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Bobina
            // 
            this.Bobina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bobina.BackColor = System.Drawing.Color.LightYellow;
            this.Bobina.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Bobina.ForeColor = System.Drawing.Color.Black;
            this.Bobina.ItemHeight = 16;
            this.Bobina.Location = new System.Drawing.Point(175, 38);
            this.Bobina.Name = "Bobina";
            this.Bobina.Size = new System.Drawing.Size(422, 212);
            this.Bobina.TabIndex = 8;
            // 
            // FormBobina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bobina);
            this.Name = "FormBobina";
            this.Text = "FormBobina";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Bobina;
    }
}
namespace sisVendas.Telas.Caixa
{
    partial class FormContasAReceber
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbDtFim = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(848, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 37);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.groupBox2.Text = "Periodo da Venda";
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
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Location = new System.Drawing.Point(6, 224);
            this.dgv_parcelas.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_parcelas.MultiSelect = false;
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.ReadOnly = true;
            this.dgv_parcelas.RowHeadersVisible = false;
            this.dgv_parcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_parcelas.Size = new System.Drawing.Size(1186, 530);
            this.dgv_parcelas.TabIndex = 8;
            this.dgv_parcelas.DoubleClick += new System.EventHandler(this.dgv_parcelas_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.mtbCpf);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1186, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // FormContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 769);
            this.Controls.Add(this.dgv_parcelas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormContasAReceber";
            this.Text = "ContasAReceber";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbDtFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDtInicio;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
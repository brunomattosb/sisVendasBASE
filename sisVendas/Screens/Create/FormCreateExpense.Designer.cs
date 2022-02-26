namespace sisVendas.Screens.Create
{
    partial class FormCreateExpense
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_dtnascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_dtcadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_dtadmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_dtdemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(30, 16);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(547, 42);
            this.lblFuncionario.TabIndex = 3;
            this.lblFuncionario.Text = "Cadastrar Categoria de Produto";
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbPesquisa);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(37, 278);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(360, 57);
            this.GbpPesquisa.TabIndex = 5;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(20, 22);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(322, 20);
            this.tbPesquisa.TabIndex = 0;
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCad.Controls.Add(this.tableLayoutPanel1);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.tbCod);
            this.gbCad.Controls.Add(this.tbNome);
            this.gbCad.Controls.Add(this.lblNome);
            this.gbCad.Location = new System.Drawing.Point(36, 70);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(694, 203);
            this.gbCad.TabIndex = 4;
            this.gbCad.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNovo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalvar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.Location = new System.Drawing.Point(34, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 37);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(190, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(503, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 37);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Location = new System.Drawing.Point(346, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 37);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(34, 27);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(37, 43);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 1;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(116, 43);
            this.tbNome.MaxLength = 49;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(572, 20);
            this.tbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(113, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "*Nome:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_funcionario, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 345);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 304);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            this.dgv_funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.func_nome,
            this.func_cod,
            this.func_cep,
            this.func_end,
            this.func_bairro,
            this.func_cidade,
            this.func_estado,
            this.func_dtnascimento,
            this.func_dtcadastro,
            this.func_pais,
            this.func_complemento,
            this.func_telefone,
            this.func_sexo,
            this.func_cpf,
            this.func_salario,
            this.func_dtadmissao,
            this.func_dtdemissao});
            this.dgv_funcionario.Location = new System.Drawing.Point(3, 3);
            this.dgv_funcionario.MultiSelect = false;
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.RowHeadersVisible = false;
            this.dgv_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionario.Size = new System.Drawing.Size(699, 298);
            this.dgv_funcionario.TabIndex = 0;
            // 
            // func_nome
            // 
            this.func_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Nome";
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
            // 
            // func_cod
            // 
            this.func_cod.DataPropertyName = "func_cod";
            this.func_cod.HeaderText = "Código";
            this.func_cod.Name = "func_cod";
            this.func_cod.ReadOnly = true;
            this.func_cod.Visible = false;
            // 
            // func_cep
            // 
            this.func_cep.DataPropertyName = "func_cep";
            this.func_cep.HeaderText = "CEP";
            this.func_cep.Name = "func_cep";
            this.func_cep.ReadOnly = true;
            this.func_cep.Visible = false;
            // 
            // func_end
            // 
            this.func_end.DataPropertyName = "func_end";
            this.func_end.HeaderText = "Endereço";
            this.func_end.Name = "func_end";
            this.func_end.ReadOnly = true;
            this.func_end.Visible = false;
            // 
            // func_bairro
            // 
            this.func_bairro.DataPropertyName = "func_bairro";
            this.func_bairro.HeaderText = "Bairro";
            this.func_bairro.Name = "func_bairro";
            this.func_bairro.ReadOnly = true;
            this.func_bairro.Visible = false;
            // 
            // func_cidade
            // 
            this.func_cidade.DataPropertyName = "func_cidade";
            this.func_cidade.HeaderText = "Cidade";
            this.func_cidade.Name = "func_cidade";
            this.func_cidade.ReadOnly = true;
            this.func_cidade.Visible = false;
            // 
            // func_estado
            // 
            this.func_estado.DataPropertyName = "func_estado";
            this.func_estado.HeaderText = "Estado";
            this.func_estado.Name = "func_estado";
            this.func_estado.ReadOnly = true;
            this.func_estado.Visible = false;
            // 
            // func_dtnascimento
            // 
            this.func_dtnascimento.DataPropertyName = "func_dtnascimento";
            this.func_dtnascimento.HeaderText = "Nascimento";
            this.func_dtnascimento.Name = "func_dtnascimento";
            this.func_dtnascimento.ReadOnly = true;
            this.func_dtnascimento.Visible = false;
            // 
            // func_dtcadastro
            // 
            this.func_dtcadastro.DataPropertyName = "func_dtcadastro";
            this.func_dtcadastro.HeaderText = "Cadastro";
            this.func_dtcadastro.Name = "func_dtcadastro";
            this.func_dtcadastro.ReadOnly = true;
            this.func_dtcadastro.Visible = false;
            // 
            // func_pais
            // 
            this.func_pais.DataPropertyName = "func_pais";
            this.func_pais.HeaderText = "Pais";
            this.func_pais.Name = "func_pais";
            this.func_pais.ReadOnly = true;
            this.func_pais.Visible = false;
            // 
            // func_complemento
            // 
            this.func_complemento.DataPropertyName = "func_complemento";
            this.func_complemento.HeaderText = "Complemento";
            this.func_complemento.Name = "func_complemento";
            this.func_complemento.ReadOnly = true;
            this.func_complemento.Visible = false;
            // 
            // func_telefone
            // 
            this.func_telefone.DataPropertyName = "func_telefone";
            this.func_telefone.DividerWidth = 2;
            this.func_telefone.HeaderText = "Telefone";
            this.func_telefone.Name = "func_telefone";
            this.func_telefone.ReadOnly = true;
            this.func_telefone.Visible = false;
            // 
            // func_sexo
            // 
            this.func_sexo.DataPropertyName = "func_sexo";
            this.func_sexo.HeaderText = "Sexo";
            this.func_sexo.Name = "func_sexo";
            this.func_sexo.ReadOnly = true;
            this.func_sexo.Visible = false;
            // 
            // func_cpf
            // 
            this.func_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.func_cpf.DataPropertyName = "func_cpf";
            this.func_cpf.HeaderText = "CPF";
            this.func_cpf.MinimumWidth = 200;
            this.func_cpf.Name = "func_cpf";
            this.func_cpf.ReadOnly = true;
            this.func_cpf.Width = 200;
            // 
            // func_salario
            // 
            this.func_salario.DataPropertyName = "func_salario";
            this.func_salario.HeaderText = "Salario";
            this.func_salario.Name = "func_salario";
            this.func_salario.ReadOnly = true;
            this.func_salario.Visible = false;
            // 
            // func_dtadmissao
            // 
            this.func_dtadmissao.DataPropertyName = "func_dtadmissao";
            this.func_dtadmissao.HeaderText = "Admissao";
            this.func_dtadmissao.MinimumWidth = 100;
            this.func_dtadmissao.Name = "func_dtadmissao";
            this.func_dtadmissao.ReadOnly = true;
            // 
            // func_dtdemissao
            // 
            this.func_dtdemissao.DataPropertyName = "func_dtdemissao";
            this.func_dtdemissao.HeaderText = "demissao";
            this.func_dtdemissao.Name = "func_dtdemissao";
            this.func_dtdemissao.ReadOnly = true;
            this.func_dtdemissao.Visible = false;
            // 
            // FormCreateExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormCreateExpense";
            this.Text = "FormCreateExpense";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_dtnascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_dtcadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_dtadmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_dtdemissao;
    }
}
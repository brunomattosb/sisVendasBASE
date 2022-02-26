﻿namespace sisVendas.Screens.Create
{
    partial class FormCreateEmployee
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
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mtbDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.mtbDemissao = new System.Windows.Forms.MaskedTextBox();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.lblDemissao = new System.Windows.Forms.Label();
            this.mtbAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbPesquisa);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(34, 364);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(336, 57);
            this.GbpPesquisa.TabIndex = 1;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(6, 22);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(322, 20);
            this.tbPesquisa.TabIndex = 0;
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCad.Controls.Add(this.lblEmail);
            this.gbCad.Controls.Add(this.tbEmail);
            this.gbCad.Controls.Add(this.maskedTextBox1);
            this.gbCad.Controls.Add(this.lblRg);
            this.gbCad.Controls.Add(this.tableLayoutPanel1);
            this.gbCad.Controls.Add(this.mtbDtNasc);
            this.gbCad.Controls.Add(this.mtbTelefone);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.lblTelefone);
            this.gbCad.Controls.Add(this.mtbCpf);
            this.gbCad.Controls.Add(this.mtbCep);
            this.gbCad.Controls.Add(this.lblSalario);
            this.gbCad.Controls.Add(this.tbSaldo);
            this.gbCad.Controls.Add(this.tbCod);
            this.gbCad.Controls.Add(this.lblSexo);
            this.gbCad.Controls.Add(this.cbbSexo);
            this.gbCad.Controls.Add(this.lblNascimento);
            this.gbCad.Controls.Add(this.lblEstado);
            this.gbCad.Controls.Add(this.cbbEstado);
            this.gbCad.Controls.Add(this.lblBairro);
            this.gbCad.Controls.Add(this.tbBairro);
            this.gbCad.Controls.Add(this.tbCidade);
            this.gbCad.Controls.Add(this.lblCidade);
            this.gbCad.Controls.Add(this.tbEnd);
            this.gbCad.Controls.Add(this.lblEnd);
            this.gbCad.Controls.Add(this.lblCep);
            this.gbCad.Controls.Add(this.tbNome);
            this.gbCad.Controls.Add(this.lblNome);
            this.gbCad.Controls.Add(this.lblCpf);
            this.gbCad.Location = new System.Drawing.Point(33, 75);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(694, 280);
            this.gbCad.TabIndex = 0;
            this.gbCad.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(162, 169);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(385, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(234, 43);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(231, 27);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG:";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 14;
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
            // mtbDtNasc
            // 
            this.mtbDtNasc.Location = new System.Drawing.Point(553, 129);
            this.mtbDtNasc.Mask = "00/00/0000";
            this.mtbDtNasc.Name = "mtbDtNasc";
            this.mtbDtNasc.Size = new System.Drawing.Size(111, 20);
            this.mtbDtNasc.TabIndex = 11;
            this.mtbDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(37, 168);
            this.mtbTelefone.Mask = "(00)00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(112, 20);
            this.mtbTelefone.TabIndex = 12;
            this.mtbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(35, 154);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(116, 43);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(112, 20);
            this.mtbCpf.TabIndex = 2;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(352, 129);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(112, 20);
            this.mtbCep.TabIndex = 9;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(550, 156);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(69, 13);
            this.lblSalario.TabIndex = 29;
            this.lblSalario.Text = "Salário Base:";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(553, 169);
            this.tbSaldo.MaxLength = 10;
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(111, 20);
            this.tbSaldo.TabIndex = 13;
            this.tbSaldo.Text = "0,00";
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(37, 43);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(349, 74);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 26;
            this.lblSexo.Text = "*Sexo:";
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbbSexo.Location = new System.Drawing.Point(352, 89);
            this.cbbSexo.MaxLength = 1;
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(112, 21);
            this.cbbSexo.TabIndex = 6;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(550, 114);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(61, 13);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "Data Nasc:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(467, 113);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(28, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "*UF:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbEstado.Location = new System.Drawing.Point(470, 128);
            this.cbbEstado.MaxLength = 2;
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(77, 21);
            this.cbbEstado.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(34, 113);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(37, 129);
            this.tbBairro.MaxLength = 20;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(309, 20);
            this.tbBairro.TabIndex = 8;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(470, 87);
            this.tbCidade.MaxLength = 29;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(194, 20);
            this.tbCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(467, 74);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(37, 90);
            this.tbEnd.MaxLength = 49;
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(309, 20);
            this.tbEnd.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(34, 74);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(349, 113);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(352, 43);
            this.tbNome.MaxLength = 49;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(312, 20);
            this.tbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(349, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "*Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(113, 27);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "*CPF:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_funcionario, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 427);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 222);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.dgv_funcionario.Size = new System.Drawing.Size(699, 216);
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
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(27, 21);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(388, 42);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Cadastrar Funcionário";
            // 
            // mtbDemissao
            // 
            this.mtbDemissao.Location = new System.Drawing.Point(176, 31);
            this.mtbDemissao.Mask = "00/00/0000";
            this.mtbDemissao.Name = "mtbDemissao";
            this.mtbDemissao.Size = new System.Drawing.Size(102, 20);
            this.mtbDemissao.TabIndex = 2;
            this.mtbDemissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDemissao.ValidatingType = typeof(System.DateTime);
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(35, 15);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(59, 13);
            this.lblAdmissao.TabIndex = 44;
            this.lblAdmissao.Text = "*Admissão:";
            // 
            // lblDemissao
            // 
            this.lblDemissao.AutoSize = true;
            this.lblDemissao.Location = new System.Drawing.Point(176, 16);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(56, 13);
            this.lblDemissao.TabIndex = 46;
            this.lblDemissao.Text = "Demissão:";
            // 
            // mtbAdmissao
            // 
            this.mtbAdmissao.Location = new System.Drawing.Point(38, 31);
            this.mtbAdmissao.Mask = "00/00/0000";
            this.mtbAdmissao.Name = "mtbAdmissao";
            this.mtbAdmissao.Size = new System.Drawing.Size(102, 20);
            this.mtbAdmissao.TabIndex = 1;
            this.mtbAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.mtbDemissao);
            this.groupBox2.Controls.Add(this.lblAdmissao);
            this.groupBox2.Controls.Add(this.mtbAdmissao);
            this.groupBox2.Controls.Add(this.lblDemissao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormCreateEmployee";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtbDtNasc;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.Label lblFuncionario;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mtbDemissao;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.Label lblDemissao;
        private System.Windows.Forms.MaskedTextBox mtbAdmissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
    }
}
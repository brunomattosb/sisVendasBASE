﻿namespace sisVendas.Screens.Create
{
    partial class FormCriarFuncionario
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.gbAdmission = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.dtpDemissao = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissao = new System.Windows.Forms.DateTimePicker();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.lblDemissao = new System.Windows.Forms.Label();
            this.gbAccess = new System.Windows.Forms.GroupBox();
            this.cbAccces = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.cbbLicence = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbBaseSalary = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbDistrict = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbAddres = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.func_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.gbAdmission.SuspendLayout();
            this.gbAccess.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(12, 339);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(336, 57);
            this.GbpPesquisa.TabIndex = 2;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(6, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gbCad
            // 
            this.gbCad.Controls.Add(this.dtpDtNasc);
            this.gbCad.Controls.Add(this.tbRg);
            this.gbCad.Controls.Add(this.gbAdmission);
            this.gbCad.Controls.Add(this.gbAccess);
            this.gbCad.Controls.Add(this.lblEmail);
            this.gbCad.Controls.Add(this.tbEmail);
            this.gbCad.Controls.Add(this.lblRg);
            this.gbCad.Controls.Add(this.mtbTelephone);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.lblTelefone);
            this.gbCad.Controls.Add(this.mtbCpf);
            this.gbCad.Controls.Add(this.mtbCep);
            this.gbCad.Controls.Add(this.lblSalario);
            this.gbCad.Controls.Add(this.tbBaseSalary);
            this.gbCad.Controls.Add(this.tbCod);
            this.gbCad.Controls.Add(this.lblSexo);
            this.gbCad.Controls.Add(this.cbbSex);
            this.gbCad.Controls.Add(this.lblNascimento);
            this.gbCad.Controls.Add(this.lblEstado);
            this.gbCad.Controls.Add(this.cbbUF);
            this.gbCad.Controls.Add(this.lblBairro);
            this.gbCad.Controls.Add(this.tbDistrict);
            this.gbCad.Controls.Add(this.tbCity);
            this.gbCad.Controls.Add(this.lblCidade);
            this.gbCad.Controls.Add(this.tbAddres);
            this.gbCad.Controls.Add(this.lblEnd);
            this.gbCad.Controls.Add(this.lblCep);
            this.gbCad.Controls.Add(this.tbName);
            this.gbCad.Controls.Add(this.lblName);
            this.gbCad.Controls.Add(this.lblCpf);
            this.gbCad.Location = new System.Drawing.Point(12, 12);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(647, 321);
            this.gbCad.TabIndex = 0;
            this.gbCad.TabStop = false;
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(525, 118);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(111, 20);
            this.dtpDtNasc.TabIndex = 10;
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(208, 32);
            this.tbRg.MaxLength = 19;
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(111, 20);
            this.tbRg.TabIndex = 2;
            // 
            // gbAdmission
            // 
            this.gbAdmission.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdmission.Controls.Add(this.cbAtivo);
            this.gbAdmission.Controls.Add(this.dtpDemissao);
            this.gbAdmission.Controls.Add(this.dtpAdmissao);
            this.gbAdmission.Controls.Add(this.lblAdmissao);
            this.gbAdmission.Controls.Add(this.lblDemissao);
            this.gbAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmission.Location = new System.Drawing.Point(369, 185);
            this.gbAdmission.Name = "gbAdmission";
            this.gbAdmission.Size = new System.Drawing.Size(267, 92);
            this.gbAdmission.TabIndex = 15;
            this.gbAdmission.TabStop = false;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(12, 19);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 51;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            this.cbAtivo.CheckedChanged += new System.EventHandler(this.cbAtivo_CheckedChanged);
            // 
            // dtpDemissao
            // 
            this.dtpDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDemissao.Location = new System.Drawing.Point(139, 58);
            this.dtpDemissao.Name = "dtpDemissao";
            this.dtpDemissao.Size = new System.Drawing.Size(111, 20);
            this.dtpDemissao.TabIndex = 52;
            // 
            // dtpAdmissao
            // 
            this.dtpAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmissao.Location = new System.Drawing.Point(12, 58);
            this.dtpAdmissao.Name = "dtpAdmissao";
            this.dtpAdmissao.Size = new System.Drawing.Size(111, 20);
            this.dtpAdmissao.TabIndex = 51;
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(9, 42);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(59, 13);
            this.lblAdmissao.TabIndex = 0;
            this.lblAdmissao.Text = "*Admissão:";
            // 
            // lblDemissao
            // 
            this.lblDemissao.AutoSize = true;
            this.lblDemissao.Location = new System.Drawing.Point(136, 42);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(56, 13);
            this.lblDemissao.TabIndex = 46;
            this.lblDemissao.Text = "Demissão:";
            // 
            // gbAccess
            // 
            this.gbAccess.Controls.Add(this.cbAccces);
            this.gbAccess.Controls.Add(this.tbPassword);
            this.gbAccess.Controls.Add(this.tbUsername);
            this.gbAccess.Controls.Add(this.lblUser);
            this.gbAccess.Controls.Add(this.lblPassword);
            this.gbAccess.Controls.Add(this.lblLicenca);
            this.gbAccess.Controls.Add(this.cbbLicence);
            this.gbAccess.Location = new System.Drawing.Point(9, 185);
            this.gbAccess.Name = "gbAccess";
            this.gbAccess.Size = new System.Drawing.Size(354, 127);
            this.gbAccess.TabIndex = 14;
            this.gbAccess.TabStop = false;
            this.gbAccess.Text = "Acesso:";
            // 
            // cbAccces
            // 
            this.cbAccces.AutoSize = true;
            this.cbAccces.Location = new System.Drawing.Point(10, 19);
            this.cbAccces.Name = "cbAccces";
            this.cbAccces.Size = new System.Drawing.Size(116, 17);
            this.cbAccces.TabIndex = 0;
            this.cbAccces.Text = "Acesso ao Sistema";
            this.cbAccces.UseVisualStyleBackColor = true;
            this.cbAccces.CheckedChanged += new System.EventHandler(this.cbAccces_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(10, 95);
            this.tbPassword.MaxLength = 49;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(10, 56);
            this.tbUsername.MaxLength = 49;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(162, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(7, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 13);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "*Usuário:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 49;
            this.lblPassword.Text = "*Senha:";
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(175, 40);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(52, 13);
            this.lblLicenca.TabIndex = 47;
            this.lblLicenca.Text = "*Licença:";
            // 
            // cbbLicence
            // 
            this.cbbLicence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLicence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLicence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLicence.Enabled = false;
            this.cbbLicence.FormattingEnabled = true;
            this.cbbLicence.Items.AddRange(new object[] {
            "Basico",
            "Neutro",
            "Master"});
            this.cbbLicence.Location = new System.Drawing.Point(178, 56);
            this.cbbLicence.MaxLength = 2;
            this.cbbLicence.Name = "cbbLicence";
            this.cbbLicence.Size = new System.Drawing.Size(170, 21);
            this.cbbLicence.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(131, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "*Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(134, 159);
            this.tbEmail.MaxLength = 99;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(385, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(204, 16);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG:";
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(9, 158);
            this.mtbTelephone.Mask = "(00)00000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(112, 20);
            this.mtbTelephone.TabIndex = 11;
            this.mtbTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTelephone.Click += new System.EventHandler(this.mtbTelephone_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(6, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 144);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "*Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(90, 32);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(112, 20);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(324, 118);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(112, 20);
            this.mtbCep.TabIndex = 8;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(522, 144);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 13);
            this.lblSalario.TabIndex = 29;
            this.lblSalario.Text = "*Salário Base:";
            // 
            // tbBaseSalary
            // 
            this.tbBaseSalary.Location = new System.Drawing.Point(525, 159);
            this.tbBaseSalary.MaxLength = 10;
            this.tbBaseSalary.Name = "tbBaseSalary";
            this.tbBaseSalary.Size = new System.Drawing.Size(111, 20);
            this.tbBaseSalary.TabIndex = 13;
            this.tbBaseSalary.Enter += new System.EventHandler(this.tbBaseSalary_Enter);
            this.tbBaseSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseSalary_KeyPress);
            this.tbBaseSalary.Leave += new System.EventHandler(this.tbBaseSalary_Leave);
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(11, 32);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(325, 60);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 26;
            this.lblSexo.Text = "*Sexo:";
            // 
            // cbbSex
            // 
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbbSex.Location = new System.Drawing.Point(325, 75);
            this.cbbSex.MaxLength = 1;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(112, 21);
            this.cbbSex.TabIndex = 5;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(522, 103);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(65, 13);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "*Data Nasc:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(439, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(28, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "*UF:";
            // 
            // cbbUF
            // 
            this.cbbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(442, 117);
            this.cbbUF.MaxLength = 2;
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(77, 21);
            this.cbbUF.Sorted = true;
            this.cbbUF.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 103);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(9, 118);
            this.tbDistrict.MaxLength = 20;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(309, 20);
            this.tbDistrict.TabIndex = 7;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(442, 76);
            this.tbCity.MaxLength = 29;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(194, 20);
            this.tbCity.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(439, 60);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "*Cidade";
            // 
            // tbAddres
            // 
            this.tbAddres.Location = new System.Drawing.Point(10, 76);
            this.tbAddres.MaxLength = 49;
            this.tbAddres.Name = "tbAddres";
            this.tbAddres.Size = new System.Drawing.Size(309, 20);
            this.tbAddres.TabIndex = 4;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(9, 60);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(60, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "*Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(321, 103);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(325, 32);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(311, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(321, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "*Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(87, 16);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "*CPF:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 587);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 31);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(17, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 24);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "[F1] - Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(339, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "[F4] - Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(501, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "[F12] - Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(178, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "[F2] - Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.func_id,
            this.func_nome,
            this.func_cpf,
            this.func_usuario,
            this.func_ativo});
            this.dgv_employee.Location = new System.Drawing.Point(12, 402);
            this.dgv_employee.MultiSelect = false;
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.RowHeadersVisible = false;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(647, 179);
            this.dgv_employee.TabIndex = 0;
            this.dgv_employee.DoubleClick += new System.EventHandler(this.dgv_employee_DoubleClick);
            // 
            // func_id
            // 
            this.func_id.DataPropertyName = "func_id";
            this.func_id.HeaderText = "Código";
            this.func_id.Name = "func_id";
            this.func_id.ReadOnly = true;
            this.func_id.Visible = false;
            // 
            // func_nome
            // 
            this.func_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Nome";
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
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
            // func_usuario
            // 
            this.func_usuario.DataPropertyName = "func_usuario";
            this.func_usuario.HeaderText = "Usuário";
            this.func_usuario.Name = "func_usuario";
            this.func_usuario.ReadOnly = true;
            // 
            // func_ativo
            // 
            this.func_ativo.DataPropertyName = "func_ativo";
            this.func_ativo.HeaderText = "Ativo";
            this.func_ativo.Name = "func_ativo";
            this.func_ativo.ReadOnly = true;
            this.func_ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.func_ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormCriarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 630);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.dgv_employee);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GbpPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCriarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Cadastrar funcionário";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.gbAdmission.ResumeLayout(false);
            this.gbAdmission.PerformLayout();
            this.gbAccess.ResumeLayout(false);
            this.gbAccess.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbBaseSalary;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbDistrict;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbAddres;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.Label lblDemissao;
        private System.Windows.Forms.GroupBox gbAdmission;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox gbAccess;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.ComboBox cbbLicence;
        private System.Windows.Forms.CheckBox cbAccces;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.DateTimePicker dtpDemissao;
        private System.Windows.Forms.DateTimePicker dtpAdmissao;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn func_ativo;
    }
}
namespace sisVendas.Screens.Create
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.gbAdmission = new System.Windows.Forms.GroupBox();
            this.mtbDemissao = new System.Windows.Forms.MaskedTextBox();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.mtbAdmission = new System.Windows.Forms.MaskedTextBox();
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
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mtbDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbBaseSalary = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_zip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_birth_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_base_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_admission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_resignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.gbAdmission.SuspendLayout();
            this.gbAccess.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(30, 436);
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
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCad.Controls.Add(this.gbAdmission);
            this.gbCad.Controls.Add(this.gbAccess);
            this.gbCad.Controls.Add(this.lblEmail);
            this.gbCad.Controls.Add(this.tbEmail);
            this.gbCad.Controls.Add(this.mtbRg);
            this.gbCad.Controls.Add(this.lblRg);
            this.gbCad.Controls.Add(this.mtbDtNasc);
            this.gbCad.Controls.Add(this.mtbTelephone);
            this.gbCad.Controls.Add(this.lblCod);
            this.gbCad.Controls.Add(this.lblTelefone);
            this.gbCad.Controls.Add(this.mtbCpf);
            this.gbCad.Controls.Add(this.mtbCep);
            this.gbCad.Controls.Add(this.lblSalario);
            this.gbCad.Controls.Add(this.tbBaseSalary);
            this.gbCad.Controls.Add(this.tbId);
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
            this.gbCad.Location = new System.Drawing.Point(33, 55);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(694, 325);
            this.gbCad.TabIndex = 0;
            this.gbCad.TabStop = false;
            // 
            // gbAdmission
            // 
            this.gbAdmission.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdmission.Controls.Add(this.mtbDemissao);
            this.gbAdmission.Controls.Add(this.lblAdmissao);
            this.gbAdmission.Controls.Add(this.mtbAdmission);
            this.gbAdmission.Controls.Add(this.lblDemissao);
            this.gbAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmission.Location = new System.Drawing.Point(367, 254);
            this.gbAdmission.Name = "gbAdmission";
            this.gbAdmission.Size = new System.Drawing.Size(312, 58);
            this.gbAdmission.TabIndex = 15;
            this.gbAdmission.TabStop = false;
            // 
            // mtbDemissao
            // 
            this.mtbDemissao.Location = new System.Drawing.Point(176, 31);
            this.mtbDemissao.Mask = "00/00/0000";
            this.mtbDemissao.Name = "mtbDemissao";
            this.mtbDemissao.Size = new System.Drawing.Size(102, 20);
            this.mtbDemissao.TabIndex = 1;
            this.mtbDemissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDemissao.ValidatingType = typeof(System.DateTime);
            this.mtbDemissao.Click += new System.EventHandler(this.mtbDemissao_Click);
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(35, 15);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(59, 13);
            this.lblAdmissao.TabIndex = 0;
            this.lblAdmissao.Text = "*Admissão:";
            // 
            // mtbAdmission
            // 
            this.mtbAdmission.Location = new System.Drawing.Point(38, 31);
            this.mtbAdmission.Mask = "00/00/0000";
            this.mtbAdmission.Name = "mtbAdmission";
            this.mtbAdmission.Size = new System.Drawing.Size(102, 20);
            this.mtbAdmission.TabIndex = 0;
            this.mtbAdmission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbAdmission.ValidatingType = typeof(System.DateTime);
            this.mtbAdmission.Click += new System.EventHandler(this.mtbAdmission_Click);
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
            // gbAccess
            // 
            this.gbAccess.Controls.Add(this.cbAccces);
            this.gbAccess.Controls.Add(this.tbPassword);
            this.gbAccess.Controls.Add(this.tbUsername);
            this.gbAccess.Controls.Add(this.lblUser);
            this.gbAccess.Controls.Add(this.lblPassword);
            this.gbAccess.Controls.Add(this.lblLicenca);
            this.gbAccess.Controls.Add(this.cbbLicence);
            this.gbAccess.Location = new System.Drawing.Point(6, 195);
            this.gbAccess.Name = "gbAccess";
            this.gbAccess.Size = new System.Drawing.Size(682, 58);
            this.gbAccess.TabIndex = 14;
            this.gbAccess.TabStop = false;
            this.gbAccess.Text = "Acesso:";
            // 
            // cbAccces
            // 
            this.cbAccces.AutoSize = true;
            this.cbAccces.Location = new System.Drawing.Point(10, 33);
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
            this.tbPassword.Location = new System.Drawing.Point(300, 32);
            this.tbPassword.MaxLength = 49;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(132, 32);
            this.tbUsername.MaxLength = 49;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(162, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(129, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 13);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "*Usuário:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(297, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 49;
            this.lblPassword.Text = "*Senha:";
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(468, 16);
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
            "Acesso 1",
            "Acesso 2",
            "Acesso 3"});
            this.cbbLicence.Location = new System.Drawing.Point(468, 32);
            this.cbbLicence.MaxLength = 2;
            this.cbbLicence.Name = "cbbLicence";
            this.cbbLicence.Size = new System.Drawing.Size(164, 21);
            this.cbbLicence.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "*Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(162, 169);
            this.tbEmail.MaxLength = 99;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(385, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // mtbRg
            // 
            this.mtbRg.Location = new System.Drawing.Point(234, 43);
            this.mtbRg.Mask = "000,000,000-00";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(112, 20);
            this.mtbRg.TabIndex = 2;
            this.mtbRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbRg.Click += new System.EventHandler(this.mtbRg_Click);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(232, 27);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG:";
            // 
            // mtbDtNasc
            // 
            this.mtbDtNasc.Location = new System.Drawing.Point(553, 129);
            this.mtbDtNasc.Mask = "00/00/0000";
            this.mtbDtNasc.Name = "mtbDtNasc";
            this.mtbDtNasc.Size = new System.Drawing.Size(111, 20);
            this.mtbDtNasc.TabIndex = 10;
            this.mtbDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDtNasc.ValidatingType = typeof(System.DateTime);
            this.mtbDtNasc.Click += new System.EventHandler(this.mtbDtNasc_Click);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(37, 168);
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
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "*Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(116, 43);
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
            this.mtbCep.Location = new System.Drawing.Point(352, 129);
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
            this.lblSalario.Location = new System.Drawing.Point(550, 156);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(73, 13);
            this.lblSalario.TabIndex = 29;
            this.lblSalario.Text = "*Salário Base:";
            // 
            // tbBaseSalary
            // 
            this.tbBaseSalary.Location = new System.Drawing.Point(553, 169);
            this.tbBaseSalary.MaxLength = 10;
            this.tbBaseSalary.Name = "tbBaseSalary";
            this.tbBaseSalary.Size = new System.Drawing.Size(111, 20);
            this.tbBaseSalary.TabIndex = 13;
            this.tbBaseSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseSalary_KeyPress);
            this.tbBaseSalary.Leave += new System.EventHandler(this.tbBaseSalary_Leave);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(37, 43);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(73, 20);
            this.tbId.TabIndex = 0;
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
            // cbbSex
            // 
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbbSex.Location = new System.Drawing.Point(352, 89);
            this.cbbSex.MaxLength = 1;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(112, 21);
            this.cbbSex.TabIndex = 5;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(550, 114);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(65, 13);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "*Data Nasc:";
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
            this.cbbUF.Location = new System.Drawing.Point(470, 128);
            this.cbbUF.MaxLength = 2;
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(77, 21);
            this.cbbUF.Sorted = true;
            this.cbbUF.TabIndex = 9;
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
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(37, 129);
            this.tbDistrict.MaxLength = 20;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(309, 20);
            this.tbDistrict.TabIndex = 7;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(470, 87);
            this.tbCity.MaxLength = 29;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(194, 20);
            this.tbCity.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(467, 74);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "*Cidade";
            // 
            // tbAddres
            // 
            this.tbAddres.Location = new System.Drawing.Point(37, 90);
            this.tbAddres.MaxLength = 49;
            this.tbAddres.Name = "tbAddres";
            this.tbAddres.Size = new System.Drawing.Size(309, 20);
            this.tbAddres.TabIndex = 4;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(34, 74);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(60, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "*Endereço:";
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(352, 43);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(312, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(349, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "*Nome:";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(34, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 37);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(190, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(503, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(346, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_employee, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 497);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 242);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            this.dgv_employee.AllowUserToDeleteRows = false;
            this.dgv_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_name,
            this.emp_rg,
            this.emp_cpf,
            this.emp_password,
            this.emp_licence,
            this.emp_id,
            this.emp_zip_code,
            this.emp_addres,
            this.emp_district,
            this.emp_city,
            this.emp_uf,
            this.emp_birth_at,
            this.emp_created_at,
            this.emp_telephone,
            this.emp_sex,
            this.emp_base_salary,
            this.emp_admission,
            this.emp_resignation,
            this.emp_username,
            this.emp_email});
            this.dgv_employee.Location = new System.Drawing.Point(3, 3);
            this.dgv_employee.MultiSelect = false;
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            this.dgv_employee.RowHeadersVisible = false;
            this.dgv_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employee.Size = new System.Drawing.Size(699, 236);
            this.dgv_employee.TabIndex = 4;
            this.dgv_employee.DoubleClick += new System.EventHandler(this.dgv_employee_DoubleClick);
            // 
            // emp_name
            // 
            this.emp_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp_name.DataPropertyName = "emp_name";
            this.emp_name.HeaderText = "Nome";
            this.emp_name.Name = "emp_name";
            this.emp_name.ReadOnly = true;
            // 
            // emp_rg
            // 
            this.emp_rg.DataPropertyName = "emp_rg";
            this.emp_rg.HeaderText = "RG";
            this.emp_rg.Name = "emp_rg";
            this.emp_rg.ReadOnly = true;
            this.emp_rg.Visible = false;
            // 
            // emp_cpf
            // 
            this.emp_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emp_cpf.DataPropertyName = "emp_cpf";
            this.emp_cpf.HeaderText = "CPF";
            this.emp_cpf.MinimumWidth = 200;
            this.emp_cpf.Name = "emp_cpf";
            this.emp_cpf.ReadOnly = true;
            this.emp_cpf.Width = 200;
            // 
            // emp_password
            // 
            this.emp_password.DataPropertyName = "emp_password";
            this.emp_password.HeaderText = "Senha";
            this.emp_password.Name = "emp_password";
            this.emp_password.ReadOnly = true;
            this.emp_password.Visible = false;
            // 
            // emp_licence
            // 
            this.emp_licence.DataPropertyName = "emp_licence";
            this.emp_licence.HeaderText = "Licença";
            this.emp_licence.Name = "emp_licence";
            this.emp_licence.ReadOnly = true;
            this.emp_licence.Visible = false;
            // 
            // emp_id
            // 
            this.emp_id.DataPropertyName = "emp_id";
            this.emp_id.HeaderText = "Código";
            this.emp_id.Name = "emp_id";
            this.emp_id.ReadOnly = true;
            this.emp_id.Visible = false;
            // 
            // emp_zip_code
            // 
            this.emp_zip_code.DataPropertyName = "emp_zip_code";
            this.emp_zip_code.HeaderText = "CEP";
            this.emp_zip_code.Name = "emp_zip_code";
            this.emp_zip_code.ReadOnly = true;
            this.emp_zip_code.Visible = false;
            // 
            // emp_addres
            // 
            this.emp_addres.DataPropertyName = "emp_addres";
            this.emp_addres.HeaderText = "Endereço";
            this.emp_addres.Name = "emp_addres";
            this.emp_addres.ReadOnly = true;
            this.emp_addres.Visible = false;
            // 
            // emp_district
            // 
            this.emp_district.DataPropertyName = "emp_district";
            this.emp_district.HeaderText = "Bairro";
            this.emp_district.Name = "emp_district";
            this.emp_district.ReadOnly = true;
            this.emp_district.Visible = false;
            // 
            // emp_city
            // 
            this.emp_city.DataPropertyName = "emp_city";
            this.emp_city.HeaderText = "Cidade";
            this.emp_city.Name = "emp_city";
            this.emp_city.ReadOnly = true;
            this.emp_city.Visible = false;
            // 
            // emp_uf
            // 
            this.emp_uf.DataPropertyName = "emp_uf";
            this.emp_uf.HeaderText = "Estado";
            this.emp_uf.Name = "emp_uf";
            this.emp_uf.ReadOnly = true;
            this.emp_uf.Visible = false;
            // 
            // emp_birth_at
            // 
            this.emp_birth_at.DataPropertyName = "emp_birth_at";
            this.emp_birth_at.HeaderText = "Nascimento";
            this.emp_birth_at.Name = "emp_birth_at";
            this.emp_birth_at.ReadOnly = true;
            this.emp_birth_at.Visible = false;
            // 
            // emp_created_at
            // 
            this.emp_created_at.DataPropertyName = "emp_created_at";
            this.emp_created_at.HeaderText = "Cadastro";
            this.emp_created_at.Name = "emp_created_at";
            this.emp_created_at.ReadOnly = true;
            this.emp_created_at.Visible = false;
            // 
            // emp_telephone
            // 
            this.emp_telephone.DataPropertyName = "emp_telephone";
            this.emp_telephone.DividerWidth = 2;
            this.emp_telephone.HeaderText = "Telefone";
            this.emp_telephone.Name = "emp_telephone";
            this.emp_telephone.ReadOnly = true;
            this.emp_telephone.Visible = false;
            // 
            // emp_sex
            // 
            this.emp_sex.DataPropertyName = "emp_sex";
            this.emp_sex.HeaderText = "Sexo";
            this.emp_sex.Name = "emp_sex";
            this.emp_sex.ReadOnly = true;
            this.emp_sex.Visible = false;
            // 
            // emp_base_salary
            // 
            this.emp_base_salary.DataPropertyName = "emp_base_salary";
            this.emp_base_salary.HeaderText = "Salario";
            this.emp_base_salary.Name = "emp_base_salary";
            this.emp_base_salary.ReadOnly = true;
            this.emp_base_salary.Visible = false;
            // 
            // emp_admission
            // 
            this.emp_admission.DataPropertyName = "emp_admission";
            this.emp_admission.HeaderText = "Admissao";
            this.emp_admission.MinimumWidth = 100;
            this.emp_admission.Name = "emp_admission";
            this.emp_admission.ReadOnly = true;
            this.emp_admission.Visible = false;
            // 
            // emp_resignation
            // 
            this.emp_resignation.DataPropertyName = "emp_resignation";
            this.emp_resignation.HeaderText = "demissao";
            this.emp_resignation.Name = "emp_resignation";
            this.emp_resignation.ReadOnly = true;
            this.emp_resignation.Visible = false;
            // 
            // emp_username
            // 
            this.emp_username.DataPropertyName = "emp_username";
            this.emp_username.HeaderText = "Usuário";
            this.emp_username.Name = "emp_username";
            this.emp_username.ReadOnly = true;
            // 
            // emp_email
            // 
            this.emp_email.DataPropertyName = "emp_email";
            this.emp_email.HeaderText = "Email";
            this.emp_email.Name = "emp_email";
            this.emp_email.ReadOnly = true;
            this.emp_email.Visible = false;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(27, 11);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(388, 42);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Cadastrar Funcionário";
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 751);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.GbpPesquisa);
            this.Name = "FormCreateEmployee";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.gbAdmission.ResumeLayout(false);
            this.gbAdmission.PerformLayout();
            this.gbAccess.ResumeLayout(false);
            this.gbAccess.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MaskedTextBox mtbDtNasc;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbBaseSalary;
        private System.Windows.Forms.TextBox tbId;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mtbDemissao;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.Label lblDemissao;
        private System.Windows.Forms.MaskedTextBox mtbAdmission;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_zip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_addres;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_birth_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_base_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_admission;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_resignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_email;
    }
}
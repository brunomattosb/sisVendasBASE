namespace sisVendas.Screens.Create
{
    partial class FormCreiarFornecedor
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
            this.tbRg = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.tbDistrict = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbAddres = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbFantasyName = new System.Windows.Forms.TextBox();
            this.lblFantasyName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.dgv_Provider = new System.Windows.Forms.DataGridView();
            this.forn_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_nome_fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_rg_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gerarPdf = new System.Windows.Forms.Button();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(12, 355);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(345, 57);
            this.GbpPesquisa.TabIndex = 7;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(19, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(309, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gbCad
            // 
            this.gbCad.Controls.Add(this.tbRg);
            this.gbCad.Controls.Add(this.tbName);
            this.gbCad.Controls.Add(this.lblName);
            this.gbCad.Controls.Add(this.lblEmail);
            this.gbCad.Controls.Add(this.tbEmail);
            this.gbCad.Controls.Add(this.lblRg);
            this.gbCad.Controls.Add(this.tableLayoutPanel1);
            this.gbCad.Controls.Add(this.mtbTelephone);
            this.gbCad.Controls.Add(this.lblId);
            this.gbCad.Controls.Add(this.lblTelefone);
            this.gbCad.Controls.Add(this.mtbCpf);
            this.gbCad.Controls.Add(this.mtbCep);
            this.gbCad.Controls.Add(this.tbCod);
            this.gbCad.Controls.Add(this.lblEstado);
            this.gbCad.Controls.Add(this.cbbUF);
            this.gbCad.Controls.Add(this.lblDistrict);
            this.gbCad.Controls.Add(this.tbDistrict);
            this.gbCad.Controls.Add(this.tbCity);
            this.gbCad.Controls.Add(this.lblCidade);
            this.gbCad.Controls.Add(this.tbAddres);
            this.gbCad.Controls.Add(this.lblEnd);
            this.gbCad.Controls.Add(this.lblCep);
            this.gbCad.Controls.Add(this.tbFantasyName);
            this.gbCad.Controls.Add(this.lblFantasyName);
            this.gbCad.Controls.Add(this.lblCpf);
            this.gbCad.Location = new System.Drawing.Point(12, 69);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(651, 280);
            this.gbCad.TabIndex = 0;
            this.gbCad.TabStop = false;
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(213, 33);
            this.tbRg.MaxLength = 19;
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(112, 20);
            this.tbRg.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(19, 73);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "*Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(19, 194);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(309, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(213, 17);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(41, 13);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG/IE:";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 33);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(39, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(192, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(498, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(345, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(531, 150);
            this.mtbTelephone.Mask = "(00)00000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelephone.TabIndex = 10;
            this.mtbTelephone.Click += new System.EventHandler(this.mtbTelefone_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblId.Location = new System.Drawing.Point(19, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(531, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "*Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(98, 33);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(112, 20);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.TextChanged += new System.EventHandler(this.mtbCpf_TextChanged);
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(334, 150);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(112, 20);
            this.mtbCep.TabIndex = 8;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(19, 33);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(449, 134);
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
            this.cbbUF.Location = new System.Drawing.Point(449, 149);
            this.cbbUF.MaxLength = 2;
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(77, 21);
            this.cbbUF.Sorted = true;
            this.cbbUF.TabIndex = 9;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(19, 134);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(37, 13);
            this.lblDistrict.TabIndex = 11;
            this.lblDistrict.Text = "Bairro:";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(19, 150);
            this.tbDistrict.MaxLength = 20;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(309, 20);
            this.tbDistrict.TabIndex = 7;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(334, 109);
            this.tbCity.MaxLength = 29;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(297, 20);
            this.tbCity.TabIndex = 6;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(333, 95);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // tbAddres
            // 
            this.tbAddres.Location = new System.Drawing.Point(19, 109);
            this.tbAddres.MaxLength = 49;
            this.tbAddres.Name = "tbAddres";
            this.tbAddres.Size = new System.Drawing.Size(309, 20);
            this.tbAddres.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(19, 95);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(331, 134);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbFantasyName
            // 
            this.tbFantasyName.Location = new System.Drawing.Point(334, 73);
            this.tbFantasyName.MaxLength = 49;
            this.tbFantasyName.Name = "tbFantasyName";
            this.tbFantasyName.Size = new System.Drawing.Size(297, 20);
            this.tbFantasyName.TabIndex = 4;
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Location = new System.Drawing.Point(334, 57);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(81, 13);
            this.lblFantasyName.TabIndex = 1;
            this.lblFantasyName.Text = "Nome Fantasia:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(98, 17);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(66, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "*CPF/CNPJ:";
            // 
            // dgv_Provider
            // 
            this.dgv_Provider.AllowUserToAddRows = false;
            this.dgv_Provider.AllowUserToDeleteRows = false;
            this.dgv_Provider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Provider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forn_nome,
            this.forn_nome_fantasia,
            this.forn_email,
            this.forn_id,
            this.forn_cep,
            this.forn_endereco,
            this.forn_bairro,
            this.forn_cidade,
            this.forn_uf,
            this.prov_created_at,
            this.forn_telefone,
            this.forn_cpf_cnpj,
            this.forn_rg_ie});
            this.dgv_Provider.Location = new System.Drawing.Point(12, 417);
            this.dgv_Provider.MultiSelect = false;
            this.dgv_Provider.Name = "dgv_Provider";
            this.dgv_Provider.ReadOnly = true;
            this.dgv_Provider.RowHeadersVisible = false;
            this.dgv_Provider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Provider.Size = new System.Drawing.Size(651, 166);
            this.dgv_Provider.TabIndex = 0;
            this.dgv_Provider.DoubleClick += new System.EventHandler(this.dgv_Provider_DoubleClick);
            // 
            // forn_nome
            // 
            this.forn_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.forn_nome.DataPropertyName = "forn_nome";
            this.forn_nome.HeaderText = "Nome";
            this.forn_nome.Name = "forn_nome";
            this.forn_nome.ReadOnly = true;
            // 
            // forn_nome_fantasia
            // 
            this.forn_nome_fantasia.DataPropertyName = "forn_nome_fantasia";
            this.forn_nome_fantasia.HeaderText = "Fantazy Name";
            this.forn_nome_fantasia.Name = "forn_nome_fantasia";
            this.forn_nome_fantasia.ReadOnly = true;
            this.forn_nome_fantasia.Visible = false;
            // 
            // forn_email
            // 
            this.forn_email.DataPropertyName = "forn_email";
            this.forn_email.HeaderText = "Email";
            this.forn_email.Name = "forn_email";
            this.forn_email.ReadOnly = true;
            this.forn_email.Visible = false;
            // 
            // forn_id
            // 
            this.forn_id.DataPropertyName = "forn_id";
            this.forn_id.HeaderText = "Código";
            this.forn_id.Name = "forn_id";
            this.forn_id.ReadOnly = true;
            this.forn_id.Visible = false;
            // 
            // forn_cep
            // 
            this.forn_cep.DataPropertyName = "forn_cep";
            this.forn_cep.HeaderText = "CEP";
            this.forn_cep.Name = "forn_cep";
            this.forn_cep.ReadOnly = true;
            this.forn_cep.Visible = false;
            // 
            // forn_endereco
            // 
            this.forn_endereco.DataPropertyName = "forn_endereco";
            this.forn_endereco.HeaderText = "Endereço";
            this.forn_endereco.Name = "forn_endereco";
            this.forn_endereco.ReadOnly = true;
            this.forn_endereco.Visible = false;
            // 
            // forn_bairro
            // 
            this.forn_bairro.DataPropertyName = "forn_bairro";
            this.forn_bairro.HeaderText = "Bairro";
            this.forn_bairro.Name = "forn_bairro";
            this.forn_bairro.ReadOnly = true;
            this.forn_bairro.Visible = false;
            // 
            // forn_cidade
            // 
            this.forn_cidade.DataPropertyName = "forn_cidade";
            this.forn_cidade.HeaderText = "Cidade";
            this.forn_cidade.Name = "forn_cidade";
            this.forn_cidade.ReadOnly = true;
            this.forn_cidade.Visible = false;
            // 
            // forn_uf
            // 
            this.forn_uf.DataPropertyName = "forn_uf";
            this.forn_uf.HeaderText = "Estado";
            this.forn_uf.Name = "forn_uf";
            this.forn_uf.ReadOnly = true;
            this.forn_uf.Visible = false;
            // 
            // prov_created_at
            // 
            this.prov_created_at.DataPropertyName = "forn_criado_em";
            this.prov_created_at.HeaderText = "Cadastro";
            this.prov_created_at.Name = "prov_created_at";
            this.prov_created_at.ReadOnly = true;
            this.prov_created_at.Visible = false;
            // 
            // forn_telefone
            // 
            this.forn_telefone.DataPropertyName = "forn_telefone";
            this.forn_telefone.DividerWidth = 2;
            this.forn_telefone.HeaderText = "Telefone";
            this.forn_telefone.Name = "forn_telefone";
            this.forn_telefone.ReadOnly = true;
            this.forn_telefone.Visible = false;
            // 
            // forn_cpf_cnpj
            // 
            this.forn_cpf_cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.forn_cpf_cnpj.DataPropertyName = "forn_cpf_cnpj";
            this.forn_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.forn_cpf_cnpj.MinimumWidth = 200;
            this.forn_cpf_cnpj.Name = "forn_cpf_cnpj";
            this.forn_cpf_cnpj.ReadOnly = true;
            this.forn_cpf_cnpj.Width = 200;
            // 
            // forn_rg_ie
            // 
            this.forn_rg_ie.DataPropertyName = "forn_rg_ie";
            this.forn_rg_ie.HeaderText = "RG";
            this.forn_rg_ie.Name = "forn_rg_ie";
            this.forn_rg_ie.ReadOnly = true;
            this.forn_rg_ie.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblFornecedor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 63);
            this.panel1.TabIndex = 10;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(135, 9);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(384, 42);
            this.lblFornecedor.TabIndex = 5;
            this.lblFornecedor.Text = "Cadastrar Fornecedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gerarPdf);
            this.groupBox2.Location = new System.Drawing.Point(364, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 57);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório:";
            // 
            // gerarPdf
            // 
            this.gerarPdf.Location = new System.Drawing.Point(17, 20);
            this.gerarPdf.Name = "gerarPdf";
            this.gerarPdf.Size = new System.Drawing.Size(75, 23);
            this.gerarPdf.TabIndex = 12;
            this.gerarPdf.Text = "Gerar PDF";
            this.gerarPdf.UseVisualStyleBackColor = true;
            this.gerarPdf.Click += new System.EventHandler(this.gerarPdf_Click);
            // 
            // FormCreiarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_Provider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.gbCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(691, 634);
            this.MinimumSize = new System.Drawing.Size(691, 634);
            this.Name = "FormCreiarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox tbDistrict;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbAddres;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbFantasyName;
        private System.Windows.Forms.Label lblFantasyName;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DataGridView dgv_Provider;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_nome_fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_rg_ie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button gerarPdf;
    }
}
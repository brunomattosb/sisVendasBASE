namespace sisVendas.Screens.Create
{
    partial class FormCreateProvider
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
            this.lblFornecedor = new System.Windows.Forms.Label();
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
            this.tbId = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Provider = new System.Windows.Forms.DataGridView();
            this.prov_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_fantazy_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_zip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_rg_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbpPesquisa.SuspendLayout();
            this.gbCad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(30, 18);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(384, 42);
            this.lblFornecedor.TabIndex = 5;
            this.lblFornecedor.Text = "Cadastrar Fornecedor";
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(37, 354);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(345, 57);
            this.GbpPesquisa.TabIndex = 7;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(9, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // gbCad
            // 
            this.gbCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.gbCad.Controls.Add(this.tbId);
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
            this.gbCad.Location = new System.Drawing.Point(36, 69);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(694, 280);
            this.gbCad.TabIndex = 6;
            this.gbCad.TabStop = false;
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(234, 33);
            this.tbRg.MaxLength = 19;
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(112, 20);
            this.tbRg.TabIndex = 42;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(37, 73);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "*Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(37, 194);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(309, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(231, 17);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 43);
            this.tableLayoutPanel1.TabIndex = 14;
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
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(552, 150);
            this.mtbTelephone.Mask = "(00)00000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(112, 20);
            this.mtbTelephone.TabIndex = 12;
            this.mtbTelephone.Click += new System.EventHandler(this.mtbTelefone_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblId.Location = new System.Drawing.Point(34, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Código:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(549, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(59, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "*Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(116, 33);
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
            this.mtbCep.Location = new System.Drawing.Point(352, 151);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(112, 20);
            this.mtbCep.TabIndex = 9;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(37, 33);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(73, 20);
            this.tbId.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(467, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(28, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "*UF:";
            // 
            // cbbUF
            // 
            this.cbbUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.cbbUF.Location = new System.Drawing.Point(470, 150);
            this.cbbUF.MaxLength = 2;
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(77, 21);
            this.cbbUF.Sorted = true;
            this.cbbUF.TabIndex = 10;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(34, 135);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(37, 13);
            this.lblDistrict.TabIndex = 11;
            this.lblDistrict.Text = "Bairro:";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(37, 151);
            this.tbDistrict.MaxLength = 20;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(309, 20);
            this.tbDistrict.TabIndex = 8;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(354, 109);
            this.tbCity.MaxLength = 29;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(310, 20);
            this.tbCity.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(351, 96);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Cidade";
            // 
            // tbAddres
            // 
            this.tbAddres.Location = new System.Drawing.Point(37, 112);
            this.tbAddres.MaxLength = 49;
            this.tbAddres.Name = "tbAddres";
            this.tbAddres.Size = new System.Drawing.Size(309, 20);
            this.tbAddres.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(34, 96);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(349, 135);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbFantasyName
            // 
            this.tbFantasyName.Location = new System.Drawing.Point(352, 73);
            this.tbFantasyName.MaxLength = 49;
            this.tbFantasyName.Name = "tbFantasyName";
            this.tbFantasyName.Size = new System.Drawing.Size(312, 20);
            this.tbFantasyName.TabIndex = 4;
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Location = new System.Drawing.Point(351, 58);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(81, 13);
            this.lblFantasyName.TabIndex = 1;
            this.lblFantasyName.Text = "Nome Fantasia:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(116, 19);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(66, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "*CPF/CNPJ:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_Provider, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 421);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 222);
            this.tableLayoutPanel2.TabIndex = 9;
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
            this.prov_name,
            this.prov_fantazy_name,
            this.prov_email,
            this.prov_id,
            this.prov_zip_code,
            this.prov_addres,
            this.prov_district,
            this.prov_city,
            this.prov_uf,
            this.prov_created_at,
            this.prov_telephone,
            this.prov_cpf_cnpj,
            this.prov_rg_ie});
            this.dgv_Provider.Location = new System.Drawing.Point(3, 3);
            this.dgv_Provider.MultiSelect = false;
            this.dgv_Provider.Name = "dgv_Provider";
            this.dgv_Provider.ReadOnly = true;
            this.dgv_Provider.RowHeadersVisible = false;
            this.dgv_Provider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Provider.Size = new System.Drawing.Size(699, 216);
            this.dgv_Provider.TabIndex = 0;
            this.dgv_Provider.DoubleClick += new System.EventHandler(this.dgv_Provider_DoubleClick);
            // 
            // prov_name
            // 
            this.prov_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prov_name.DataPropertyName = "prov_name";
            this.prov_name.HeaderText = "Nome";
            this.prov_name.Name = "prov_name";
            this.prov_name.ReadOnly = true;
            // 
            // prov_fantazy_name
            // 
            this.prov_fantazy_name.DataPropertyName = "prov_fantazy_name";
            this.prov_fantazy_name.HeaderText = "Fantazy Name";
            this.prov_fantazy_name.Name = "prov_fantazy_name";
            this.prov_fantazy_name.ReadOnly = true;
            this.prov_fantazy_name.Visible = false;
            // 
            // prov_email
            // 
            this.prov_email.DataPropertyName = "prov_email";
            this.prov_email.HeaderText = "Email";
            this.prov_email.Name = "prov_email";
            this.prov_email.ReadOnly = true;
            this.prov_email.Visible = false;
            // 
            // prov_id
            // 
            this.prov_id.DataPropertyName = "prov_id";
            this.prov_id.HeaderText = "Código";
            this.prov_id.Name = "prov_id";
            this.prov_id.ReadOnly = true;
            this.prov_id.Visible = false;
            // 
            // prov_zip_code
            // 
            this.prov_zip_code.DataPropertyName = "prov_zip_code";
            this.prov_zip_code.HeaderText = "CEP";
            this.prov_zip_code.Name = "prov_zip_code";
            this.prov_zip_code.ReadOnly = true;
            this.prov_zip_code.Visible = false;
            // 
            // prov_addres
            // 
            this.prov_addres.DataPropertyName = "prov_addres";
            this.prov_addres.HeaderText = "Endereço";
            this.prov_addres.Name = "prov_addres";
            this.prov_addres.ReadOnly = true;
            this.prov_addres.Visible = false;
            // 
            // prov_district
            // 
            this.prov_district.DataPropertyName = "prov_district";
            this.prov_district.HeaderText = "Bairro";
            this.prov_district.Name = "prov_district";
            this.prov_district.ReadOnly = true;
            this.prov_district.Visible = false;
            // 
            // prov_city
            // 
            this.prov_city.DataPropertyName = "prov_city";
            this.prov_city.HeaderText = "Cidade";
            this.prov_city.Name = "prov_city";
            this.prov_city.ReadOnly = true;
            this.prov_city.Visible = false;
            // 
            // prov_uf
            // 
            this.prov_uf.DataPropertyName = "prov_uf";
            this.prov_uf.HeaderText = "Estado";
            this.prov_uf.Name = "prov_uf";
            this.prov_uf.ReadOnly = true;
            this.prov_uf.Visible = false;
            // 
            // prov_created_at
            // 
            this.prov_created_at.DataPropertyName = "prov_created_at";
            this.prov_created_at.HeaderText = "Cadastro";
            this.prov_created_at.Name = "prov_created_at";
            this.prov_created_at.ReadOnly = true;
            this.prov_created_at.Visible = false;
            // 
            // prov_telephone
            // 
            this.prov_telephone.DataPropertyName = "prov_telephone";
            this.prov_telephone.DividerWidth = 2;
            this.prov_telephone.HeaderText = "Telefone";
            this.prov_telephone.Name = "prov_telephone";
            this.prov_telephone.ReadOnly = true;
            this.prov_telephone.Visible = false;
            // 
            // prov_cpf_cnpj
            // 
            this.prov_cpf_cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.prov_cpf_cnpj.DataPropertyName = "prov_cpf_cnpj";
            this.prov_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.prov_cpf_cnpj.MinimumWidth = 200;
            this.prov_cpf_cnpj.Name = "prov_cpf_cnpj";
            this.prov_cpf_cnpj.ReadOnly = true;
            this.prov_cpf_cnpj.Width = 200;
            // 
            // prov_rg_ie
            // 
            this.prov_rg_ie.DataPropertyName = "prov_rg_ie";
            this.prov_rg_ie.HeaderText = "RG";
            this.prov_rg_ie.Name = "prov_rg_ie";
            this.prov_rg_ie.ReadOnly = true;
            this.prov_rg_ie.Visible = false;
            // 
            // FormCreateProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormCreateProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateProvider";
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFornecedor;
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
        private System.Windows.Forms.TextBox tbId;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_fantazy_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_zip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_addres;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_rg_ie;
        private System.Windows.Forms.TextBox tbRg;
    }
}
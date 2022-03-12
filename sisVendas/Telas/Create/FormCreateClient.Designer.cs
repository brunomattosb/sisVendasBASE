namespace sisVendas.Screens.Create
{
    partial class FormCreateClient
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
            this.gbCod = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbRgIe = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mtbDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblBairro = new System.Windows.Forms.Label();
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
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.cli_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg_ie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_fantasy_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_zip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_birth_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCod.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.GbpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCod
            // 
            this.gbCod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCod.Controls.Add(this.lblSaldo);
            this.gbCod.Controls.Add(this.tbSaldo);
            this.gbCod.Controls.Add(this.tbName);
            this.gbCod.Controls.Add(this.label1);
            this.gbCod.Controls.Add(this.lblEmail);
            this.gbCod.Controls.Add(this.tbEmail);
            this.gbCod.Controls.Add(this.mtbRgIe);
            this.gbCod.Controls.Add(this.lblRg);
            this.gbCod.Controls.Add(this.tableLayoutPanel1);
            this.gbCod.Controls.Add(this.mtbDtNasc);
            this.gbCod.Controls.Add(this.mtbTelephone);
            this.gbCod.Controls.Add(this.lblCod);
            this.gbCod.Controls.Add(this.lblTelefone);
            this.gbCod.Controls.Add(this.mtbCpf);
            this.gbCod.Controls.Add(this.mtbCep);
            this.gbCod.Controls.Add(this.tbCod);
            this.gbCod.Controls.Add(this.lblSexo);
            this.gbCod.Controls.Add(this.cbbSex);
            this.gbCod.Controls.Add(this.lblNascimento);
            this.gbCod.Controls.Add(this.lblEstado);
            this.gbCod.Controls.Add(this.cbbEstado);
            this.gbCod.Controls.Add(this.lblBairro);
            this.gbCod.Controls.Add(this.tbDistrict);
            this.gbCod.Controls.Add(this.tbCity);
            this.gbCod.Controls.Add(this.lblCidade);
            this.gbCod.Controls.Add(this.tbAddres);
            this.gbCod.Controls.Add(this.lblEnd);
            this.gbCod.Controls.Add(this.lblCep);
            this.gbCod.Controls.Add(this.tbFantasyName);
            this.gbCod.Controls.Add(this.lblFantasyName);
            this.gbCod.Controls.Add(this.lblCpf);
            this.gbCod.Location = new System.Drawing.Point(39, 72);
            this.gbCod.Name = "gbCod";
            this.gbCod.Size = new System.Drawing.Size(694, 280);
            this.gbCod.TabIndex = 1;
            this.gbCod.TabStop = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(550, 181);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 43;
            this.lblSaldo.Text = "Saldo:";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(553, 194);
            this.tbSaldo.MaxLength = 10;
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(111, 20);
            this.tbSaldo.TabIndex = 42;
            this.tbSaldo.Text = "0,00";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(37, 73);
            this.tbName.MaxLength = 49;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(162, 194);
            this.tbEmail.MaxLength = 99;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(302, 20);
            this.tbEmail.TabIndex = 13;
            // 
            // mtbRgIe
            // 
            this.mtbRgIe.Location = new System.Drawing.Point(234, 33);
            this.mtbRgIe.Mask = "000,000,000-00";
            this.mtbRgIe.Name = "mtbRgIe";
            this.mtbRgIe.Size = new System.Drawing.Size(112, 20);
            this.mtbRgIe.TabIndex = 2;
            this.mtbRgIe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbRgIe.Click += new System.EventHandler(this.mtbRgIe_Click);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(231, 17);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(346, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // mtbDtNasc
            // 
            this.mtbDtNasc.Location = new System.Drawing.Point(553, 150);
            this.mtbDtNasc.Mask = "00/00/0000";
            this.mtbDtNasc.Name = "mtbDtNasc";
            this.mtbDtNasc.Size = new System.Drawing.Size(111, 20);
            this.mtbDtNasc.TabIndex = 11;
            this.mtbDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDtNasc.ValidatingType = typeof(System.DateTime);
            this.mtbDtNasc.Click += new System.EventHandler(this.mtbDtNasc_Click);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(37, 194);
            this.mtbTelephone.Mask = "(00)00000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(112, 20);
            this.mtbTelephone.TabIndex = 12;
            this.mtbTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTelephone.Click += new System.EventHandler(this.mtbTelephone_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(34, 17);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(35, 178);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(116, 33);
            this.mtbCpf.Mask = "999.999.999-99";
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
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(37, 33);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(351, 96);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 26;
            this.lblSexo.Text = "Sexo:";
            // 
            // cbbSex
            // 
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbbSex.Location = new System.Drawing.Point(352, 111);
            this.cbbSex.MaxLength = 1;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(112, 21);
            this.cbbSex.TabIndex = 6;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(550, 135);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(61, 13);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "Data Nasc:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(469, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(24, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "UF:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
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
            this.cbbEstado.Location = new System.Drawing.Point(470, 150);
            this.cbbEstado.MaxLength = 2;
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(77, 21);
            this.cbbEstado.Sorted = true;
            this.cbbEstado.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(34, 135);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(37, 151);
            this.tbDistrict.MaxLength = 49;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(309, 20);
            this.tbDistrict.TabIndex = 8;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(470, 109);
            this.tbCity.MaxLength = 29;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(194, 20);
            this.tbCity.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(467, 96);
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
            this.tbFantasyName.Enabled = false;
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
            this.lblCpf.Location = new System.Drawing.Point(114, 19);
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
            this.tableLayoutPanel2.Controls.Add(this.dgv_client, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 424);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 222);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_name,
            this.cli_rg_ie,
            this.cli_email,
            this.cli_fantasy_name,
            this.cli_id,
            this.cli_zip_code,
            this.cli_addres,
            this.cli_district,
            this.cli_city,
            this.cli_uf,
            this.cli_birth_at,
            this.cli_telephone,
            this.cli_cpf_cnpj,
            this.cli_sex,
            this.cli_balance,
            this.cli_created_at});
            this.dgv_client.Location = new System.Drawing.Point(3, 3);
            this.dgv_client.MultiSelect = false;
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(699, 216);
            this.dgv_client.TabIndex = 0;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // cli_name
            // 
            this.cli_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_name.DataPropertyName = "cli_name";
            this.cli_name.HeaderText = "Nome";
            this.cli_name.MinimumWidth = 320;
            this.cli_name.Name = "cli_name";
            this.cli_name.ReadOnly = true;
            this.cli_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cli_rg_ie
            // 
            this.cli_rg_ie.DataPropertyName = "cli_rg_ie";
            this.cli_rg_ie.HeaderText = "RG/IE";
            this.cli_rg_ie.Name = "cli_rg_ie";
            this.cli_rg_ie.ReadOnly = true;
            this.cli_rg_ie.Visible = false;
            // 
            // cli_email
            // 
            this.cli_email.DataPropertyName = "cli_email";
            this.cli_email.HeaderText = "Email";
            this.cli_email.Name = "cli_email";
            this.cli_email.ReadOnly = true;
            this.cli_email.Visible = false;
            // 
            // cli_fantasy_name
            // 
            this.cli_fantasy_name.DataPropertyName = "cli_fantasy_name";
            this.cli_fantasy_name.HeaderText = "Nome Fantasia";
            this.cli_fantasy_name.Name = "cli_fantasy_name";
            this.cli_fantasy_name.ReadOnly = true;
            this.cli_fantasy_name.Visible = false;
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // cli_zip_code
            // 
            this.cli_zip_code.DataPropertyName = "cli_zip_code";
            this.cli_zip_code.HeaderText = "CEP";
            this.cli_zip_code.Name = "cli_zip_code";
            this.cli_zip_code.ReadOnly = true;
            this.cli_zip_code.Visible = false;
            // 
            // cli_addres
            // 
            this.cli_addres.DataPropertyName = "cli_addres";
            this.cli_addres.HeaderText = "Endereço";
            this.cli_addres.Name = "cli_addres";
            this.cli_addres.ReadOnly = true;
            this.cli_addres.Visible = false;
            // 
            // cli_district
            // 
            this.cli_district.DataPropertyName = "cli_district";
            this.cli_district.HeaderText = "Bairro";
            this.cli_district.Name = "cli_district";
            this.cli_district.ReadOnly = true;
            this.cli_district.Visible = false;
            // 
            // cli_city
            // 
            this.cli_city.DataPropertyName = "cli_city";
            this.cli_city.HeaderText = "Cidade";
            this.cli_city.Name = "cli_city";
            this.cli_city.ReadOnly = true;
            this.cli_city.Visible = false;
            // 
            // cli_uf
            // 
            this.cli_uf.DataPropertyName = "cli_uf";
            this.cli_uf.HeaderText = "Estado";
            this.cli_uf.Name = "cli_uf";
            this.cli_uf.ReadOnly = true;
            this.cli_uf.Visible = false;
            // 
            // cli_birth_at
            // 
            this.cli_birth_at.DataPropertyName = "cli_birth_at";
            this.cli_birth_at.HeaderText = "Nascimento";
            this.cli_birth_at.Name = "cli_birth_at";
            this.cli_birth_at.ReadOnly = true;
            this.cli_birth_at.Visible = false;
            // 
            // cli_telephone
            // 
            this.cli_telephone.DataPropertyName = "cli_telephone";
            this.cli_telephone.DividerWidth = 2;
            this.cli_telephone.HeaderText = "Telefone";
            this.cli_telephone.Name = "cli_telephone";
            this.cli_telephone.ReadOnly = true;
            this.cli_telephone.Visible = false;
            // 
            // cli_cpf_cnpj
            // 
            this.cli_cpf_cnpj.DataPropertyName = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.HeaderText = "CPF/CNPJ";
            this.cli_cpf_cnpj.MinimumWidth = 200;
            this.cli_cpf_cnpj.Name = "cli_cpf_cnpj";
            this.cli_cpf_cnpj.ReadOnly = true;
            this.cli_cpf_cnpj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_cpf_cnpj.Width = 200;
            // 
            // cli_sex
            // 
            this.cli_sex.DataPropertyName = "cli_sex";
            this.cli_sex.HeaderText = "Sexo";
            this.cli_sex.Name = "cli_sex";
            this.cli_sex.ReadOnly = true;
            this.cli_sex.Visible = false;
            // 
            // cli_balance
            // 
            this.cli_balance.DataPropertyName = "cli_balance";
            this.cli_balance.HeaderText = "Saldo";
            this.cli_balance.MinimumWidth = 75;
            this.cli_balance.Name = "cli_balance";
            this.cli_balance.ReadOnly = true;
            this.cli_balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_balance.Width = 75;
            // 
            // cli_created_at
            // 
            this.cli_created_at.DataPropertyName = "cli_created_at";
            this.cli_created_at.HeaderText = "Cadastro";
            this.cli_created_at.MinimumWidth = 100;
            this.cli_created_at.Name = "cli_created_at";
            this.cli_created_at.ReadOnly = true;
            this.cli_created_at.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(33, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(308, 42);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cadastrar Cliente";
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(40, 359);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(360, 57);
            this.GbpPesquisa.TabIndex = 6;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(20, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // FormCreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 661);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.gbCod);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormCreateClient";
            this.Text = "FormCreateClient";
            this.gbCod.ResumeLayout(false);
            this.gbCod.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCod;
        private System.Windows.Forms.MaskedTextBox mtbRgIe;
        private System.Windows.Forms.Label lblRg;
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
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblBairro;
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
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg_ie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_fantasy_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_zip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_addres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_birth_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_created_at;
    }
}
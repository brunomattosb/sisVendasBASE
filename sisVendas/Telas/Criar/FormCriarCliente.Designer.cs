namespace sisVendas.Screens.Create
{
    partial class FormCriarCliente
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbpPesquisa = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gerarPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbMunicipio = new System.Windows.Forms.ComboBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.tbAddres = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbDistrict = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.gbCod = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDtNascimento = new System.Windows.Forms.CheckBox();
            this.dtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.tbFantasyName = new System.Windows.Forms.TextBox();
            this.lblFantasyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.GbpPesquisa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCod.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(521, 58);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 46;
            this.lblSaldo.Text = "Saldo:";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(32, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 24);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "[F1] - Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(605, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "[F12] - Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(223, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "[F2] - Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(414, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "[F4] - Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_id,
            this.cli_nome,
            this.cli_cpf_cnpj,
            this.cli_telefone,
            this.cli_saldo});
            this.dgv_client.Location = new System.Drawing.Point(12, 285);
            this.dgv_client.MultiSelect = false;
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(765, 159);
            this.dgv_client.TabIndex = 17;
            this.dgv_client.DoubleClick += new System.EventHandler(this.dgv_client_DoubleClick);
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "cli_id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Nome";
            this.cli_nome.MinimumWidth = 320;
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // cli_telefone
            // 
            this.cli_telefone.DataPropertyName = "cli_telefone";
            this.cli_telefone.DividerWidth = 2;
            this.cli_telefone.HeaderText = "Telefone";
            this.cli_telefone.MinimumWidth = 120;
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.ReadOnly = true;
            this.cli_telefone.Width = 120;
            // 
            // cli_saldo
            // 
            this.cli_saldo.DataPropertyName = "cli_saldo";
            this.cli_saldo.HeaderText = "Saldo";
            this.cli_saldo.MinimumWidth = 75;
            this.cli_saldo.Name = "cli_saldo";
            this.cli_saldo.ReadOnly = true;
            this.cli_saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cli_saldo.Width = 75;
            // 
            // GbpPesquisa
            // 
            this.GbpPesquisa.Controls.Add(this.tbSearch);
            this.GbpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbpPesquisa.Location = new System.Drawing.Point(12, 222);
            this.GbpPesquisa.Name = "GbpPesquisa";
            this.GbpPesquisa.Size = new System.Drawing.Size(345, 57);
            this.GbpPesquisa.TabIndex = 18;
            this.GbpPesquisa.TabStop = false;
            this.GbpPesquisa.Text = "Pesquisar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(9, 23);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // gerarPdf
            // 
            this.gerarPdf.Location = new System.Drawing.Point(27, 20);
            this.gerarPdf.Name = "gerarPdf";
            this.gerarPdf.Size = new System.Drawing.Size(75, 23);
            this.gerarPdf.TabIndex = 12;
            this.gerarPdf.Text = "Gerar PDF";
            this.gerarPdf.UseVisualStyleBackColor = true;
            this.gerarPdf.Click += new System.EventHandler(this.gerarPdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gerarPdf);
            this.groupBox2.Location = new System.Drawing.Point(647, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 57);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(6, 75);
            this.tbComplemento.MaxLength = 50;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(300, 20);
            this.tbComplemento.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Complemento:";
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
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 450);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 43);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Location = new System.Drawing.Point(521, 73);
            this.tbSaldo.MaxLength = 10;
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(108, 20);
            this.tbSaldo.TabIndex = 45;
            this.tbSaldo.Text = "0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbMunicipio);
            this.groupBox3.Controls.Add(this.tbComplemento);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbNumero);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.mtbTelephone);
            this.groupBox3.Controls.Add(this.lblEnd);
            this.groupBox3.Controls.Add(this.tbAddres);
            this.groupBox3.Controls.Add(this.lblCidade);
            this.groupBox3.Controls.Add(this.lblTelefone);
            this.groupBox3.Controls.Add(this.lblEstado);
            this.groupBox3.Controls.Add(this.lblCep);
            this.groupBox3.Controls.Add(this.tbDistrict);
            this.groupBox3.Controls.Add(this.lblBairro);
            this.groupBox3.Controls.Add(this.cbbEstado);
            this.groupBox3.Controls.Add(this.mtbCep);
            this.groupBox3.Location = new System.Drawing.Point(6, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 109);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMunicipio.FormattingEnabled = true;
            this.cbbMunicipio.Location = new System.Drawing.Point(386, 74);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.Size = new System.Drawing.Size(237, 21);
            this.cbbMunicipio.TabIndex = 40;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(312, 32);
            this.tbNumero.MaxLength = 5;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(68, 20);
            this.tbNumero.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Numero";
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(629, 75);
            this.mtbTelephone.Mask = "(00)00000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(116, 20);
            this.mtbTelephone.TabIndex = 11;
            this.mtbTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbTelephone.Click += new System.EventHandler(this.mtbTelephone_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(6, 16);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(64, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Logradouro:";
            // 
            // tbAddres
            // 
            this.tbAddres.Location = new System.Drawing.Point(6, 32);
            this.tbAddres.MaxLength = 49;
            this.tbAddres.Name = "tbAddres";
            this.tbAddres.Size = new System.Drawing.Size(300, 20);
            this.tbAddres.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(383, 59);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 13);
            this.lblCidade.TabIndex = 15;
            this.lblCidade.Text = "Município:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(626, 59);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(312, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(24, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "UF:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(386, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbDistrict
            // 
            this.tbDistrict.Location = new System.Drawing.Point(475, 32);
            this.tbDistrict.MaxLength = 49;
            this.tbDistrict.Name = "tbDistrict";
            this.tbDistrict.Size = new System.Drawing.Size(271, 20);
            this.tbDistrict.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(475, 16);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            // 
            // cbbEstado
            // 
            this.cbbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(312, 74);
            this.cbbEstado.MaxLength = 2;
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(68, 21);
            this.cbbEstado.Sorted = true;
            this.cbbEstado.TabIndex = 9;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(386, 32);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(83, 20);
            this.mtbCep.TabIndex = 6;
            this.mtbCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(85, 18);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "*CPF:";
            // 
            // gbCod
            // 
            this.gbCod.Controls.Add(this.lblSaldo);
            this.gbCod.Controls.Add(this.tbSaldo);
            this.gbCod.Controls.Add(this.groupBox3);
            this.gbCod.Controls.Add(this.groupBox1);
            this.gbCod.Controls.Add(this.tbRg);
            this.gbCod.Controls.Add(this.tbName);
            this.gbCod.Controls.Add(this.label1);
            this.gbCod.Controls.Add(this.lblEmail);
            this.gbCod.Controls.Add(this.tbEmail);
            this.gbCod.Controls.Add(this.lblRg);
            this.gbCod.Controls.Add(this.lblCod);
            this.gbCod.Controls.Add(this.mtbCpf);
            this.gbCod.Controls.Add(this.tbCod);
            this.gbCod.Controls.Add(this.lblSexo);
            this.gbCod.Controls.Add(this.cbbSex);
            this.gbCod.Controls.Add(this.tbFantasyName);
            this.gbCod.Controls.Add(this.lblFantasyName);
            this.gbCod.Controls.Add(this.lblCpf);
            this.gbCod.Location = new System.Drawing.Point(12, 8);
            this.gbCod.Name = "gbCod";
            this.gbCod.Size = new System.Drawing.Size(765, 214);
            this.gbCod.TabIndex = 16;
            this.gbCod.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDtNascimento);
            this.groupBox1.Controls.Add(this.dtpDtNascimento);
            this.groupBox1.Location = new System.Drawing.Point(635, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 74);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de Nascimento";
            // 
            // cbDtNascimento
            // 
            this.cbDtNascimento.AutoSize = true;
            this.cbDtNascimento.Location = new System.Drawing.Point(12, 23);
            this.cbDtNascimento.Name = "cbDtNascimento";
            this.cbDtNascimento.Size = new System.Drawing.Size(90, 17);
            this.cbDtNascimento.TabIndex = 0;
            this.cbDtNascimento.Text = "Informar Data";
            this.cbDtNascimento.UseVisualStyleBackColor = true;
            this.cbDtNascimento.CheckedChanged += new System.EventHandler(this.cbDtNascimento_CheckedChanged);
            // 
            // dtpDtNascimento
            // 
            this.dtpDtNascimento.Enabled = false;
            this.dtpDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascimento.Location = new System.Drawing.Point(6, 44);
            this.dtpDtNascimento.Name = "dtpDtNascimento";
            this.dtpDtNascimento.Size = new System.Drawing.Size(111, 20);
            this.dtpDtNascimento.TabIndex = 1;
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(203, 33);
            this.tbRg.MaxLength = 19;
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(112, 20);
            this.tbRg.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(321, 34);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(308, 20);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(203, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(203, 73);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(203, 18);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 36;
            this.lblRg.Text = "RG:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCod.Location = new System.Drawing.Point(6, 18);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(85, 33);
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
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(6, 33);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(73, 20);
            this.tbCod.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(453, 58);
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
            this.cbbSex.Location = new System.Drawing.Point(453, 72);
            this.cbbSex.MaxLength = 1;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(58, 21);
            this.cbbSex.TabIndex = 5;
            // 
            // tbFantasyName
            // 
            this.tbFantasyName.Enabled = false;
            this.tbFantasyName.Location = new System.Drawing.Point(6, 73);
            this.tbFantasyName.MaxLength = 49;
            this.tbFantasyName.Name = "tbFantasyName";
            this.tbFantasyName.Size = new System.Drawing.Size(191, 20);
            this.tbFantasyName.TabIndex = 3;
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Location = new System.Drawing.Point(6, 58);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(81, 13);
            this.lblFantasyName.TabIndex = 1;
            this.lblFantasyName.Text = "Nome Fantasia:";
            // 
            // FormCriarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 499);
            this.Controls.Add(this.dgv_client);
            this.Controls.Add(this.GbpPesquisa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCriarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automações Brasil - Cadastrar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.GbpPesquisa.ResumeLayout(false);
            this.GbpPesquisa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbCod.ResumeLayout(false);
            this.gbCod.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.GroupBox GbpPesquisa;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button gerarPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox tbAddres;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbDistrict;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.GroupBox gbCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDtNascimento;
        private System.Windows.Forms.DateTimePicker dtpDtNascimento;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.TextBox tbFantasyName;
        private System.Windows.Forms.Label lblFantasyName;
        private System.Windows.Forms.ComboBox cbbMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_saldo;
    }
}
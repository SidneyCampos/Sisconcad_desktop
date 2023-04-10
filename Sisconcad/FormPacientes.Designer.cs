namespace Sisconcad
{
    partial class FormPacientes
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
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelPacientePrincipal = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.comboBoxRegistros = new System.Windows.Forms.ComboBox();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.panelSpacer = new System.Windows.Forms.Panel();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFicha = new System.Windows.Forms.Label();
            this.labelFichaNum = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dateTimePickerDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelDataRegistro = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.textBoxMae = new System.Windows.Forms.TextBox();
            this.labelMae = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelPacientePrincipal.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1109, 50);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Cadastro";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPacientePrincipal
            // 
            this.panelPacientePrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPacientePrincipal.Controls.Add(this.panelDataGrid);
            this.panelPacientePrincipal.Controls.Add(this.panelSpacer);
            this.panelPacientePrincipal.Controls.Add(this.panelFormulario);
            this.panelPacientePrincipal.Location = new System.Drawing.Point(0, 50);
            this.panelPacientePrincipal.Name = "panelPacientePrincipal";
            this.panelPacientePrincipal.Padding = new System.Windows.Forms.Padding(8);
            this.panelPacientePrincipal.Size = new System.Drawing.Size(1109, 634);
            this.panelPacientePrincipal.TabIndex = 1;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDataGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDataGrid.Controls.Add(this.panel2);
            this.panelDataGrid.Controls.Add(this.dataGridViewPacientes);
            this.panelDataGrid.Location = new System.Drawing.Point(8, 246);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Padding = new System.Windows.Forms.Padding(8);
            this.panelDataGrid.Size = new System.Drawing.Size(1093, 377);
            this.panelDataGrid.TabIndex = 2;
            // 
            // comboBoxRegistros
            // 
            this.comboBoxRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegistros.FormattingEnabled = true;
            this.comboBoxRegistros.Items.AddRange(new object[] {
            "100",
            "1000",
            "Todas"});
            this.comboBoxRegistros.Location = new System.Drawing.Point(3, 7);
            this.comboBoxRegistros.Name = "comboBoxRegistros";
            this.comboBoxRegistros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxRegistros.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRegistros.TabIndex = 20;
            this.comboBoxRegistros.Text = "100";
            this.comboBoxRegistros.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegistros_SelectedIndexChanged);
            // 
            // labelRegistros
            // 
            this.labelRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistros.Location = new System.Drawing.Point(130, 10);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(210, 20);
            this.labelRegistros.TabIndex = 19;
            this.labelRegistros.Text = "Registros sendo exibidos";
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.AllowUserToOrderColumns = true;
            this.dataGridViewPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(1077, 314);
            this.dataGridViewPacientes.TabIndex = 17;
            this.dataGridViewPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellClick);
            // 
            // panelSpacer
            // 
            this.panelSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer.Location = new System.Drawing.Point(8, 240);
            this.panelSpacer.Name = "panelSpacer";
            this.panelSpacer.Size = new System.Drawing.Size(1093, 5);
            this.panelSpacer.TabIndex = 1;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFormulario.Controls.Add(this.panel1);
            this.panelFormulario.Controls.Add(this.maskedTextBoxTelefone);
            this.panelFormulario.Controls.Add(this.maskedTextBoxRg);
            this.panelFormulario.Controls.Add(this.maskedTextBoxCpf);
            this.panelFormulario.Controls.Add(this.panelBusca);
            this.panelFormulario.Controls.Add(this.buttonExcluir);
            this.panelFormulario.Controls.Add(this.buttonNovo);
            this.panelFormulario.Controls.Add(this.buttonCadastrar);
            this.panelFormulario.Controls.Add(this.dateTimePickerDataRegistro);
            this.panelFormulario.Controls.Add(this.labelDataRegistro);
            this.panelFormulario.Controls.Add(this.dateTimePickerDataNascimento);
            this.panelFormulario.Controls.Add(this.labelDataNascimento);
            this.panelFormulario.Controls.Add(this.labelTelefone);
            this.panelFormulario.Controls.Add(this.textBoxCidade);
            this.panelFormulario.Controls.Add(this.labelCidade);
            this.panelFormulario.Controls.Add(this.textBoxEndereco);
            this.panelFormulario.Controls.Add(this.labelEndereco);
            this.panelFormulario.Controls.Add(this.labelRg);
            this.panelFormulario.Controls.Add(this.labelCpf);
            this.panelFormulario.Controls.Add(this.textBoxMae);
            this.panelFormulario.Controls.Add(this.labelMae);
            this.panelFormulario.Controls.Add(this.textBoxNome);
            this.panelFormulario.Controls.Add(this.labelNome);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormulario.Location = new System.Drawing.Point(8, 8);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(8);
            this.panelFormulario.Size = new System.Drawing.Size(1093, 232);
            this.panelFormulario.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelFicha);
            this.panel1.Controls.Add(this.labelFichaNum);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 47);
            this.panel1.TabIndex = 28;
            // 
            // labelFicha
            // 
            this.labelFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFicha.AutoSize = true;
            this.labelFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFicha.Location = new System.Drawing.Point(3, 3);
            this.labelFicha.Name = "labelFicha";
            this.labelFicha.Size = new System.Drawing.Size(53, 20);
            this.labelFicha.TabIndex = 26;
            this.labelFicha.Text = "Ficha";
            // 
            // labelFichaNum
            // 
            this.labelFichaNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFichaNum.AutoSize = true;
            this.labelFichaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaNum.ForeColor = System.Drawing.Color.Red;
            this.labelFichaNum.Location = new System.Drawing.Point(3, 23);
            this.labelFichaNum.Name = "labelFichaNum";
            this.labelFichaNum.Size = new System.Drawing.Size(59, 20);
            this.labelFichaNum.TabIndex = 27;
            this.labelFichaNum.Text = "00000";
            this.labelFichaNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(511, 84);
            this.maskedTextBoxTelefone.Mask = "(99) 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(135, 26);
            this.maskedTextBoxTelefone.TabIndex = 7;
            this.maskedTextBoxTelefone.TextChanged += new System.EventHandler(this.maskedTextBoxTelefone_TextChanged);
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxRg.Location = new System.Drawing.Point(143, 84);
            this.maskedTextBoxRg.Mask = "99,999,999";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(93, 26);
            this.maskedTextBoxRg.TabIndex = 5;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(11, 84);
            this.maskedTextBoxCpf.Mask = "###,###,###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(126, 26);
            this.maskedTextBoxCpf.TabIndex = 4;
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.SystemColors.Control;
            this.panelBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusca.Controls.Add(this.buttonPesquisar);
            this.panelBusca.Controls.Add(this.textBoxPesquisar);
            this.panelBusca.Controls.Add(this.labelPesquisar);
            this.panelBusca.Location = new System.Drawing.Point(652, 86);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(430, 140);
            this.panelBusca.TabIndex = 25;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.Color.Black;
            this.buttonPesquisar.Location = new System.Drawing.Point(32, 83);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(100, 42);
            this.buttonPesquisar.TabIndex = 16;
            this.buttonPesquisar.Text = "Ok";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(32, 51);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(387, 26);
            this.textBoxPesquisar.TabIndex = 15;
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.Location = new System.Drawing.Point(24, 25);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(88, 20);
            this.labelPesquisar.TabIndex = 1;
            this.labelPesquisar.Text = "Pesquisar";
            this.labelPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.Red;
            this.buttonExcluir.Location = new System.Drawing.Point(235, 176);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 45);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            this.buttonExcluir.MouseEnter += new System.EventHandler(this.buttonExcluir_MouseEnter);
            this.buttonExcluir.MouseLeave += new System.EventHandler(this.buttonExcluir_MouseLeave);
            // 
            // buttonNovo
            // 
            this.buttonNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(113)))));
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(113)))));
            this.buttonNovo.Location = new System.Drawing.Point(123, 176);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 45);
            this.buttonNovo.TabIndex = 13;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            this.buttonNovo.MouseEnter += new System.EventHandler(this.buttonNovo_MouseEnter);
            this.buttonNovo.MouseLeave += new System.EventHandler(this.buttonNovo_MouseLeave);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonCadastrar.Location = new System.Drawing.Point(11, 176);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 45);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Salvar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            this.buttonCadastrar.MouseEnter += new System.EventHandler(this.buttonCadastrar_MouseEnter);
            this.buttonCadastrar.MouseLeave += new System.EventHandler(this.buttonCadastrar_MouseLeave);
            // 
            // dateTimePickerDataRegistro
            // 
            this.dateTimePickerDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataRegistro.Location = new System.Drawing.Point(451, 138);
            this.dateTimePickerDataRegistro.Name = "dateTimePickerDataRegistro";
            this.dateTimePickerDataRegistro.Size = new System.Drawing.Size(122, 26);
            this.dateTimePickerDataRegistro.TabIndex = 10;
            // 
            // labelDataRegistro
            // 
            this.labelDataRegistro.AutoSize = true;
            this.labelDataRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataRegistro.Location = new System.Drawing.Point(447, 115);
            this.labelDataRegistro.Name = "labelDataRegistro";
            this.labelDataRegistro.Size = new System.Drawing.Size(77, 20);
            this.labelDataRegistro.TabIndex = 18;
            this.labelDataRegistro.Text = "Registro";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CustomFormat = "\"dd-MM-yyyy\"";
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(323, 138);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(122, 26);
            this.dateTimePickerDataNascimento.TabIndex = 9;
            this.dateTimePickerDataNascimento.Value = new System.DateTime(2023, 3, 21, 0, 0, 0, 0);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(319, 115);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(103, 20);
            this.labelDataNascimento.TabIndex = 16;
            this.labelDataNascimento.Text = "Nascimento";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(507, 61);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(79, 20);
            this.labelTelefone.TabIndex = 14;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.Location = new System.Drawing.Point(242, 84);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(263, 26);
            this.textBoxCidade.TabIndex = 6;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(238, 61);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(65, 20);
            this.labelCidade.TabIndex = 12;
            this.labelCidade.Text = "Cidade";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(11, 138);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(305, 26);
            this.textBoxEndereco.TabIndex = 8;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(15, 115);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(86, 20);
            this.labelEndereco.TabIndex = 10;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRg.Location = new System.Drawing.Point(138, 64);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(32, 20);
            this.labelRg.TabIndex = 8;
            this.labelRg.Text = "Rg";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(11, 63);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(37, 20);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "Cpf";
            // 
            // textBoxMae
            // 
            this.textBoxMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMae.Location = new System.Drawing.Point(380, 30);
            this.textBoxMae.Name = "textBoxMae";
            this.textBoxMae.Size = new System.Drawing.Size(266, 26);
            this.textBoxMae.TabIndex = 2;
            // 
            // labelMae
            // 
            this.labelMae.AutoSize = true;
            this.labelMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMae.Location = new System.Drawing.Point(379, 8);
            this.labelMae.Name = "labelMae";
            this.labelMae.Size = new System.Drawing.Size(43, 20);
            this.labelMae.TabIndex = 4;
            this.labelMae.Text = "Mãe";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(121, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(253, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(117, 8);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.labelRegistros);
            this.panel2.Controls.Add(this.comboBoxRegistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 38);
            this.panel2.TabIndex = 21;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panelPacientePrincipal);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPacientePrincipal.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelPacientePrincipal;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRegistro;
        private System.Windows.Forms.Label labelDataRegistro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox textBoxMae;
        private System.Windows.Forms.Label labelMae;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelSpacer;

        private System.Windows.Forms.BindingSource pacientesBindingSource;

        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label labelFichaNum;
        private System.Windows.Forms.Label labelFicha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.ComboBox comboBoxRegistros;
        private System.Windows.Forms.Panel panel2;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelPacientePrincipal = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.buttonExcluirConsulta = new System.Windows.Forms.Button();
            this.buttonNovaConsulta = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.panelTitleConsultas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitlePacientes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.comboBoxRegistros = new System.Windows.Forms.ComboBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelFicha = new System.Windows.Forms.Panel();
            this.labelFicha = new System.Windows.Forms.Label();
            this.labelFichaNum = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelDataRegistro = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelMae = new System.Windows.Forms.Label();
            this.textBoxMae = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelCpf = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.labelRg = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.dateTimePickerDataRegistro = new System.Windows.Forms.DateTimePicker();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.dataSet = new Sisconcad.DataSet();
            this.pacientesTableAdapter = new Sisconcad.DataSetTableAdapters.ConsultasTableAdapter();
            this.panelTitle.SuspendLayout();
            this.panelPacientePrincipal.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.panelTitleConsultas.SuspendLayout();
            this.panelTitlePacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFicha.SuspendLayout();
            this.panelBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1109, 684);
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
            this.panelPacientePrincipal.Controls.Add(this.panelDataGrid);
            this.panelPacientePrincipal.Controls.Add(this.panelFormulario);
            this.panelPacientePrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPacientePrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPacientePrincipal.Name = "panelPacientePrincipal";
            this.panelPacientePrincipal.Padding = new System.Windows.Forms.Padding(8);
            this.panelPacientePrincipal.Size = new System.Drawing.Size(1109, 684);
            this.panelPacientePrincipal.TabIndex = 1;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDataGrid.Controls.Add(this.buttonExcluirConsulta);
            this.panelDataGrid.Controls.Add(this.buttonNovaConsulta);
            this.panelDataGrid.Controls.Add(this.dataGridViewPacientes);
            this.panelDataGrid.Controls.Add(this.panelTitleConsultas);
            this.panelDataGrid.Controls.Add(this.panelTitlePacientes);
            this.panelDataGrid.Controls.Add(this.dataGridViewConsultas);
            this.panelDataGrid.Controls.Add(this.panel2);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(8, 246);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Padding = new System.Windows.Forms.Padding(8);
            this.panelDataGrid.Size = new System.Drawing.Size(1093, 430);
            this.panelDataGrid.TabIndex = 2;
            // 
            // buttonExcluirConsulta
            // 
            this.buttonExcluirConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExcluirConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExcluirConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonExcluirConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirConsulta.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirConsulta.ForeColor = System.Drawing.Color.Black;
            this.buttonExcluirConsulta.Image = global::Sisconcad.Properties.Resources.delete;
            this.buttonExcluirConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirConsulta.Location = new System.Drawing.Point(925, 327);
            this.buttonExcluirConsulta.Name = "buttonExcluirConsulta";
            this.buttonExcluirConsulta.Size = new System.Drawing.Size(160, 50);
            this.buttonExcluirConsulta.TabIndex = 26;
            this.buttonExcluirConsulta.Text = "Excluir Consulta";
            this.buttonExcluirConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirConsulta.UseVisualStyleBackColor = true;
            this.buttonExcluirConsulta.Click += new System.EventHandler(this.buttonExcluirConsulta_Click);
            // 
            // buttonNovaConsulta
            // 
            this.buttonNovaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNovaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNovaConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonNovaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaConsulta.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovaConsulta.ForeColor = System.Drawing.Color.Black;
            this.buttonNovaConsulta.Image = global::Sisconcad.Properties.Resources.novaConsul;
            this.buttonNovaConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovaConsulta.Location = new System.Drawing.Point(676, 327);
            this.buttonNovaConsulta.Name = "buttonNovaConsulta";
            this.buttonNovaConsulta.Size = new System.Drawing.Size(157, 50);
            this.buttonNovaConsulta.TabIndex = 25;
            this.buttonNovaConsulta.Text = "Nova Consulta";
            this.buttonNovaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNovaConsulta.UseVisualStyleBackColor = true;
            this.buttonNovaConsulta.Click += new System.EventHandler(this.buttonNovaConsulta_Click);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.AllowUserToAddRows = false;
            this.dataGridViewPacientes.AllowUserToDeleteRows = false;
            this.dataGridViewPacientes.AllowUserToOrderColumns = true;
            this.dataGridViewPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(8, 49);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(665, 328);
            this.dataGridViewPacientes.TabIndex = 17;
            this.dataGridViewPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellClick);
            this.dataGridViewPacientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellEnter);
            this.dataGridViewPacientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPacientes_CellMouseDoubleClick);
            // 
            // panelTitleConsultas
            // 
            this.panelTitleConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.panelTitleConsultas.Controls.Add(this.label2);
            this.panelTitleConsultas.Location = new System.Drawing.Point(676, 0);
            this.panelTitleConsultas.Name = "panelTitleConsultas";
            this.panelTitleConsultas.Size = new System.Drawing.Size(409, 50);
            this.panelTitleConsultas.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consultas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTitlePacientes
            // 
            this.panelTitlePacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.panelTitlePacientes.Controls.Add(this.label1);
            this.panelTitlePacientes.Location = new System.Drawing.Point(8, 0);
            this.panelTitlePacientes.Name = "panelTitlePacientes";
            this.panelTitlePacientes.Size = new System.Drawing.Size(665, 50);
            this.panelTitlePacientes.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.AllowUserToOrderColumns = true;
            this.dataGridViewConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConsultas.Location = new System.Drawing.Point(676, 49);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(409, 272);
            this.dataGridViewConsultas.TabIndex = 22;
            this.dataGridViewConsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultas_CellDoubleClick);
            this.dataGridViewConsultas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultas_CellEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.labelRegistros);
            this.panel2.Controls.Add(this.comboBoxRegistros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 38);
            this.panel2.TabIndex = 21;
            // 
            // labelRegistros
            // 
            this.labelRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistros.Location = new System.Drawing.Point(130, 10);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(183, 20);
            this.labelRegistros.TabIndex = 19;
            this.labelRegistros.Text = "Registros sendo exibidos";
            // 
            // comboBoxRegistros
            // 
            this.comboBoxRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRegistros.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegistros.FormattingEnabled = true;
            this.comboBoxRegistros.Items.AddRange(new object[] {
            "100",
            "1000",
            "Todas"});
            this.comboBoxRegistros.Location = new System.Drawing.Point(3, 7);
            this.comboBoxRegistros.Name = "comboBoxRegistros";
            this.comboBoxRegistros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxRegistros.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRegistros.TabIndex = 20;
            this.comboBoxRegistros.Text = "100";
            this.comboBoxRegistros.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegistros_SelectedIndexChanged);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFormulario.Controls.Add(this.panelForm);
            this.panelFormulario.Controls.Add(this.panelBusca);
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormulario.Location = new System.Drawing.Point(8, 8);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.panelFormulario.Size = new System.Drawing.Size(1093, 238);
            this.panelFormulario.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.panelFicha);
            this.panelForm.Controls.Add(this.maskedTextBoxTelefone);
            this.panelForm.Controls.Add(this.labelDataRegistro);
            this.panelForm.Controls.Add(this.labelNome);
            this.panelForm.Controls.Add(this.maskedTextBoxRg);
            this.panelForm.Controls.Add(this.textBoxNome);
            this.panelForm.Controls.Add(this.maskedTextBoxCpf);
            this.panelForm.Controls.Add(this.labelMae);
            this.panelForm.Controls.Add(this.textBoxMae);
            this.panelForm.Controls.Add(this.buttonExcluir);
            this.panelForm.Controls.Add(this.labelCpf);
            this.panelForm.Controls.Add(this.buttonNovo);
            this.panelForm.Controls.Add(this.labelRg);
            this.panelForm.Controls.Add(this.buttonCadastrar);
            this.panelForm.Controls.Add(this.labelEndereco);
            this.panelForm.Controls.Add(this.dateTimePickerDataRegistro);
            this.panelForm.Controls.Add(this.textBoxEndereco);
            this.panelForm.Controls.Add(this.labelCidade);
            this.panelForm.Controls.Add(this.dateTimePickerDataNascimento);
            this.panelForm.Controls.Add(this.textBoxCidade);
            this.panelForm.Controls.Add(this.labelDataNascimento);
            this.panelForm.Controls.Add(this.labelTelefone);
            this.panelForm.Location = new System.Drawing.Point(8, 11);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(665, 223);
            this.panelForm.TabIndex = 26;
            // 
            // panelFicha
            // 
            this.panelFicha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFicha.Controls.Add(this.labelFicha);
            this.panelFicha.Controls.Add(this.labelFichaNum);
            this.panelFicha.Location = new System.Drawing.Point(12, 5);
            this.panelFicha.Name = "panelFicha";
            this.panelFicha.Size = new System.Drawing.Size(104, 47);
            this.panelFicha.TabIndex = 28;
            // 
            // labelFicha
            // 
            this.labelFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFicha.AutoSize = true;
            this.labelFicha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFicha.Location = new System.Drawing.Point(3, 3);
            this.labelFicha.Name = "labelFicha";
            this.labelFicha.Size = new System.Drawing.Size(45, 20);
            this.labelFicha.TabIndex = 26;
            this.labelFicha.Text = "Ficha";
            // 
            // labelFichaNum
            // 
            this.labelFichaNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFichaNum.AutoSize = true;
            this.labelFichaNum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFichaNum.ForeColor = System.Drawing.Color.Red;
            this.labelFichaNum.Location = new System.Drawing.Point(3, 23);
            this.labelFichaNum.Name = "labelFichaNum";
            this.labelFichaNum.Size = new System.Drawing.Size(54, 20);
            this.labelFichaNum.TabIndex = 27;
            this.labelFichaNum.Text = "00000";
            this.labelFichaNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFichaNum.TextChanged += new System.EventHandler(this.labelFichaNum_TextChanged);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(512, 79);
            this.maskedTextBoxTelefone.Mask = "(99) 9999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(135, 24);
            this.maskedTextBoxTelefone.TabIndex = 7;
            this.maskedTextBoxTelefone.TextChanged += new System.EventHandler(this.maskedTextBoxTelefone_TextChanged);
            // 
            // labelDataRegistro
            // 
            this.labelDataRegistro.AutoSize = true;
            this.labelDataRegistro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataRegistro.Location = new System.Drawing.Point(484, 110);
            this.labelDataRegistro.Name = "labelDataRegistro";
            this.labelDataRegistro.Size = new System.Drawing.Size(68, 20);
            this.labelDataRegistro.TabIndex = 18;
            this.labelDataRegistro.Text = "Registro";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(118, 3);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(52, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxRg.Location = new System.Drawing.Point(144, 79);
            this.maskedTextBoxRg.Mask = "99,999,999";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(93, 24);
            this.maskedTextBoxRg.TabIndex = 5;
            // 
            // textBoxNome
            // 
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(122, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(253, 24);
            this.textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(12, 79);
            this.maskedTextBoxCpf.Mask = "###,###,###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(126, 24);
            this.maskedTextBoxCpf.TabIndex = 4;
            // 
            // labelMae
            // 
            this.labelMae.AutoSize = true;
            this.labelMae.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMae.Location = new System.Drawing.Point(380, 3);
            this.labelMae.Name = "labelMae";
            this.labelMae.Size = new System.Drawing.Size(39, 20);
            this.labelMae.TabIndex = 4;
            this.labelMae.Text = "Mãe";
            // 
            // textBoxMae
            // 
            this.textBoxMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMae.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMae.Location = new System.Drawing.Point(381, 25);
            this.textBoxMae.Name = "textBoxMae";
            this.textBoxMae.Size = new System.Drawing.Size(266, 24);
            this.textBoxMae.TabIndex = 2;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.Red;
            this.buttonExcluir.Location = new System.Drawing.Point(236, 171);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 45);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            this.buttonExcluir.MouseEnter += new System.EventHandler(this.buttonExcluir_MouseEnter);
            this.buttonExcluir.MouseLeave += new System.EventHandler(this.buttonExcluir_MouseLeave);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpf.Location = new System.Drawing.Point(12, 58);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(33, 20);
            this.labelCpf.TabIndex = 6;
            this.labelCpf.Text = "Cpf";
            // 
            // buttonNovo
            // 
            this.buttonNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(113)))));
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(113)))));
            this.buttonNovo.Location = new System.Drawing.Point(124, 171);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 45);
            this.buttonNovo.TabIndex = 13;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            this.buttonNovo.MouseEnter += new System.EventHandler(this.buttonNovo_MouseEnter);
            this.buttonNovo.MouseLeave += new System.EventHandler(this.buttonNovo_MouseLeave);
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRg.Location = new System.Drawing.Point(139, 59);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(28, 20);
            this.labelRg.TabIndex = 8;
            this.labelRg.Text = "Rg";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(61)))));
            this.buttonCadastrar.Location = new System.Drawing.Point(12, 171);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 45);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Salvar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            this.buttonCadastrar.MouseEnter += new System.EventHandler(this.buttonCadastrar_MouseEnter);
            this.buttonCadastrar.MouseLeave += new System.EventHandler(this.buttonCadastrar_MouseLeave);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(12, 110);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(73, 20);
            this.labelEndereco.TabIndex = 10;
            this.labelEndereco.Text = "Endereço";
            // 
            // dateTimePickerDataRegistro
            // 
            this.dateTimePickerDataRegistro.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataRegistro.Location = new System.Drawing.Point(488, 133);
            this.dateTimePickerDataRegistro.Name = "dateTimePickerDataRegistro";
            this.dateTimePickerDataRegistro.Size = new System.Drawing.Size(159, 24);
            this.dateTimePickerDataRegistro.TabIndex = 10;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEndereco.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 133);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(305, 24);
            this.textBoxEndereco.TabIndex = 8;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(239, 56);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(56, 20);
            this.labelCidade.TabIndex = 12;
            this.labelCidade.Text = "Cidade";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.CustomFormat = "\"dd-MM-yyyy\"";
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(324, 133);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(159, 24);
            this.dateTimePickerDataNascimento.TabIndex = 9;
            this.dateTimePickerDataNascimento.Value = new System.DateTime(2023, 3, 21, 0, 0, 0, 0);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.Location = new System.Drawing.Point(243, 79);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(263, 24);
            this.textBoxCidade.TabIndex = 6;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(320, 110);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(93, 20);
            this.labelDataNascimento.TabIndex = 16;
            this.labelDataNascimento.Text = "Nascimento";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(508, 56);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(69, 20);
            this.labelTelefone.TabIndex = 14;
            this.labelTelefone.Text = "Telefone";
            // 
            // panelBusca
            // 
            this.panelBusca.BackColor = System.Drawing.SystemColors.Control;
            this.panelBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusca.Controls.Add(this.buttonPesquisar);
            this.panelBusca.Controls.Add(this.textBoxPesquisar);
            this.panelBusca.Controls.Add(this.labelPesquisar);
            this.panelBusca.Location = new System.Drawing.Point(676, 94);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(409, 140);
            this.panelBusca.TabIndex = 25;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBoxPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(32, 50);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(347, 24);
            this.textBoxPesquisar.TabIndex = 15;
            this.textBoxPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisar_KeyDown);
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.Location = new System.Drawing.Point(29, 27);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(76, 20);
            this.labelPesquisar.TabIndex = 1;
            this.labelPesquisar.Text = "Pesquisar";
            this.labelPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
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
            this.Enter += new System.EventHandler(this.FormPacientes_Enter);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPacientePrincipal.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.panelTitleConsultas.ResumeLayout(false);
            this.panelTitleConsultas.PerformLayout();
            this.panelTitlePacientes.ResumeLayout(false);
            this.panelTitlePacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFormulario.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelFicha.ResumeLayout(false);
            this.panelFicha.PerformLayout();
            this.panelBusca.ResumeLayout(false);
            this.panelBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelPacientePrincipal;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelTitleConsultas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitlePacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.ComboBox comboBoxRegistros;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelFicha;
        private System.Windows.Forms.Label labelFicha;
        public System.Windows.Forms.Label labelFichaNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label labelDataRegistro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label labelMae;
        private System.Windows.Forms.TextBox textBoxMae;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRegistro;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label labelPesquisar;
        private DataSet dataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn chistoricoPessoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chistoricoFamiliarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacuidadeOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacuidadeOeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbioOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbioOeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfundoOlhoOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfundoOlhoOeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpressaoOcularOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpressaoOcularOeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccondutaConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgeralDataGridViewTextBoxColumn;
        private DataSetTableAdapters.ConsultasTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.Button buttonNovaConsulta;
        private System.Windows.Forms.Button buttonExcluirConsulta;
    }
}
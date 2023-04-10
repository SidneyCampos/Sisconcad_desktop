namespace Sisconcad
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.panelSpacer = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(23)))), ((int)(((byte)(113)))));
            this.panelMenu.Controls.Add(this.buttonSair);
            this.panelMenu.Controls.Add(this.buttonPacientes);
            this.panelMenu.Controls.Add(this.panelSpacer);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelMenu.Size = new System.Drawing.Size(145, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSair
            // 
            this.buttonSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSair.Image = global::Sisconcad.Properties.Resources.exit;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(0, 392);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(145, 50);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPacientes.FlatAppearance.BorderSize = 0;
            this.buttonPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPacientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPacientes.Image = global::Sisconcad.Properties.Resources.user;
            this.buttonPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPacientes.Location = new System.Drawing.Point(0, 70);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(145, 50);
            this.buttonPacientes.TabIndex = 2;
            this.buttonPacientes.Text = "    Pacientes";
            this.buttonPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // panelSpacer
            // 
            this.panelSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacer.Location = new System.Drawing.Point(0, 50);
            this.panelSpacer.Name = "panelSpacer";
            this.panelSpacer.Size = new System.Drawing.Size(145, 20);
            this.panelSpacer.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BackgroundImage = global::Sisconcad.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(145, 50);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(145, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(655, 450);
            this.panelPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.Text = "Sisconcad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Panel panelSpacer;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}


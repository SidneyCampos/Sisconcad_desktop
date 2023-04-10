using System;
using System.Windows.Forms;

namespace Sisconcad
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            FormPacientes f = new FormPacientes();
            f.TopLevel = false;
            panelPrincipal.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            FormPacientes f = new FormPacientes();
            f.TopLevel = false;
            panelPrincipal.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}

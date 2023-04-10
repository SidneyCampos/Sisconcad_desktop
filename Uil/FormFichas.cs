using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sisconcad
{

    public partial class FormFichas : Form
    {

        public FormFichas()
        {
            InitializeComponent();
        }

        private void Fichas_Load(object sender, EventArgs e)
        {
            if (VarGlobais.eFichaCompleta)
            {
                MessageBox.Show(VarGlobais.IdConsultaAtual);
                this.consultasTableAdapter.FillById(this.dataSet2.Consultas, Int32.Parse(VarGlobais.IdAtual), Int32.Parse(VarGlobais.IdConsultaAtual));
                this.pacientesTableAdapter.FillBy(this.dataSet.Pacientes, Int32.Parse(VarGlobais.IdAtual));
                reportViewerFicha.Hide();
                reportViewerConsulta.RefreshReport();
            } else
            {
                this.pacientesTableAdapter.FillBy(this.dataSet.Pacientes, Int32.Parse(VarGlobais.IdAtual));
                reportViewerConsulta.Hide();
                reportViewerFicha.RefreshReport();
            }
        }


    }
}

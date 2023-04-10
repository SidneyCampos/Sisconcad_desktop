using Sisconcad.Bll;
using Sisconcad.Dal;
using Sisconcad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisconcad.Uil
{
    public partial class FormConsultas : Form
    {

        // ---------- INSTANCIAÇÃO ----------
        consultaBll consultabll = new consultaBll();

        // ---------- FUNÇÕES ---------

        public void preencheForm()
        {
            labelDataNum.Text = VarGlobais.consultaRow.Cells[1].Value.ToString();
            textBoxQueixaPessoal.Text = VarGlobais.consultaRow.Cells[2].Value.ToString();
            textBoxCondutaConsulta.Text = VarGlobais.consultaRow.Cells[3].Value.ToString();
            textBoxHistoricoPessoal.Text = VarGlobais.consultaRow.Cells[4].Value.ToString();
            textBoxHistoricoFamiliar.Text = VarGlobais.consultaRow.Cells[5].Value.ToString();
            textBoxAcuidadeOd.Text = VarGlobais.consultaRow.Cells[6].Value.ToString();
            textBoxAcuidadeOe.Text = VarGlobais.consultaRow.Cells[7].Value.ToString();
            textBoxBioOd.Text = VarGlobais.consultaRow.Cells[8].Value.ToString();
            textBoxBioOe.Text = VarGlobais.consultaRow.Cells[9].Value.ToString();
            textBoxFundoOlhoOd.Text = VarGlobais.consultaRow.Cells[10].Value.ToString();
            textBoxFundoOlhoOe.Text = VarGlobais.consultaRow.Cells[11].Value.ToString();
            textBoxPressaoOcularOd.Text = VarGlobais.consultaRow.Cells[12].Value.ToString();
            textBoxPressaoOcularOe.Text = VarGlobais.consultaRow.Cells[13].Value.ToString();
            richTextBoxGeral.Text = VarGlobais.consultaRow.Cells[14].Value.ToString();
        }

        public FormConsultas()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
             consultaModel consultamodel = new consultaModel();
            consultamodel.DataConsulta = labelDataNum.Text;
            //TODO - PEGAR NOME DO PACIENTE
            consultamodel.QueixaPessoal = textBoxQueixaPessoal.Text;
            consultamodel.HistoricoPessoal = textBoxHistoricoPessoal.Text;
            consultamodel.HistoricoFamiliar = textBoxHistoricoFamiliar.Text;
            consultamodel.AcuidadeOd = textBoxAcuidadeOd.Text;
            consultamodel.AcuidadeOe = textBoxAcuidadeOe.Text;
            consultamodel.BioOd = textBoxBioOd.Text;
            consultamodel.BioOe = textBoxBioOe.Text;
            consultamodel.FundoOlhoOd = textBoxFundoOlhoOd.Text;
            consultamodel.FundoOlhoOe = textBoxFundoOlhoOe.Text;
            consultamodel.PressaoOcularOd = textBoxPressaoOcularOd.Text;
            consultamodel.PressaoOcularOe = textBoxPressaoOcularOe.Text;
            consultamodel.CondutaConsulta = textBoxCondutaConsulta.Text;
            consultamodel.Geral = richTextBoxGeral.Text;

            try
            {
                consultabll.salvarConsultaDal(consultamodel, VarGlobais.eNovaConsulta);
            }
            catch (Exception)
            {

                throw;
            } finally
            {
                this.Close();
            }
            
        }

        private void FormConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            VarGlobais.eNovaConsulta = false;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            labelNomeValor.Text = VarGlobais.nomeAtual;
            if(!VarGlobais.eNovaConsulta)
                this.preencheForm();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            VarGlobais.eFichaCompleta = true;
            if (VarGlobais.eNovaConsulta)
            {
                VarGlobais.IdConsultaAtual = consultabll.getLastIdConsultaDal();
                buttonSalvar.PerformClick();
            }
               

            using (var frm = new FormFichas())
            {
                frm.ShowDialog();
            }
        }
    }
}

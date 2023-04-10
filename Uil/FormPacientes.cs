using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System;
using Microsoft.Win32;
using Sisconcad.Bll;
using Sisconcad.Model;
using Sisconcad.Uil;

namespace Sisconcad
{
    public partial class FormPacientes : Form
    {

        // ---------- INSTANCIAÇÃO ----------
        pacienteBll pacientebll = new pacienteBll();
        consultaBll consultabll = new consultaBll();

        // ---------- FUNÇÕES ----------
        public void RefreshGrid()
        {
            
            try
            {
                dataGridViewPacientes.DataSource = pacientebll.listaPacientesDal(comboBoxRegistros.Text);
                // TODO - alterar combobox com quantidade exata
                

                textBoxNome.Text = "";
                textBoxMae.Text = "";
                maskedTextBoxCpf.Text = "";
                maskedTextBoxRg.Text = "";
                textBoxCidade.Text = "";
                maskedTextBoxTelefone.Text = "";
                textBoxEndereco.Text = "";
                labelFichaNum.Text = pacientebll.getLastIdDal();
                VarGlobais.IdAtual = labelFichaNum.Text;
               
                textBoxNome.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na listagem de pacientes: " + erro);
                throw;
            }
            dataGridViewPacientes.CurrentCell = null;
        }

        private void PreencheForm(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pega a célula clicada para preenchimento dos campos
            {
                DataGridViewRow row = dataGridViewPacientes.Rows[e.RowIndex];
                labelFichaNum.Text = row.Cells[0].Value.ToString();
                textBoxNome.Text = row.Cells[1].Value.ToString();
                maskedTextBoxTelefone.Text = row.Cells[2].Value.ToString();
                maskedTextBoxCpf.Text = row.Cells[3].Value.ToString();
                maskedTextBoxRg.Text = row.Cells[4].Value.ToString();
                textBoxEndereco.Text = row.Cells[5].Value.ToString();
                textBoxCidade.Text = row.Cells[6].Value.ToString();
                textBoxMae.Text = row.Cells[7].Value.ToString();
                dateTimePickerDataNascimento.Text = row.Cells[8].Value.ToString();
                dateTimePickerDataRegistro.Text = row.Cells[9].Value.ToString();
            }
        }

        // ---------- INICIALIZAÇÃO DO FORM
        
        public FormPacientes()
            
        {
            InitializeComponent();
        }

        // ---------- DATAGRID PACIENTES

        private void dataGridViewPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheForm(e);
        }
        private void dataGridViewPacientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VarGlobais.eFichaCompleta = false;
            using (var frm = new FormFichas())
            {
                frm.ShowDialog();
            }
        }

        private void dataGridViewPacientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                PreencheForm(e);
                dataGridViewConsultas.DataSource = consultabll.listaConsultasDal(VarGlobais.IdAtual);
                VarGlobais.nomeAtual = textBoxNome.Text;
        }

        // ---------- DATAGRID CONSULTAS

        private void dataGridViewConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VarGlobais.eNovaConsulta = false;
            using (var frm = new FormConsultas())
            {
                frm.ShowDialog();
            }
        }

        private void dataGridViewConsultas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            VarGlobais.consultaRow = dataGridViewConsultas.Rows[e.RowIndex];
            VarGlobais.IdConsultaAtual = VarGlobais.consultaRow.Cells[0].Value.ToString();
        }

        // ---------- EVENTOS DE AÇÃO ---------- //

        private void FormPacientes_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
            comboBoxRegistros.Items[2] = labelFichaNum.Text;
            VarGlobais.lastIDConsulta = consultabll.getLastIdConsultaDal();
        }

        private void buttonNovo_Click(object sender, System.EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonCadastrar_Click(object sender, System.EventArgs e)
        {
            pacienteModel pacientemodel = new pacienteModel();

            pacientemodel.Id = Int32.Parse(labelFichaNum.Text);
            pacientemodel.Nome = textBoxNome.Text;
            pacientemodel.Mae = textBoxMae.Text;
            pacientemodel.Cpf = maskedTextBoxCpf.Text;
            pacientemodel.Rg = maskedTextBoxRg.Text;
            pacientemodel.Endereco = textBoxEndereco.Text;
            pacientemodel.Cidade = textBoxCidade.Text;
            pacientemodel.Fone = maskedTextBoxTelefone.Text;
            pacientemodel.Nascimento = dateTimePickerDataNascimento.Text;
            pacientemodel.Data = dateTimePickerDataRegistro.Text;

            try
            {
                if (labelFichaNum.Text == pacientebll.getLastIdDal())
                {
                    pacientebll.salvarPacienteDal(pacientemodel, true); //INSERT
                }
                else
                {
                    pacientebll.salvarPacienteDal(pacientemodel, false); //UPDATE
                }

                RefreshGrid();
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void buttonPesquisar_Click(object sender, System.EventArgs e)
        {
            if(textBoxPesquisar.Text != "")
            {
                try
                {
                    dataGridViewPacientes.DataSource = pacientebll.pesquisaPacientesDal(textBoxPesquisar.Text);
                    // dataGridViewPacientes.Rows[0].Selected = true ;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        private void maskedTextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            if ("9".Equals(maskedTextBoxTelefone.Text.Substring(5, 1)))
                maskedTextBoxTelefone.Mask = "(99) 99999-9999";
            else
                maskedTextBoxTelefone.Mask = "(99) 9999-9999";
        }

        private void comboBoxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
            
        {
            // string registro = labelFichaNum.Text;
            pacientebll.excluirPacientesDal(Int32.Parse(VarGlobais.IdAtual));
            RefreshGrid();
        }

        private void labelFichaNum_TextChanged(object sender, EventArgs e)
        {
            VarGlobais.IdAtual = labelFichaNum.Text;
        }

        private void buttonNovaConsulta_Click(object sender, EventArgs e)
        {
            VarGlobais.eNovaConsulta = true;
            using (var frm = new FormConsultas())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirConsulta_Click(object sender, EventArgs e)
        {
            consultabll.excluirConsultasDal(Int32.Parse(VarGlobais.IdConsultaAtual));
        }

        // ---------- EVENTOS VISUAIS -------------------------------------- //
        private void buttonCadastrar_MouseEnter(object sender, System.EventArgs e)
        {
            buttonCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void buttonCadastrar_MouseLeave(object sender, System.EventArgs e)
        {
            buttonCadastrar.ForeColor = Color.FromArgb(10, 130, 61);
        }

        private void buttonNovo_MouseEnter(object sender, System.EventArgs e)
        {
            buttonNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void buttonNovo_MouseLeave(object sender, System.EventArgs e)
        {
            buttonNovo.ForeColor = Color.FromArgb(43, 23, 113);
        }

        private void buttonExcluir_MouseEnter(object sender, System.EventArgs e)
        {
            buttonExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void buttonExcluir_MouseLeave(object sender, System.EventArgs e)
        {
            buttonExcluir.ForeColor = System.Drawing.Color.Red;
        }

        private void FormPacientes_Enter(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonPesquisar.PerformClick();
            }
        }
    }
}

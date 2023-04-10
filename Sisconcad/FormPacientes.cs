using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System;
using Microsoft.Win32;

namespace Sisconcad
{
    public partial class FormPacientes : Form
    {

        // ---------- VARIÁVEIS GLOBAIS ----------

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        string strSQL = null;
        string lastID = null;
        string sqlConnection = "Server = DESKTOP-GVVKSFK\\SQLEXPRESS; Database = db_sisconcad; User Id=sa; Password=1234;";
        
        // ---------- FUNÇÕES ----------
        
        public void RefreshGrid()
        {
            try
            {
                conexao = new SqlConnection(sqlConnection);

                strSQL = "SELECT id_paciente AS FICHA , p_nome AS NOME, p_mae  AS MAE, " +
                    "p_cpf AS CPF, p_rg AS RG, p_endereco AS ENDERECO, p_cidade AS CIDADE,\r\n\t\tp_fone AS TELEFONE, " +
                    "p_nascimento AS DATA_DE_NASCIMENTO, p_data AS DATA_DE_REGISTRO\r\n\tFROM Pacientes ORDER BY id_paciente DESC OFFSET 0 ROWS FETCH FIRST @LIMIT ROWS ONLY;";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                da.SelectCommand.Parameters.AddWithValue("@LIMIT", Int32.Parse(comboBoxRegistros.Text));

                conexao.Open();

                da.Fill(ds);

                dataGridViewPacientes.DataSource = ds.Tables[0];        
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conexao?.Close();
                textBoxNome.Focus();
                // labelFichaNum.Text = GetLastId();
            }

        }

        private string GetLastId()
        {
            try
            {
                conexao = new SqlConnection(sqlConnection);

                strSQL = "SELECT MAX(id_paciente) + 1 AS proximo_id FROM Pacientes";
 
                conexao.Open();
            
                SqlCommand comando = new SqlCommand(strSQL, conexao);
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read()) {
                    lastID = dr["proximo_id"].ToString();
                }
                    
                return lastID;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);    
                throw;

            } finally { 
                conexao?.Close();
                // MessageBox.Show(lastID);
            }
        }

        // ---------- INICIALIZAÇÃO DO FORM
        
        public FormPacientes()
            
        {
            InitializeComponent();
        }

        private void FormPacientes_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
            string _lastId = GetLastId();
            labelFichaNum.Text = _lastId;
            comboBoxRegistros.Items[2] = _lastId;
        }

        private void buttonNovo_Click(object sender, System.EventArgs e)
        {
            labelFichaNum.Text = GetLastId();
            textBoxNome.Text = "";
            textBoxNome.Focus();
            textBoxMae.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxRg.Text = "";
            textBoxCidade.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEndereco.Text = "";

            RefreshGrid();
        }

        private void buttonCadastrar_Click(object sender, System.EventArgs e)
        {
            string verificaFicha = GetLastId();
            string registro = null;

            if (labelFichaNum.Text == verificaFicha)
            {
                // INSERT
                try
                {
                    conexao = new SqlConnection(sqlConnection);
                    //conexao = new SqlConnection("Server=DESKTOP-GVVKSFK\\SQLEXPRESS;Database=Pacientes;Trusted_Connection=True;MultipleActiveResultSets=true;");

                    strSQL = "INSERT INTO Pacientes (id_paciente, p_nome, p_mae, p_cpf, p_rg, p_endereco, p_cidade, p_fone, p_nascimento, p_data) VALUES (@ID_PACIENTE, @NOME, @MAE, @CPF, @RG, @ENDERECO, @CIDADE, @FONE, @NASCIMENTO, @DATA)";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID_PACIENTE", labelFichaNum.Text);
                    comando.Parameters.AddWithValue("@NOME", textBoxNome.Text);
                    comando.Parameters.AddWithValue("@MAE", textBoxMae.Text);
                    comando.Parameters.AddWithValue("@CPF", maskedTextBoxCpf.Text);
                    comando.Parameters.AddWithValue("@RG", maskedTextBoxRg.Text);
                    comando.Parameters.AddWithValue("@ENDERECO", textBoxEndereco.Text);
                    comando.Parameters.AddWithValue("@CIDADE", textBoxCidade.Text);
                    comando.Parameters.AddWithValue("@FONE", maskedTextBoxTelefone.Text);
                    comando.Parameters.AddWithValue("@NASCIMENTO", dateTimePickerDataNascimento.Value);
                    comando.Parameters.AddWithValue("@DATA", dateTimePickerDataRegistro.Value);


                    conexao.Open();
                    comando.ExecuteNonQuery();
                    RefreshGrid();
                }
                catch (System.Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    // MessageBox.Show(dateTimePickerDataNascimento.Text);
                    throw;
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                    labelFichaNum.Text = GetLastId();
                }
            } else
            {
                // UPDATE
                
                    registro = labelFichaNum.Text;

                    DialogResult result = MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR A FICHA: " + registro + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            conexao = new SqlConnection(sqlConnection);

                            strSQL = "UPDATE Pacientes SET p_nome = @NOME, p_mae = @MAE, " +
                            "p_cpf = @CPF, p_rg = @RG, p_endereco = @ENDERECO, " +
                            "p_cidade = @CIDADE, p_fone = @FONE, p_nascimento = @NASCIMENTO, p_data = @DATA " +
                            "WHERE id_paciente = @ID";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@ID", labelFichaNum.Text);
                            comando.Parameters.AddWithValue("@NOME", textBoxNome.Text);
                            comando.Parameters.AddWithValue("@MAE", textBoxMae.Text);
                            comando.Parameters.AddWithValue("@CPF", maskedTextBoxCpf.Text);
                            comando.Parameters.AddWithValue("@RG", maskedTextBoxRg.Text);
                            comando.Parameters.AddWithValue("@ENDERECO", textBoxEndereco.Text);
                            comando.Parameters.AddWithValue("@CIDADE", textBoxCidade.Text);
                            comando.Parameters.AddWithValue("@FONE", maskedTextBoxTelefone.Text);
                            comando.Parameters.AddWithValue("@NASCIMENTO", dateTimePickerDataNascimento.Value);
                            comando.Parameters.AddWithValue("@DATA", dateTimePickerDataRegistro.Value);


                            conexao.Open();
                            comando.ExecuteNonQuery();
                            RefreshGrid();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }finally { 
                            conexao.Close(); 
                        }
                    }
                        
                        
                        
                        
                
                
            }
        }

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

        private void buttonPesquisar_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                conexao = new SqlConnection(sqlConnection);

                string palavra_chave = textBoxPesquisar.Text;
                string fPalavra_chave = "'%" + palavra_chave + "%'";
                string strSQL = "SELECT id_paciente AS FICHA, " +
                                        "p_nome AS NOME, " +
                                        "p_mae AS MÃE, " +
                                        "p_cpf AS CPF, " +
                                        "p_rg AS RG, " +
                                        "p_endereco AS ENDEREÇO, " +
                                        "p_cidade AS CIDADE, " +
                                        "p_fone AS TELEFONE, " +
                                        "p_nascimento AS NASCIMENTO, " +
                                        "p_data AS REGISTRO" +
                    " FROM Pacientes WHERE id_paciente LIKE " + fPalavra_chave +
                    " OR p_nome LIKE " + fPalavra_chave +
                    " OR p_mae LIKE " + fPalavra_chave +
                    " OR p_cpf LIKE " + fPalavra_chave +
                    " OR p_rg LIKE " + fPalavra_chave +
                    " OR p_endereco LIKE " + fPalavra_chave +
                    " OR p_cidade LIKE " + fPalavra_chave +
                    " OR p_fone LIKE " + fPalavra_chave +
                    " OR p_nascimento LIKE " + fPalavra_chave +
                    " OR p_data LIKE " + fPalavra_chave; 

                da = new SqlDataAdapter(strSQL, conexao);

                DataSet ds = new DataSet();

                conexao.Open();

                da.Fill(ds);

                dataGridViewPacientes.DataSource = ds.Tables[0];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }
            finally
            {
                //MessageBox.Show(palavra_chave);
                conexao.Close();
            }

            
            
        }

        private void maskedTextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            if ("9".Equals(maskedTextBoxTelefone.Text.Substring(5, 1)))
            {
                maskedTextBoxTelefone.Mask = "(99) 99999-9999";
            }
            else
            {
                maskedTextBoxTelefone.Mask = "(99) 9999-9999";
            }
        }

        private void dataGridViewPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0) // Pega a célula clicada para preenchimento dos campos
            {
                // int rowNumber = e.RowIndex + 1;

                DataGridViewRow row = dataGridViewPacientes.Rows[e.RowIndex];
                labelFichaNum.Text = row.Cells[0].Value.ToString();
                textBoxNome.Text = row.Cells[1].Value.ToString();
                textBoxMae.Text = row.Cells[2].Value.ToString();
                maskedTextBoxCpf.Text = row.Cells[3].Value.ToString();
                maskedTextBoxRg.Text = row.Cells[4].Value.ToString();
                textBoxEndereco.Text = row.Cells[5].Value.ToString();
                textBoxCidade.Text = row.Cells[6].Value.ToString();
                maskedTextBoxTelefone.Text = row.Cells[7].Value.ToString();
                dateTimePickerDataNascimento.Text = row.Cells[8].Value.ToString();
                dateTimePickerDataRegistro.Text = row.Cells[9].Value.ToString();



                //MessageBox.Show(firstCellValue.ToString());
            }
        }

        private void comboBoxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
            
        {

            string registro = labelFichaNum.Text;

            DialogResult result = MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR A FICHA: " + registro + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conexao = new SqlConnection(sqlConnection);

                    strSQL = "DELETE Pacientes WHERE id_paciente = @ID";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@ID", labelFichaNum.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    conexao.Close();
                    RefreshGrid();
                    labelFichaNum.Text = GetLastId();
                }
            }

            

        }
    }
}

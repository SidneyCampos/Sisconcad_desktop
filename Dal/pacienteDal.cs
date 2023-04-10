using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Sisconcad.Model;
using Microsoft.Win32;

namespace Sisconcad.Dal
{
    internal class pacienteDal
    {

        public DataTable listaPacientes(string qtdRegistros)
        {
            try
            {
                VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);
                VarGlobais.stringSql = "SELECT id_paciente AS FICHA, p_nome AS NOME, p_fone AS TELEFONE, " +
                    "p_cpf AS CPF, p_rg AS RG, p_endereco AS ENDERECO, p_cidade AS CIDADE,\r\n\t\t p_mae  AS MAE, " +
                    "p_nascimento AS DATA_DE_NASCIMENTO, p_data AS DATA_DE_REGISTRO\r\n\tFROM Pacientes " +
                    "ORDER BY id_paciente DESC OFFSET 0 ROWS FETCH FIRST @LIMIT ROWS ONLY;";
                VarGlobais.adapter = new SqlDataAdapter(VarGlobais.stringSql, VarGlobais.conn);
                VarGlobais.adapter.SelectCommand.Parameters.AddWithValue("@LIMIT", Int32.Parse(qtdRegistros));

                VarGlobais.dt = new DataTable();
                VarGlobais.adapter.Fill(VarGlobais.dt);
                return VarGlobais.dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                VarGlobais.conn.Close();
            }
        }

        public string GetLastId()
        {
            try
            {
                VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);
                VarGlobais.stringSql = "SELECT MAX(id_paciente) + 1 AS proximo_id FROM Pacientes";
                VarGlobais.conn.Open();
                VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);
                VarGlobais.reader = VarGlobais.cmd.ExecuteReader();
                if (VarGlobais.reader.Read())
                    VarGlobais.lastID = VarGlobais.reader["proximo_id"].ToString();

                return VarGlobais.lastID;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                VarGlobais.conn?.Close();
            }
        }

        public void salvarPaciente(pacienteModel paciente, bool isLastId)
        {
            if (isLastId)
            {
                try
                {
                    VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);

                    VarGlobais.stringSql = "INSERT INTO Pacientes (id_paciente, p_nome, p_mae, p_cpf, p_rg, p_endereco, p_cidade, p_fone, p_nascimento, p_data) VALUES (@ID_PACIENTE, @NOME, @MAE, @CPF, @RG, @ENDERECO, @CIDADE, @FONE, @NASCIMENTO, @DATA);";

                    VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);

                    VarGlobais.cmd.Parameters.AddWithValue("@ID_PACIENTE", paciente.Id);//Int32.Parse(guaranteeLastId));
                    VarGlobais.cmd.Parameters.AddWithValue("@NOME", paciente.Nome);
                    VarGlobais.cmd.Parameters.AddWithValue("@MAE", paciente.Mae);
                    VarGlobais.cmd.Parameters.AddWithValue("@CPF", paciente.Cpf);
                    VarGlobais.cmd.Parameters.AddWithValue("@RG", paciente.Rg);
                    VarGlobais.cmd.Parameters.AddWithValue("@ENDERECO", paciente.Endereco);
                    VarGlobais.cmd.Parameters.AddWithValue("@CIDADE", paciente.Cidade);
                    VarGlobais.cmd.Parameters.AddWithValue("@FONE", paciente.Fone);
                    VarGlobais.cmd.Parameters.AddWithValue("@NASCIMENTO", paciente.Nascimento);
                    VarGlobais.cmd.Parameters.AddWithValue("@DATA", paciente.Data);

                    VarGlobais.conn.Open();
                    VarGlobais.cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    VarGlobais.conn.Close();
                }
            } else
            {
                DialogResult result = MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR A FICHA: " + VarGlobais.IdAtual + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);

                        VarGlobais.stringSql = "UPDATE Pacientes SET p_nome = @NOME, p_mae = @MAE, " +
                        "p_cpf = @CPF, p_rg = @RG, p_endereco = @ENDERECO, " +
                        "p_cidade = @CIDADE, p_fone = @FONE, p_nascimento = @NASCIMENTO, p_data = @DATA " +
                        "WHERE id_paciente = @ID;";

                        VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);

                        VarGlobais.cmd.Parameters.AddWithValue("@ID", paciente.Id);
                        VarGlobais.cmd.Parameters.AddWithValue("@NOME", paciente.Nome);
                        VarGlobais.cmd.Parameters.AddWithValue("@MAE", paciente.Mae);
                        VarGlobais.cmd.Parameters.AddWithValue("@CPF", paciente.Cpf);
                        VarGlobais.cmd.Parameters.AddWithValue("@RG", paciente.Rg);
                        VarGlobais.cmd.Parameters.AddWithValue("@ENDERECO", paciente.Endereco);
                        VarGlobais.cmd.Parameters.AddWithValue("@CIDADE", paciente.Cidade);
                        VarGlobais.cmd.Parameters.AddWithValue("@FONE", paciente.Fone);
                        VarGlobais.cmd.Parameters.AddWithValue("@NASCIMENTO", paciente.Nascimento);
                        VarGlobais.cmd.Parameters.AddWithValue("@DATA", paciente.Data);


                        VarGlobais.conn.Open();
                        VarGlobais.cmd.ExecuteNonQuery();

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                    finally
                    {
                        VarGlobais.conn.Close();
                    }
                }
                    
            }
            
        }

        public DataTable pesquisaPaciente(string palavraChave)
        {
            try
            {
                string fPalavraChave = "'%" + palavraChave + "%'";
                VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);
                VarGlobais.stringSql = "SELECT id_paciente AS FICHA, " +
                                        "p_nome AS NOME, " +
                                        "p_fone AS TELEFONE, " +
                                        "p_cpf AS CPF, " +
                                        "p_rg AS RG, " +
                                        "p_endereco AS ENDEREÇO, " +
                                        "p_cidade AS CIDADE, " +
                                        "p_mae AS MÃE, " +
                                        "p_nascimento AS NASCIMENTO, " +
                                        "p_data AS REGISTRO" +
                    " FROM Pacientes WHERE id_paciente LIKE " + fPalavraChave +
                    " OR p_nome LIKE " + fPalavraChave +
                    " OR p_mae LIKE " + fPalavraChave +
                    " OR p_cpf LIKE " + fPalavraChave +
                    " OR p_rg LIKE " + fPalavraChave +
                    " OR p_endereco LIKE " + fPalavraChave +
                    " OR p_cidade LIKE " + fPalavraChave +
                    " OR p_fone LIKE " + fPalavraChave +
                    " OR p_nascimento LIKE " + fPalavraChave +
                    " OR p_data LIKE " + fPalavraChave;
                VarGlobais.adapter = new SqlDataAdapter(VarGlobais.stringSql, VarGlobais.conn);

                VarGlobais.dt = new DataTable();
                VarGlobais.adapter.Fill(VarGlobais.dt);
                return VarGlobais.dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                VarGlobais.conn.Close();
            }
        }

        public void excluirPaciente(int id)
        {
            DialogResult result = MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR A FICHA: " + id + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);

                    VarGlobais.stringSql = "DELETE Pacientes WHERE id_paciente = @ID";

                    VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);

                    VarGlobais.cmd.Parameters.AddWithValue("@ID", id);

                    VarGlobais.conn.Open();
                    VarGlobais.cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    VarGlobais.conn.Close();
                }
            }
        }
    }
}
 
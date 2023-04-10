using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Sisconcad.Model;

namespace Sisconcad.Dal
{
    internal class consultaDal
    {
        public string GetLastIdConsulta()
        {
            try
            {
                VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);
                VarGlobais.stringSql = "SELECT MAX(id_consulta) + 1 AS proximo_id FROM Consultas";
                VarGlobais.conn.Open();
                VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);
                VarGlobais.reader = VarGlobais.cmd.ExecuteReader();
                if (VarGlobais.reader.Read())
                    VarGlobais.lastIDConsulta = VarGlobais.reader["proximo_id"].ToString();

                return VarGlobais.lastIDConsulta;
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

        public DataTable listaConsultas(string id)
        {
            try
            {

                VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);
                VarGlobais.stringSql = "SELECT Consultas.id_consulta AS 'Nº', " +
                    "Consultas.c_dataConsulta AS DATA, Consultas.c_queixaPessoal AS 'QUEIXA PESSOAL', Consultas.c_condutaConsulta AS CONDUTA, " +
                    "Consultas.c_historicoPessoal AS 'HISTÓRICO PESSOAL', Consultas.c_historicoFamiliar AS 'HISTÓRICO FAMILIAR', " +
                    "Consultas.c_acuidadeOd AS 'ACUIDADE OLHO DIREITO', Consultas.c_acuidadeOe AS 'ACUIDADE OLHO ESQUERDO', " +
                    "Consultas.c_bioOd AS 'BIO OLHO DIREITO', Consultas.c_bioOe AS 'BIO OLHO ESQUERDO', Consultas.c_fundoOlhoOd AS 'FUNDO DO OLHO DIREITO', " +
                    "Consultas.c_fundoOlhoOe AS 'FUNDO DO OLHO ESQUERDO', Consultas.c_pressaoOcularOd AS 'PRESSÃO OCULAR OLHO DIREITO', " +
                    "Consultas.c_pressaoOcularOe AS 'PRESSAO OCULAR OLHO ESQUERDO', Consultas.c_geral AS GERAL " +
                    "FROM Consultas " +
                    "INNER JOIN Pacientes ON Consultas.id_paciente = Pacientes.id_paciente " +
                    "WHERE Pacientes.id_paciente = @ID;";
                VarGlobais.adapter = new SqlDataAdapter(VarGlobais.stringSql, VarGlobais.conn);
  
                VarGlobais.adapter.SelectCommand.Parameters.AddWithValue("@ID", Int32.Parse(id));

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

        public void salvarConsulta(consultaModel consulta, bool eNovaConsulta)
        {
            if (eNovaConsulta)
            {
                try
                {
                    VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);


                    VarGlobais.stringSql = "INSERT INTO Consultas (id_paciente, c_queixaPessoal, c_historicoPessoal, c_historicoFamiliar, c_acuidadeOd, c_acuidadeOe, c_bioOd, c_bioOe, c_fundoOlhoOd, c_fundoOlhoOe, c_pressaoOcularOd, c_pressaoOcularOe, c_condutaConsulta, c_geral, c_dataConsulta) VALUES (@ID, @QP, @HP, @HF, @AOD, @AOE, @BOD, @BOE, @FOOD, @FOOE, @POOD, @POOE, @CC, @G, @DC)";

                    VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);

                    VarGlobais.cmd.Parameters.AddWithValue("@ID", VarGlobais.IdAtual);
                    VarGlobais.cmd.Parameters.AddWithValue("@QP", consulta.QueixaPessoal);
                    VarGlobais.cmd.Parameters.AddWithValue("@HP", consulta.HistoricoPessoal);
                    VarGlobais.cmd.Parameters.AddWithValue("@HF", consulta.HistoricoFamiliar);
                    VarGlobais.cmd.Parameters.AddWithValue("@AOD", consulta.AcuidadeOd);
                    VarGlobais.cmd.Parameters.AddWithValue("@AOE", consulta.AcuidadeOe);
                    VarGlobais.cmd.Parameters.AddWithValue("@BOD", consulta.BioOd);
                    VarGlobais.cmd.Parameters.AddWithValue("@BOE", consulta.BioOe);
                    VarGlobais.cmd.Parameters.AddWithValue("@FOOD", consulta.FundoOlhoOd);
                    VarGlobais.cmd.Parameters.AddWithValue("@FOOE", consulta.FundoOlhoOe);
                    VarGlobais.cmd.Parameters.AddWithValue("@POOD", consulta.PressaoOcularOd);
                    VarGlobais.cmd.Parameters.AddWithValue("@POOE", consulta.PressaoOcularOe);
                    VarGlobais.cmd.Parameters.AddWithValue("@CC", consulta.CondutaConsulta);
                    VarGlobais.cmd.Parameters.AddWithValue("@G", consulta.Geral);
                    VarGlobais.cmd.Parameters.AddWithValue("@DC", consulta.DataConsulta);

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
            else
            {
                DialogResult result = MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR A CONSULTA DA FICHA: " + VarGlobais.IdAtual + " ?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);

                        VarGlobais.stringSql = "UPDATE consultas SET c_queixaPessoal = @QP, c_historicoPessoal = @HP, " +
                        "c_historicoFamiliar = @HF, c_acuidadeOd = @AOD, c_acuidadeOe = @AOE, c_bioOd = @BOD, c_bioOe = @BOE, "  +
                        "c_fundoOlhoOd = @FOOD, c_fundoOlhoOe = @FOOE, c_pressaoOcularOd = @POOD, c_pressaoOcularOe = @POOE, c_condutaConsulta = @CC, " +
                        "c_geral = @G, c_dataConsulta = @DC " +
                        "WHERE id_consulta = @ID";

                        VarGlobais.cmd = new SqlCommand(VarGlobais.stringSql, VarGlobais.conn);

                        VarGlobais.cmd.Parameters.AddWithValue("@ID", VarGlobais.consultaRow.Cells[0].Value.ToString());
                        VarGlobais.cmd.Parameters.AddWithValue("@QP", consulta.QueixaPessoal);
                        VarGlobais.cmd.Parameters.AddWithValue("@HP", consulta.HistoricoPessoal);
                        VarGlobais.cmd.Parameters.AddWithValue("@HF", consulta.HistoricoFamiliar);
                        VarGlobais.cmd.Parameters.AddWithValue("@AOD", consulta.AcuidadeOd);
                        VarGlobais.cmd.Parameters.AddWithValue("@AOE", consulta.AcuidadeOe);
                        VarGlobais.cmd.Parameters.AddWithValue("@BOD", consulta.BioOd);
                        VarGlobais.cmd.Parameters.AddWithValue("@BOE", consulta.BioOe);
                        VarGlobais.cmd.Parameters.AddWithValue("@FOOD", consulta.FundoOlhoOd);
                        VarGlobais.cmd.Parameters.AddWithValue("@FOOE", consulta.FundoOlhoOe);
                        VarGlobais.cmd.Parameters.AddWithValue("@POOD", consulta.PressaoOcularOd);
                        VarGlobais.cmd.Parameters.AddWithValue("@POOE", consulta.PressaoOcularOe);
                        VarGlobais.cmd.Parameters.AddWithValue("@CC", consulta.CondutaConsulta);
                        VarGlobais.cmd.Parameters.AddWithValue("@G", consulta.Geral);
                        VarGlobais.cmd.Parameters.AddWithValue("@DC", consulta.DataConsulta);


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

        public void excluirConsulta(int id)
        {  
                try
                {
                    VarGlobais.conn = new SqlConnection(VarGlobais.sqlConnection);

                    VarGlobais.stringSql = "DELETE Consultas WHERE id_consulta = @ID";

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

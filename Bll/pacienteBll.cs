using Sisconcad.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sisconcad.Model;

namespace Sisconcad.Bll
{
    internal class pacienteBll
    {
        pacienteDal pacientedal = null;



        public DataTable listaPacientesDal(string qtdRegistros)
        {
            VarGlobais.dt = new DataTable();
            try
            {
                pacientedal = new pacienteDal();
                VarGlobais.dt = pacientedal.listaPacientes(qtdRegistros);
            }
            catch (Exception)
            {

                throw;
            }
            return VarGlobais.dt;
        }

        public string getLastIdDal()
        {
            try
            {
                pacientedal = new pacienteDal();
                VarGlobais.lastID = pacientedal.GetLastId();
            }
            catch (Exception)
            {

                throw;
            }
            return VarGlobais.lastID;
        }

        public void salvarPacienteDal(pacienteModel paciente, bool isLastId)
        {
            try
            {
                pacientedal = new pacienteDal();
                pacientedal.salvarPaciente(paciente, isLastId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable pesquisaPacientesDal(string palavraChave)
        {
            VarGlobais.dt = new DataTable();
            try
            {
                pacientedal = new pacienteDal();
                VarGlobais.dt = pacientedal.pesquisaPaciente(palavraChave);
            }
            catch (Exception)
            {

                throw;
            }
            return VarGlobais.dt;
        }

        public void excluirPacientesDal(int id)
        {
            try
            {
                pacientedal = new pacienteDal();
                pacientedal.excluirPaciente(id);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

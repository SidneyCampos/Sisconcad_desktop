using Sisconcad.Dal;
using Sisconcad.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisconcad.Bll
{
    internal class consultaBll
    {
        consultaDal consultadal = null;

        public string getLastIdConsultaDal()
        {
            try
            {
                consultadal = new consultaDal();
                VarGlobais.lastID = consultadal.GetLastIdConsulta();
            }
            catch (Exception)
            {

                throw;
            }
            return VarGlobais.lastIDConsulta;
        }

        public DataTable listaConsultasDal(string id)
        {
            VarGlobais.dt = new DataTable();
            try
            {
                consultadal = new consultaDal();
                VarGlobais.dt = consultadal.listaConsultas(id);
            }
            catch (Exception)
            {

                throw;
            }
            return VarGlobais.dt;
        }

        public void salvarConsultaDal(consultaModel consulta, bool eNovaFicha)
        {
            try
            {
                consultadal = new consultaDal();
                consultadal.salvarConsulta(consulta, eNovaFicha);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void excluirConsultasDal(int id)
        {
            try
            {
                consultadal = new consultaDal();
                consultadal.excluirConsulta(id);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

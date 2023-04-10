using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisconcad
{
    public static class VarGlobais
    {


        // ---------- VARIÁVEIS GLOBAIS ----------
        // public static string sqlConnection = "Server = DESKTOP-GVVKSFK\\SQLEXPRESS; Database = db_sisconcad; User Id=sa; Password=1234;";
        // public static string sqlConnection = "Data Source = 192.168.100.199,59148; Database = db_sisconcad; User Id=sa; Password=1234;";
        public static string sqlConnection = "Data Source = 192.168.100.199,1433; Initial Catalog = db_sisconcad; Persist Security Info=True;User ID = sa; Password=1234;";

        
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataAdapter adapter = null;
        public static SqlDataReader reader = null;
        public static DataTable dt = null;
        public static DataGridViewRow consultaRow = null; // Transporta conteúdo de um Form para outro
        public static string stringSql = null;
        public static string lastID = null;
        public static string lastIDConsulta = "";
        public static string IdAtual = "";
        public static string IdConsultaAtual = "";
        public static string nomeAtual = "";
        public static bool eNovaConsulta = false;
        public static bool eFichaCompleta = false;
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisconcad.Model
{
    internal class consultaModel
    {
        int id_consulta;
        int id_paciente;
        string p_nome;
        string queixaPessoal;
        string historicoPessoal;
        string historicoFamiliar;
        string acuidadeOd;
        string acuidadeOe;
        string bioOd;
        string bioOe;
        string fundoOlhoOd;
        string fundoOlhoOe;
        string pressaoOcularOd;
        string pressaoOcularOe;
        string condutaConsulta;
        string geral;
        string dataConsulta;

        public int Id_consulta { get => id_consulta; set => id_consulta = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string P_nome { get => p_nome; set => p_nome = value; }
        public string QueixaPessoal { get => queixaPessoal; set => queixaPessoal = value; }
        public string HistoricoPessoal { get => historicoPessoal; set => historicoPessoal = value; }
        public string HistoricoFamiliar { get => historicoFamiliar; set => historicoFamiliar = value; }
        public string AcuidadeOd { get => acuidadeOd; set => acuidadeOd = value; }
        public string AcuidadeOe { get => acuidadeOe; set => acuidadeOe = value; }
        public string BioOd { get => bioOd; set => bioOd = value; }
        public string BioOe { get => bioOe; set => bioOe = value; }
        public string FundoOlhoOd { get => fundoOlhoOd; set => fundoOlhoOd = value; }
        public string FundoOlhoOe { get => fundoOlhoOe; set => fundoOlhoOe = value; }
        public string PressaoOcularOd { get => pressaoOcularOd; set => pressaoOcularOd = value; }
        public string PressaoOcularOe { get => pressaoOcularOe; set => pressaoOcularOe = value; }
        public string CondutaConsulta { get => condutaConsulta; set => condutaConsulta = value; }
        public string Geral { get => geral; set => geral = value; }
        public string DataConsulta { get => dataConsulta; set => dataConsulta = value; }
        
    }
}

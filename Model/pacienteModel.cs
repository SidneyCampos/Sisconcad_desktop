using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisconcad.Model
{
    internal class pacienteModel
    {
        int id;
        string nome;
        string mae;
        string cpf;
        string rg;
        string endereco;
        string cidade;
        string fone;
        string nascimento;
        string data;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Mae { get => mae; set => mae = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Fone { get => fone; set => fone = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Data { get => data; set => data = value; }
    }
}

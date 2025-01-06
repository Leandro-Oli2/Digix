using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public class Endereco
    {
        public string? Rua { get; set; }
        public string Cidade { get; set; }
        public string? Estado { get; set; }
        public int? CEP { get; set; }

        public Endereco(string rua, string cidade, string estado, int cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep; 
        }
        public Endereco()
        {
        }
    }
}

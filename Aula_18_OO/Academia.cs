using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO
{
    public class Academia
    {
        public string Nome { get; set; }

        public double Mensalidade { get; set; }

        public Academia()
        {
        }

        public Academia(string nome, double mensalidade){
            Nome = nome;
            Mensalidade = mensalidade;
        }
    }
}
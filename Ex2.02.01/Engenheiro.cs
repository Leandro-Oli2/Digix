using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class Engenheiro : Pessoa
    {
        public int crea { get; set; }

        public Engenheiro(string nome, int cpf, int crea) : base(nome, cpf)
        {
            this.crea = crea;
        }
    }
}
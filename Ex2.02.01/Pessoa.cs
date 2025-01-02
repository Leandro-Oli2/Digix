using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int cpf { get; set; }

        public Pessoa(string nome, int cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
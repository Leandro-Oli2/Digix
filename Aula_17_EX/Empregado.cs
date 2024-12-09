using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Aula_17_EX
{
    public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;

        public string Cpf;

        public Empregado(string Nome, string Sobrenome, string Cpf){
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Cpf = Cpf;
        }

        public abstract double Vencimento();
    }
}
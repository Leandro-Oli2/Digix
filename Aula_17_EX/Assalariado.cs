using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX
{
    public class Assalariado : Empregado
    {
        public double Salario;

        public Assalariado(string nome, string Sobrenome, string Cpf, double salario) : base(nome, Sobrenome, Cpf)
        {
            this.Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }
    }
}
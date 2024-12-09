using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX
{
    public class Horista : Empregado
    {
        public double precoHora;
        public double horasTrabalhadas;
        public Horista(string nome, string Sobrenome, string cpf, double precoHora, double horasTrabalhadas) : base(nome, Sobrenome, cpf)
        {
            this.precoHora = precoHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double Vencimento()
        {
            return precoHora * horasTrabalhadas;
        }
    }
}
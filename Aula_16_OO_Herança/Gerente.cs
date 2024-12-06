using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Herança
{
    public class Gerente : Funcionario
    {
        public string Setor;
        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario)
        {
            // base é utilizado para chamar o construtor da classe pai
            this.Setor = setor;
        }

        //metodo 
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
        public override void ImprimirSaida(){
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("CPF: " + CPF);
            System.Console.WriteLine("Salario: " + Salario);
            System.Console.WriteLine("Setor: " + Setor);
            System.Console.WriteLine("Bonificacao: " + GetBonificacao());
        }
    }
}
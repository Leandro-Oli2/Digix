using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Herança
{
    public class Secretaria : Funcionario
    {
        public string Ramal;

        public Secretaria(string nome, string cpf, double salario, string ramal) : base(nome, cpf, salario){
            this.Ramal = ramal;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void ImprimirSaida()
        {
            System.Console.WriteLine("Nome: "+ Nome);
            System.Console.WriteLine("CPF: "+ CPF);
            System.Console.WriteLine("Salário: "+ Salario);
            System.Console.WriteLine("Ramal: "+ Ramal);
            System.Console.WriteLine("Bonificação: "+ GetBonificacao());
        }

        public void AtenderTelefone(){
            System.Console.WriteLine("Atendendo Telefone");
        }
    }
}
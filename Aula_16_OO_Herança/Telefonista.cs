using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Herança
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho;


        public Telefonista(string nome, string cpf, double salario, string EstacaoDeTrabalho) : base(nome, cpf, salario){
            this.EstacaoDeTrabalho = EstacaoDeTrabalho;
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
            System.Console.WriteLine("Estação de Trabalho: "+ EstacaoDeTrabalho);
            System.Console.WriteLine("Bonificação: "+ GetBonificacao());
        }

        public void AtenderTelefone(){
            System.Console.WriteLine("Atendendo Telefone");
        }
    }
}
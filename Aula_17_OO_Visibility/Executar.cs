using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibility
{
    public class Executar
    {
          static void Main(string [] args){
            
            Funcionarios funcionario = new Funcionarios("Jonas", 2000, "Analista");
            Console.WriteLine("Funcionario:" + funcionario.Nome);
            funcionario.Nome = "Áticos";
            Console.WriteLine("Funcionario:" + funcionario.Nome);
            

            Gerente gerente = new Gerente("Maria", 5000);
            Console.WriteLine("Gerente:" + gerente.Nome);
            gerente.Nome = "Carlos";
            gerente.Nome = "Beatriz";
            Console.WriteLine("Gerente:" + gerente.Nome);
            gerente.AtualizarCargoGerente("Diretor");

            // gerente.CalcularImpostoGerente(); "erro, porque é privado"

        }

    }
}
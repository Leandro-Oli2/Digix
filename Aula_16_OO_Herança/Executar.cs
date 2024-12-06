using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Herança
{
    public class Executar
    {
        static void Main(string[] args){
            Gerente g1 = new Gerente("Rafael", "109.465.231-33", 5000, "TI");
            System.Console.WriteLine("Salario do Gerente: "+g1.Salario);
            System.Console.WriteLine("Mostrar a Bonificação: "+g1.GetBonificacao());
            g1.ImprimirSaida();

            
        }
    }
}
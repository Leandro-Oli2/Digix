using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Caminhao caminhao = new Caminhao("Volvo", "FH", "ABC-1234", 500m, 50m, 4);
            Carro carro = new Carro("Toyota", "Corolla", "DEF-5678", 200m, 20m, "A");
            Utilitario utilitario = new Utilitario("Fiat", "Ducato", "GHI-9101", 300m, 30m);
            Moto moto = new Moto("Honda", "CB500", "JKL-1121", 100m, 10m, 500);

            Console.WriteLine($"Caminhão Aluguel: R${caminhao.CalcularAluguel()}");
            Console.WriteLine($"Carro Aluguel: R${carro.CalcularAluguel()}");
            Console.WriteLine($"Utilitário Aluguel: R${utilitario.CalcularAluguel()}");
            Console.WriteLine($"Moto Aluguel: R${moto.CalcularAluguel()}");

            Console.ReadLine();
        }
    }
}
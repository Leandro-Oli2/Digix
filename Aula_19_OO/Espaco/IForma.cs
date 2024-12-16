using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();


        // esse tipo de declaração de função
        void ExibirInformacoes(){
            Console.WriteLine($"Area: {CalcularArea()}");
            Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
    }
}
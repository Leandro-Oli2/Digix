using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO.Espaco
{
    public class Circulo : IForma
    {
        public double Raio { get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public void ExibirInformacoes(){
            Console.WriteLine($"Nome: Circulo, \nRaio: {Raio}, \nArea: {CalcularArea():F2}, \nPerímetro: {CalcularPerimetro():F2}");
        }
    }
}
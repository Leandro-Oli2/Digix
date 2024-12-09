using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Abstract
{
    public class Circulo : Forma
    {
        public double Raio;
        public Circulo(string nome, double raio) : base(nome)
        {
            this.Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.Raio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, Raio: {Raio}, Area: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}");
        }
    }
}
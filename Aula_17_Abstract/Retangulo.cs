using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Abstract
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;
        
        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }
        
        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
        
        public override void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}, \nArea: {CalcularArea()}, \nPerímetro: {CalcularPerimetro()}"); 
        }

    }
}
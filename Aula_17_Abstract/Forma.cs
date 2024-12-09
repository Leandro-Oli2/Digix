using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Abstract
{
    public abstract class Forma
    {
        public string Nome;

        public Forma(string nome){
            Nome = nome;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual void ImprimirDados(){
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Area: {CalcularArea()}");
            Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
        
        
    }
}
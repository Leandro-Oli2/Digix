using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public abstract class Animalia
    {
        public abstract string Reino { get; }
        public abstract string Filo { get; }
        public abstract string Classe { get; }
        public abstract string Ordem { get; }
        public abstract string Familia { get; }
        public abstract string Genero { get; }
        public abstract string Especie { get; }

        public virtual void obterDescricao(){
            Console.WriteLine($"Reino: {Reino}");
            Console.WriteLine($"Filo: {Filo}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Ordem: {Ordem}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Especie: {Especie}");
        }
         
    }
}
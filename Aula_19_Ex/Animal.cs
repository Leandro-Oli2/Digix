using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public class Animal
    {
        protected int Pernas = 0;

        public Animal()
        {
            
        }
        public virtual void Andar()
        {
            Console.WriteLine("Animal andando");
        }
        public virtual void Comer()
        {
            Console.WriteLine("Animal Comendo");
        }
    }
}
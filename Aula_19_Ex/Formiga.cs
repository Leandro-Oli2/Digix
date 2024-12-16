using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public class Formiga : Animal
    {
        public Formiga(){
            Console.WriteLine("Formiga criada!");
        }
        public override void Comer(){
            Console.WriteLine("Formiga comeu!");
        }
    }
}
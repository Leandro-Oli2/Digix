using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO
{
    public class Professor
    {
        public string Name { get; set; }

        public Professor(string name){
            Name = name;
        }
        public void Ensinar(){
            Console.WriteLine($"Professor: {Name} esta ensinando..." );
        }
    }
}
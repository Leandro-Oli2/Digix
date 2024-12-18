using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO
{
    public class Estudante
    {
        public string Nome { get; set; }
        
        public Estudante(string nome){
            Nome = nome;
        }
        public void MostrarInfo(){
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}
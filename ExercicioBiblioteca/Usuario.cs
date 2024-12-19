using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Usuario
    {
        public string Name { get; set; }
        public string Cpf { get; set; }

        public Usuario( string name, string cpf ){
            Name = name;
            Cpf = cpf;
        }

        public void GetInformacoes(){
            Console.WriteLine($"Nome: {Name}, CPF: {Cpf}");
        }
    }
}
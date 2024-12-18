using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class Gerente : Funcionario
    {
        public double Salario { get; set; }
        public Gerente(string nome, string nascimento, string cpf) : base(nome, nascimento, cpf)
        {
              
        }
        public void GetSalario(){
            Console.WriteLine($"Nome: {Nome}, Salario: {Salario}");
        }
    }
}
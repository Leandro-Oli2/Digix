using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public virtual void Salario(double salario){
            Console.WriteLine($"O salário base do funcionário {Nome} é R${salario}");
        }
        public virtual void Trabalhar(){
            Console.WriteLine($"O funcionário {Nome} está trabalhando...");
        }
        
    }
}
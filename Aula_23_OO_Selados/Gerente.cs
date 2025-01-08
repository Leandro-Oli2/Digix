using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public sealed class Gerente : Funcionario
    //selead é o final do java. Ou seja não pode ser herdado.
    {
        public override void Salario(double salario)
        {
            Console.WriteLine("Salario base: "+ salario* 1.5);
        }
        public override void Trabalhar()
        {
            Console.WriteLine("Gerenciando...");
        }
    }
}
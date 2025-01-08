using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Instrutor : Cordenador
    {
        public override void Salario(double salario)
        {
            Console.WriteLine("Salario base: "+ salario* 1.0);
        }
    }
}
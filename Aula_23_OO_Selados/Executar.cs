using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selados
{
    public class Executar
    {
        static void Main(string[] args){
            Funcionario f = new Funcionario();
            f.Salario(2000);
            f.Trabalhar();

            Cordenador c = new Cordenador();
            c.Salario(3000);
            c.Trabalhar();

            // Gerente g = new Gerente();
            // g.Salario(4000);
            // g.Trabalhar(); = Gerente é selead

            Instrutor i = new Instrutor();
            i.Salario(5000);
            i.Trabalhar();

            

        }
    }
}
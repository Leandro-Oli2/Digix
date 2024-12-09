using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX
{
    public class Executar
    {
        static void Main(string[] args){
            Assalariado a1 = new Assalariado("Leandro", "Oliveira", "109.545.555-32", 5000.32);
            System.Console.WriteLine($"Salario do Assalariado {a1.Nome} foi de: " + a1.Vencimento());
            Comissario c1 = new Comissario("Leonardo", "Silva", "109.545.555-32", 300, 20);
            System.Console.WriteLine($"Salario do Comissario {c1.Nome} foi de: " + c1.Vencimento());
            Horista h1 = new Horista("Claudio", "Santos", "109.545.555-32", 150, 40);
            System.Console.WriteLine($"Salario do Horista {h1.Nome} foi de: " + h1.Vencimento());
        }
    }
}
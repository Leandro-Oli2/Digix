using System;
using System.Security.Cryptography.X509Certificates;
namespace Aula_3
{
    class Programa3
    {
        static void sla(String[] args)
        {
            int idade = 20;
            switch(idade){
                case int n when n >= 18 && n <= 50:
                    System.Console.WriteLine("Adulto");
                    break;
                case int n when n >= 50 && n <= 100:
                    System.Console.WriteLine("Idoso");
                    break;
                case int n when n > 100:
                    System.Console.WriteLine("Ja morreu");
                    break;
                default:
                    System.Console.WriteLine("Criança");
                    break;
            }
        }
    }
}
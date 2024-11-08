using System;

namespace Exemplo_7
{
    class Triangulo
    {
        static void tri(String[] args)
        {
            Console.WriteLine("Informe o valor de altura: ");
            double alt = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Informe o valor do Base: ");
            double bas = double.Parse(System.Console.ReadLine());
            double hip = (bas*alt)/2;
            Console.WriteLine($"A area do triangulo eh: {hip:F2}");
        }
    }
}
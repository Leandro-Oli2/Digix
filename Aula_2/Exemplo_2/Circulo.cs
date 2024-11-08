using System;

namespace Exemplo_4
{
    class Circulo
    {
        static void Circ(String[] args)
        {
            Console.WriteLine("Informe o valor de pi: ");
            double pi = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Informe o valor do Raio: ");
            double raio = double.Parse(System.Console.ReadLine());
            double alt = 0;
            alt = pi*(Math.Pow(raio,2));
            Console.WriteLine($"A area do circulo eh: {alt:F2}");
        }
    }
}
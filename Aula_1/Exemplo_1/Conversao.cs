using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Exemplo
{
    internal class Programa11
    {
        static void Main(String[] args)
        {
            String produto1 = "Computador";
            String produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int cod = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preco é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preco é ${preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"\nRegistro: {idade} anos de idade, codigo {cod} e genero: {genero}");
            Console.WriteLine();
            decimal m = (decimal) medida;
            Console.Write($"\nMedida com oito casas decimais: {medida:F8}");
            Console.Write($"\nArredondado (Três casas decimais): {medida:F3}");
            Console.Write($"\nSeparador decimal invariant culture: {m.ToString("F3",CultureInfo.InvariantCulture)}");

        
        }
    }
}
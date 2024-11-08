using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace Exemplo
{
    internal class Programa
    {
        static void Main1(String[] args)
        {
            String produto1 = "Computador";
            String produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int cod = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine(medida.GetType());
            Console.WriteLine(produto1.GetType());
            Console.WriteLine(produto2.GetType());
            Console.WriteLine(idade.GetType());
            Console.WriteLine(cod.GetType());
            Console.WriteLine(genero.GetType());
            Console.WriteLine(preco1.GetType());
            Console.WriteLine(preco2.GetType());

            // int[] array = new int[5];

        
        }
    }
}
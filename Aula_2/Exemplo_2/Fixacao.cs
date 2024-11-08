using System;

namespace Exemplo_3
{
    class Fixacao
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Informe sue nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa: ");
            int qtd = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double preco = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
            string nomef = Console.ReadLine();
            int idade = int.Parse(System.Console.ReadLine());
            double alt = double.Parse(System.Console.ReadLine());

            Console.WriteLine("========= SAIDA =========");
            Console.WriteLine(nome);
            Console.WriteLine(qtd);
            Console.WriteLine($"{preco:F2}");
            Console.WriteLine(nomef);
            Console.WriteLine(idade);
            Console.WriteLine(alt);
        }
    }
}
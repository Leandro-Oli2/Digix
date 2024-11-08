using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace aula_4
{
    class Programa_4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Informe um valor inicial: ");
            double preco = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Informe o tipo de Investimento: ");
            Console.WriteLine("1 - Poupanca ");
            Console.WriteLine("2 - Renda Fixa ");
            Console.WriteLine("3 - Acoes ");
            int tipo = int.Parse(System.Console.ReadLine());
            switch(tipo){
                case 1:
                    Console.WriteLine("=========== POUPANCA ============");
                    Console.WriteLine("Tempo de Investimento: ");
                    int temp = int.Parse(System.Console.ReadLine());
                    double tax = 0.03;
                    double n = tax/temp;
                    for(int x = 1; x <= temp; x++){
                    preco *= 1 + n;
                    Console.WriteLine($"O montante final apos {x} meses eh: {preco:F2}");
                    }
                    break;
                case 2:
                    Console.WriteLine("=========== RENDA FIXA ============");
                    Console.WriteLine("Tempo de Investimento: ");
                    int tempo = int.Parse(System.Console.ReadLine());
                    double t = 0.05;
                    for(int u = 1; u<=tempo; u++){
                        preco *= 1+t;
                        Console.WriteLine($"O Total apos {tempo} anos eh: R${preco:F2}");
                    }
                    break;
                case 3:
                    Console.WriteLine("=========== ACOES ============");
                    Console.WriteLine("Tempo de Investimento: ");
                    int tempoa = int.Parse(System.Console.ReadLine());
                    double taxa = 0.10;
                    Random random = new Random();
                    for(int i = 1; i<=tempoa; i++){
                        int chance = random.Next(1, 100);
                        if(chance <= 50){
                            preco -= preco*0.05;
                            Console.WriteLine($"Ano {i}: Perda de 5%, Capital: {preco:F2} ");
                        }
                        else{
                            preco += preco * taxa;
                            Console.WriteLine($"Ano {i}: Rendimeno de 10%, Capital: {preco:F2} ");
                        }
                    }
                    Console.WriteLine($"Total apos {tempoa} anos: R${preco:F2} ");
                    break;
            }
        }
    }
}
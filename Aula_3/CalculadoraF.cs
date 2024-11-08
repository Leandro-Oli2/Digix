using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace aula3
{
    class Programa_3
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
                    double m = preco*Math.Pow(1 + n, temp);
                    Console.WriteLine($"O montante final apos {temp} meses eh: {m:F2}");
                    break;
                case 2:
                    Console.WriteLine("=========== RENDA FIXA ============");
                    Console.WriteLine("Tempo de Investimento: ");
                    int tempo = int.Parse(System.Console.ReadLine());
                    double t = 0.05; 
                    double tot = preco * Math.Pow(1 + t, tempo);
                    Console.WriteLine($"O Total apos {tempo} anos eh: R${tot:F2}");
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
                            Console.WriteLine($"Ano {i}: Rendimento de 10%, Capital: {preco:F2} ");
                        }
                    }
                    Console.WriteLine($"Total apos {tempoa} anos: R${preco:F2} ");
                    break;
            }
        }
    }
}
using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int[] vet = new int[10];
            for(int i = 0; i < 10; i++){
                Console.WriteLine($"Informe o numero {i}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j <10; j++){
                soma += vet[j];
            }
            double media = 0;
            media = soma/10;
            System.Console.WriteLine($"A Media dos numeros no vetor eh: {media}");
        }
    }
}
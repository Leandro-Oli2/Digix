using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont = 0;
           int soma = 0;
           int soma2 = 0;
           int k = 0; 
           int l = 0;
           int[,] mat = new int[4,4];
           for(int i = 0; i < 4; i++){
               for(int j = 0; j < 4; j++){
                   Console.WriteLine($"Informe o numero da posicao [{i}] [{j}]: ");
                   mat[i,j] = int.Parse(Console.ReadLine());
               }
           }
           while(cont < 4){
               soma += mat[k, l];
               cont += 1;
               k += 1;
               l += 1;
           }
           cont = 0;
           l = 3;
           k = 0;
           while(cont < 4){
               soma2 += mat[k, l];
               cont += 1;
               k += 1;
               l -= 1;
           }
           int result = soma + soma2;
           Console.WriteLine($"A soma da Diagonal Principal Com A Segundaria eh: {result} ");
        }
    }
}
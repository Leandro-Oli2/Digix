using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
           int soma = 0;
           int[,] mat = new int[4,4];
           for(int i = 0; i < 4; i++){
               for(int j = 0; j <4; j++){
                    Console.WriteLine($"Informe o numero da posicao [{i}] [{j}]: ");
                    mat[i,j] = int.Parse(Console.ReadLine());
               }
           }
           for(int i = 0; i < 4; i++){
               for(int j = 0; j <4; j++){
                    soma += mat[i,j];
               }
           }
           System.Console.WriteLine($"A Soma dos numeros na Matriz 4x4 eh: {soma}");
        }
    }
}
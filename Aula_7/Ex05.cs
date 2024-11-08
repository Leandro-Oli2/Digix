using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] mat = new int[4,4];
           for(int i = 0; i < 4; i++){
               for(int j = 0; j < 4; j++){
                   Console.WriteLine($"Informe o numero da posicao [{i}] [{j}]: ");
                   mat[i,j] = int.Parse(Console.ReadLine());
               }
           }
           Console.WriteLine("Matriz Padrao: ");
           for(int i = 0; i < 4; i++){
               for(int j = 0; j < 4; j++){
                   Console.Write($"[{mat[i,j]}]");
               }
               Console.WriteLine("");
           }
           int[,] mat1 = new int[4,4];
           for(int i = 0; i < 4; i++){
               for(int j = 0; j < 4; j++){
                   mat1[j, 3-i] = mat[i,j];
               }
           }
           Console.WriteLine("Matriz Rotacionada: ");
           for(int i = 0; i < 4; i++){
               for(int j = 0; j < 4; j++){
                   Console.Write($"[{mat1[i,j]}]");
               }
               Console.WriteLine("");
           }
        }
    }
}
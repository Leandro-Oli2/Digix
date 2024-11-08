using System;
using System.Runtime.InteropServices;
class Matriz03{
  static void Main(string[] args) {
    int i = 0;
    int j = 0;
    int[,] vet3 = new int[4,4];
    System.Console.WriteLine($"Informe um numero da matriz[{i}][{j}]: ");
    vet3[i,j] = int.Parse(Console.ReadLine());
    int maior = vet3[i,j];
    int menor = vet3[i,j];
    for(int v = 1; v < 4; v++){
            for(int z = 1; z < 4; z++){
            System.Console.WriteLine($"Informe um numero da matriz[{z}][{v}]: ");
            vet3[v,z] = int.Parse(Console.ReadLine());
            if(vet3[v,z] > maior){
                maior = vet3[v,z];
            }else if(vet3[v,z] < menor){
                menor = vet3[v,z];
            }
        }
    }
    int soma = maior + menor;
    System.Console.WriteLine($"A soma do maior com o menor numero eh: {soma}");
  }
}
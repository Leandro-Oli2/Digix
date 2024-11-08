using System;
class Matriz04{
  static void Main111() {
    int i = 0;
    int j = 0;
    int soma = 0;
    int[,] vet3 = new int[4,4];
    System.Console.WriteLine($"Informe um numero da matriz[{i}][{j}]: ");
    vet3[i,j] = int.Parse(Console.ReadLine());
    int maior = vet3[i,j];
    int menor = vet3[i,j];
    for(int v = 1; v < 4; v++){
            for(int z = 1; z < 4; z++){
            System.Console.WriteLine($"Informe um numero da matriz[{z}][{v}]: ");
            vet3[v,z] = int.Parse(Console.ReadLine());
        }
    }
     for(int v = 1; v < 4; v++){
            for(int z = 1; z < 4; z++){
            int d = 0;
            int g = 0;
            soma += vet3[d,g];
            d += 1;
            g += 1;
        }
    }
    System.Console.WriteLine($"A soma da diagonal eh: {soma}");
  }
}
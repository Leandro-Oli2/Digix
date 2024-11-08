
using System;
class Matriz01{
  static void Main1() {
    int[] vet = new int[10];
    for(int i = 0; i <10; i++){
        Console.WriteLine("Informe um numero: ");
        vet[i] = int.Parse(System.Console.ReadLine());
    }
    for(int j = 0; j <10; j++){
        Console.Write(vet[j]+", ");
    }
    Console.WriteLine("");
    for(int x = 10 - 1; x >= 0; x--){
        Console.Write(vet[x]+", ");
    }
  }
}

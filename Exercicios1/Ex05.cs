using System;

namespace Exercicio05{
    class Exercicio_05{
        static void Main(String[] args){
            System.Console.WriteLine("Informe um numero inteiro: ");
            int resp = int.Parse(System.Console.ReadLine());
            int i = 1;
            int maior = resp;
            int menor = resp;
            while(i != -1){
                System.Console.WriteLine("Deseja Informar Mais um?(0 - Sim, -1 - Não): ");
                int resp2 = int.Parse(System.Console.ReadLine());
                if(resp2 == -1){
                    break;
                }else{
                    System.Console.WriteLine("Informe um numero inteiro: ");
                    resp = int.Parse(System.Console.ReadLine());
                    if(resp > maior){
                        maior = resp;
                    }else if(resp < menor){
                        menor = resp;
                    }
                }
            }
            System.Console.WriteLine($"O maior numero eh: {maior}");
            System.Console.WriteLine($"O menor numero eh: {menor}");
        }
    }
}

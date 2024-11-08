
using System;

namespace Aula05{
    class Aula_05{
        static void sssssss(String[] args){
            // See https://aka.ms/new-console-template for more information
            int[] vetor3 = new int[4];
            int[] vet3 = {};
            int[] vetor = {2,3,4,5};

            System.Console.WriteLine(vetor[3]);
            for(int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine(vetor[i]);
            }
            foreach(int i in vetor3){
                System.Console.WriteLine(i);
            }
            int j = 0;
            while(j < vetor.Length){
                System.Console.WriteLine(vetor[j]);
                j += 1;
            }
            for(int k = 0; k < 5; k++){
                System.Console.WriteLine("Informe um numero: ");
                vet3[k] = int.Parse(System.Console.ReadLine());
                
            }
            for(int q = 0; q<vetor.Length;q++){
                System.Console.WriteLine(vet3[q]);
            }
        }
    }
}
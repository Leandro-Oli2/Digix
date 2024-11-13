using System;

class Pares{
    static int ParesVet(int[] vetor, int n){
        if(n == 0){
            return 0;
        }else if(n % 2 == 0){
            return vetor[n - 1] + ParesVet(vetor, n - 2);
        } else{
            return ParesVet(vetor, n - 1);
        }
    }
    static int Impares(int[] vetor, int n){
        if(n == 0){
            return 0;
        } else if(n % 2!= 0){
            return vetor[n - 1] + Impares(vetor, n - 2);
        } else{
            return Impares(vetor, n - 1);
        }
    }
    
    public static void Main(string[] args){
        int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        System.Console.WriteLine(ParesVet(vetor, vetor.Length));
        int[] vet = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        System.Console.WriteLine(Impares(vet, vet.Length));
    }
}
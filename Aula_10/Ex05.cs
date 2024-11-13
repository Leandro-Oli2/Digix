using System;

public class exercicio5{
    static public int SomaVet(int[] vet, int i){
        if(i == 0){
            return vet[i];
        }else{
            return vet[i] + SomaVet(vet, i-1);
        }
    }
    static void Main(string[] args){
        int[] num = new int[3];
        for(int i = 0; i < 3; i++){
            System.Console.WriteLine($"Informe um número inteiro {i}: ");
            num[i] = int.Parse(Console.ReadLine());
        }

        int result = SomaVet(num, num.Length - 1);
        System.Console.WriteLine($"A Soma dos valores do vetor é: {result}");
    }
}
using System;

public class exercicio6{
    static public double MediaVet(double[] vet, int i){
        if(i == 0){
            return vet[i];
        }else{
            return vet[i] + MediaVet(vet, i-1);
        }
    }
    static void Main(string[] args){
        double[] num = new double[3];
        for(int i = 0; i < 3; i++){
            System.Console.WriteLine($"Informe um número inteiro {i}: ");
            num[i] = double.Parse(Console.ReadLine());
        }

        double result = MediaVet(num, num.Length - 1);
        double media = result / num.Length;
        System.Console.WriteLine($"A media dos valores do vetor é: {media:F2}");
    }
}
using System;

public class exercicio3{
    static public double potencia(int baseNum, int expNum){
        if(expNum == 0){
            return 1;
        }
        else if(expNum > 0){
            return baseNum * potencia(baseNum, expNum - 1);
        }else{
            return 1/potencia(baseNum, -expNum);
        }
    }
    static void Main(string[] args){
        System.Console.WriteLine("Informe um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe um número inteiro negativo: ");
        int neg = int.Parse(Console.ReadLine());
        double result = potencia(num, neg);
        System.Console.WriteLine($"O resultado da potência é: {result:F10}");
    }
}
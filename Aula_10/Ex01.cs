using System;

class exercicio1{
    static public int soma(int n){
        int i = n;
        if(i == 0){
            return 0;
        }else{
            return i + soma(n-1);
        }
    }
    static void Main(string[] args){
        System.Console.WriteLine("Informe um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        int som = soma(num);
        System.Console.WriteLine($"A soma dos números é: {som}");
    }
}

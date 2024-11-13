using System;

public class exercicio2{
    static public int Produto(int n){
        int i = n;
        if(i == 1){
            return 1;
        }else{
            return i * Produto(n-1);
        }
    }
    static void Main(string[] args){
        System.Console.WriteLine("Informe um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        int prod = Produto(num);
        System.Console.WriteLine($"o Produto dos números é: {prod}");
    }
}
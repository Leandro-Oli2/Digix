using System;

public class exercicio4{
    static public int MDC(int num, int num2){
            if(num2 == 0){;
                return num;
            }else{
                return MDC(num2, num % num2);
            }
        
    }
    static void Main(string[] args){
        System.Console.WriteLine("Informe um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe outro número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());
        int result = MDC(num, num2);
        System.Console.WriteLine($"O  resultado do mdc de {num} e {num2} eh: {result}");
    }
}
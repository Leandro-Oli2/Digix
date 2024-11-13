using System;
using System.Security.Cryptography.X509Certificates;

class RecursiveFunc{
    static int fatorial(int n){
        if(n == 0){
            return 1;
        }else{
            return n * fatorial(n - 1);
        }

    }
    static int fatorial2(int n){
        int fat= 1;
        for(int i= 0; i < n; i++){
            fat *= n;
        }
        return fat;
    }
    static int fibonacci(int n){
        if(n <= 1){
            return n;
        } else{
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
    static int fibonacci2(int n){
        int a=0, b=1, c=1;
        for(int i = 2; i <= n; i++){
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
    public static void Main5(string[] args){
        int x = 5;
        int result = fatorial(x);
        System.Console.WriteLine($"O resultado do fatorial eh: {result}");

        int y = 4;
        int result2 = fibonacci(y);
        System.Console.WriteLine($"O resultado do fibonacci eh: {result2}");

        int z = 3;
        int result3 = fatorial2(z);
        System.Console.WriteLine($"O resultado do fatorial eh: {result3}");

        int v = 4;
        int result4 = fibonacci2(v);
        System.Console.WriteLine($"O resultado do fibonacci eh: {result4}");
    }




}
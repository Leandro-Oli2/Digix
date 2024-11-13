using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Referencias{
    static int Quadrado(int n){
        return n * n;
    }
    static void Quadradoref(ref int x){
        x = x*x;
    }
    static int QuadradoOut(out int a){
        a = 6;
        return a * a;
    
    }
    public static void Main3(){
        int x = 5;
        //Só altera dentro da função, não altera o valor original.
        System.Console.WriteLine(Quadrado(x));
        System.Console.WriteLine(x);
        
        //Altera o valor original com referência.
        Quadradoref(ref x);
        System.Console.WriteLine(x);

        int b;
        System.Console.WriteLine(QuadradoOut(out b));

    }


}
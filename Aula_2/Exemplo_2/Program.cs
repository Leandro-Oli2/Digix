using System;
using System.Security.Cryptography.X509Certificates;
namespace Exemplo_2
{
    class Programa2
    {
        static void Teste(String[] args)
        {
            // Operadores Aritmeticos
            Console.WriteLine("====== Aritmeticos ======");
            int a = 10;
            int b = 20;
            Console.WriteLine(a+b); // soma
            Console.WriteLine(a/b); // divisao
            Console.WriteLine(a*b); // multiplicação
            Console.WriteLine(a-b); // subtração
            Console.WriteLine(a%b); // resto da divisão

            // Aribuição
            Console.WriteLine("====== Atribuicao ======");
            int c = 10;
            int d = 5;
            c += d;
            Console.WriteLine(c);
            c -= d;
            Console.WriteLine(c);
            c *= d;
            Console.WriteLine(c);
            c /= d;
            Console.WriteLine(c);
            c %= d;
            Console.WriteLine(c);

            // Comparacao
            Console.WriteLine("====== Comparacao ======");
            int x = 10;
            int y = 5;
            System.Console.WriteLine(x == y);
            System.Console.WriteLine(x != y);
            System.Console.WriteLine(x > y);
            System.Console.WriteLine(x < y);
            System.Console.WriteLine(x >= y);
            System.Console.WriteLine(x <= y);

            // Lógicos
            Console.WriteLine("====== Logicos ======");
            bool w = true;
            bool z = false;
            System.Console.WriteLine(w && z);
            System.Console.WriteLine(w || z);
            System.Console.WriteLine(!w && z);
            System.Console.WriteLine((!w && z)&&(w || z));

            //operadores de incremento e decremento
            Console.WriteLine("====== Incremento e Decremento ======");
            int i = 19;
            i++;
            System.Console.WriteLine(i);
            int j = 21;
            j--;
            System.Console.WriteLine(j);

            // Bitwise
            Console.WriteLine("====== Bitwise ======");
            int l = 10;//1010
            int m = 5;//0101
            for(int cont = 0; cont < 4; cont++){
                System.Console.Write(l & m);
            }
            /*for(int cont1 = 0; cont1 < 4; cont1++){
                System.Console.Write(l | m);
            }*/
            
            
        }
    }
}

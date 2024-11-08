using System;

namespace Exercicio02{
    class Exercicio_02{
        static void sssss(String[] args){
            System.Console.WriteLine("Informe sua senha: ");
            string sen = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Informe o nome de Usuario");
            string usu = Console.ReadLine();
            System.Console.WriteLine("Informe sua senha: ");
            string sen2 = Console.ReadLine();
            while(sen2 != sen){
                System.Console.WriteLine("Invalido, Informe novamente sua senha: ");
                sen2 = Console.ReadLine();
            }
            System.Console.WriteLine($"Sucesso, Bem vindo {usu}");
        }
    }
}

using System;
namespace Exemplo_4
{
    class Program4
    {
        static void ain(String[] args){
            System.Console.WriteLine("Qual Tabuada Voce Deseja Saber?: ");
            int resp = int.Parse(Console.ReadLine());
            System.Console.WriteLine("===== Com For =====");
            for(int i = 0; i <= 10; i++){

                Console.WriteLine($"{resp}x{i}: {resp*i}");
            }
            System.Console.WriteLine("===== Com While =====");
            int x = 1;
            while (x<=10){
                Console.WriteLine($"{resp}x{x}: {resp*x}");
                x++;
            }
            System.Console.WriteLine("===== Com Do-While =====");
            int j = 1;
            do{
                Console.WriteLine($"{resp}x{j}: {resp*j}");
                j++;
            }while(j <= 10);
            
        }
    }
}
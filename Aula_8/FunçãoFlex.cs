using System.Security.Cryptography.X509Certificates;

namespace Aula_8{

    public class funcaoflex{
       public delegate int Operation(int a, int b);
       //expressão lambda
       static int Soma(int a, int b) => a+b;

       public delegate void Notificar();
       public static void EnvioEmail() => Console.WriteLine("Email Enviado");

       public static void EnvioSms() => Console.WriteLine("SMS Enviado");


        static void Main1(string[] args){
            Operation op = Soma;
            System.Console.WriteLine(op(15,15));

            Operation op2 = (int a, int b) => a*b;
            System.Console.WriteLine(op2(10, 10));

            //Metodo Anonimo
            Func<int, int ,int> op3 = delegate(int a, int b){
                return a * b;
            };
            System.Console.WriteLine(op3(5, 5));

            //Juntando com delegate
            Notificar noti = EnvioEmail;
            noti += EnvioSms;
            noti();
        }
    }
}
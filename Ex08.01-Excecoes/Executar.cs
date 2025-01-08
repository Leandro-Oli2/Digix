using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex08._01_Excecoes
{
    public class Executar
    {
        public static void Main(string[] args){
            try{
                System.Console.WriteLine("===================== Conta Bancaria =====================");
                System.Console.WriteLine("Informe o numero da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                System.Console.Write("Informe o nome do titular: ");
                string nome = Console.ReadLine();
                System.Console.Write("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Informe o limite de saldo para deposito: ");
                double limite = double.Parse(Console.ReadLine());
                Account a1 = new Account(numeroConta, nome, saldo, limite);
                a1.Deposit(50);
                a1.Withdraw(600);
                System.Console.WriteLine("Iforma~ções da conta: " + a1.ToString);
            }catch(Exception e){
                System.Console.WriteLine("Erro: " + e.Message);
            }finally{
                System.Console.WriteLine("===================== Fim do Programa =====================");
            }
        }
    }
}
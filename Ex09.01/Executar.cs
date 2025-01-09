using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class Executar
    {
        public static void Main(string[] args){
            // Supondo que você tenha contas e banco configurados:

            Bank bank = new Bank(); // Sua classe Bank
            CurrentAccount currentAccount = new CurrentAccount("1234", 1000.0, bank, 500);
            SavingAccount savingAccount = new SavingAccount("5678", 2000.0, bank);

            Account account = new Account();

            // Realizando uma transação de depósito
            account.createTransaction("Current", 500.0, currentAccount); // Depósito na conta corrente
            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            account.createTransaction("Saving", 300.0, savingAccount);


        }
    }
}
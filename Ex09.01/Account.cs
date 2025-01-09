using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class Account
    {
        public string number { get; set; }
        public double balance { get; set; }
        public Bank bank { get; set; }
        List<ATMTransactions> transactions = new List<ATMTransactions>();

        public Account(string number, double balance, Bank bank)
        {
            this.number = number;
            this.balance = balance;
            this.bank = bank;
        }
        public Account(){

        }
        
        public void deposit(double amount)
        {
            if(amount > 0){
                balance += amount;
                ATMTransactions depositTransactions = new ATMTransactions(balance, "Deposito", amount);
                transactions.Add(depositTransactions);
                Console.WriteLine($"Deposito realizado com sucesso.");
                depositTransactions.toString();
            }
            else{
                throw new DomainException("O valor do deposito não pode ser negativo.");
            }
        }
        
        public virtual void withdraw(double amount)
        {
            if(amount > 0 && amount <= balance){
                balance -= amount;
                ATMTransactions saqueTransitios = new ATMTransactions(balance, "Saque", amount);
                transactions.Add(saqueTransitios);
                Console.WriteLine($"Saque realizado com sucesso.");
                saqueTransitios.toString();
            }
            else{
                throw new DomainException("O valor do saque não pode ser negativo ou superior ao saldo.");
            }
        }
        public void createTransaction(string tipo, double amount, Account destinationAccount){
            if(tipo == "Current" && destinationAccount is CurrentAccount){
                CurrentAccount currentAccount = (CurrentAccount)destinationAccount;
                currentAccount.deposit(amount);
                ATMTransactions aTMTransactions = new ATMTransactions(amount, tipo, currentAccount.balance);
                transactions.Add(aTMTransactions);
                Console.WriteLine($"Transferencia realizada com sucesso.");
                aTMTransactions.toString();

            }else if(tipo == "Saving" && destinationAccount is SavingAccount){
                SavingAccount savingAccount = (SavingAccount)destinationAccount;
                savingAccount.deposit(amount);
                ATMTransactions aTMTransactions = new ATMTransactions(amount, tipo, savingAccount.balance);
                transactions.Add(aTMTransactions);
                Console.WriteLine($"Transferencia realizada com sucesso.");
                aTMTransactions.toString();
            }
            else{
                throw new DomainException("Conta de transacao invalida.");
            }
        }
    }
}
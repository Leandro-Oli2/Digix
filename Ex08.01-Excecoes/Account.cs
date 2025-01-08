using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex08._01_Excecoes
{
    public class Account
    {
        public int Number { get; private set;}
        public double Balance { get; private set;}
        public string holder { get; private set;}
        public double withdrawLimit { get; private set;}

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            this.holder = holder;
            Balance = balance;
            this.withdrawLimit = withdrawLimit;
        }
        
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainExcept("Valor para saque deve ser maior que zero.");
            }
            if (amount > withdrawLimit)
            {
                throw new DomainExcept("Limite de saque excedido.");
            }
            if (Balance - amount < 0)
            {
                throw new DomainExcept("Saldo insuficiente.");
            }
            System.Console.WriteLine("Saque realizado com sucesso!");
            Balance -= amount;
        }
        
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainExcept("Valor para deposito deve ser maior que zero.");
            }
            System.Console.WriteLine("Valor deposiado com sucesso!");
            Balance += amount;
        }
        
        public override string ToString()
        {
            return $"Conta {Number}, Dono: {holder}, Saldo: {Balance}, Limite de saque: {withdrawLimit}";
        }
    }
}
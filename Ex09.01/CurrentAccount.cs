using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class CurrentAccount : Account
    {
        public double withdrawLimit { get; set; }

        public CurrentAccount(string number, double balance, Bank bank, double withdrawLimit) : base(number, balance, bank)
        {
            this.withdrawLimit = withdrawLimit;
        }
        public override void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Valor para saque deve ser maior que zero.");
            }
            if (amount > withdrawLimit)
            {
                throw new DomainException("Limite de saque excedido.");
            }
            if (balance - amount < 0)
            {
                throw new DomainException("Saldo insuficiente.");
            }
            System.Console.WriteLine($"Saque realizado na conta Current {number} com sucesso!");
            balance -= amount;
        }
    }
}
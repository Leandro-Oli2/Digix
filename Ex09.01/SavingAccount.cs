using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class SavingAccount : Account
    {
        public SavingAccount(string number, double balance, Bank bank) : base(number, balance, bank)
        {
        }
    }
}
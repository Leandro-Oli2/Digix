using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class Bank
    {
        public string Code { get; set; }
        public string address { get; set; }

        public Bank(string code, string address)
        {
            Code = code;
            this.address = address;
        }
        public Bank(){
        }

        public void Manage(){
            Console.WriteLine($"Gerenciando banco {Code} - {address}");
        }
        public void Maintains(){
            Console.WriteLine($"Manutenção do banco {Code} - {address}");
        }
    }
}
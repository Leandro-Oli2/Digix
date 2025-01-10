using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class ATM : Account
    {
        public string location { get; set; }
        public Bank managedby { get; set; }

         public void Identificar()
    {
        Console.WriteLine($"Caixa eletrônico localizado em {location}, gerenciado pelo banco com código {managedby.Code}.");
    }

    public void Transacoes()
    {
        Console.WriteLine("Processando transações no caixa eletrônico...");
        
    }
        
        
    }
}
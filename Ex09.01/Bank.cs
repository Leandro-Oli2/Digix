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
        private List<Account> contas = new List<Account>();

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
            public void AdicionarConta(Account conta)
        {
            contas.Add(conta);
            Console.WriteLine($"Conta {conta.number} adicionada ao banco.");
        }

        public void ListarContas()
        {
            Console.WriteLine("Lista de Contas no Banco:");
            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta Número: {conta.number}, Saldo: {conta.balance}");
            }
        }

        public Account BuscarContaPorNumero(string numero)
        {
            var conta = contas.Find(c => c.number == numero);
            if (conta != null)
            {
                Console.WriteLine($"Conta encontrada: Número {conta.number}, Saldo {conta.balance}");
                return conta;
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
                return null;
            }
        }

    }
}
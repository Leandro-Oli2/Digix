using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
    public struct ContaBancariaStruct{
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaStruct( string numeroConta, string nomeTitular, decimal saldo){
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public void Depositar(decimal valor){
            Saldo += valor;
        }
        public void Sacar(decimal valor){
            if(Saldo >= valor){
                Saldo -= valor;
            }else{
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public void AlterarSaldo(decimal valor){
            this = new ContaBancariaStruct(this.NumeroConta, this.NomeTitular, valor + Saldo);

        }
        public override string ToString(){
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: {Saldo}";
        }
    }
    public class ContaBancariaClass{
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancariaClass( string numeroConta, string nomeTitular, decimal saldo){
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public void Depositar(decimal valor){
            Saldo += valor;
        }
        public void Sacar(decimal valor){
            if(Saldo >= valor){
                Saldo -= valor;
            }else{
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public void AlterarSaldo(decimal valor){
            Saldo = valor;
            System.Console.WriteLine("Saldo alterado!");    
        }
        public override string ToString(){
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: {Saldo}";
        }
    }
    class Exe{
        static void Main(string[] args){
            ContaBancariaStruct conta1 = new ContaBancariaStruct("12345", "Leandro", 1000);
            conta1.AlterarSaldo(500);
            Console.WriteLine(conta1);

            ContaBancariaClass conta2 = new ContaBancariaClass("12345", "Leandro", 2000);
            conta2.AlterarSaldo(400);
            Console.WriteLine(conta2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Ex09._01
{
    public class ATMTransactions
    {
        public int idTransaction { get; set; }
        public DateTime dateTransaction { get; set; }
        public double amountTransaction { get; set; }
        public string typeTransaction { get; set; }
        public double postBalance { get; set; }
        Random random = new Random();

        public ATMTransactions( double amountTransaction, string typeTransaction, double postBalance)
        {
            this.amountTransaction = amountTransaction;
            this.typeTransaction = typeTransaction;
            dateTransaction = DateTime.Now;
            this.postBalance = postBalance;
            generateID();
        }
        public void generateID(){
            idTransaction = random.Next();
        }
        public void toString(){
            Console.WriteLine($"ID da transação: {idTransaction}, Data: {dateTransaction.ToShortDateString()}, Valor: {amountTransaction}, Tipo: {typeTransaction}, Saldo após a transação: {postBalance}");
        }
        public void Modificar(double novoValor)
        {
            double Valor;
            Valor = novoValor;
            Console.WriteLine($"Transação modificada. Novo valor: {Valor}");
        }
    }
}
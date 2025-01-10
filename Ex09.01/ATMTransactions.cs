using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Ex09._01
{
    public class ATMTransactions : ITransacoes
    {
        public int idTransaction { get; set; }
        public DateTime dateTransaction { get; set; }
        public Account saldo { get; set; }
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
        public void Transacoes(){
            Console.WriteLine($"ID da transação: {idTransaction}, Data: {dateTransaction.ToShortDateString()}, Valor Após Transação: {amountTransaction}, Tipo: {typeTransaction}, Valor Informado: {postBalance}");
        }
        public void Modificar(double novoValor)
        {
            double Valor;
            Valor = novoValor;
            Console.WriteLine($"Transação modificada. Novo valor: {Valor}");
        }
    }
}
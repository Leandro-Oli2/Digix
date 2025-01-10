using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class Customer
    {
        public string nome { get; set; }
        public string address { get; set; }
        public DateTime dob { get; set; }
        public string cardNumber { get; set; }
        public string Pin { get; set; }

        public Customer(string nome, string address, DateTime dob, string cardNumber, string Pin){
            this.nome = nome;
            this.address = address;
            this.dob = dob;
            this.cardNumber = cardNumber;
            this.Pin = Pin;
        }
        public Customer(){

        }
        public bool VerifyPassword(string password){
            if(password != Pin){
                throw new DomainException("Senha inválida!");
            }else{
                Console.WriteLine("Senha válida!");
                return true;
            }
        }
    }
}
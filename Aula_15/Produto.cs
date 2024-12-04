using System;
using System.Diagnostics.Metrics;

namespace Produto{

    public class Produto{
        public string nome;
        public double preco;
        public Produto(string nome, double Preco){
            this.nome = nome;
            this.preco = Preco;
        }

        public void Exibir(){
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Preco: " + this.preco);
        }
        static void Main(string[] args){
            Produto p1 = new Produto("Notebook", 2000);
            p1.Exibir();

        }

    }
}
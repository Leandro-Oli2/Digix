using System;

namespace padariaEX{

    public class Padaria{
        public string NomeAlimento;
        public double Preco;
        public string Bebidas;
        public string Doces;
        DateTime data = DateTime.Now;

        public void encomenda(){
            Console.WriteLine("Nome: " + NomeAlimento + " \nBebidas: " + Bebidas + " \nDoces: " + Doces + " \nPreço: " + Preco + " \nEncomenda feita com sucesso na data: " + data);
        }
        public double cestaCompra(List<(string NomeAlimento, double Preco)> itens){
            double total = 0;
            foreach(var item in itens){
                System.Console.WriteLine($"Item: {item.NomeAlimento}, preco: {item.Preco}");
                total += item.Preco;
            }
            return total;
        }

    }
}
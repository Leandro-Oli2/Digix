using System.Collections.Generic;
using System;
using padariaEX;

namespace padariaEX{

    public class ExecutarPad{
        static void Main3(string[] args){
            Padaria p1 = new Padaria();
            p1.Bebidas = "Coca Cola";
            p1.Doces = "Pão de Mel";
            p1.NomeAlimento = "Croassaint de presunto e queijo";
            p1.Preco = 4.99;
            p1.encomenda();
            List<(string NomeAlimento, double Preco)> listasCompras = new List<(string NomeAlimento, double Preco)>();
            listasCompras.Add(("Coca Cola", 2.50));
            listasCompras.Add(("Pão de Mel", 1.50));
            listasCompras.Add(("Croissant de presunto e queijo", 4.99));
            listasCompras.Add(("Batata frita", 3.99));
            listasCompras.Add(("Refrigerante", 2.99));

            double total = p1.cestaCompra(listasCompras);
            Console.WriteLine($"Total da compra: {total}");
        }
    }



}

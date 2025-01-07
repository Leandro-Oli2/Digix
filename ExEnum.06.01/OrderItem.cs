using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExEnum._06._01
{
    public class OrderItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public double subTotal(){
            return Quantidade * Preco;
        }
    }
}
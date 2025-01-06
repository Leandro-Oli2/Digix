using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExEnum._06._01
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        List<OrderItem> items = new List<OrderItem>();

        public void AddItem(OrderItem item){
            // Adiciona o item ao pedido
            items.Add(item);  
        }
        public void RemoveItem(OrderItem item){
            // Remove o item do pedido
            items.Remove(item);
        }
        public double Total(){
            // Calcula o total do pedido
            return items.Sum(i => i.Quantidade * i.Preco);
        }
    }
}
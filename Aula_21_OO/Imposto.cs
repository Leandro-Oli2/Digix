using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public class Imposto
    {
        public double TotalVendas { get; set; }
        public double TotalImposto { get; set; }

        public double CalcularImpostoVendas(){
            return TotalVendas * 0.1; // Exemplo: 10% do total das vendas
        }
         public double CalcularImpostoSalario(){
            return TotalVendas * 0.2; 
        }
        
    }
}
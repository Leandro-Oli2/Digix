using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class EquipeVenda
    {
        public string Nome { get; set; }
        public EquipeVenda(string nome){
            Nome = nome;
        }
        public void Trabalho(){
            Console.WriteLine("Equipe de vendas: "+ Nome +" esta trabalhando...");
        }
    }
}
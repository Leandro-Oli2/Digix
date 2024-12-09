using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16OO
{
    public record Ferramentas(string Nome, double Preco, int Qtd)
    {
        /* Record: Permite criar classes imutaveis. 
        Ou seja que não podem ser modificadas após a sua criação*/
        
        // public string Nome;

        // public double Preco;

        // public int Qtd;
    
        // // construtor sem parametros
        // // public Ferramentas(){
        // //     Nome = null;
        // //     Preco = 0;
        // //     Qtd = 10;
        // // }

        // //construtor com parametros
        // public Ferramentas( string nome, double preco, int qtd ){
        //     this.Nome = nome;
        //     this.Preco = preco;
        //     this.Qtd = qtd;
        // }

        public double CalcularEstoque(){
            return (double)Preco * Qtd;
        }
        public void EscreverSaida(){
            Console.WriteLine($"Nome: {Nome}, Preco: {Preco}, Qtd: {Qtd}");
        }
    }
}
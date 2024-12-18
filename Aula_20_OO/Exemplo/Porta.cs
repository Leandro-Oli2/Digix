using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class Porta
    {
        //Properties
        public string? Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }
        public Porta( string Cor, float Largura, float Altura, double Peso){
            this.Cor = Cor;
            this.Largura = Largura;
            this.Altura = Altura;
            this.Peso = Peso;
        }

        public virtual void Abrir(){
            Console.WriteLine("Porta aberta.");
        }
        public virtual void Fechar(){
            Console.WriteLine("Porta fechada.");
        }
    }

}
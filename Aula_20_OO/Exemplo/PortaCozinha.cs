using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class PortaCozinha : Porta
    {
        public PortaCozinha(string cor, float largura, float Altura, double peso) : base(cor, largura, Altura,  peso){
        }
        // Subscrevendo o metodo Abrir
        public override void Abrir()
        {
            Console.WriteLine("A porta da cozinha está aberta.");
        }
        // Implementando o metodo Fechar
        public override void Fechar()
        {
            Console.WriteLine("A porta da cozinha está fechada.");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class PortaSala : Porta
    {
        public PortaSala(string cor, float largura, float Altura, double peso) : base(cor, largura, Altura,  peso){
        }

        public override void Abrir()
        {
            Console.WriteLine("Porta da sala está aberta.");
        }
        public override void Fechar()
        {
            Console.WriteLine("Porta da sala está fechada.");
        }

    }
}
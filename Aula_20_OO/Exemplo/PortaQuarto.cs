using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class PortaQuarto : Porta
    {
        public PortaQuarto(string cor, float largura, float Altura, double peso) : base(cor, largura, Altura,  peso){
        }

        public override void Abrir()
        {
            Console.WriteLine($"A porta da sala de quarto está aberta, cor: {Cor}");
        }
        public override void Fechar()
        {
            Console.WriteLine($"A porta da sala de quarto está fechada, cor: {Cor}");
        }
    }
}
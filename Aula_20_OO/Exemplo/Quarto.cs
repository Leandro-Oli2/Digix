using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class Quarto
    {
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public float MetragemQuadrada { get; set; }

        public Quarto( bool banheiro, float metragemQuadrada){
            Banheiro = banheiro;
            MetragemQuadrada = metragemQuadrada;
            //Instanciando a porta quarto, tendo a relação de composição
            PortaQuarto = new PortaQuarto("Branca", 0.80f, 2.10f, 40);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class Cozinha
    {
        //properties
        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }
        
        //constructor
        public Cozinha(bool americana, float metragemQuadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemQuadrada;
        }

        public void Entrar(PortaCozinha portaCozinha){
             Console.WriteLine("Entrou pela porta " + portaCozinha.Cor + " da cozinha.");
        }
    }
}
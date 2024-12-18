using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO.Exemplo
{
    public class Sala
    {
        public PortaSala PortaSala { get; set; }
        public float MetragemQuadrada { get; set; }
        public Porta PortaAux { get; set; }


        public Sala(PortaSala portaSala, Porta portaAux, float metragemQuadrada)
        {
            
            MetragemQuadrada = metragemQuadrada;
            PortaAux = portaAux;
            // composition
            PortaSala = new PortaSala(portaSala.Cor, portaSala.Largura, portaSala.Altura, portaSala.Peso);
        }

        public void AbrirPortaAux(){
            PortaAux.Abrir();
        }
    }
}
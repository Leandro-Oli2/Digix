using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Composicao
{
    public class Computador
    {
        public Processador processador;
        public Computador()
        {
            processador = new Processador();
        }

        void iniciar(){
            Console.WriteLine("Computador Iniciado");
            processador.processar();
        }
    }
}
//composicao é quando a classe principal contem partes essenciais que não existe sem ela

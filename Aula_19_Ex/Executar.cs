using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public class Executar
    {
        static void Main(string[] args){
            Formiga f1 = new Formiga();
            Cachorro cachorro = new Cachorro ("Spike");
            Peixe peixe = new Peixe ();
            f1.Comer();
            cachorro.Comer();
            cachorro.Brincar();
            peixe.Comer();

        }
    }
}
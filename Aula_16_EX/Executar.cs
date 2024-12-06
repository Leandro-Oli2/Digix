using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_EX
{
    public class Executar
    {
        static void Main(string[] args){
            Cobra cobra = new Cobra(true, false);
            Javali javali = new Javali(true, true);

            cobra.Alimento("Rato");
            cobra.venenosa(false);

            System.Console.WriteLine("Velocidade maxima do javali eh: " + javali.GetVelocidade());
            javali.SetSelvagem(true);
        }
    }
}
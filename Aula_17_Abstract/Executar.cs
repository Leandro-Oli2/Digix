using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_Abstract
{
    public class Executar
    {
        static void Main(string[] args){
            Circulo circulo = new Circulo("Circulo", 5);
            circulo.CalcularPerimetro();
            circulo.CalcularArea();
            circulo.ImprimirDados();

            Retangulo retangulo = new Retangulo("Retangulo", 4, 6);
            retangulo.CalcularPerimetro();
            retangulo.CalcularArea();
            retangulo.ImprimirDados();

        }
    }
}
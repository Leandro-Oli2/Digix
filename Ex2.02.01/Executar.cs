using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Engenheiro engenheiro = new Engenheiro("Eng. Edvaldo", 5546375, 12345);
            Pessoa pes1 = new Pessoa("Maria", 3424);
            UnidadeResidencial uu1 = new UnidadeResidencial(4, 20, 3, 2 , pes1);
            Predio p1 = new Predio(10, "Ponta das Pedras", engenheiro , uu1, "Predio da esperança", 10, 5);
            string x = p1.DescricaoDoImovel();
            System.Console.WriteLine(x);
            CasaSobrado c1 = new CasaSobrado(5, "av Costa Melo", engenheiro, uu1, true, 2);
            string t = c1.DescricaoDoImovel();
            System.Console.WriteLine("================= Casa Sobrado =================");
            System.Console.WriteLine(t);

        }
    }
}
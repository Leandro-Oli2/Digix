using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public class Executar
    {
        static void Main(string[] args){
            MuscaDomestica m1 = new MuscaDomestica();
            m1.obterDescricao();
            HomoSapiens h1 = new HomoSapiens();
            h1.obterDescricao();
            CanisFamiliaris c1 = new CanisFamiliaris();
            c1.obterDescricao();
        }
    }
}
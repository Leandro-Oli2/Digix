using System.Collections.Generic;
using System;
using POO;

namespace POO{

    public class Executar{
        static void Main2(string[] args){
            Cachorro c1 = new Cachorro();
            c1.Nome = "Rex";
            c1.Idade = 2;
            c1.Raca = "Golden Retriver";

            c1.escreverSaida();
        }
    }



}

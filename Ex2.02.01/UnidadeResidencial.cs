using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class UnidadeResidencial
    {
        public int num { get; set; }
        public float metragemUnidade { get; set; }
        public int numeroQuartos { get; set; }
        public int numeroBanheiros { get; set; }
        public Pessoa proprietario { get; set; }

        public UnidadeResidencial(int numero, float metragem, int quartos, int banheiros, Pessoa proprietarios)
        {
            num = numero;
            metragemUnidade = metragem;
            numeroQuartos = quartos;
            numeroBanheiros = banheiros;
            proprietario = proprietarios;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            this.estado = estado;
        }
    }
}
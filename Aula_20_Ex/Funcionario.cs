using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string CPF { get; set; }
        public Endereco endereco { get; set; }

        public Funcionario(string nome, string nascimento, string cpf) {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
        }
        
    }
}
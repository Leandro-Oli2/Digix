using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX
{
    public class Comissario : Empregado
    {
        public double totalVenda;
        public double taxaComissao;
        public Comissario(string nome, string Sobrenome, string cpf, double totalVenda, double taxaComissao) : base(nome, Sobrenome, cpf)
        {
            this.totalVenda = totalVenda;
            this.taxaComissao = taxaComissao;
        }

        public override double Vencimento()
        {
            return totalVenda * taxaComissao;
        }
    }
}
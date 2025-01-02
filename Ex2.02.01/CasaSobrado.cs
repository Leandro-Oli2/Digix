using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class CasaSobrado : Casa
    {
        protected int numeroAndares { get; set; }

        public CasaSobrado(float metT, string endereco, Engenheiro engenheiro, UnidadeResidencial unidade, bool condominio, int numeroAndares) : base(metT, endereco, engenheiro, unidade, condominio)
        {
            this.numeroAndares = numeroAndares;
        }
        public override string DescricaoDoImovel()
        {
            return $"Unidade: {unidade.num},\nMetragem: {metragemTotal},\nnumero de Quarto: {unidade.numeroQuartos},\nnumero de banheiros: {unidade.numeroBanheiros},\npropiedade: {unidade.proprietario.nome},\nEngenheiro: {responsavel.nome}";
        }
    }
}
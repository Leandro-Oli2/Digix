using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class CasaTerrea : Casa
    {
        public CasaTerrea(float metT, string endereco, Engenheiro engenheiro, UnidadeResidencial unidade, bool condominio) : base(metT, endereco, engenheiro, unidade, condominio){

        }
        public override string DescricaoDoImovel()
        {
            return $"Unidade: {unidade.num},\nMetragem: {metragemTotal},\nnumero de Quarto: {unidade.numeroQuartos},\nnumero de banheiros: {unidade.numeroBanheiros},\npropiedade: {unidade.proprietario.nome},\nEngenheiro: {responsavel.nome}";
        }
    }
}
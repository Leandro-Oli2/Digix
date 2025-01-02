using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class Casa : Edificação
    {
        protected bool condominio { get; set; }

        public Casa(float metT, string endereco, Engenheiro engenheiro, UnidadeResidencial unidade,  bool condominio) : base(metT, endereco, engenheiro, unidade)
        {
            this.condominio = condominio;
        }
        public override string DescricaoDoImovel()
        {
            return $"Unidade: {unidade.num},\nMetragem: {metragemTotal},\nnumero de Quarto: {unidade.numeroQuartos},\nnumero de banheiros: {unidade.numeroBanheiros},\npropiedade: {unidade.proprietario.nome},\nEngenheiro: {responsavel.nome}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public abstract class Edificação
    {
        protected float metragemTotal { get; set; }
        protected string endereco { get; set; }
        public Engenheiro responsavel { get; set; }
        protected UnidadeResidencial unidade { get; set; }

        public Edificação(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial unidade)
        {
            this.metragemTotal = metragemTotal;
            this.endereco = endereco;
            this.responsavel = responsavel;
            this.unidade = unidade;
        }
        public virtual void AdicionarUnidadeResidencial(UnidadeResidencial unidade)
        {
            this.unidade = unidade;
        }

        public abstract string DescricaoDoImovel();
    }
}
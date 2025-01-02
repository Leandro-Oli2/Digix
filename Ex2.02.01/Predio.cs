using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2._02._01
{
    public class Predio : Edificação
    {
        public string nome { get; set; }
        public int andares { get; set; }
        public int apPorAndar { get; set; }

        public Predio(float metragemTotal, string endereco, Engenheiro responsavel, UnidadeResidencial unidade, string nome, int andares, int apPorAndar) : base(metragemTotal, endereco, responsavel, unidade)
        {
            this.nome = nome;
            this.andares = andares;
            this.apPorAndar = apPorAndar;
        }
        
        public override string DescricaoDoImovel()
        {
            return $"Nome: {nome},\nArea Total: {metragemTotal},\nResponsavel: {responsavel.nome},\nCrea: {responsavel.crea},\nNumero de andares: {andares},\nApt por andar: {apPorAndar},\nUnidade: {unidade.num},\nProprietario: {unidade.proprietario.nome}";
        }
        public override void AdicionarUnidadeResidencial(UnidadeResidencial unidade)
        {
            this.unidade = unidade;
        }
    }
}
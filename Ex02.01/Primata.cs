using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public abstract class Primata : Mammalia
    {
        public override string Reino => "Animalia";
        public override string Filo => "Chordata";
        public override string Classe => "Mammalia";
        public override string Ordem => "Primata";
        public override string Familia => "";
        public override string Genero => "";
        public override string Especie => "";
        public abstract override void obterDescricao();
    }
}
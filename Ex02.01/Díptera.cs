using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public abstract class Díptera : Insecta
    {
        public override string Reino => "Animalia";
        public override string Filo => "Arthropoda";
        public override string Classe => "Insecta";
        public override string Ordem => "Díptera";
        public override string Familia => "";
        public override string Genero => "";
        public override string Especie => "";
        public abstract override void obterDescricao();
    }
}
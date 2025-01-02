using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public class CanisFamiliaris : Canis
    {
        public override string Reino => "Animalia";
        public override string Filo => "Chordata";
        public override string Classe => "Mammalia";
        public override string Ordem => "Carnivora";
        public override string Familia => "Canidae";
        public override string Genero => "Canis";
        public override string Especie => "Canis Familiaris";
        public override void obterDescricao(){
            Console.WriteLine("============ Canis Familiaris: ============");
            Console.WriteLine($"Reino: {Reino}");
            Console.WriteLine($"Filo: {Filo}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Ordem: {Ordem}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Especie: {Especie}");
        }
    }
}
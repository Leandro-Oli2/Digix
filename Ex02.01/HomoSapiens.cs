using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public class HomoSapiens : Homo
    {
        public override string Reino => "Animalia";
        public override string Filo => "Chordata";
        public override string Classe => "Mammalia";
        public override string Ordem => "Primata";
        public override string Familia => "Hominidae";
        public override string Genero => "Homo";
        public override string Especie => "Homo sapiens";
        public override void obterDescricao(){
            Console.WriteLine("============ Informações sobre o Homo sapiens: ============");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02._01
{
    public class MuscaDomestica : Musca
    {
        public override string Reino => "Animalia";
        public override string Filo => "Arthropoda";
        public override string Classe => "Insecta";
        public override string Ordem => "Díptera";
        public override string Familia => "Muscidae";
        public override string Genero => "Musca";
        public override string Especie => "Musca domestica";
        public override void obterDescricao(){
            Console.WriteLine("============ Descrição de uma Musca Domestica: ============");
            Console.WriteLine($"Reino: {Reino}");
            Console.WriteLine($"Filo: {Filo}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Ordem: {Ordem}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Espécie: {Especie}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public class Cachorro : Animal, IAnimalDeEstimação
    {
        private string nome;

        public void SetNome(string nome)
        {
            this.nome = nome; // Define o nome do cachorro
        }

        public string GetNome()
        {
            return nome; // Retorna o nome do cachorro
        }

        public Cachorro(){
            nome = "Cachorro";
        }
        public Cachorro(string nome){
            this.nome = nome;
        }
        public override void Comer()
        {
            Console.WriteLine($"{nome} está comendo.");
        }
        public void Brincar(){
            Console.WriteLine($"{nome} está brincando.");
        }
    }
}
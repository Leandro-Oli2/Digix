using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_Ex
{
    public class Peixe : Animal, IAnimalDeEstimação
    {
        private string Nome;

        public void SetNome(string nome)
        {
            Nome = nome; // Define o nome do cachorro
        }

        public string GetNome()
        {
            return Nome; // Retorna o nome do cachorro
        }
        public Peixe(){
            Nome = "Peixe";
        }
        public override void Comer()
        {
            Console.WriteLine($"{Nome} esta a comer");
        }
        public void Brincar(){
            Console.WriteLine($"{Nome} esta brincando");
        }
    }
}
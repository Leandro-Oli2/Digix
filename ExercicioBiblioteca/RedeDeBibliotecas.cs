using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class RedeDeBibliotecas
    {
        private List<Biblioteca> bibliotecas;

        public RedeDeBibliotecas()
        {
            bibliotecas = new List<Biblioteca>();
        }

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            bibliotecas.Add(biblioteca);
        }

        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            bibliotecas.Remove(biblioteca);
        }
    }
}

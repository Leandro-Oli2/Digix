using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoDePublicacao { get; private set; }
        public int Exemplares { get; private set; }

        public Livro(string titulo, string autor, int anoDePublicacao, int exemplares)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            Exemplares = exemplares;
        }
    }
}

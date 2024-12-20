using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class CatalogoLivros
    {
        private List<Livro> livros;

        public CatalogoLivros()
        {
            livros = new List<Livro>();
        }

        public void AdicionarLivro(string titulo, string autor, int ano, int exemplares)
        {
            livros.Add(new Livro(titulo, autor, ano, exemplares));
        }

        public void RemoverLivro(string titulo)
        {
            livros.RemoveAll(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public bool LivroDisponivel(string titulo)
        {
            return livros.Any(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase) && l.Exemplares > 0);
        }
        public List<Livro> ListarLivros()
        {
            return livros;
        }
    }
}
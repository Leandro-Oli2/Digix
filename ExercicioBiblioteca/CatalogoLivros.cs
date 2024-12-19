using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class CatalogoLivros
    {
        private List<string> livros;
        public CatalogoLivros()
        {
            livros = new List<string>();
        }
        
        public List<string> ConsultarCatalog(){
            return livros;
        }
    }
}
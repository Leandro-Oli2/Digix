using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Livro
    {
        public string _titulo;
        private string _autor;
        private string _isbn;
        private DateTime _anoPub;
        private int _numeroExmp;

        public Livro(string titulo, string autor, string isbn, DateTime anoPub, int numeroExmp){
            _titulo = titulo;
            _autor = autor;
            _isbn = isbn;
            _anoPub = anoPub;
            _numeroExmp = numeroExmp;    
        }
    }
}
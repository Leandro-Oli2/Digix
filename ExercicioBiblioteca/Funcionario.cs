using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Funcionario : Usuario
    {
        public string Nivel { get; set; }
        public Funcionario(string nome, string senha, string nivel) : base(nome, senha)
        {
            Nivel = nivel;
        }
        public void AdicionarLivro(Biblioteca biblioteca, string livro){
            biblioteca.AdicionarLivro(livro);
        }
        public void RemoverLivro(Biblioteca biblioteca, string livro){
            biblioteca.RemoverLivro(livro);
        }
        public void RealizarEmprestimo(Biblioteca biblioteca, Leitor leitor, string livro){
            
        }
        
    }
}
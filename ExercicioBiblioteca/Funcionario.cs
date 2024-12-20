using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; private set; }

        public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
        {
            Cargo = cargo;
        }

        public void AtualizarCatalogo(CatalogoLivros catalogo, string titulo, string autor, int ano, int exemplares, bool adicionar)
        {
            if (adicionar)
            {
                catalogo.AdicionarLivro(titulo, autor, ano, exemplares);
            }
            else
            {
                catalogo.RemoverLivro(titulo);
            }
        }
        public void RealizarEmprestimo(Leitor leitor, string livro, CatalogoLivros catalogo)
        {
            if (catalogo.LivroDisponivel(livro))
            {
                leitor.EmprestarLivro(livro);
                catalogo.RemoverLivro(livro);
            }
            else
            {
                Console.WriteLine($"O livro '{livro}' não está disponível no catálogo.");
            }
        }
    }
}
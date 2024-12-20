using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Leitor : Usuario
    {
        public string LivroEmprestado {get; private set;}

        public Leitor (string nome, string cpf) : base(nome, cpf){
            LivroEmprestado = null;
        }
          public void ConsultarLivrosDisponiveis(List<Livro> livros)
        {
                foreach (var livro in livros.Where(l => l.Exemplares > 0))
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoDePublicacao}, Exemplares: {livro.Exemplares}");
            }
        }
           public void EmprestarLivro(string livro)
        {
            if (LivroEmprestado == null)
            {
                LivroEmprestado = livro;
                Console.WriteLine($"Livro '{livro}' emprestado ao leitor {Nome}.");
            }
            else
            {
                Console.WriteLine($"O leitor {Nome} já possui um livro emprestado: {LivroEmprestado}.");
            }
        }
        public void DevolverLivro()
        {
            if (LivroEmprestado != null)
            {
                Console.WriteLine($"Livro '{LivroEmprestado}' devolvido.");
                LivroEmprestado = null;
            }
            else
            {
                Console.WriteLine("Nenhum livro para devolver.");
            }
        }
    }
}
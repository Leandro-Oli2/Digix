using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // rede de bibliotecas
            RedeDeBibliotecas rede = new RedeDeBibliotecas();

            // biblioteca
            Biblioteca bibliotecaCentral = new Biblioteca("Biblioteca Central");
            rede.AdicionarBiblioteca(bibliotecaCentral);

            // funcionários
            Funcionario funcionario1 = new Funcionario("Ana Silva", "12345678900", "Bibliotecária");
            Funcionario funcionario2 = new Funcionario("Carlos Oliveira", "98765432100", "Auxiliar");
            bibliotecaCentral.AdicionarFuncionario(funcionario1);
            bibliotecaCentral.AdicionarFuncionario(funcionario2);

            // leitores
            Leitor leitor1 = new Leitor("João Pereira", "11122233344");
            Leitor leitor2 = new Leitor("Maria Souza", "55566677788");

            // Adicionando livros no catalogo
            CatalogoLivros catalogo = bibliotecaCentral.ConsultarCatalogo();
            funcionario1.AtualizarCatalogo(catalogo, "O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 5, true);
            funcionario1.AtualizarCatalogo(catalogo, "Dom Quixote", "Miguel de Cervantes", 1605, 2, true);

            // Consultando livros disponíveis
            Console.WriteLine("\n--- Livros Disponíveis ---");
            leitor1.ConsultarLivrosDisponiveis(catalogo.ListarLivros());

            // Realizando empréstimo
            funcionario1.RealizarEmprestimo(leitor1, "O Senhor dos Anéis", catalogo);

            // Tentando emprestar um livro ja emprestado
            funcionario1.RealizarEmprestimo(leitor1, "Dom Quixote", catalogo);

            // Devolvendo livro
            leitor1.DevolverLivro();

            // Emprestimo
            funcionario1.RealizarEmprestimo(leitor1, "Dom Quixote", catalogo);

            // Removendo livro 
            funcionario2.AtualizarCatalogo(catalogo, "Dom Quixote", "autor", 2005, 3, false);

        }
    }
}
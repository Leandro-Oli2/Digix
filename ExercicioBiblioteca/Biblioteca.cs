using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Biblioteca
    {
        private string name;
        private string endereco;
        private CatalogoLivros catalogo;

        private List<Funcionario> Funcionarios { get; set; }
        
        public Biblioteca(string name, string endereco)
        {
            this.name = name;
            this.endereco = endereco;
            catalogo = new CatalogoLivros();
            Funcionarios = new List<Funcionario>();
        }
        public void AdicionarLivro(string livro)
        {
            catalogo.ConsultarCatalog().Add(livro); 
            System.Console.WriteLine("Livro Adicionado ao Catalogo!");
        }
        
        public void RemoverLivro(string livro)
        {
            catalogo.ConsultarCatalog().Remove(livro);
            System.Console.WriteLine("Livro Removido do Catalogo!");
        }
        
        public List<string> ConsultarCatalog(){
            return catalogo.ConsultarCatalog();
        }
        
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
            System.Console.WriteLine("Funcionario Adicionado!");
        }
        public void RealizarEmprestimo(Leitor leitor, string livro){
            
        }
    }
}
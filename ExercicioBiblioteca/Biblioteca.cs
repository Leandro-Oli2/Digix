using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Biblioteca
    {
        public string Nome { get; private set; }
        private CatalogoLivros catalogo;
        private List<Funcionario> funcionarios;

        public Biblioteca(string nome)
        {
            Nome = nome;
            catalogo = new CatalogoLivros();
            funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public CatalogoLivros ConsultarCatalogo()
        {
            return catalogo;
        }
    }
}

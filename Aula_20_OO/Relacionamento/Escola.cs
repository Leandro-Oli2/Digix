using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO
{
    public class Escola
    {
        /// <summary>
        ///  diamante preto composição obrigatorio
        ///  diamante branco agregção não obrigatorio
        /// </summary>
        private Estudante aluno;
        private Professor professor;

        public Escola(string nomeEstudante )
        {
            aluno = new Estudante(nomeEstudante);
            
        }

        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        public void MostrarInfo(){
            Console.WriteLine("Nome do aluno: " + aluno.Nome);
            Console.WriteLine("Nome do professor: " + professor.Name);
            professor.Ensinar();
        }
    }
}
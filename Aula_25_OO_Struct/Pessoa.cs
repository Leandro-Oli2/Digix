using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString(){
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    public class PessoaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString(){
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class ExecutarExe{
        static void Main1()
        {
            PessoaStruct pessoaStruct1 = new PessoaStruct("Leandro", 25);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "LeandroAlterado";
            Console.WriteLine(pessoaStruct1);
            Console.WriteLine(pessoaStruct2);

            PessoaClasse pessoaClasse1 = new PessoaClasse("Leandro", 25);
            PessoaClasse pessoaClasse2 = pessoaClasse1;
            pessoaClasse2.Nome = "LeandroAlterado";
            Console.WriteLine(pessoaClasse1);
            Console.WriteLine(pessoaClasse2);

            //1. struct é um tipo de valor, então atribuições criam copias independentes.
            //2. Classe é um tipo de referencia, então atribuições criam referencias para o mesmo objeto.
            //3. Struct são mais leves e geralmente são usados parados simples e imutaveis.
            //4. Classes são mais adequadas para objetos complexos e com estados mutaveis e comportamentos
        }
    }
}
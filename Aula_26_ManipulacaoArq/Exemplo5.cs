using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo5
    {
        // static void Main(string[] args){
        static void ex5(){
            string path = @"C:\Users\leandrocandido\Desktop\teste";
            try
            {
                //directory é uma classe estatica que permite a manipulação dos diretorios.
                //EnumerateDirectories que esta listando os diretorios/pasta
                //SearchOption.AllDirectories é para listar os diretorios/pastas em todos os niveis de profundidade.
                //*.* é para listar todos os tipos de arquivos/pastas.
                //Observação: Esta lista não contém o arquivo/pasta em si, apenas os nomes dos mesmos.
                //Para ver os nomes dos arquivos/pastas, é necessário usar Directory.GetFiles().
                //Observação: Se você quiser filtrar os nomes de arquivos/pastas, você pode usar LINQ para fazer isso.
                IEnumerable<string>pastas = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string item in pastas)
                {
                    Console.WriteLine(item);
                }
                //Inumerar arquivos
                IEnumerable<string> arquivos = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string item in arquivos)
                {
                    Console.WriteLine(item);
                }

                // //Criar uma Pasta
                // Directory.CreateDirectory(path + @"\teste2");

                // //Deletar uma Pasta
                // Directory.Delete(path + @"\teste2", true);

                //verificar se uma pasta existe
                bool existe = Directory.Exists(path + @"\Nova");
                System.Console.WriteLine("A pasta Existe: " + existe);
            }
            catch (IOException e)
            {
            System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
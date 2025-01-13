using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo6
    {
        // static void Main(string[] args){

        static void ex6(){
            string inicioPath = @"C:\Users\leandrocandido\Desktop\teste4.txt";
            System.Console.WriteLine("Diretory Separator Char" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de Caminho: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo" + Path.GetDirectoryName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo" + Path.GetFileName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo sem extensão" + Path.GetFileNameWithoutExtension(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo sem extensão" + Path.GetFileNameWithoutExtension(inicioPath));
            System.Console.WriteLine("Retorna somente e xtenção do arquivo" + Path.GetExtension(inicioPath));
        }
    }
}
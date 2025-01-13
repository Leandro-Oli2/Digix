using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo1
    {
        // static void Main(string[] args){
            static void Exe1(){
            //File é uma classe estaica que contem metodos para manipulação de arquivos
            string inicioPath = @"C:\Users\leandrocandido\Desktop\teste1.txt"; 

            string finalFile = @"C:\Users\leandrocandido\Desktop\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(inicioPath);
                fileInfo.CopyTo(finalFile); // Copia do arquivo de origem par ao destino

                //Mostrando o que ta escrito no arquivo no console.
                string[] lines = File.ReadAllLines(inicioPath);
                foreach(string line in lines)
                {
                    System.Console.WriteLine(line);
                }
            }
            catch(IOException e) //Tratamento de erro especifico para manipular arquivo 
            {
                System.Console.WriteLine("Ocorreu Error: " + e.Message);
            }

        }
    }
}
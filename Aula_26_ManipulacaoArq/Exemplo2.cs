using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo2
    {
        // static void Main(string[] args){
        static void ex2(){
             string inicioPath = @"C:\Users\leandrocandido\Desktop\teste1.txt";
             FileStream fileStream = null;//Esssa é uma classe que permite leitura e escrita de arquivos, e é uma classe de baixo nivel.
             StreamReader streamReader = null;///Esssa é uma classe que permite leitura e escrita de arquivos, e é uma classe de alto nivel.

             try
             {
                fileStream = new FileStream(inicioPath, FileMode.Open); // abre o arquivo
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                System.Console.WriteLine(line);

                while(line != null){
                    line = streamReader.ReadLine();
                    System.Console.WriteLine(line);
                }
             }
             catch (IOException e)
             {
                
                System.Console.WriteLine("Error: " + e.Message);
             }
             finally{
                //precisa fechar o arquivo, pois o s.o não faz isso automaticamente.
                if(streamReader!=null){
                    streamReader.Close();
                }
                if(fileStream!=null){
                    fileStream.Close();
                }
             }

        }
    }
}
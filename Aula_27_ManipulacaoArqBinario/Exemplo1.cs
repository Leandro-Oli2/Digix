using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipulacaoArqBinario
{
    public class Exemplo1
    {
        // static void Main(string[] args){
        static void ex1(){
            string filePath = "dados.bin";

            using(BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create))){
                writer.Write(123); // colocado o valor 123 no arquivo
                writer.Write(45.3546);
                writer.Write("Hello, world!");
            }
            
            System.Console.WriteLine("Dados gravados: "+ filePath);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipulacaoArqBinario
{
    public class Exemplo2
    {
        // lendo o arquivo binario e imprimindo no prompt
        // static void Main(string[] args){
            static void ex2(){
            string filePath = "dados.bin";

            using(BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open))){
                int inteiro = reader.ReadInt32();
                double numero = reader.ReadDouble();
                string texto = reader.ReadString();

                System.Console.WriteLine("Numero int do arquvio: " + inteiro);
                System.Console.WriteLine("Numero double do arquvio: " + numero);
                System.Console.WriteLine("Texto do arquvio: " + texto);
            }
        }
    }
}
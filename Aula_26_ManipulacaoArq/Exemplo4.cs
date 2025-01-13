using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo4
    {
        // static void Main(string[] args){
        static void ex4(string[] args){
        string inicioPath = @"C:\Users\leandrocandido\Desktop\teste1.txt";
        string finalPath = @"C:\Users\leandrocandido\Desktop\teste2.txt";

        try
        {
            string [] lines = File.ReadAllLines(inicioPath);
            using(StreamWriter sw = File.AppendText(finalPath)){
                foreach(string item in lines){
                    sw.WriteLine(item.ToUpper()); // escreve a linha em MAIUSCULO
                    //todos em maiusculo
                    sw.WriteLine(item.ToLower());
                    //Invertendo a ordem
                    sw.WriteLine(item.Reverse().ToArray());
                }
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine("Error: " + e.Message);
        }
        }
    }
}
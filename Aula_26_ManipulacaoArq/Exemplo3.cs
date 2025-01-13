using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_26_ManipulacaoArq
{
    public class Exemplo3
    {
        // static void Main(string[] args){
        static void ex3(){
            string inicioPath = @"C:\Users\leandrocandido\Desktop\teste1.txt";

            try{
                
                using (FileStream fs = new FileStream(inicioPath, FileMode.Open)){
                    using (StreamReader sr = new StreamReader(fs)){
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }catch(IOException e){
                    System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
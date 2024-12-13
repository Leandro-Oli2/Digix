using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aula_18_OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos("Bomba Atomica", 10000);
            // p.setNome("Bomba Nuclear");
            p.Nome = "Bomba Container";
            p.Preco = 20000;
            p.setQuantidade(20);
            System.Console.WriteLine(p.ToString());

            //Algumas funções para validar seus tipos e Propriedade
            Type t = typeof(Produtos); // retorna o tipo da classe
            Console.WriteLine(t.Name);
            
            System.Console.WriteLine("Propriedades");
            foreach(PropertyInfo prop in t.GetProperties()){
                System.Console.WriteLine(prop.Name);
            }
        }

        
    }
}
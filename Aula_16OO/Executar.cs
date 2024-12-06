using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_16OO;

namespace Aula_16OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
        Carnes c1 = new Carnes("Picanha", 48.89, 4);
        Ferramentas f1 = new Ferramentas("Chave de Fenda", 20.0, 3);
        Laticinios l1 = new Laticinios("Queijo", 34.56, 4);
        Limpeza lim1 = new Limpeza("Sabão de Barra", 23.56, 8);
        Petiscos p1 = new Petiscos("Petisco de Frango", 50.00, 20);
        
        System.Console.WriteLine("=========== Produto 1 ===========");
        c1.EscreverSaida();
        System.Console.WriteLine("=========== Produto 2 ===========");
        f1.EscreverSaida();
        System.Console.WriteLine("=========== Produto 3 ===========");
        l1.EscreverSaida();
        System.Console.WriteLine("=========== Produto 4 ===========");
        lim1.EscreverSaida();
        System.Console.WriteLine("=========== Produto 5 ===========");
        p1.EscreverSaida();

        double maiorValor = Math.Max(c1.CalcularEstoque(),
        Math.Max(f1.CalcularEstoque(), 
            Math.Max(l1.CalcularEstoque(), 
                Math.Max(lim1.CalcularEstoque(),
                    p1.CalcularEstoque())))); 
        System.Console.WriteLine($"O produto com maior estoque é: {maiorValor}");
        }
    }
}
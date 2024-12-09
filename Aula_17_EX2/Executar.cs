using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX2
{
    public class Executar
    {
        static void Main(string[] args){
        Produto [] produtos = new Produto[3];
        produtos[0] =  new Livro(1, 20.0, "Autor 1", 123456789);
        produtos[1] =  new CompactDisc(2, 15.0, "Artista 1", "Gravadora 1");
        produtos[2] = new Livro(3, 120.0, "Autor 2", 3344555322);

        foreach(Produto produto in produtos){
            Console.WriteLine("CODIGO: " + produto.GetCodigo());
            Console.WriteLine("PREÇO: " + produto.GetPreco());
            produto.atualizaPreco(produto.GetPreco() * 1.1);
            Console.WriteLine("PREÇO ATUALIZADO: " + produto.GetPreco());
            Console.WriteLine();
        }

        }  
    }
}
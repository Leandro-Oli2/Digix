using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public class Estoque
    {
        public Produto[] Produtos { get; set; }
        public int[] Quantidades { get; set; }

        public bool VerificarEstoque(Produto produto){
            int index = Array.IndexOf(Produtos, produto);
            if(index == -1){
                return false;
            }
            return index >= 0 && Quantidades[index] > 0;
        }
        public Produto ProcurarProduto(string nome){
            foreach(var produto in Produtos){
                if(produto.Nome == nome){
                    return produto;
                }
            }
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX2
{
    public class Livro : Produto
    {
        public string Autor;
        public long Isbn;

        public Livro(int Codigo, double preco, string autor, long isbn) : base(Codigo, preco)
        {
            Autor = autor;
            Isbn = isbn;
        }
        public void SetAutor(string autor){
            Autor = autor;
        }

        public void SetIsbn(long isbn){
            Isbn = isbn;
        }
        public string GetAutor(){
            return Autor;
        }
        public long GetIsbn(){
            return Isbn;
        }
        public override string atualizaPreco(double Preco)
        {
            if (Preco <= 0)
                return "Preço inválido!";
            else
            {
                this.Preco = Preco;
                return $"Novo preço: {this.Preco}";
            }
        }
    }
}
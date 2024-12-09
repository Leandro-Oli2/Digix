using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX2
{
    public class CompactDisc : Produto
    {
        public string Artista;
        public string Gravadora;

        public CompactDisc(int Codigo, double preco, string artista, string gravadora) : base(Codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }
        public void SetArtista(string artista){
            Artista = artista;
        }

        public void SetGravadora(string gravadora){
            Gravadora = gravadora;
        }

        public string GetArtista(){
            return Artista;
        }
        public string GetGravadora(){
            return Gravadora;
        }
        public override string atualizaPreco(double p)
        {
            if (p <= 0)
                return "Preço inválido!";
            else
            {
                Preco = p;
                return $"Novo preço: {Preco}";
            }
        }

    }
}
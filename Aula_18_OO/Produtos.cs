using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO
{
    public class Produtos
    {
        public string Nome {get; set; } // convenção de nomenclatura do C#
        private double _preco;

        private int _quantidade;

        public Produtos(string nome, double preco){
            Nome = nome;
            _preco = preco;
        }

        public Produtos(string nome, double preco, int quantidade) : this(nome, preco){
            _quantidade = quantidade;
        }


        // public string GetNome(){
        //     return _nome;
        // }
        // public void setNome(string nome){
        //     if(nome != null && nome.Length > 0){
        //         _nome = nome;
        //     }
        // }
        // public string Nome{
        //     get { 
        //         return _nome;
        //     }
        //     set{ 
        //         if(value != null && value.Length > 1){
        //             _nome = value; 
        //         }
        //     }
        // }
        // // public double GetPreco(){
        // //     return _preco;
        // // }
        // // public void setPreco(double preco){
        // //     _preco = preco;
        // // }

        public double Preco{
            get{
                return _preco;
            }
            set{
                if(value > 0){
                    _preco = value;
                }
            }
        }
        
        public int GetQuantidade(){
            return _quantidade;
        }
        public void setQuantidade(int quantidade){
            _quantidade = quantidade;
        }
        public void AdicionarProduto(int quantidade){
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade){
            _quantidade -= quantidade;
        }
        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }
        public override string ToString(){
            return Nome + ", $" + _preco.ToString("F2") + ", " + _quantidade + "unidades, Total: $ "
             + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
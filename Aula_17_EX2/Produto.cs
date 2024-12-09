using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_EX2
{
    public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        public Produto(int codigo, double preco){
            Codigo = codigo;
            Preco = preco;
        }

        public void SetCodigo(int codigo){
            Codigo = codigo;
        }
        public void SetPreco(double preco){
            Preco = preco;
        }
        public double GetPreco(){
            return Preco;
        }
        public string GetCodigo(){
            return $"Código: {Codigo}";
        }
        public abstract string atualizaPreco(double Preco);
    }
}
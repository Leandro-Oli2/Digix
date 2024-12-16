using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO
{
    public class CartaoCretido : IPagamento, IAnuidade
    {
        //Properties
        public string NumeroCartao { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorAnuidade { get; set; }

        //constructor
        public CartaoCretido(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
        }

        public CartaoCretido(string numeroCartao, DateTime dataVencimento, double valorAnuidade){
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            ValorAnuidade = valorAnuidade;
        }

        public void RealizarPagamento(double valor){
            Console.WriteLine($"Pagamento realizado com cartão de crédito. Valor: {valor}");
        }

        public void ExibirComprovante(){
            Console.WriteLine($"Gerando comprovante para pagamento com cartão de crédito {NumeroCartao}, \nno dia {DateTime.Now}.");
        }
        public DateTime CalcularDataVencimento(){
            return DateTime.Now.AddYears(1);
        }
        public double CalcularValorAnuidade(){
            return 100;
        }

    }
}
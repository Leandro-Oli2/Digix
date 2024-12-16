using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO
{
    public class Pix : IPagamento
    {   
        public string? ChavePix { get; set; }
        public string? NomeTitular { get; set; }
        public string? Cpf { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Pix(string chavePix, string nomeTitular, string cpf, double valor, DateTime dataPagamento)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            Cpf = cpf;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        public void RealizarPagamento(double valor){
            Valor = valor;
            Console.WriteLine("Pagamento relizado com sucesso via pix!");
        }

        public void Pagar(){
            Console.WriteLine($"Pagamento realizado com Pix: {ChavePix}");
        }

        public void ExibirComprovante(){
            Console.WriteLine($"Nome Titular: {NomeTitular}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Data Pagamento: {DataPagamento.ToShortDateString()}");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_26_ManipulacaoArq.Banco;
using ClosedXML.Excel;

namespace Aula_26_ManipulacaoArq
{
    public class ExecutarBanco
    {
        static void Main(string[] args){
            var cliente = new Customer("João de Deus");
            var contaCorrente = new CurrentAccount(1234, cliente, 500);
            var contaPoupanca = new SavingAccount(5323, cliente, 0.01);

            contaCorrente.Depositar(100);
            contaCorrente.Sacar(100);

            contaPoupanca.Depositar(500);
            contaPoupanca.AplicarRendimento();

            GerarExcel(new List<Account> { contaCorrente, contaPoupanca});


        }
        public static void GerarExcel(List<Account> contas){
            using(var workbook = new XLWorkbook()){
                //aqui estamos criando o arquivo Contas bancarias em excel
                var worksheet = workbook.Worksheets.Add("Contas Bancarias");

                //cabeçalho
                worksheet.Cell(1,1).Value = "Numero da Conta";//cell é celular no excel
                worksheet.Cell(1,2).Value = "Nome do Cliente";
                worksheet.Cell(1,3).Value = "Tipo da Conta";
                worksheet.Cell(1,4).Value = "Saldo";

                //Configurar para preencher a partir da linha 2
                int row = 2;
                foreach(var item in contas){
                    worksheet.Cell(row, 1).Value = item.NumeroConta;
                    worksheet.Cell(row, 2).Value = item.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = item.GetType().Name;
                    worksheet.Cell(row, 4).Value = item.Saldo;
                    row++;
                }
                workbook.SaveAs("ContasBancarias.xlsx");
                Console.WriteLine("Arquivo criado com sucesso!");
            }
        }
    }
}

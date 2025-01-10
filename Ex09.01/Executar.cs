using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09._01
{
    public class Executar
    {
        public static void Main(string[] args){
            // Supondo que você tenha contas e banco configurados
            Bank banco = new Bank("001", "Rua Principal, 123");
            Customer cliente = new Customer("Leandro", "Rua 10, 456", new DateTime(2005, 1, 1), "123456789", "1234");
            Account contaCorrente = new CurrentAccount("CC001", 1000.00, banco, cliente, 500.00);
            Account contaPoupanca = new SavingAccount("CP001", 1500.00, banco, cliente);
            
            // Adicionando as contas ao banco
            banco.AdicionarConta(contaCorrente);
            banco.AdicionarConta(contaPoupanca);
            
            Menu(banco, cliente);

        }
         public static void Menu(Bank banco, Customer cliente)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n========== Menu Principal ==========");
                Console.WriteLine("1. Sacar");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Transferir");
                Console.WriteLine("4. Exibir Histórico de Transações");
                Console.WriteLine("5. Listar Contas");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o número da conta para o saque (ex: CC001 ou CP001): ");
                        string numeroContaSaque = Console.ReadLine();
                        Account contaSaque = banco.BuscarContaPorNumero(numeroContaSaque);
                        if (contaSaque != null)
                        {
                            Console.Write("Digite o valor para o saque: ");
                            double valorSaque = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                contaSaque.withdraw(valorSaque);
                            }
                            catch (DomainException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;

                    case "2":
                        Console.Write("Digite o número da conta para depósito (ex: CC001 ou CP001): ");
                        string numeroContaDeposito = Console.ReadLine();
                        Account contaDeposito = banco.BuscarContaPorNumero(numeroContaDeposito);
                        if (contaDeposito != null)
                        {
                            Console.Write("Digite o valor para depósito: ");
                            double valorDeposito = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                contaDeposito.deposit(valorDeposito);
                            }
                            catch (DomainException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número da contapara transferência (ex: CC001 ou CP001): ");
                        string numeroContaOrigem = Console.ReadLine();
                        Account contaOrigem = banco.BuscarContaPorNumero(numeroContaOrigem);
                        if (contaOrigem != null)
                        {
                            Console.Write("Digite o número da conta para transferência (ex: CC001 ou CP001): ");
                            string numeroContaDestino = Console.ReadLine();
                            Account contaDestino = banco.BuscarContaPorNumero(numeroContaDestino);
                            if (contaDestino != null)
                            {
                                Console.Write("Digite o valor para transferencia: ");
                                double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                                try
                                {
                                    contaOrigem.createTransaction("Current", valorTransferencia, contaDestino); 
                                }
                                catch (DomainException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                        }
                        break;

                    case "4":
                        Console.Write("Informe o número da conta para ver o histórico: ");
                        string numeroContaHistorico = Console.ReadLine();
                        Account contaHistorico = banco.BuscarContaPorNumero(numeroContaHistorico);
                        if (contaHistorico != null)
                        {
                            contaHistorico.ExibirHistoricoTransacoes();
                        }
                        break;

                    case "5":
                        banco.ListarContas();
                        break;

                    case "6":
                        continuar = false;
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
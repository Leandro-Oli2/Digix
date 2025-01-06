using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace Aula_21_OO
{
    public class Executar
    {
        static void Main(string[] args){
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;
            do{
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Fazer Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao){
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos);
                        break;
                    case 3:
                        RegistrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }while(opcao != 6);
            
        }
    }
}
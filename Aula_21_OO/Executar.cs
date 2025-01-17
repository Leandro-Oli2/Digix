using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace Aula_21_OO
{
    public class Executar
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();//Limpa a tela
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Funcionarios");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
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
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 6);
        }

        

        private static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Cidade, Estado, CEP)");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite o estado: ");
            string estadoendereco = Console.ReadLine();
            if(!Enum.TryParse(estadoendereco, out Estado estadoEnum)){
                Console.WriteLine("Estado inválido!");
                return;
            }

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[3])
                }
            };
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {
            Console.Clear(); //Limpa a tela
            Console.WriteLine("===== Cadastro de Produto =====");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de custo: ");
            double precoCusto = double.Parse(Console.ReadLine());
            // Console.Write("Digite o Apelido: ");
            // string apelido = Console.ReadLine();
            Console.Write("Digite se o produto é perecível: ");
            bool perecivel = bool.Parse(Console.ReadLine());
            Console.Write("Digite o preço final: ");
            double precoFinal = double.Parse(Console.ReadLine());
            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());

            // Cadatrar do fornecedor
            Console.Write("=== Cadastro do Fornecedor ===");
            Console.Write("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Cidade, Estado, CEP)");
            string endereco = Console.ReadLine();
            Console.Write("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("Digite se o fornecedor é recorrente: ");
            bool recorrente = bool.Parse(Console.ReadLine());
            Console.Write("Digite o desconto: ");
            double desconto = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o estado: ");
            string estadoendereco = Console.ReadLine();
            if(!Enum.TryParse(estadoendereco, out Estado estadoEnum)){
                Console.WriteLine("Estado inválido!");
                return;
            }

            string apelido = ApelidosPorEstado[estadoEnum];

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = nomeFornecedor,
                CNPJ = cnpj,
                Recorrente = recorrente,
                Desconto = desconto,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[3])
                }
            };

            Produto produto = new Produto
            {
                Nome = nome,
                Codigo = codigo,
                PrecoCusto = precoCusto,
                Apelido = apelido,
                Perecivel = perecivel,
                PrecoFinal = precoFinal,
                DataValidade = dataValidade,
                Fornecedor = fornecedor
            };
            produtos.Add(produto);
            estoque.Produtos = produtos.ToArray();
            System.Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas)
        {
            Console.Clear(); //Limpa a tela
            Console.WriteLine("===== Cadastro de Venda =====");
            Console.Write("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Cliente cliente = clientes.First(c => c.CPF == cpf);// Find é metodo que procura um elemento na lista

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
                return;
            }

            List<Produto> produtosVenda = new List<Produto>();
            while (true)
            {
                Console.Write("Digito o codigo do produto (0 para finalizar): ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0) break;

                Produto produto = produtos.First(p => p.Codigo == codigo);
                if (produto != null)
                {
                    produtosVenda.Add(produto);
                }
                else
                {
                    Console.WriteLine("Produto não encontrado");
                }
            }

            Venda venda = new Venda
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente,
                FormaPagamento = "Cartão",
                Parcelas = 3,
                // ValorTotal = vendas.CalcularValorFinal();
            };
            venda.ValorTotal = venda.CalcularValorFinal(); // Aqui eu estou chamando o método CalcularValorFinal da classe Venda


            vendas.Add(venda);
            Console.WriteLine("Venda registrada com sucesso!");
        }

        private static void ConsultarEstoque(Estoque estoque){
            Console.Clear();
            Console.WriteLine("===== Consulta de Estoque =====");
            Console.WriteLine("Produtos disponíveis:");
            if(estoque.Produtos != null){
                foreach (var produto in estoque.Produtos)
                {
                    Console.WriteLine($"Nome: {produto.Nome}, Apelido: {produto.Apelido}, Código: {produto.Codigo}, Preço Final: {produto.PrecoFinal},");
                }
            }else{
                Console.WriteLine("Estoque Vazio!.");
            }
        }
        
        private static void GerarRelatorioVendas(List<Venda> vendas){
            Console.Clear();
            Console.WriteLine("===== Relatório de Vendas =====");
            Console.WriteLine("Data | Cliente | Valor Total");
            foreach (var venda in vendas)
            {
                Console.WriteLine($"{venda.Data.ToString("dd/MM/yyyy")} | {venda.Cliente.Nome} | {venda.ValorTotal}");
            }
        }
        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string>{
            
            { Estado.BA, "Acarajé" },
            { Estado.MG, "Pão de Queijo" },
            { Estado.MS, "Chipa" },
            { Estado.RJ, "Bixcoito" },
            { Estado.SP, "Chipa" },
        };
    }
}


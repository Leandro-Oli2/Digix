using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_Ex
{
    public class ContaBancaria
    {
        public int numeroC { get; private set; }

        private string _nome;

        private double _saldo;

        public ContaBancaria(int numeroConta, string nome){
            if(numeroC == 0){
                numeroC = numeroConta;
            }
            _nome = nome;
        }
        public ContaBancaria(int numeroConta, string nome, double saldo) :this(numeroConta, nome){
            _saldo = saldo;
        }
        public void AlterarNome(string nome){
            _nome = nome;
            System.Console.WriteLine("Nome alterado com sucesso!");
        }
        public void Depositar(double valor){
            if(valor > 0){
                _saldo += valor;
                System.Console.WriteLine($"Deposito de {valor} realizado com sucesso!");
            } else {
                System.Console.WriteLine("Valor inválido para deposito!");
            }
        }
        public void Sacar(double valor){
            if(valor > 0){
                _saldo -= valor;
            }
        }

        public override string ToString(){
            return $"Conta: {numeroC}, Titular: {_nome}, Saldo: {_saldo}";
        }
        public static void Main(string[] args){
            ContaBancaria c1 = new ContaBancaria(0, "");
            System.Console.WriteLine("========= Cadatrar Conta =========");
            System.Console.WriteLine("1- Com Deposito Incial");
            System.Console.WriteLine("2- Sem Deposito Incial");
            System.Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());
            if(opcao == 1){
                System.Console.Write("Informe o numero da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                System.Console.Write("Informe o nome do titular: ");
                string nome = Console.ReadLine();
                System.Console.Write("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                c1 = new ContaBancaria(numeroConta, nome, saldo);
            }else if(opcao == 2){
                System.Console.Write("Informe o numero da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                System.Console.Write("Informe o nome do titular: ");
                string nome = Console.ReadLine();
                c1 = new ContaBancaria(numeroConta, nome);
            }
            int cont = 1;
            while(cont == 1){
                System.Console.WriteLine("==== MENU ===");
                System.Console.WriteLine("1 - Alterar Nome");
                System.Console.WriteLine("2 - Depositar");
                System.Console.WriteLine("3 - Sacar");
                System.Console.WriteLine("4 - Mostrar Conta");
                System.Console.WriteLine("5 - Sair");
                System.Console.Write("Escolha: ");
                int escolha = int.Parse(Console.ReadLine());
                if(escolha == 1){
                    System.Console.Write("Informe o novo nome: ");
                    string novoNome = Console.ReadLine();
                    c1.AlterarNome(novoNome);
                } else if(escolha == 2){
                    System.Console.Write("Informe o valor do deposito: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    c1.Depositar(valorDeposito);
                } else if(escolha == 3){
                    System.Console.Write("Informe o valor do saque: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    c1.Sacar(valorSaque);
                } else if(escolha == 4){
                    System.Console.WriteLine(c1.ToString());
                    cont = 0;
                } else if(escolha == 5){
                    System.Console.WriteLine("Saindo...");
                    cont = 0;
                }
            }
        }
    }
}
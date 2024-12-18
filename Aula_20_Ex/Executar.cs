using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class Executar
    {
        static void Main(string[] args){
            Console.WriteLine("Herança: ");
            Funcionario funcionario = new Funcionario("Leandro", "10-08-2005", "109.493.234-56");
            Console.WriteLine($"Funcionario: Nome: {funcionario.Nome}, Data Nascimento: {funcionario.Nascimento}, CPF: {funcionario.CPF}");

            Console.WriteLine("Composição:");
            EquipeVenda equipe1 = new EquipeVenda("PulsarDigix");
            Vendedor vendedor1 = new Vendedor("Carlos", "20-02-2005", "134.234.666-56");
            System.Console.WriteLine($"{vendedor1.equipeVenda.Nome}");
        }
    }
}
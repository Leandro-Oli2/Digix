using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20_OO.Exemplo;
namespace Aula_20_OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Escola escola = new Escola("Leandro");
            // Professor professor = new Professor("Edvaldo");
            // escola.ContratarProfessor(professor);
            // escola.MostrarInfo();
            Console.WriteLine("Herança:");
            PortaCozinha portaC = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            portaC.Abrir();
            Console.WriteLine($"PortaCozinha: Cor: {portaC.Cor}, Largura: {portaC.Largura}, Altura: {portaC.Altura}, Peso: {portaC.Peso}");
        
            Console.WriteLine("Agregação:");
            Cozinha cozinha = new Cozinha(true, 20);
            cozinha.Entrar(portaC);

            Console.WriteLine("Composição:");
            PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            Quarto quarto = new Quarto(true, 15);
            Console.WriteLine($"Quarto: {quarto.PortaQuarto.Cor}");

            Console.WriteLine("Associação Simples:");
            PortaSala portaSala = new PortaSala("Azul", 1.5f, 1.0f, 20);
            Sala sala = new Sala(portaSala, portaQuarto, 20);
            sala.AbrirPortaAux();
        }
                
    }
}
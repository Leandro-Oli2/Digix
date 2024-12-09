using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Aula_17_OO_Visibility
{
    public class Funcionarios
    {
        //Qualquer Lugar
        public string Nome;

        //Apenas Dentro da classe
        private double Salario;

        //Apenas Dentro da Classe e Filha
        protected string Cargo;

        public Funcionarios(string nome, double Sal, string cargo){
            Nome = nome;
            Salario = Sal;
            Cargo = cargo;
        }
 public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            // Console.WriteLine($"Salario: {Salario}"); // * Acessando atributo privado
            Console.WriteLine($"Cargo: {Cargo}");
        }

        // Metodo protegido: acessivel apenas dentro da classe e suas subclasses
        protected void AtualizarCargo(string novoCargo)
        {
            Cargo = novoCargo;
            Console.WriteLine($"Cargo atualizado para: {Cargo}");
        }

        // Metodo privado: acessivel apenas dentro da classe
        private double CalcularImposto()
        {
            return Salario * 0.1; // 10%
        }
        
    }
}
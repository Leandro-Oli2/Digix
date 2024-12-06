using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Herança
{
    public class Funcionario
    {
            //Atributos globais de Funcionario
            public string Nome;
            public string CPF;
            public double Salario;

            public Funcionario(string nome, string cpf, double salario){
                this.Nome = nome;
                this.CPF = cpf;
                this.Salario = salario;
            }

            public virtual double GetBonificacao(){
                return Salario * 0.1;
            }

            public virtual void ImprimirSaida(){
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"CPF: {CPF}");
                Console.WriteLine($"Salario: {Salario}");
                Console.WriteLine($"Bonificacao: {GetBonificacao()}");
            }
    }
}
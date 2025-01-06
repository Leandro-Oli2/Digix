using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set;}
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }


        public abstract double CalcularSalario();
        public abstract void GerarRelatorio();
        
    }

    public class Gerente : Funcionario{
        public override double CalcularSalario(){
            return SalarioBase * 1.1;
        }
        public void CalcularGratificacao(){
            Console.WriteLine("foi calculada a gratificação do Gerente...");
        }
        public override void GerarRelatorio(){
            System.Console.WriteLine("Gerente: " + Nome);
            System.Console.WriteLine("Salario: " + CalcularSalario());
        }
    }
    public class Vendedor : Funcionario{
        public double VendasReaizadas { get; set; }
        public override double CalcularSalario(){
            return SalarioBase + (VendasReaizadas * 0.1);
        }
        public void CalcularComissao(){
            Console.WriteLine("foi calculada a comissao do vendedor...");
        }
        public override void GerarRelatorio(){
            System.Console.WriteLine("Vendedor: " + Nome);
            System.Console.WriteLine("Salario: " + CalcularSalario());
        }
    }
    public class Padeiro : Funcionario{
        public int HorasNoturnasTrabalhadas { get; set; }
        public override double CalcularSalario(){
            double adicionalNoturno = HorasNoturnasTrabalhadas * (SalarioBase * 0.25/160);
            return SalarioBase + adicionalNoturno;
        }
        public void CalcularProducao(){
            Console.WriteLine("foi calculada a produção do Padeiro...");
        }
        public override void GerarRelatorio(){
            System.Console.WriteLine("Padeiro: " + Nome);
            System.Console.WriteLine("Salario: " + CalcularSalario());
        }
    }
}
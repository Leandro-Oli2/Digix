using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public class Empregados
    {
        public int iNumeroMax = 50;
        public List<Empregado> empregados { get; set; } = new List<Empregado>();
        public int iNumeroEmpregados { get; set; }

        public void Inserir(Empregado empregado)
        {
            if (iNumeroEmpregados < iNumeroMax)
            {
                empregados.Add(empregado);
                iNumeroEmpregados++;
            }
            else
            {
                Console.WriteLine("Número máximo de empregados atingido.");
            }
        }
        public void Imprimir(){
            foreach(var empregado in empregados){
                Console.WriteLine($"Nome: {empregado.nome}, Status de licença: {empregado.statusLicenca}, Tipo de empregado: {empregado.tipoEmpregador}");
            }
        }
        public double FolhaPagamento(){
            double total = 0;
            foreach(var empregado in empregados){
                total += empregado.salario;
            }
            return total;
        }
    }
}
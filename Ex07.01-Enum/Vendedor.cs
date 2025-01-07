using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public class Vendedor : Empregado
    {
        public double comissao { get; set; }

        public Vendedor(string nome, double salario, double dSalarioMin, int iLicencasRecebidas, eStatusLicenca statusLicenca, eTipoEmpregado tipoEmpregador, double comissao) : base(nome, salario, dSalarioMin, iLicencasRecebidas, statusLicenca, tipoEmpregador)
        {
            this.comissao = comissao;
        }

        public double getSalario(){
            return salario + comissao;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public class Empregado : Pessoa
    {
        public double salario { get; set; }
        public double dSalarioMin = 250;
        public int iLicencasRecebidas { get; set; }
        public eStatusLicenca statusLicenca { get; set;}
        public eTipoEmpregado tipoEmpregador { get; set;}
        public Empregado(string nome, double salario, double dSalarioMin, int iLicencasRecebidas, eStatusLicenca statusLicenca, eTipoEmpregado tipoEmpregador): base(nome){
            this.salario = salario;
            this.dSalarioMin = dSalarioMin;
            this.iLicencasRecebidas = iLicencasRecebidas;
            this.statusLicenca = statusLicenca;
            this.tipoEmpregador = tipoEmpregador;
        }
    }
}
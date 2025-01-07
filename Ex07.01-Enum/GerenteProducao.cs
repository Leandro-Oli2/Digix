using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public class GerenteProducao : Empregado, Igerente
    {
        public GerenteProducao(string nome, double salario, double dSalarioMin, int iLicencasRecebidas, eStatusLicenca statusLicenca, eTipoEmpregado tipoEmpregador): base(nome, salario, dSalarioMin, iLicencasRecebidas, statusLicenca, tipoEmpregador)
        {
        }
        public void Autorizar(){
            Console.WriteLine("Autorizando trabalho do gerente de produção");
        }
        public bool ConcederAumento(){
            salario = 500.00;
            return true;
        }

        public bool AutorizarLicenca(Empregado empregado) {
            if(empregado.salario > 2000){
                Console.WriteLine("Autorizando licença para " + empregado.nome);
                return true;
            }else{
                Console.WriteLine("Não é possível autorizar licença para " + empregado.nome);
                return false;
            }
        }
    }
}
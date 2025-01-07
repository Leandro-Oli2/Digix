using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex07._01_Enum
{
    public class GerenteVendas : Vendedor, Igerente
    {
        public eRegiao Regiao { get; set; }

        public GerenteVendas(string nome, double salario, double dSalarioMin, int iLicencasRecebidas, eStatusLicenca statusLicenca, eTipoEmpregado tipoEmpregador, double comissao, eRegiao regiao) : base(nome, salario, dSalarioMin, iLicencasRecebidas, statusLicenca, tipoEmpregador, comissao)
        {
            Regiao = regiao;
        }

        public void Autorizar(){
            // Lógica para aumentar o salário do gerente
            Console.WriteLine("Autorizando trabalho do gerente de Vendas");
        }
         public bool ConcederAumento()
        {
            // Lógica para conceder aumento ao vendedor
            // Exemplo: Aumento de 10% no salário
            salario *= 1.10;
            Console.WriteLine($"Aumento concedido ao vendedor {nome}. Novo salário: {salario}");
            return true;  // Retorna true indicando que o aumento foi concedido com sucesso
        }

    // Implementando o método AutorizarLicenca
    public bool AutorizarLicenca(Empregado empregador)
    {
        // Lógica para autorizar a licença
        // Exemplo: Verificando se a região do vendedor é Norte para autorizar a licença
        if (Regiao == eRegiao.Norte || Regiao == eRegiao.Leste || Regiao == eRegiao.Oeste || Regiao == eRegiao.Sul)
        {
            Console.WriteLine($"Licença autorizada para o vendedor {empregador.nome} da região {Regiao}.");
            return true;  // Retorna true se a licença foi autorizada
        }
        else
        {
            Console.WriteLine($"Licença não autorizada para o vendedor {empregador.nome} da região {Regiao}.");
            return false;  // Retorna false se a licença não foi autorizada
        }
    }

    }
}
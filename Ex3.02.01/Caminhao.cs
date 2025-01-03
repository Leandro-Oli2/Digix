using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public class Caminhao : Veiculo
    {
        public int Eixos { get; set; }

        public Caminhao(string marca, string modelo, string placa, decimal valorDiaria, decimal impostoDiaria, int eixos)
            : base(marca, modelo, placa, valorDiaria, impostoDiaria)
        {
            Eixos = eixos;
        }

        public override decimal CalcularAluguel()
        {
            return (ValorDiaria + ImpostoDiaria) * Eixos;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, string placa, decimal valorDiaria, decimal impostoDiaria, int cilindradas = 125)
            : base(marca, modelo, placa, valorDiaria, impostoDiaria)
        {
            Cilindradas = cilindradas;
        }

        public override decimal CalcularAluguel()
        {
            return (ValorDiaria + ImpostoDiaria) * (Cilindradas / 100m);
        }
    }
}
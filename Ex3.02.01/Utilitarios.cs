using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public class Utilitario : Veiculo
    {
        public Utilitario(string marca, string modelo, string placa, decimal valorDiaria, decimal impostoDiaria)
            : base(marca, modelo, placa, valorDiaria, impostoDiaria)
        {
        }

        public override decimal CalcularAluguel()
        {
            return (ValorDiaria * 1.2m) + ImpostoDiaria;
        }
    }
}
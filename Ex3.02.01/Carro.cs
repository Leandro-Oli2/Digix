using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public class Carro : Veiculo
    {
        public string Categoria { get; set; } // A, B, C

        public Carro(string marca, string modelo, string placa, decimal valorDiaria, decimal impostoDiaria, string categoria)
            : base(marca, modelo, placa, valorDiaria, impostoDiaria)
        {
            Categoria = categoria;
        }

        public override decimal CalcularAluguel()
        {
            return ValorDiaria + ImpostoDiaria;
        }
    }
}
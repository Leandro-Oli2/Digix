using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3._02._01
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ImpostoDiaria { get; set; }

        public Veiculo(string marca, string modelo, string placa, decimal valorDiaria, decimal impostoDiaria)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            ValorDiaria = valorDiaria;
            ImpostoDiaria = impostoDiaria;
        }

        public abstract decimal CalcularAluguel();
    }
}
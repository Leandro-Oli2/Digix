using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Ex
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda equipeVenda { get; set; }
        public float Salario { get; set; }
        public Vendedor(string nome, string nascimento, string cpf) : base(nome, nascimento, cpf)
        {
            equipeVenda = new EquipeVenda("PulsarDigix");
        }
        public float GetSalario(){
            return Salario;
        }
    }
}
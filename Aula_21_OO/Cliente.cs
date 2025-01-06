using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco? Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        //para ocorrer composição o Endereço deve ser instanciado no construtor
        public Cliente()
        {
            Endereco = new Endereco();
        }
        //constructed
        public Cliente(string nome, string rua, string cidade, string estado, int cep, string telefone, string cpf ){
                Nome = nome;
                Endereco = new Endereco(rua, cidade, estado, cep);
                Telefone = telefone;
                CPF = cpf;

        }

        public abstract string ConsultarFidlidade();

    }
    public class ClienteGold: Cliente{
        public double Desconto { get; set; }
        public override string ConsultarFidlidade(){
            return "Cliente Gold, tem o desconto de 10%";
        }
    }
    public class ClientePremium: Cliente{
        public double Desconto { get; set; }
        public override string ConsultarFidlidade(){
            return "Cliente Premium,tem desconto de 15%";
        }
    }
}
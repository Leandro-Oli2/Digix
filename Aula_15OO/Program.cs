using System;

namespace POO{
    public class Cachorro{
        public string Nome;
        public string Raca;
        public int Idade;
        public void escreverSaida(){
            Console.WriteLine("Nome: " + Nome + ", Raça: " + Raca + ", Idade: " + Idade);
            Console.WriteLine("Idade em Humano: " + getIdade());
        }

        public int getIdade(){
            int idadehumano = 0;
            if(Idade <= 2){
                idadehumano = Idade * 11;
            }else{
                idadehumano = 22 + (Idade - 2) * 7;
            }
            return idadehumano;
        }
    }

}
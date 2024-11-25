using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Aula_13{
    

    public class Pilha{
        static int[] pilha = new int[10];
        static int topo = 0;

        public static void Empilhar(int item){
            if(topo < pilha.Length){
                pilha[topo] = item;
                topo++;
            }else{
                System.Console.WriteLine("Pilha Cheia!");
            }

        } 
        public static int Desempilhar(){
            if(topo > 0){
                topo--;
                return pilha[topo];
            } else{
                System.Console.WriteLine("Pilha Vazia!");
                return -1;
            }
        }
        public static void Listar(){
            for(int i = topo-1; i >= 0; i--){
                System.Console.WriteLine(pilha[i]);
            }
        }
        static void Main(string[] args){
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Empilhar(40);
            Empilhar(50);
            Listar();
            for(int i = 0; i < 5; i++){
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("Desempilhando: " + Desempilhar());
            System.Console.WriteLine("==================================");
            Listar();
            }



        }

    }
}

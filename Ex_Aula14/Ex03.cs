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
                if(i == topo - 1){ 
                    System.Console.Write(pilha[topo-1] + "(topo)->");
                }else{
                    System.Console.Write(pilha[i] + "->");
                }
            }
            System.Console.WriteLine("");
        }
        public static void topoP(){
            System.Console.WriteLine("Topo da Pilha: " + pilha[topo-1]);
        }
        static void Main3(string[] args){
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Empilhar(40);
            Empilhar(50);
            Listar();
            topoP();
            
        }
    }
}

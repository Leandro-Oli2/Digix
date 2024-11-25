using System;
using System.Diagnostics.Contracts;

namespace PilhaEncadeada{

    public class PilhaEncad{

        class Node{
            public int Valor;
            public Node? Proximo;
        }
        static Node? topo = null;
        static void Empilhar(int valor){
            Node novoNode = new Node { Valor = valor, Proximo = null };

            topo = novoNode;

        }
        static void Desempilhar(){
            if(topo == null){
                System.Console.WriteLine("A pilha esta vazia.");
                return;
            }
            int valor = topo.Valor;


        }
        static void listar(){
            if(topo == null){
                System.Console.WriteLine("A pilha esta vazia.");
                return;
            }
            Node? atual = topo;
            Console.WriteLine("Elementos na pilha:");
            while(atual!= null){
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }

        }
        static void Main(string[] args){
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            listar();
            Desempilhar();
            listar();
            
        }

    }
}
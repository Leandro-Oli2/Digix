using System;
using System.Diagnostics.Contracts;

namespace ListaDupEncadeada{

    public class ListaDuplamenteEncad{

        class Node{
            public int Valor;
            public Node? Proximo;
            public Node? Anterior;
        }
        static Node? inicio = null;

        static void inserir(int valor){
            Node novoNode = new Node { Valor = valor, Proximo = null, Anterior = null };
            if(inicio == null){
                inicio = novoNode;
            }else{
                Node atual = inicio;
                while(atual.Proximo != null){
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
                novoNode.Anterior = atual;
            }
        }
        static void Excluir(int valor){
            if(inicio == null){
                System.Console.WriteLine("Lista Vazia...");
                return;
            }
            // if(inicio.Valor == valor){
            //     inicio = inicio.Proximo;
            //     inicio.Anterior = null;
            //     return;
            // }
            if(inicio.Valor == valor){
                if( inicio.Proximo != null){
                    inicio.Proximo.Anterior = null;
                }
                inicio = inicio.Proximo;
                return;
            }
            Node? atual = inicio;
            while(atual != null && atual.Valor != valor){
                atual = atual.Proximo;
            }
            if(atual != null){
                if(atual.Anterior != null){
                    atual.Anterior.Proximo = atual.Proximo;
                }
            }
        }
        static void Listar(){
            Node? atual = inicio;
            while(atual!= null){
                Console.Write(atual.Valor + ", ");
                atual = atual.Proximo;
            }
            System.Console.WriteLine("");
        }
        
        static void Main(string[] args){
            inserir(10);
            inserir(20);
            inserir(30);
            System.Console.WriteLine("Lista antes da Primeira Exclusão: ");
            Listar();
            Excluir(20);
            System.Console.WriteLine("Lista Pós Primeira Exclusão: ");
            Listar();
        }

    }
}
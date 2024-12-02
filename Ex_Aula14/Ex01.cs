using System;

namespace Exemplo12ListPilhFilaENCADEADA
{
    class Lista
    {
        
        class Node
        {
            public int Valor;      
            public Node? Proximo;  
        }

        
        private Node? inicio = null;

        
        public void Inserir(int valor, int pos)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (pos < 0)
            {
                Console.WriteLine("Posição inválida.");
                return;
            }

            
            if (pos == 0)
            {
                novoNode.Proximo = inicio;
                inicio = novoNode;
                return;
            }

            Node atual = inicio;
            int contador = 0;

            
            while (atual != null && contador < pos - 1)
            {
                atual = atual.Proximo;
                contador++;
            }

            
            if (atual == null)
            {
                Console.WriteLine("Posição inválida! A lista é menor que a posição fornecida.");
                return;
            }

            
            novoNode.Proximo = atual.Proximo;
            atual.Proximo = novoNode;
        }

       
        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("\nElementos na lista:");

            while (atual != null)
            {
                Console.Write(atual.Valor + " -> ");
                atual = atual.Proximo;
            }
            Console.WriteLine("null"); 
        }
        static void Main1(string[] args)
        {
            Lista minhaLista = new Lista();

          
            minhaLista.Inserir(10, 0); 
            minhaLista.Inserir(20, 1); 
            minhaLista.Inserir(30, 2); 

            
            minhaLista.Listar();

            minhaLista.Inserir(15, 1); 

            minhaLista.Listar();
        }
    }
}

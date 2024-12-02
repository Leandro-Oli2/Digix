using System;

namespace Exemplo12ListPilhFilaENCADEADA
{
    class Lista2
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
        public bool Contem(int valor)
        {
            Node? atual = inicio;

                
            while (atual != null)
            {
                if (atual.Valor == valor) 
                {
                    return true;
                }
                atual = atual.Proximo;
            }
            return false; 
        }

        static void Main2(string[] args)
        {
            Lista2 minhaLista = new Lista2();

          
            minhaLista.Inserir(10, 0); 
            minhaLista.Inserir(20, 1); 
            minhaLista.Inserir(30, 2); 

            Console.WriteLine("\nVerificando se valores estão na lista:");
            Console.WriteLine("Contém 20? " + minhaLista.Contem(20)); 
            Console.WriteLine("Contém 40? " + minhaLista.Contem(40));

        }
    }
}

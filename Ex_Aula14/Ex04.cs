using System;

namespace Aula_13
{
    public class PilhaInverted
    {
        static int[] pilha = new int[10];
        static int topo = 0;

        public static void Empilhar(int item)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = item;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha Cheia!");
            }
        }

        public static int Desempilhar()
        {
            if (topo > 0)
            {
                topo--;
                return pilha[topo];
            }
            else
            {
                Console.WriteLine("Pilha Vazia!");
                return -1;
            }
        }

        public static void Listar()
        {
            if (topo == 0)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }

            Console.Write("Pilha: ");
            for (int i = topo - 1; i >= 0; i--)
            {
                if (i == topo - 1)
                {
                    Console.Write($"{pilha[i]}(topo)"); // Indica o topo
                }
                else
                {
                    Console.Write($" -> {pilha[i]}");
                }
            }
            Console.WriteLine();
        }

        public static void Inverter()
        {
            // Inverte os elementos da pilha
            int inicio = 0, fim = topo - 1;

            while (inicio < fim)
            {
                int temp = pilha[inicio];
                pilha[inicio] = pilha[fim];
                pilha[fim] = temp;

                inicio++;
                fim--;
            }
        }

        public static void TopoP()
        {
            if (topo > 0)
            {
                Console.WriteLine($"Topo da Pilha: {pilha[topo - 1]}");
            }
            else
            {
                Console.WriteLine("A pilha está vazia.");
            }
        }

        static void Main4(string[] args)
        {
            // Empilha elementos
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Empilhar(40);
            Empilhar(50);

            // Lista a pilha antes da inversão
            Console.WriteLine("Pilha antes da inversão:");
            Listar();

            // Inverte a pilha
            Inverter();

            // Lista a pilha após a inversão
            Console.WriteLine("\nPilha após a inversão:");
            Listar();

            // Exibe o topo da pilha
            TopoP();
        }
    }
}

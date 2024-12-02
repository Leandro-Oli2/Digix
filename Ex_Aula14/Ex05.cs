using System;

namespace Aula_13
{
    public class Fila
    {
         int[] fila = new int[10];
         int inicio = 0;
         int fim = 0;
         int cont = 0;

        public void Adicionar(int valor)
        {
            if (cont < fila.Length)
            {
                fila[fim] = valor;
                fim = (fim + 1) % fila.Length;
                cont++;
            }
            else
            {
                Console.WriteLine("Fila Cheia!");
            }
        }

        public void Listar()
        {
            if (cont == 0)
            {
                Console.WriteLine("Fila Vazia!");
                return;
            }

            Console.WriteLine("Elementos da fila:");
            for (int i = 0; i < cont; i++)
            {
                int idx = (inicio + i) % fila.Length;
                Console.Write(fila[idx] + (i < cont - 1 ? " -> " : "\n"));
            }
        }

        public static Fila Concatenar(Fila fila1, Fila fila2)
        {
            Fila resultado = new Fila();

            // Adiciona elementos da primeira fila
            for (int i = 0; i < fila1.cont; i++)
            {
                int idx = (fila1.inicio + i) % fila1.fila.Length;
                resultado.Adicionar(fila1.fila[idx]);
            }

            // Adiciona elementos da segunda fila
            for (int i = 0; i < fila2.cont; i++)
            {
                int idx = (fila2.inicio + i) % fila2.fila.Length;
                resultado.Adicionar(fila2.fila[idx]);
            }

            return resultado;
        }

        static void Main6(string[] args)
        {
            Fila fila1 = new Fila();
            Fila fila2 = new Fila();

            // Adicionando elementos às filas
            fila1.Adicionar(10);
            fila1.Adicionar(20);
            fila2.Adicionar(30);
            fila2.Adicionar(40);

            // Exibindo as filas originais
            Console.WriteLine("Fila 1:");
            fila1.Listar();

            Console.WriteLine("\nFila 2:");
            fila2.Listar();

            // Concatenando as filas
            Fila filaConcatenada = Fila.Concatenar(fila1, fila2);

            // Exibindo a fila concatenada
            Console.WriteLine("\nFila Concatenada:");
            filaConcatenada.Listar();
        }
    }
}

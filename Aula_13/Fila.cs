using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Aula_13{
    

    public class Fila{
        static int[] fila = new int[10];
        static int inicio = 0;
        static int fim = 0;
        static int cont = 0;

        public static void Adicionar(int valor){
            if(cont < fila.Length){
                fila[fim] = valor;
                fim = (fim + 1) % fila.Length;
                cont++;
            }else{
                System.Console.WriteLine("Fila Cheia!");
            }
        }
        public static void Remover(){
            if(cont > 0){
                fila[inicio] = 0;
                inicio = (inicio + 1) % fila.Length;
                cont--;

            }else{
                System.Console.WriteLine("Não a numeros para Remover!");
            }

        }
        public static void Listar()
        {   
            if (cont == 0)
            {
                Console.WriteLine("Fila Vazia!");
                return;
            }

            Console.WriteLine("Elementos da fila:");
            for (int i = 0; i < cont; i++)
            {
                // Corrigir o índice com o operador módulo
                int idx = (inicio + i) % fila.Length;
                Console.WriteLine(fila[idx]);
            }
        }

        static void Main2(string[] args){
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Adicionar(50);
            Adicionar(100);
            Adicionar(200);
            Remover();
            Listar();



        }

    }
}

using System;

public class InsertionSort{
        static void Ordernar(int[] numeros){
            int aux, j;
            for(int i = 1; i < numeros.Length; i++){
                aux = numeros[i];
                j = i - 1;
                while(j >= 0 && numeros[j] < aux){
                    numeros[j+1] = numeros[j];
                    j--;
                }
                numeros[j+1] = aux;
            }
        }   
        static void Imprimir(int[] numeros){

            for(int i = 0; i < numeros.Length; i++){
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main4(string[] args){
            int[] numeros = {5, 3, 8, 1, 9, 2};
            Console.WriteLine("Antes da ordenacao:");
            for(int i = 0; i < numeros.Length; i++){
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine("\nDepois da ordenacao:");
            Ordernar(numeros);
            Imprimir(numeros);
           
        }
}
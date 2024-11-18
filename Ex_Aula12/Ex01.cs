using System;

class Ordenação{
    static void Ordenar(int[] numeros){
        int aux;
        for( int i = 0; i < numeros.Length; i++){
            for(int j = 0; j < numeros.Length - 1; j++){
                if(numeros[j] > numeros[j+1]){
                    aux = numeros[j];
                    numeros[j] = numeros[j+1];
                    numeros[j+1] = aux;
                }
            }
        }
        MostrarOrdenado(numeros);
    }
    static void MostrarOrdenado(int[] arr){
        Console.WriteLine("\nArray ordenado:"); 
        for(int i = 0; i < arr.Length; i++){
            Console.Write(arr[i] + " ");
        }
    }
    static void Main1(string[] args){
        System.Console.WriteLine("Quantos Numeros sera digitado: ");
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        for(int i =0; i <= numeros.Length - 1; i++){
            System.Console.WriteLine($"Informe o número [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine();
        Console.WriteLine("Array desordenado:");
        for(int i = 0; i < numeros.Length; i++){
            Console.Write(numeros[i] + " ");
        }
        Ordenar(numeros);
    }
}

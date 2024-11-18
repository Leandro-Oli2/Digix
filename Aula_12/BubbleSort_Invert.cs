using System;

class OrderInversa{
    static void Ordenar(int[] numeros){
        int aux;
        for( int i = 0; i < numeros.Length; i++){
            for(int j = 0; j < numeros.Length - 1; j++){
                if(numeros[j] < numeros[j+1]){
                    aux = numeros[j];
                    numeros[j] = numeros[j+1];
                    numeros[j+1] = aux;
                }
            }
        }
        MostrarOrdenado(numeros);
    }
    static void MostrarOrdenado(int[] arr){
        Console.WriteLine("\nArray ordenado reverso:"); 
        for(int i = 0; i < arr.Length; i++){
            Console.Write(arr[i] + " ");
        }
    }
    static void Main(string[] args){
        int[] numeros = {5, 3, 8, 1, 9, 2};
        Console.WriteLine("Array desordenado:");
        for(int i = 0; i < numeros.Length; i++){
            Console.Write(numeros[i] + " ");
        }
        Ordenar(numeros);
    }
}

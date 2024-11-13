using System;

public class OrdenacaoS{
    static void Ordenar(int[] numeros){
        int menor, aux;
        for(int i = 0; i < numeros.Length - 1; i++){
            menor = i;
            for( int j = i + 1; j < numeros.Length; j++){
                if(numeros[j] < numeros[menor]){
                    menor = j;
                }
            }
            aux = numeros[i];
            numeros[i] = numeros[menor];
            numeros[menor] = aux;
        }
    }
    static void Imprimir( int[] numeros){
        Console.WriteLine("\nNumeros apos a ordenacao: "); 
        for( int i = 0; i < numeros.Length; i++){
            Console.WriteLine(numeros[i] + "");
        }
    }
    
    public static void Main2( string[] args ){
        int [] numeros = {5, 3, 8, 1, 9, 2};
        Console.WriteLine("Numeros antes da ordenacao: ");
        for( int i = 0; i < numeros.Length; i++){
            Console.WriteLine(numeros[i] + "");
        }
        Ordenar(numeros);
        Imprimir(numeros);
    }
}
using System;

public class QuickInvert{
    static void Ordenar(int[] vetor, int inicio, int fim){
        if(inicio < fim){
            int p = Particionar( vetor, inicio, fim);
                Ordenar(vetor, inicio, p - 1);
                Ordenar(vetor, p + 1, fim);
        }
    }
        static int Particionar(int[] vetor, int inicio, int fim){
            int pivo = vetor[fim];
            int i = (inicio - 1);
            for( int j = inicio; j < fim; j++){
                if(vetor[j] >= pivo){
                    i++;
                    int aux = vetor[j];
                    vetor[j] = vetor[i];
                    vetor[i] = aux;
                }
            }
            int aux2 = vetor[i+1];
            vetor[i+1] = vetor[fim];
            vetor[fim] = aux2;
            return i+1;
        }
        static void Mostrar(int[] vetor){
            for(int i = 0; i < vetor.Length; i++){
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
    static void Main(string[] args){
        //chamandos as fuções

        int[] vetor = {10, 7, 8, 9, 1, 5};
        Console.WriteLine("Vetor original: ");
        Mostrar(vetor);
        Ordenar(vetor, 0, vetor.Length - 1);
        Console.WriteLine("Vetor ordenado: ");
        Mostrar(vetor);

    }
}

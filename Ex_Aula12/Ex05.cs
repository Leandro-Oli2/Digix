using System;

class Program{
    static void OrdenarBubble(int[] numeros){
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
    }
    static void OrdernarInsert(int[] numeros){
        int aux, j;
        for(int i = 1; i < numeros.Length; i++){
            aux = numeros[i];
            j = i - 1;
            while(j >= 0 && numeros[j] > aux){
                numeros[j+1] = numeros[j];
                j--;
            }
            numeros[j+1] = aux;
        }
    }  
    static void OrdenarSelect(int[] numeros){
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
    //calculando tempo do bubble sort
     static double TempoBubbleSort(int[] numeros){
        DateTime inicio = DateTime.Now;
        OrdenarBubble(numeros);
        DateTime fim = DateTime.Now;
        TimeSpan duracao = fim - inicio;
        return duracao.TotalMilliseconds;
    }
    //calculando tempo do insertion sort
    static double TempoInsertSort(int[] numeros){
        DateTime inicio = DateTime.Now;
        OrdernarInsert(numeros);
        DateTime fim = DateTime.Now;
        TimeSpan duracao = fim - inicio;
        return duracao.TotalMilliseconds;
    }
    //calculando tempo do selection sort
    static double TempoSelectionSort(int[] numeros){
        DateTime inicio = DateTime.Now;
        OrdenarSelect(numeros);
        DateTime fim = DateTime.Now;
        TimeSpan duracao = fim - inicio;
        return duracao.TotalMilliseconds;
    }
    static void Main(string[] args){
         Random random = new Random();
        int[] numeros = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            numeros[i] = random.Next(0, 101); // Gera números aleatórios entre 0 e 100
        }
        double b = TempoBubbleSort(numeros);
        double ins = TempoInsertSort(numeros);
        double s = TempoSelectionSort(numeros);
        System.Console.WriteLine("Bubble Sort: " + b);
        System.Console.WriteLine("Insertion Sort: " + ins);
        System.Console.WriteLine("Selection Sort: " + s);
        if(b <= ins && b <= s){
            System.Console.WriteLine("Melhor Desempenho: Bubble Sort");
        }
        else if(ins <= s){
            System.Console.WriteLine("Melhor Desempenho: Insertion Sort");
        }
        else{
            System.Console.WriteLine("Melhor Desempenho: Selection Sort");
        }
    }
}
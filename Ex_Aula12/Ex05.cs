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

     static void OrdenarQuick(int[] vetor, int inicio, int fim){
        if(inicio > fim){
            int p = Particionar( vetor, inicio, fim);
                OrdenarQuick(vetor, inicio, p - 1);
                OrdenarQuick(vetor, p + 1, fim);
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
    
    static void OrdernarMerge(int[] vetor, int inicio, int fim){
        if(inicio < fim){
            int meio = (inicio + fim) /2;
            OrdernarMerge(vetor, inicio, meio);
            OrdernarMerge(vetor, meio + 1, fim);
            intercalar(vetor, inicio, meio, fim);
        }
    }
    static void intercalar(int[] vetor, int inicio, int meio, int fim){
         int[] aux = new int[vetor.Length];
         for( int j = inicio; j <= fim; j++){
            aux[j] = vetor[j];
        }   
        int i1 = inicio;
        int i2 = meio + 1;
        int i3 = inicio;
        while(i1 <= meio && i2 <= fim){
            if(aux[i1] < aux[i2]){
                vetor[i3] = aux[i1];
                i1++;
            }else{
                vetor[i3] = aux[i2];
                i2++;
            }
            i3++;
        }
        while(i1 <= meio){
            vetor[i3] = aux[i1];
            i1++;
            i3++;
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
    static double TempoQuickSort(int[] numeros){
        DateTime inicio = DateTime.Now;
        OrdenarQuick(numeros, 0 , numeros.Length-1);
        DateTime fim = DateTime.Now;
        TimeSpan duracao = fim - inicio;
        return duracao.TotalMilliseconds;
    }
    static double TempoMerge(int[] numeros){
        DateTime inicio = DateTime.Now;
        OrdernarMerge(numeros, 0, numeros.Length-1);
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
        double bub = TempoBubbleSort(numeros);
        double ins = TempoInsertSort(numeros);
        double sel = TempoSelectionSort(numeros);
        double qui = TempoQuickSort(numeros);
        double mer = TempoMerge(numeros);
        System.Console.WriteLine("Bubble Sort: " + bub);
        System.Console.WriteLine("Insertion Sort: " + ins);
        System.Console.WriteLine("Selection Sort: " + sel);
        System.Console.WriteLine("Quick Sort: " + qui);
        System.Console.WriteLine("Merge Sort: " + mer);
        if(bub <= ins && bub <= sel){
            System.Console.WriteLine("Melhor Desempenho: Bubble Sort");
        }
        else if(ins <= sel){
            System.Console.WriteLine("Melhor Desempenho: Insertion Sort");
        }
        else{
            System.Console.WriteLine("Melhor Desempenho: Selection Sort");
        }

        // entre quick e merge
        if(qui <= mer){
            System.Console.WriteLine("Desempenho entre Quick Sort e Merge Sort: Quick Sort");
        }
        else{
            System.Console.WriteLine("Desempenho entre Quick Sort e Merge Sort: Merge Sort");
        }
    }
}
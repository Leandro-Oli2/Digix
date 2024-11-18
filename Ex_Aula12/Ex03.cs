using System;

public class OrdenacaoS{
    static void Ordenar(string[] nomes){
        int n = nomes.Length;
        int menor;
        for(int i = 0; i < n - 1; i++){
            menor = i;
            for( int j = i + 1; j < n; j++){
                if(string.Compare(nomes[j], nomes[menor]) < 0){
                    menor = j;
                }
            }
            if(menor != i){
                string aux = nomes[i];
                nomes[i] = nomes[menor];
                nomes[menor] = aux;
            }
        }
    }
    static void Imprimir(string[] nomes){
        Console.WriteLine("\nnomes apos a ordenacao: "); 
        for( int i = 0; i < nomes.Length; i++){
            Console.WriteLine(nomes[i] + "");
        }
    }
    
     static void Main3( string[] args ){
        System.Console.WriteLine("Quantos nomes serão informados: ");
        int n = int.Parse(Console.ReadLine());
        string [] nomes = new string[n];
        for(int i = 0; i < n; i++){
            System.Console.WriteLine($"Informe o nome {i+1}: ");
            nomes[i] = Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Numeros antes da ordenacao: ");
        for( int i = 0; i < nomes.Length; i++){
            Console.WriteLine(nomes[i] + "");
        }
        Ordenar(nomes);
        Imprimir(nomes);
    }
}
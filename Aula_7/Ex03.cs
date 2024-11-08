using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
           int cont = 0;
           int j = 0;
           int[] vet = new int[4];
           int[] vet2 = new int[4];
           for(int i = 0; i < 4 ; i++){
                Console.WriteLine($"Informe o Numero {i}: ");
                vet[i] = int.Parse(Console.ReadLine());
           }
           string lista = String.Join(",", vet);
           for(int i = 4 - 1; i >= 0 ; i--){
                vet2[j] = vet[i];
                j+=1;
           }
           string lista2 = String.Join(",", vet2);
           for(int i = 0; i <4; i++){
               if(lista[i] == lista2[i]){
                   cont += 1;
               }else{
                   cont -= 1;
               }
           }
           if(cont == 4){
               Console.WriteLine("Sua Lista eh Palindromo!");
           }else{
               Console.WriteLine("Sua Lista nao eh Palindromo!");
           }
           
        }
    }
}
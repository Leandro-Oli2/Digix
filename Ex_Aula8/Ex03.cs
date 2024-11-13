namespace Aula_8{

    public class Ex03{
        static void Palindromo(int[] val){
            int[] vet2 = new int[4]; 
            int j = 0;
            int cont = 0;
            for(int i = 4 - 1; i >= 0 ; i--){
                vet2[j] = val[i];
                j+=1;
           }
            string lista2 = String.Join(",", vet2);
            string lista = String.Join(",", val);
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
               Console.WriteLine("Sua Lista não eh Palindromo!");
           }
        }
        static void Main(string[] args){
            int[] vet = {4,4,4,4};
            Palindromo(vet);

        }
    }
}
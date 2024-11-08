using System;
namespace aula_8{

    class Program{
        //Função
        static int soma(int a, int b){
            return a + b;
        }
        //Procedimento de soma
        static void subtrair(int i, int j){
            int result = i - j;
            Console.WriteLine($"O resultado da subtracao é: {result}");
        }
        //função com 3 parametros
        static int mult(int a, int b, int c){
            return a*b*c;
        }
        //função com vetor
        static int somavet(int[] vet){
            int soma = 0;
            for(int i = 0; i < vet.Length; i++){
                soma += vet[i];
            }
            return soma;
        }
        //Função com Matriz
        static int somaMat(int[,] mat){
            int soma1=0;
            for(int i = 0; i < mat.GetLength(0); i++){
                for(int j = 0; j< mat.GetLength(1); j++){
                    soma1 += mat[i,j];
                }
            }
            return soma1;
        }
        static void Main1(string[] args){

           int a = 10;
           int b = 20;
           int somar = soma(a, b);
           Console.WriteLine($"A soma de {a} com {b} eh: "+somar);

           subtrair(b, a);

           int result = mult(10, 50, 32);
           Console.WriteLine("O resultado da multiplicacao eh: "+result);

           int[] teste = {1,2,3,4};
           int som = somavet(teste);
           Console.WriteLine("O resultado da soma do vetor eh: "+som);

           int[,] mat={{3,3,3},{3,3,3}};
           int som1 = somaMat(mat);
           Console.WriteLine("O resultado da soma da Matriz eh: "+som1);
        }
    }
}
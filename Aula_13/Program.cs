using System;
using System.Collections.Specialized;

namespace Aula_13{

    public class lista{
        static int[] vetor = new int[10];
        static void Inserir(int valor){
                for( int i = 0; i < vetor.Length; i++){
                    if(vetor[i] == 0){
                    vetor[i] = valor;
                    break;
                }
            }
        }
          static void Remover(int valor){
            for( int i = 0; i < vetor.Length; i++){
                if(vetor[i] == valor){
                    vetor[i] = 0;
                    break;
                }
            }
        }
        static void Listar(){
            for( int i = 0; i < vetor.Length; i++){
                if(vetor[i] != 0){
                    System.Console.WriteLine(vetor[i]);
                }
            }
        }
        static void ListarInverso(){
            System.Console.WriteLine();
            for( int i = vetor.Length-1; i>=0; i--){
                if(vetor[i] != 0){
                    System.Console.WriteLine(vetor[i]);
                }
            }
        }
        static void Main1(string[] args){
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(40);
            Listar();
            Remover(20);
            Listar();
            ListarInverso();
    

        }

    }

}
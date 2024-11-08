using System;
using System.Threading.Tasks.Dataflow;
public class matrizx{
    static void Main11(string[] args){
        int[,] mat = new int[3,3]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        int[,] transposta = new int[3,3];
        for(int i = 0; i < transposta.GetLength(0); i++){
            for(int j = 0; j<transposta.GetLength(1); j++){
                transposta[i,j] = mat[i,j];
            }
            System.Console.WriteLine();
        }
        for(int i = 0; i < transposta.GetLength(0); i++){
            for(int j = 0; j<transposta.GetLength(1); j++){
                System.Console.WriteLine(transposta[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
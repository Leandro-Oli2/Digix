using System;
    class Mat{
        static void Main22(String[] args){
            int[,] mat = new int[3,2];
            
            Console.WriteLine(mat[0,0]);
            Console.WriteLine(mat[0,1]);
            for(int c = 0; c < 3; c++){
                for(int j = 0; j <  2; j++){
                   Console.WriteLine(mat[c, j]);
                }
            }
            int[,] matrizA = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[,] matrizB= {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[,] matrizC = new int[3,3];
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    matrizC[i,j] = matrizA[i,j]+matrizB[i,j];
                    System.Console.WriteLine(matrizC[i,j]);
                }
            }
        }
    }
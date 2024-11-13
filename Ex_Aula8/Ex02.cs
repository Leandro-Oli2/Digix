using System.Security.Cryptography.X509Certificates;

namespace Aula_8{

    public class Ex02{
        public delegate void SomaMatriz(int[,] valores);
        static void SomaMat(int[,] val){
            int soma = 0;
            int soma2 = 0;
            int soma3 = 0;
            int soma4 = 0;
            for(int i = 0; i < val.GetLength(0); i++){
                for(int j = 0; j < val.GetLength(1); j++){
                    if(i == 0){
                        soma += val[i,j];
                    }
                    if(i == 1){
                        soma2 += val[i,j];
                    }
                    if(i == 2){
                        soma3 += val[i,j];
                    }
                    if(i == 3){
                        soma4 += val[i,j];
                    }
                }
            }
            System.Console.WriteLine($"A SOMA DA PRIMEIRA LINHA: {soma}");
            System.Console.WriteLine($"A SOMA DA SEGUNDA LINHA: {soma2}");
            System.Console.WriteLine($"A SOMA DA TERCEIRA LINHA: {soma3}");
            System.Console.WriteLine($"A SOMA DA QUARTA LINHA: {soma4}");
        }
        static void Main(string[] args){
            int[,] mat = new int[4,4];
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    System.Console.WriteLine($"Informe o numero [{i}] [{j}]: ");
                    mat[i, j] = int.Parse(System.Console.ReadLine());
                }
            }
            SomaMatriz media1 = SomaMat;
            media1(mat);
        }
    }
}
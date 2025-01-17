using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExMatriz17._01
{
    public class Matriz
    {
        static void Main(string[] args){
            string caminhoPath = @"C:\Users\leandrocandido\Desktop\ExMatriz\resultado.csv";
            bool arquivoExiste = File.Exists(caminhoPath);
            bool cont = true;
            Random random = new Random();


            System.Console.WriteLine("Informe a quantidade de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe a quantidade de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[linhas, colunas];
            for(int i = 0; i < linhas; i++){
                for(int j = 0; j < colunas; j++){
                    matriz[i,j] = random.Next(1, 101);
                }
            }
            while(cont){
                System.Console.WriteLine("================ MENU =================");
                System.Console.WriteLine("1 - Soma das linhas da matriz");
                System.Console.WriteLine("2 - Soma das colunas da matriz");
                System.Console.WriteLine("3 - Transpor a matriz");
                System.Console.WriteLine("4 - Imprimir a matriz");
                System.Console.WriteLine("5 - Sair");
                System.Console.WriteLine("=======================================");
                System.Console.WriteLine("Escolha: ");
                int opcao = int.Parse(Console.ReadLine());
                
                switch(opcao){
                    case 1:
                        Console.Clear();
                        using(StreamWriter sw = new StreamWriter(caminhoPath, append: false)){
                            if (!arquivoExiste)
                                {
                                    sw.WriteLine("Arquivo não encontrado.");
                                    return;
                                }
                            int somaLinhas = 0;
                            for(int i = 0; i < linhas; i++){
                                for(int j = 0; j < colunas; j++){
                                    somaLinhas += matriz[i,j];
                                }
                                    sw.WriteLine($"Soma da linha {i+1}: {somaLinhas}");
                                    somaLinhas = 0;
                                }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        using(StreamWriter sw = new StreamWriter(caminhoPath, append: false)){
                            int somaColunas = 0;
                            for(int j = 0; j < colunas; j++){
                                for(int i = 0; i < linhas; i++){
                                    somaColunas += matriz[i,j];
                                }
                                sw.WriteLine($"Soma da coluna {j+1}: {somaColunas}");
                                somaColunas = 0;
                            }
                        }
                        break;
                    case 3:
                        using(StreamWriter sw = new StreamWriter(caminhoPath, append: false)){
                            int lin = matriz.GetLength(0);
                            int col = matriz.GetLength(1);
                            int[,] transposta = new int[col, lin];
                            for(int i = 0; i < lin; i++){
                                for(int j = 0; j < col; j++){
                                    transposta[j,i] = matriz[i,j];
                                }
                            }
                            sw.WriteLine("Matriz transposta:");
                            for(int i = 0; i < col; i++){
                                for(int j = 0; j < lin; j++){
                                    sw.Write($"{transposta[i,j]} ");
                                }
                                sw.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        System.Console.WriteLine("Matriz:");
                        for(int i = 0; i < linhas; i++){
                            for(int j = 0; j < colunas; j++){
                                System.Console.Write($"{matriz[i,j]} ");
                            }
                            System.Console.WriteLine();
                        }
                        break;
                    case 5:
                        cont = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
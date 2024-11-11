using System;

class Program{
    static void Main(string[] args){
        double[,,] temperaturas = new double[5, 3, 2]{
            {
                {10, 15},
                {12, 18},
                {14, 20}
            },
            {
                {8, 11},
                {10, 13},
                {12, 15}
            },
            {
                {6, 9},
                {8, 11},
                {10, 13}
            },
            {
                {4, 6},
                {6, 8},
                {8, 10}
            },
            {
                {2, 4},
                {4, 6},
                {6, 8}
            }
        };
        for (int i = 0; i < temperaturas.GetLength(0); i++){
            for (int j = 0; j < temperaturas.GetLength(1); j++){
                System.Console.WriteLine($"Região: {i}, Dia: {j}");
            }
        }
    }

}
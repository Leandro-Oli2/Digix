// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_28_Manipulacao
// {
//     public class ClasseTask
//     {
//         static async Task Main(string[] args){
//             //o async é quando a  função e assincrona, ou seja
//             //ela pode retornar um valor assíncrono
//             //o await é quando a função aguarda um valor assíncrono ser retornado
//             Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10, 20);
//             Console.WriteLine($"Resultado da soma: {resultado}");
//         }

//         static Task<int> Soma(int n, int m){
//             return Task.Run(() => {
//                 Task.Delay(2000).Wait(); //timeout 2seg
//                 return n + m;
//             });
//         }
//     }
// }
using System.Security.Cryptography.X509Certificates;

namespace Aula_8{

    public class Ex01{
        public delegate double CalcMedia(int[] valores);
        static double Media(int[] val){
            double media = 0;
            foreach (var valor in val)
            {
                media += valor;
            }
            return media / val.Length;
        }
        static void dsa(string[] args){
            int[] val = new int[10];
            for(int i = 0; i < 10; i++){
                System.Console.WriteLine($"Informe o numero {i}: ");
                val[i] = int.Parse(System.Console.ReadLine());
            }
            CalcMedia media1 = Media;
            System.Console.WriteLine($"A media eh dos valores eh: {media1(val)} ");
        }
    }
}
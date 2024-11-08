namespace Aula_8{

    public class Mudificadores{
        public int soma(int a, int b){
            return a+b;
        }
        static void Main1(string[] args){
            Mudificadores m = new Mudificadores();
            System.Console.WriteLine(m.soma(10,20));

        }
    }
}
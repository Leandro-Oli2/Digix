using System;

public class VariaveisImplicias{
    public static void Main2(){
        var nome = "C#";
        System.Console.WriteLine(nome);
        System.Console.WriteLine(nome.GetType());
        
        const double pi = 3.14;
        System.Console.WriteLine(pi);
        System.Console.WriteLine(pi.GetType());


        var lista = new List<int>(){1, 2, 3, 4, 5};
        System.Console.WriteLine(lista.GetType());
        foreach(var item in lista){
            Console.WriteLine(item);
        }
        var comidas = new Dictionary<string, int>(){
            {"Arroz", 4},
            {"Feijão", 6},
            {"Carne", 10}
        };
        foreach(var item in comidas){
            Console.WriteLine($"Comida: {item.Key}, Preço: {item.Value}");
        }

    }
}
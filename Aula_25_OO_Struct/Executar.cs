using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
    public struct Point{
        public int X { get; set;}
        public int Y { get; set;}
            //Construtor no struct
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Distancia(Point P){
            // X = 10 isso não é permitido em um metodo de struct.
            return Math.Sqrt(Math.Pow(X - P.X, 2) + Math.Pow(Y - P.Y, 2));
        }
    }
    public class Player{
        public string Name { get; set; }
        public Point Position { get; set;}
        public Player(string name, Point position){
            Name = name;
            Position = position;
        }
        public void Move(Point newPosition){
            Position = newPosition;
            
        }
    }
    public class Executar{
        static void Main2()
        {
            Point p1 = new Point(10, 5);
            Point p2 = new Point(20, 15);
            Console.WriteLine($"Distância entre p1 e p2: {p1.Distancia(p2)}");
            Player player1 = new Player("Player 1", p1);
            player1.Move(p2);
            Console.WriteLine($"Novo posição de {player1.Name}: ({player1.Position.X}, {player1.Position.Y})");
        }
    }
}
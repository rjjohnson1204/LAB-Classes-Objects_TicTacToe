using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        public static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("      Welcome to Tic Tac Toe");
            Console.WriteLine("           X O X O X O               ");

            Console.WriteLine("      Care to try your luck?");
            Console.WriteLine("                          ");
            Console.WriteLine("         Enter player One's name... ");
            Console.WriteLine("                          ");
            string Player1;
            Player1 = Console.ReadLine();
            Console.WriteLine(            $"Hello {Player1} ");
            Console.WriteLine("                          ");
            Console.WriteLine("         Enter player Two's name... ");
            Console.WriteLine("                          ");
            string Player2;
            Player2 = Console.ReadLine();
            Console.WriteLine("                          ");
            Console.WriteLine(            $"Hello {Player2} ");

            Console.ReadLine();


            Player P1 = new Player(); 
            
               P1.Name = Player1;
               P1.Marker = "X";
               P1.IsTurn = true;

            Player P2 = new Player();

                P2.Name = Player2;
                P2.Marker = "O";
                P2.IsTurn = false;

            Board board = new Board();

            Game TicTacToe = new Game(P1, P2);

            Player PlayerWinner = TicTacToe.Play();

            









            

        }
    }
}

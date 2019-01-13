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
            Console.WriteLine("         Enter player Ones name... ");
            Console.WriteLine("                          ");
            string Player1;
            Player1 = Console.ReadLine();
            Console.WriteLine($"hello {Player1} ");

            Console.WriteLine("                          ");
            Console.WriteLine("         Enter player Two name... ");
            Console.WriteLine("                          ");
            Console.ReadLine();


            Player P1 = new Player(); 
            
               P1.Name = Player1;
               P1.Marker = "X";
               








            Board board = new Board();

            string[,] GameBoard = board.GameBoard;
            board.DisplayBoard(GameBoard);

        }
    }
}

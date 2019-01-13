using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("                          ");

            Console.WriteLine("Care to try your luck?");
            Console.WriteLine("                          ");
            Console.WriteLine(" Enter player name... ");
            Console.WriteLine("                          ");
            Console.ReadLine();





            Board board = new Board();

            string[,] GameBoard = board.GameBoard;
            board.DisplayBoard(GameBoard);

        }
    }
}

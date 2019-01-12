using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Board board = new Board();

            string[,] GameBoard = board.GameBoard;
            board.DisplayBoard(GameBoard);

        }
    }
}

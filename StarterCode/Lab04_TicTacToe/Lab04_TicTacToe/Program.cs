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
            Console.WriteLine("      Enter player One's name... ");
            Console.WriteLine("                          ");
            string Player1;
            Player1 = Console.ReadLine();
            Console.WriteLine($"     Hello {Player1} ");
            Console.WriteLine("                          ");
            Console.WriteLine("      Enter player Two's name... ");
            Console.WriteLine("                          ");
            string Player2;
            Player2 = Console.ReadLine();
            Console.WriteLine("                          ");
            Console.WriteLine($"     Hello {Player2} ");

            Console.ReadLine();

            // Player 1 object
            Player P1 = new Player(); 
            
               P1.Name = Player1;
               P1.Marker = "X";
               P1.IsTurn = true;

            //Player 2 object
            Player P2 = new Player();

                P2.Name = Player2;
                P2.Marker = "O";
                P2.IsTurn = false;

            //creates new gameboard
            Board board = new Board();

            //Creates new game
            Game TicTacToe = new Game(P1, P2);

            //Starts new game
            Player PlayerWinner = TicTacToe.Play();

            if (PlayerWinner == null)
            {   // a draw
                Console.WriteLine("Stalemate!");
            }
            else
            {    //The winner
                Console.WriteLine($"{PlayerWinner.Name} is NOT the LOSER!");
            }

        
        }
    }
}

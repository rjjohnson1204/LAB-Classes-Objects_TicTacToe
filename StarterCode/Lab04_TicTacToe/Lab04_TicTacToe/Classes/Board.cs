using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {

        /// <summary>
        /// Tic Tac Toe Gameboard states
        /// </summary>
        public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        public void DisplayBoard(string[,] Board)
            
		{
             
            //TODO: Output the board to the console
            //loops through the rows of the number 
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.WriteLine();
                //loops through the columns
                for (int j = 0; j< Board.GetLength(1); j++)
                { // writes the rows and columns as matrix
                    Console.Write(Board[i, j]);
                }
            }
		}
	}      
}

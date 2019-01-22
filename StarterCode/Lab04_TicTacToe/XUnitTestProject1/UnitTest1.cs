using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // test to see if a win is produced 
        [Fact]
        public void Winner()
        {
            Player P1 = new Player();
            Player P2 = new Player();
            Game TicTacToe = new Game(P1, P2);

            TicTacToe.Board.GameBoard[0, 0] = "X";
            TicTacToe.Board.GameBoard[0, 1] = "X";
            TicTacToe.Board.GameBoard[0, 2] = "X";

            Assert.True(TicTacToe.CheckForWinner(TicTacToe.Board));
        }

        // test to see if players switch between turns
        [Fact]
        public void SwitchPlayer()
        {
            Player P1 = new Player();
            P1.IsTurn = true;
            Player P2 = new Player();
            P2.IsTurn = false;
            Game TicTacToe = new Game(P1, P2);

            TicTacToe.SwitchPlayer();

            Assert.True(TicTacToe.PlayerTwo.IsTurn);
        }
    }
}

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
        public void Test1()
        {
            Player P1 = new Player();
            Player P2 = new Player();
            Game TicTacToe = new Game(P1, P2);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    internal class TicTacToe
    {
        public TicTacToe() { }

        public void Play()
        {
            Menu startMenu = new Menu();
            startMenu.PrintStartMenu();
            switch (startMenu.GetChoice())
            {
                case 1:
                    this.PlayGame(new Player('X'), new Player('O'));
                    break;
                case 2:
                    this.PlayGame(new Player('X'), new Computer('O'));
                    break;
                case 3:
                    this.PlayGame(new Computer('X'), new Computer('O'));
                    break;
            }
        }

        public void PlayGame(Player playerX, Player playerO)
        {
            int moveCounter = 0;
            Menu endMenu= new Menu();
            Board gameBoard = new Board();
            Player currentPlayer = playerX;
            bool play = true;
            string debugFolderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = System.IO.Path.Combine(debugFolderPath, "log.txt");
       
             Logger logger = new Logger(filePath);

            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    if (currentPlayer is Computer)
                    {
                        gameBoard.putMark(currentPlayer, playerO.takeTurn());
                        Thread.Sleep(600);
                    }
                       
                    else
                        gameBoard.putMark(currentPlayer, playerX.takeTurn());
                    
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        logger.Log($"Player {currentPlayer.getSign()} won the game.");
                        if(! (currentPlayer is Computer))
                        {
                            endMenu.PrintEndMenu();
                            switch (endMenu.GetChoice())
                            {
                                case 1:                                   
                                    Console.Write("Enter Your Name: ");
                                    string playerName = Console.ReadLine();
                      
                                    Score.SaveScore(playerName, currentPlayer.getSign().ToString());
                                    Console.WriteLine("Saved");
                                    break;
                            }
                        }
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        logger.Log( "draw game.");
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }
    }
}

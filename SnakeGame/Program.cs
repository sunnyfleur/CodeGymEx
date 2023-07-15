using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {

    }
    class Game
    {

    }
    class Bait
    {

    }
    class Input
    {
        ConsoleKeyInfo keyPress = new ConsoleKeyInfo();
        public void CheckInput()
        {
            while (Console.KeyAvailable)
            {
                //CHo bam phim bat ky 
                keypress = Console.ReadKey();
                //luu lai thao tac phim truoc do
                pre_dir = dir;
                switch (keypress.Key)
                {
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;

                    case ConsoleKey.P: dir = "STOP"; break;   //play -> P (pause) -> stop
                    case ConsoleKey.Q: Environment.Exit(0); break;
                }

            }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

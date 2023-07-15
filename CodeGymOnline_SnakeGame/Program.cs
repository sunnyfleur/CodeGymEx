using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGymOnline_SnakeGame
{
    class GamePlay
    {
       
        public Board board = new Board();
        public Snake snake = new Snake();
        public void Start()
        {
            snake.SetDefaultPosition();
            
        }
        public void Update()
        {

            LoadComponent();
            
            
        }

        public void LoadComponent()
        {
            board.BoardOutLinePrinting();
            snake.GetPosition();
            snake.SetPosition();
            
            snake.DrawSnake();

        }


    }
    class Input
    {
        public static ConsoleKeyInfo keyInfo = Console.ReadKey();
        public static int CheckInput()
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                return 1;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                return 2;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                return 3;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
    class Snake
    {
        public int snakeOx;
        public int snakeOy;
       

        public void SetDefaultPosition()
        {
            this.snakeOx = 2;
            this.snakeOy = 2;
        }
        public void SetPosition()
        {
            Console.SetCursorPosition(this.snakeOx, this.snakeOy);
        }
        
        public void DrawSnake()
        {
            Console.Write("*");
        }
        public void GetPosition()
        {
            switch (Input.CheckInput())
            {
                case 1: 
                    this.snakeOy += 1;
                    break;
                case 2:
                    this.snakeOy -= 1;
                    break;
                case 3:
                    this.snakeOx -= 1;
                    break;
                case 4:
                    this.snakeOy += 1;
                    break;
            }    
        }
    }
    class Bait
    {

    }
    class Board
    {
        public static int height = 20;
        public static int width = 50;
        public static char[,] rectangle = new char[height, width];

        public void BoardOutLinePrinting()
        {
            for (int col = 0; col < width; col++)
            {
                rectangle[0, col] = '*';
            }
           
            for (int col = 0; col < width; col++)
            {
                rectangle[height - 1, col] = '*';
            }
         
            for (int row = 1; row < height - 1; row++)
            {
                rectangle[row, 0] = '*';
            }
            
            for (int row = 1; row < height - 1; row++)
            {
                rectangle[row, width - 1] = '*';
            }
            
            for (int row = 1; row < height - 1; row++)
            {
                for (int col = 1; col < width - 1; col++)
                {
                    rectangle[row, col] = ' ';
                }
            }           
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(rectangle[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GamePlay game = new GamePlay();
            game.Start();
            while (game.snake.snakeOx<19&game.snake.snakeOy<19)
            {
                game.Update();
                Console.ReadKey();
            }
                
                
                
            
            
        }
    }
}

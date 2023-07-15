using System;
using System.Threading;

namespace CodeGymOnline_SnakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class GamePlay
    {
        private Board board;
        private Snake snake;
        private Bait bait;
        private int score;
        private bool isGameOver;

        public GamePlay()
        {
            board = new Board();
            snake = new Snake();
            bait = new Bait();
            score = 0;
            isGameOver = false;
        }

        public void Start()
        {
            snake.SetDefaultPosition();
            bait.GenerateNewPosition(snake);
        }

        public void Update()
        {
            if (!isGameOver)
            {
                ProcessInput();
                MoveSnake();
                CheckCollision();
                Draw();
                Thread.Sleep(100);
            }
        }

        private void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                snake.ChangeDirection(key);
            }
        }

        private void MoveSnake()
        {
            snake.Move();
        }

        private void CheckCollision()
        {
            if (snake.CheckSelfCollision() || snake.CheckWallCollision(board))
            {
                isGameOver = true;
            }

            if (snake.CheckBaitCollision(bait))
            {
                score++;
                snake.Grow();
                bait.GenerateNewPosition(snake);
            }
        }

        private void Draw()
        {
            Console.Clear();
            board.Draw();
            snake.Draw();
            bait.Draw();
            Console.SetCursorPosition(0, board.Height);
            Console.WriteLine("Score: " + score);
        }
    }

    class Input
    {
        public static ConsoleKeyInfo KeyInfo;

        public static void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                KeyInfo = Console.ReadKey(true);
            }
        }
    }

    class Snake
    {
        private const char SnakeBodyChar = '*';
        private const char SnakeHeadChar = '@';

        private int headX;
        public int headY;
        public int[] tailX;
        public int[] tailY;
        public int tailLength;
        public Direction direction;

        public Snake()
        {
            headX = 0;
            headY = 0;
            tailX = new int[100];
            tailY = new int[100];
            tailLength = 0;
            direction = Direction.Right;
        }

        public void SetDefaultPosition()
        {
            int startX = Console.WindowWidth / 2;
            int startY = Console.WindowHeight / 2;

            for (int i = 0; i < 4; i++)
            {
                tailX[i] = startX - i;
                tailY[i] = startY;
                tailLength++;
            }

            headX = startX;
            headY = startY;
        }

        public void ChangeDirection(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (direction != Direction.Down)
                    {
                        direction = Direction.Up;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.Up)
                    {
                        direction = Direction.Down;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.Right)
                    {
                        direction = Direction.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.Left)
                    {
                        direction = Direction.Right;
                    }
                    break;
            }
        }

        public void Move()
        {
            for (int i = tailLength - 1; i > 0; i--)
            {
                tailX[i] = tailX[i - 1];
                tailY[i] = tailY[i - 1];
            }

            tailX[0] = headX;
            tailY[0] = headY;

            switch (direction)
            {
                case Direction.Up:
                    headY--;
                    break;
                case Direction.Down:
                    headY++;
                    break;
                case Direction.Left:
                    headX--;
                    break;
                case Direction.Right:
                    headX++;
                    break;
            }
        }

        public void Grow()
        {
            tailLength++;
        }

        public bool CheckSelfCollision()
        {
            for (int i = 1; i < tailLength; i++)
            {
                if (headX == tailX[i] && headY == tailY[i])
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckWallCollision(Board board)
        {
            if (headX == 0 || headX == board.Width - 1 || headY == 0 || headY == board.Height - 1)
            {
                return true;
            }

            return false;
        }

        public bool CheckBaitCollision(Bait bait)
        {
            if (headX == bait.X && headY == bait.Y)
            {
                return true;
            }

            return false;
        }

        public void Draw()
        {
            Console.SetCursorPosition(headX, headY);
            Console.Write(SnakeHeadChar);

            for (int i = 0; i < tailLength; i++)
            {
                Console.SetCursorPosition(tailX[i], tailY[i]);
                Console.Write(SnakeBodyChar);
            }
        }
    }

    class Bait
    {
        private const char BaitChar = 'X';

        public int X { get; private set; }
        public int Y { get; private set; }

        public Bait()
        {
            X = 0;
            Y = 0;
        }

        public void GenerateNewPosition(Snake snake)
        {
            Random random = new Random();
            bool isOverlappingWithSnake;

            do
            {
                X = random.Next(1, Console.WindowWidth - 1);
                Y = random.Next(1, Console.WindowHeight - 1);

                isOverlappingWithSnake = false;

                for (int i = 0; i < snake.tailLength; i++)
                {
                    if (X == snake.tailX[i] && Y == snake.tailY[i])
                    {
                        isOverlappingWithSnake = true;
                        break;
                    }
                }
            }
            while (isOverlappingWithSnake);
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(BaitChar);
        }
    }

    class Board
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Board()
        {
            Width = Console.WindowWidth;
            Height = Console.WindowHeight - 1;
        }

        public void Draw()
        {
            Console.Clear();

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    if (row == 0 || row == Height - 1 || col == 0 || col == Width - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            GamePlay game = new GamePlay();
            game.Start();

            while (true)
            {
                Input.ProcessInput();
                game.Update();
            }
        }
    }
}

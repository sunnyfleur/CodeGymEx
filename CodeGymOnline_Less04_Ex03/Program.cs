using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeGymOnline_Less04_Ex03
{

    public class Triangle
    {
        public static int squareTriangleHeight = 10;

        public static void PrintIsoscelesTriangle()
        {
            for (int i = 1; i <= squareTriangleHeight; i++)
            {
                for (int space = 1; space <= squareTriangleHeight - i; space++) Console.Write(" ");
                for (int star = 1; star <= 2 * i - 1; star++) Console.Write("*");
                Console.WriteLine(); 
            }

        }
        public static void PrintTriangleBottomLeft()
        {
            for (int i = 0; i <= squareTriangleHeight; i++)
            {
                for (int j = squareTriangleHeight; j > 0; j--)
                {
                    if (j > i) Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
        public static void PrintTriangleBottomRight()
        {
            for (int i = 0; i < squareTriangleHeight; i++)
            {
                for (int j = 0; j < squareTriangleHeight; j++)
                {
                    if (j >= i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine(); 
            }

        }
        public static void PrintTriangleTopLeft()
        {
            for (int i = 0; i <= squareTriangleHeight; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j <= i) Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public static void PrintTriangleTopRight()
        {
            for (int i = 0; i <= squareTriangleHeight; i++)
            {
                for (int j = squareTriangleHeight; j > 0; j--)
                {
                    if (j < i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        #region Rectangle
        public class Rectangle
        {
            public int width = 10;
            public int height = 5;
            public static void PrintRectangle()
            {
                int width = 40;
                int height = 5;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++) Console.Write("*");

                    Console.WriteLine();
                }
            }
        }
        #endregion Rectangle
        #region Menu

        public class Menu
        {
            public static int choice = -1;
            public static void PrintMainMenu()
            {
                while (choice != 0)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Print the rectangle");
                    Console.WriteLine("2. Print the square triangle");
                    Console.WriteLine("3. Print isosceles triangle");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice: ");
                    choice = Int32.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Rectangle.PrintRectangle(); break;
                        case 2:
                            PrintTriangleMenu(); break;
                        case 3:
                            Triangle.PrintIsoscelesTriangle(); break;
                        case 0:
                            Environment.Exit(0); break;
                        default:
                            Console.WriteLine("no choice"); break;
                    }
                }
            }
            public static void PrintTriangleMenu()
            {
                while (choice != 0)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Print the triangle top-left");
                    Console.WriteLine("2. Print the triangle top-right");
                    Console.WriteLine("3. Print the triangle bottom-left");
                    Console.WriteLine("4. Print the triangle bottom-right");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("Enter your choice: ");
                    choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Triangle.PrintTriangleTopLeft(); break;
                        case 2:
                            Triangle.PrintTriangleTopRight(); break;
                        case 3:
                            Triangle.PrintTriangleBottomLeft(); break;
                        case 4:
                            Triangle.PrintTriangleBottomRight(); break;
                        case 0:
                            Environment.Exit(0); break;
                        default:
                            Console.WriteLine("no choice"); break;
                    }
                }
            }
        }
        #endregion Menu
        internal class Program
        {
            static void Main(string[] args)
            {
                Menu.PrintMainMenu();
                Console.ReadKey();
            }

        }
    }
}



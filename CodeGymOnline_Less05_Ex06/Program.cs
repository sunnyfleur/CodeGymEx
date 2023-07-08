using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row;
            int[,] matrix;
            int mainDiagonalValue=0;

            Console.Write("Enter square matrix's size: ");
            row=Convert.ToInt32(Console.ReadLine());
            matrix = new int[row, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("Enter the element of row " + i + 1 + " column " + j + 1 + " : ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Properties of matrix: ");

          
            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < row; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            for (int i = 0; i < row; i++)
            {                
                for (int j = 0; j < row; j++)
                {
                    if (i == j) mainDiagonalValue += matrix[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n Main diagonal: {0}", mainDiagonalValue);

            Console.ReadKey();
        }
    }
}

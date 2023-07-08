using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row;
            int column;
            int[,] matrix;
            int max;
            int xPos=0;
            int yPos=0;

            Console.Write("Enter the row size: ");
            row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the column size: ");
            column= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            matrix= new int[row,column];

            for(int i=0; i < row; i++)
            {
                for(int j=0; j < column;j++)
                {
                    Console.Write("Enter the element of row "+i+1+" column "+j+1+ " : ");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Properties of matrix: ");

            max = matrix[0, 0];

            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i,j] > max)
                    {
                        max= matrix[i,j];
                        xPos= i+1;
                        yPos= j+1;
                    }

                    Console.Write(matrix[i,j]+" ") ;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Max: " + max + " at " + xPos + ", " + yPos);

            Console.ReadKey();
        }
    }
}

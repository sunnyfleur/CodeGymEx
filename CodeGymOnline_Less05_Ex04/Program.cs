using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            int[] array2;
            int inputX;
            int indexX;


            Console.Write("Enter size of the array ");
            size = Convert.ToInt32(Console.ReadLine());

            array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter the element at position " + i+" : " );
                array[i] = Convert.ToInt32(Console.ReadLine());               
            }

            Console.WriteLine("Properties of array: ");
            foreach (int element in array)
                Console.Write(element + " ");
            Console.WriteLine();

            Console.Write("Enter the value of the element to insert: ");
            inputX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Where to insert: ");
            indexX = Convert.ToInt32(Console.ReadLine());

            if (indexX <= 1 || indexX >= array.Length - 1)
                Console.WriteLine("Can not insert");
            else
            {
                array2 = new int[size + 1];
                for (int i = 0; i < indexX; i++)
                {
                    array2[i] = array[i];
                }
                array2[indexX] = inputX;
                for(int i = indexX; i < array.Length; i++)
                {
                    array2[i+1] = array[i];
                }
                Console.Write("New Properties of array: ");
                foreach (int element in array) Console.Write(element + " ");
                
            }

            Console.ReadKey();











        }
    }
}

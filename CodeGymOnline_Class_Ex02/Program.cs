using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Class_Ex02
{
    internal class Program
    {

        public static int[] IncreasinglySort(ref int[] NumArray)
        {
            var arrayLength = NumArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = NumArray[smallestVal];
                NumArray[smallestVal] = NumArray[i];
                NumArray[i] = tempVar;
            }
            return NumArray;
        }
        static void Main(string[] args)
        {
            int size;
            int[] array;

            Console.Write("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());

            array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} value: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Value of array is: ");
            foreach (int item in array)
            {   
                Console.Write(item + " ");
            }
            Console.WriteLine();
            IncreasinglySort(ref array);
            Console.WriteLine(" Increasingly Sorted: ");
            foreach (int item in array)
            {               
                Console.Write(item + " ");
            }


            Console.ReadKey();
            


        }
    }
}

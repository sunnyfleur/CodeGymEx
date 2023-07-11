﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less06_Ex02
{
    internal class Program
    {
        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for(int i=1;i<array.Length;i++)
            {
                if (array[i] < min)
                {
                    array[i] = min;
                    index= i;

                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int index = MinValue(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);
            Console.ReadKey();
        }
    }
}

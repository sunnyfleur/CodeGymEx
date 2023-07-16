using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less07_Ex
{
    
    internal class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        public static void Main(string[] args)
        {
            Random rand= new Random();
            StopWatch s = new StopWatch();
            int[] array = new int[100000];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10000);
            }
            s.Start();
            SelectionSort(array);
            s.End();
            Console.Write("Elapsed: " + s.ElapsedTime());
            Console.ReadKey();


        }
    }
}

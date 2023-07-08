using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int total=0;

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            for(int i = 0; i < numbers.Length; i++)
                total += numbers[i];

            Console.WriteLine("Total value is: "+total);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less04_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool check = true;
            
            Console.Write("Enter Your Number: "); 
            number=Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) check= false;

            else
            {
                int i = 2;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check= false;
                        break;
                    }
                    i++;
                }
            }

            if (check == true) Console.WriteLine(number + " is a prime");
            else Console.WriteLine(number + " is not a prime");

            Console.ReadKey();
        }
    }
}

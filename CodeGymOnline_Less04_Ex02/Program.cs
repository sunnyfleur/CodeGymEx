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
            
            Console.Write("Enter Your Number: "); 
            number=Convert.ToInt32(Console.ReadLine());

            double numberSquare = Math.Pow(number, 2);

            if (number < 2) Console.WriteLine("It's not a prime");
            else
            {
                int i = 2;
                bool check=true;    
                while (i < Math.Pow(number, 2))
                {
                    if ((number % i == 0))
                    {
                        check = false; break;
                        i++;

                    }
                    
                }
                if (check) Console.WriteLine("Your Number is a prime");
                else Console.WriteLine("Your number is not a prime");
                

            }
            Console.ReadKey();
                                    
        }
    }
}

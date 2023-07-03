using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants: ");

            
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution;
                solution= -b / a;
                Console.WriteLine("The solution is: {0} ", solution);
            }
            else if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("The solution is all x!");
                }
                else
                {
                    Console.WriteLine("Nod Solution");
                }
            }

            Console.ReadKey();
            

        }
    }
}

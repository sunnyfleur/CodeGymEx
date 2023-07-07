using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            int product;
            for(int i = 1; i < 11; i++)
            {
                for(int j = 1; j < 11; j++)
                {
                    product = i * j;
                    Console.WriteLine(i + " x " + j + " = " + product);
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less2_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            float area;

            Console.Write("Enter Width: ");
            width = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Height: ");
            height = Convert.ToInt64(Console.ReadLine());

            area = width * height;
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();


        }
    }
}

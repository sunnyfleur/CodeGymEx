using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Class_Ex
{
    internal class Program
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp;            
            temp = a;
            a = b; 
            b=temp;         
        }
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Enter a: ");
            a= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before: ");
            Console.WriteLine("a is: {0}, b is: {1}", a, b);

            Swap(ref a,ref  b);
            Console.WriteLine("After");
            Console.WriteLine("a is: {0}, b is: {1}", a, b);

            Console.ReadKey();

        }
    }
}

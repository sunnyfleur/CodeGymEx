using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Enter Your Name: ");
            myName = Console.ReadLine();
            Console.WriteLine("My name is " + myName);
            Console.ReadKey();
            
        }
    }
}

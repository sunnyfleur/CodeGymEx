using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit a = new Orange();
            Console.WriteLine(a.HowToEat());
            Console.ReadKey();

        }
    }
}

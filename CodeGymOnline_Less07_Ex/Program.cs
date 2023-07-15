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
        public static void Main(string[] args)
        {
            Fan fan1= new Fan(Fan.fast,true,6,"yellow");
            Fan fan2 = new Fan(Fan.medium, false, 7, "blue");

            Console.WriteLine("fan1: " + fan1.FanToString() );
            Console.WriteLine("fan2: " + fan2.FanToString());
            Console.ReadLine();
        }
    }
}

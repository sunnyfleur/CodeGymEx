using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less12_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please input file path");
                string path = Console.ReadLine();
                Console.WriteLine("File path: " + path);
                ReadTextFileExample example = new ReadTextFileExample();
                example.ReadTextFile(path);
            
        }
    }
}

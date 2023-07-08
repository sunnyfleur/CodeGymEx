using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less05_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            bool isExist=false;

            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.Write("Enter a name’s student: ");
            inputName = Console.ReadLine();

            for(int i=0; i < students.Length; i++)
            {
                if (inputName == students[i])
                {
                    Console.WriteLine("Position of the students in the list " + inputName + " is: " + (i + 1));
                    isExist = true; break;
                }
            }

            if (!isExist) Console.WriteLine("Not found " + inputName + " in the list.");
            Console.ReadKey();
        }
    }
}

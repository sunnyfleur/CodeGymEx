using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less06_Ex03
{
    internal class Program
    {
        public static int CheckCharacter(string inputString, char inputChar)
        {
            int count=0;
            foreach(char c in inputString)
            {
                if(c == inputChar)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string inputString;
            char inputChar;
            int count;

            Console.Write("Enter your string: ");
            inputString = Console.ReadLine();
            Console.Write("Enter your character: ");
            inputChar= Convert.ToChar(Console.ReadLine());

            count=CheckCharacter(inputString, inputChar);

            Console.Write(inputChar + " appear " + count + " times in " + inputString);
            Console.ReadKey();


        }
    }
}

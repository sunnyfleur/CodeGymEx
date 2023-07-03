using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less03_Ex03

{
    public class ReadNumber
    {
      private string[] units = {"zero", "one", "two", "three", "four",
                                "five", "six", "seven", "eight", "nine"};
        private string[] tys = { "", "ten", "twenty", "thirty", "forty",
                                "fifty", "sixty", "seventy", "eighty", "ninety"};
        private string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen",
                                   "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        public string Read(int number)
        {
            if (number < 10)
                return units[number];
            if (number < 20)
                return teens[number - 10];
            if (number < 100)
                return tys[number / 10] + ((number % 10 != 0) ? " " + units[number % 10] : "") ;
            if (number < 1000)
                return units[number / 100] + " hundred" + ((number % 100 != 0) ? " " + Read(number % 100) : "") ;
            else return "out of ability";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            string outputRead;
            Console.Write("Enter Number To Read: ");
            inputNumber =Convert.ToInt32( Console.ReadLine());

            ReadNumber read = new ReadNumber();          
            outputRead=read.Read(inputNumber);
            Console.WriteLine("It is: "+ outputRead);
            Console.ReadKey();
        }
    }
}

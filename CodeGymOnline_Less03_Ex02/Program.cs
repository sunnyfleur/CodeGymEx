using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less03_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height,BMI;
            Console.Write("Enter Your Weight: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Your Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            BMI = weight / Math.Pow(height,2);
            BMI=Math.Round(BMI);
            Console.WriteLine("BMI: " + BMI);

            if (BMI < 18.5) Console.WriteLine("Underweight");
            else if (BMI < 25) Console.WriteLine("Normal");
            else if (BMI < 30) Console.WriteLine("Overweight");
            else Console.WriteLine("Obese");

            Console.ReadKey();

            


        }   
    }
}

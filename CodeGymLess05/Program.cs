using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymLess05
{
    public class Exchanging
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }
        public  double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
    public class Menu
    {
        public static int choice;
        public Exchanging ex =new Exchanging();
        public int MenuPrinting()
        {
            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(this.Fahrenheit());
                        
                        break;
                    case 2:
                        Console.WriteLine(this.Celsius());


                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

            return choice;
        }

        public string Fahrenheit()
        {
            double fahrenheit;
            Console.Write("Enter fahrenheit: ");
            fahrenheit = Double.Parse(Console.ReadLine());

            return "Fahrenheit to Celsius: " + ex.FahrenheitToCelsius(fahrenheit);
        }
        public string Celsius()
        {
            double celsius;
            Console.WriteLine("Enter Celsius: ");
            celsius = Double.Parse(Console.ReadLine());
            return "Celsius to Fahrenheit: " + ex.CelsiusToFahrenheit(celsius);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Menu a = new Menu();
            a.MenuPrinting();
            Console.ReadKey();
        }
    }
}

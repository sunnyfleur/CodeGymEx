using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less07_Ex
{
    public class Rectangle
    {

        //Fields
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        //Constructors
        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Perimeter()
        {
            return width + height;
        }

        public double Area()
        {
            return width * height;
        }
        public void Input()
        {
            Console.WriteLine("Enter width: ");
            this.width=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            this.height = Convert.ToDouble(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Height: {0}, Width: {1}", height,width);
        }

    }
}

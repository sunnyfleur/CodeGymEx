using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less10_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(3);
            shapes[2] = new Rectangle(2, 3);
            shapes[1] = new Square(2);

            foreach(Shape item in shapes)
            {
                Console.WriteLine(item.GetArea());
                if(item is Square square && item is IColourable)
                {
                    Console.WriteLine(square.HowToColour());
                }
            }

            Console.ReadKey();

        }
    }
}

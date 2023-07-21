using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less10_Ex01
{
    internal class Square:Shape,IResizable,IColourable
    {
        private double side;

        public double Side { get => side; set => side = value; }

        public Square(double side)
        {
            this.side = side;   
        }
        public string HowToColour()
        {
            return "Color all four sides.";
        }
        public void Resize(double percent)
        {
            side *= percent;
        }
        public override double GetArea()
        {
            return side*side;
        }
    }
}

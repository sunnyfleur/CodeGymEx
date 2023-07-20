using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    public class Circle:Shape
    {
        private double radius=1.0;

        public double Radius { get => radius; set => radius = value; }

        public Circle() { }
        public Circle(string colour, bool filled, double radius = 1.0):base(colour,filled)
        {
            this.Radius = radius;
        }
       
        public double GetArea()
        {
            return this.radius*3.14;
        }
        public double GetPerimeter()
        {
            return this.radius * 2 * 3.14;
        }
        public override string ToString()
        {
           return "A Circle with radius= "+this.radius+" which is a subclass of " +base.ToString();
        }
    }
}

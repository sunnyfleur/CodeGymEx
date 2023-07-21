using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex02
{
    public class Circle
    {
        private double radius;
        private double pi=Math.PI;

        public Circle(double radius)
        {
            this.radius = radius;   
        }
        public double Radius { get => radius; set => radius = value; }
        public double Pi { get => pi; set => pi = value; }

        public override string ToString()
        {
            return "radius: "+radius;
        }
        public double GetArea()
        {
            return radius*radius*pi;
        }

    }
}

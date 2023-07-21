using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less10_Ex01
{
    internal class Circle: Shape,IResizable
    {
        private double radius;
        private double pi=Math.PI;

        public double Radius { get => radius; set => radius = value; }
        public Circle(double radius)
        {
            this.radius = radius;   
        }
        public void Resize(double percent)
        {
            this.radius= this.radius*percent;
        }
        public override double GetArea()
        {
            return radius*radius*pi;
        }

    }
}

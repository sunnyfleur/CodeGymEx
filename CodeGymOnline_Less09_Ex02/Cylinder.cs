using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex02
{
    internal class Cylinder:Circle
    {
        private double height;

        public double Height { get => height; set => height = value; }
        
        public Cylinder(double height,double radius):base(radius)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            return base.GetArea() * height;
        }
        public override string ToString()
        {
            return base.ToString()+" height: "+height;
        }
    }
}

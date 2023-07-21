using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less10_Ex01
{
    internal class Rectangle:Shape,IResizable
    {
        private double height;
        private double width;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public Rectangle(double height,double width)
        {
            this.width = width;
            this.height = height;
        }

        public void Resize(double percent)
        {
            height *= percent;
            width *= percent;
        }
        public override double GetArea()
        {
            return height * width;
        }
    }
}

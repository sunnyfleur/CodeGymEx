using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    public class Rectangle:Shape
    {
        private double lenght=1;
        private double width=1;

        public double Lenght { get => lenght; set => lenght = value; }
        public double Width { get => width; set => width = value; }

        public Rectangle() { }
        public Rectangle(double lenght, double width,string colour,bool filled):base(colour,filled)
        {
            this.width = width;
            this.lenght = lenght;
        }

        public double GetPerimeter()
        {
            return (width + lenght) * 2;
        }
        public double GetArea()
        {
            return width * lenght;
        }

        public override string ToString()
        {
            return "A Rectangle with width="+ this.width+" and length= "+ this.lenght+" which is a subclass of "+base.ToString();
        }
    }
}

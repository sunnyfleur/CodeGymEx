using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex03
{
    internal class Point2D
    {
        private float x=0.0f, y=0.0f;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point2D() { }
        public float[] GetXY()
        {
            float[] XY= new float[2];
            XY[0] = X;
            XY[1] = Y;
            return XY;
        }
        public override string ToString()
        {
            return "x: " + x + " y " + y; 
        }
    }
}

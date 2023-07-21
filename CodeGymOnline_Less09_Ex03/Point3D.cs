using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex03
{
    internal class Point3D:Point2D
    {
        private float z=0.0f;

        public float Z { get => z; set => z = value; }

        public Point3D() { }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.Z = z;
        }
        public float[] GetXYZ()
        {
            float[] XYZ= new float[3];
            XYZ[0] = base.X;
            XYZ[1] = base.Y;
            XYZ[2] = this.Z;
            return XYZ;
        }
        public override string ToString()
        {
            return base.ToString()+" z "+z;
        }


    }
}

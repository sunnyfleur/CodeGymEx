using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    internal class CircleComparator:IComparer<Circle >
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Radius > c2.Radius) return 1;
            else if (c1.Radius < c2.Radius) return -1;
            else return 0;
        }
    }
}

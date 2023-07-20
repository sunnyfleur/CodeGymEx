using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    internal class ComperableCircle:Circle, IComparable<ComperableCircle>
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius, bool filled, string colour) : base(colour, filled, radius) { }

        public int CompareTo(ComperableCircle o)
        {
            if (base.Radius > o.Radius)
            {
                return 1;
            }
            else if(base.Radius < o.Radius)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
}

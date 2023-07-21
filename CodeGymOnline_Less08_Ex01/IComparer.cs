using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    internal interface IComparer<Circle>
    {
        int Compare(Circle c1, Circle c2);
    }
}

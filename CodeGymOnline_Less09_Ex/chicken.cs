using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less09_Ex
{
    public class chicken:Animal,Edible
    {
        public override string makeSound()
        {
            return "chicken chicken";
        }
        public string HowToEat()
        {
            return "cook and an";
        }
    }
}

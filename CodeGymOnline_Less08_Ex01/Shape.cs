using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less08_Ex01
{
    public class Shape
    {
        private string colour;
        private bool filled;

        public string Colour { get => colour; set => colour = value; }
        public bool Filled { get => filled; set => filled = value; }

        public Shape() { }
        public Shape(string colour="green", bool filled=true)
        {
            this.Colour = colour;
            this.Filled = filled;       
        }
        public virtual string ToString()
        {
            if (this.filled) return "A Shape with color of " + this.colour + " and filled";
            else return "A Shape with color of " + this.colour + " and not filled";
        }
    }
}

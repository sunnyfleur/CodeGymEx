using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less07_Ex
{
    public class Fan
    {
        public const int slow= 1;
        public const int medium= 2;
        public const int fast = 3;

        private int speed;
        private bool isOn;
        private double radius;
        private string colour;

        public Fan(int speed=slow, bool isOn=false, double radius=5, string colour="blue")
        {
            this.speed = speed;
            this.isOn = isOn;
            this.radius = radius;
            this.colour = colour;
        }

        public int Speed { get => speed; set => speed =value; }
        public bool IsOn { get => isOn; set => isOn = value; }
        public double Radius { get => radius; set => radius = value; }

        public string FanToString()
        {
            if (this.isOn)
            {
               return Convert.ToString(("Speed: {0},Colour:{2}, Radius: {1}, Fan is on ",this.speed, this.radius,this.colour));

            }
            else
            {
                return Convert.ToString(("Colour:{2}, Radius: {1}, Fan is off ", this.speed, this.radius, this.colour));
            }
        }
    }
}

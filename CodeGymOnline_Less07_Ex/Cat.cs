using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less07_Ex
{
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string height, string weight, string name): base(height,weight)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }
}

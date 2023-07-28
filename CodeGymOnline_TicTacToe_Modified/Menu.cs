using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    public class Menu
    {
        private int choice;
        public void PrintStartMenu()
        {            
            Console.WriteLine("Choose mode: ");
            Console.WriteLine("1. PvP");
            Console.WriteLine("2. PvR");
            Console.WriteLine("3. PvZ");          
        }
        public void PrintEndMenu()
        {
            Console.WriteLine("Save your score?");
            Console.WriteLine("1. Save");
            Console.WriteLine("2. No");
        }
        public int GetChoice()
        {
            choice=int.Parse(Console.ReadLine());
            return choice;
        }
    }
}

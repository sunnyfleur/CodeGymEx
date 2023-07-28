using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    internal class Computer : Player
    {

        private List<int> randomNumber = new List<int>(); 
        
        public Computer(char computerSign = 'O')
        {
            randomNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            base.sign= computerSign;
        }
       
        public override int takeTurn()
        {
            Random random= new Random();
            int index=random.Next(0,randomNumber.Count-1);
            int fieldNumber = randomNumber[index];
            randomNumber.RemoveAt(index);
            return fieldNumber;
        }
        public bool isRemovedByValue(int value)
        {
            int index=randomNumber.IndexOf(value);
            if (index < 0)
            {
                return false;
            }
            randomNumber.RemoveAt(index);
            return true;
        }

    }
}


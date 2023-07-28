using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    public enum FIELD { FLD_EMPTY = ' ', FLD_X = 'X', FLD_O = 'O' }
    internal class Cell
    {
        FIELD fieldState = FIELD.FLD_EMPTY;
        //Khởi tạo ô giá trị rỗng
        public Cell()
        {
            fieldState = FIELD.FLD_EMPTY;
        }
        //Lấy giá trị tại ô
        public FIELD getFieldState()
        {
            return fieldState;
        }
        //Kiểm tra ô rỗng
        public bool isEmpty()
        {
            if (fieldState != FIELD.FLD_EMPTY) //X hoac O
                return false;
            return true;
        }
        //Gán giá trị tại ô theo dấu
        public void markField(Player player)
        {
            if (isEmpty())
            {
                if (player.getSign() == 'X')
                    fieldState = FIELD.FLD_X;
                else
                    fieldState = FIELD.FLD_O;
            }
        }
    }
}

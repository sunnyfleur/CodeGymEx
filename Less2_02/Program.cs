using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less2_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float inputUSD;
            float outputVND;
            const int exchangeRate = 23000;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Nhập giá trị USD: ");
            inputUSD= Convert.ToInt64(Console.ReadLine());
            outputVND = inputUSD * exchangeRate;
            Console.WriteLine("Chuyển đổi sang VND: "+outputVND);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_Less06_Ex04
{
    internal class Program
    {

        public static int[] DeleteValue( int[] array, int deleteValue, int size)
        {
            int index = 0;
            int[] newArray= new int[size-1];

             for(int i=0; i<array.Length; i++)
             {
                if (deleteValue == array[i])
                {
                    index = i;
                    break;
                }
              
             }
            for(int i=0;i<index; i++)
            {
                newArray[i]= array[i];  
            }
            for(int i = index+1 ; i < array.Length; i++)
            {
                newArray[i-1] = array[i];
            }

            return newArray;

        }
        static void Main(string[] args)
        {
            int size;
            int[] array;
            int deleteValue;
            int[] newArray;

            Console.Write("Enter your array size: ");
            size=Convert.ToInt32(Console.ReadLine());

            array = new int[size];  

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} value: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter value to delete: ");
            deleteValue= Convert.ToInt32(Console.ReadLine());

            newArray=DeleteValue( array, deleteValue, size);

            foreach(int item in newArray)
            {
                Console.Write(item+" ");
            }

            Console.ReadKey();

        }
    }
}

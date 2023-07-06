using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now=DateTime.Now;
            string inputBirthday;
            DateTime birthday;
            TimeSpan timeRemain;        
            int dayRemain;
            int count=0;

        EnterBirthday:;
            Console.Write("Enter Your Birthday: ");
            inputBirthday=Console.ReadLine();

            if (DateTime.TryParseExact(inputBirthday, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthday))
            {
                Console.WriteLine("Your birthday is : " + birthday);
                DateTime birthdayYear = new DateTime(now.Year, birthday.Month, birthday.Day);

                if (now== birthday )
                {
                    Console.WriteLine("Happy Birthday");
                }
                else if(birthdayYear>now)
                {
                    timeRemain = birthdayYear-now;
                    dayRemain = (int)timeRemain.TotalDays;
                    Console.WriteLine("Days Remaining: " + dayRemain+" days");
                }
                else if(birthdayYear < now)
                {
                    Console.WriteLine("Your birthday this year had passed");
                    birthday.AddYears(1);
                    timeRemain= birthdayYear-now;
                    dayRemain= (int)timeRemain.TotalDays;
                    Console.WriteLine("Days Remaining: " + dayRemain + " days");
                }
            }
            else
            {
                Console.WriteLine("Wrong format");
                count++;
                if (count < 3) goto EnterBirthday;
                else
                {
                    Console.WriteLine("Out of time try");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }

            

            Console.ReadKey();

            

        }
    }
}

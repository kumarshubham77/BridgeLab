using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class LeapYear
    {
        public void Leapyear()
        {
            Console.WriteLine("Enter the year which you wanna check");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("The number is leap Year");
            }
            else
            {
                Console.WriteLine("The number is not a leap year");
            }
        }
    }
}

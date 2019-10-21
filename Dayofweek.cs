// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Dayofweek.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Dayofweek
    {
        /// <summary>
        /// Declaring a function Which takes the following Inputs:
        /// </summary>
        /// <param name="m">Month</param>
        /// <param name="d">Day</param>
        /// <param name="y">Year</param>
        public static void DayOfWeek(int m, int d, int y)
        {
            //Calculation of d0.
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            //Comparing the value of d0 with integers and 
            //result in the corresponding days.
            if (d0 == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (d0 == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (d0 == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (d0 == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (d0 == 4)
            {
                Console.WriteLine("Thrusday");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("Saturday");
            }
            Console.WriteLine("Value of d0 = " + d0);
        }
    }
}

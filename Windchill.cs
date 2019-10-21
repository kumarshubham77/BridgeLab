using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Windchill
    {
        public void WindChill()
        {
            Console.WriteLine("Enter the value of v and t");
            int v =Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            if (v > 3 && v < 120)
            { 
                if (t < 50)
                {
                        double w = 35.74 + 0.6215 * t + ((0.4275 * t - 35.75) * Math.Pow(v, 0.16));
                        Console.WriteLine("The value is " + w);
                }
                else
                    {
                        Console.WriteLine("Please provide the input for t <50 and v >3 and v<120");
                    }
                }
        }
    }
}

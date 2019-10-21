using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Distance
    {
        public void Distances()
        {
            Console.WriteLine("Calculating Distance using Eualr method");
            Console.WriteLine("Enter the value of x and y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            // calcualting x and y respectively
            double b = Convert.ToInt32(x * x + y * y);
            double Origdistance = Convert.ToDouble(Math.Sqrt(b));
            Console.WriteLine(Origdistance);
        }
    }
}

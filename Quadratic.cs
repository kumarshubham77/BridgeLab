using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Quadratic
    {
        public void Quardratics()
        {
            Console.WriteLine("Provide the input of a,b and c");
            int a =Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            float delta = ((b * b) - (4 * a * c));
            double root1 = ((-b + Math.Sqrt(delta)) / (2 * a));
            double root2 = ((-b - Math.Sqrt(delta)) / (2 * a));
            Console.WriteLine("First root value of X is :" +root1);
            Console.WriteLine("First root value of X is :" + root2);

        }
    }
}

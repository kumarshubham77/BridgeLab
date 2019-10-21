// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SquareRoot
    {
        public static void Sqrt()
        {
            //Taking input from the User and converting it to Integers.
            Console.WriteLine("Enter the number here");
            int c = Convert.ToInt32(Console.ReadLine());
            //Assigning value of variable c to variable t.
            int t = c;
            //Comparing values 
            while (Math.Abs(t - c / t) > Double.Epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            Console.WriteLine(t);
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Monthlypayment.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Monthlypayment
    {
        public static void MonthlyPayment()
        {
            //Taking input from the user as Principle, Rate of Interest and Year.
            double payment = 0;
            Console.WriteLine("Enter principal loan amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            double R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            double Y = Convert.ToInt32(Console.ReadLine());
            double n = 12 * Y;
            double r = R / (12 * 100);
            double N = (1 + r);
            //Calculation of the Payment.
            payment = (P * r) / (1 - (Math.Pow(N, -n)));
            Console.WriteLine("Your payment is " + payment);
        }
    }
}

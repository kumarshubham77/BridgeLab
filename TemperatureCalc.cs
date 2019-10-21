// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TemperatureCalc.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class TemperatureCalc
    {
        public static void Temparature()
        {
            //Taking input from the user as Temperature for Conversion.
            Console.WriteLine("Temperature Conversion Program");
            Console.WriteLine("Enter temperature here to find in farenheit --> celcius or Vice-Versa");
            Console.WriteLine("Enter your temperature here");
            int temp = Convert.ToInt32(Console.ReadLine());
            //Taking input from the user which type of conversion wanted?
            //1 for Fareheit to Celcius.
            //2 fro Celcius to Farenheit.
            Console.WriteLine("Which type of conversion you want ?");
            Console.WriteLine("press 1 for farenheit to celcius");
            Console.WriteLine("Press 2 for celcius to farenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            //Comparing value of the choice 
            if (choice == 1)
            {

                int c = (temp - 32) * 5 / 9;
                Console.WriteLine("Your temperature in celcius is -->" + c);
            }
            if (choice == 2)
            {

                int f = (temp * 9 / 5) + 32;
                Console.WriteLine("Your temperature in farenheit is -->" + f);
            }
        }
    }
}

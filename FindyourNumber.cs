// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FindyourNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubhamm"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindyourNumber
    {
        public static void FindyourNumbers()
        {
            //Taking input from the user.
            Console.WriteLine("Enter the value upto N(what upto you think)");
            int N = Convert.ToInt32(Console.ReadLine());
            //Taking Input from the User from 0 to N(given by user above).
            Console.WriteLine("Thinked number must lie in between 0 to " + N);
            int low = 0;
            int high = N - 1;
            int num = N;
            //Implementing binary Search Algorithm here
            while (low < high)
            {
                //Calcualting Mid.
                int mid = (low + high) / 2;
                Console.WriteLine("number you choose is " + mid);
                Console.WriteLine("number you choose is >" + mid);
                Console.WriteLine("number you choose is <" + mid);
                Console.WriteLine("Enter your choice please");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Number found !!!" + mid);
                }
                if (choice == 2)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
    }
}

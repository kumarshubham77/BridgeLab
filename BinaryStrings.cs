// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinaryStrings.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BinaryStrings
    {
        public static void BinaryforStrings()
        {
            //Taking Input from the user, and Converting them to Integer.
            Console.WriteLine("This is binary search for strings");
            Console.WriteLine("Enter the N to enter the strings upto N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements upto" + N);
            string[] arr = new string[N];
            // taking user input upto N, i.e., given by user itself
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            //Taking input from the user which they want to search in the array
            //and storing it in a key.
            Console.WriteLine("Enter the string you want to search");
            string key = Console.ReadLine();
            int low = 0;
            int high = arr.Length - 1;
            //Comparing high with the low.
            while (low < high)
            {
                int mid = (low + high) / 2;
                //String that is to be searched gets compared with Array of mid
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    Console.WriteLine("string found on" + mid);
                }
                if (res > 0)
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

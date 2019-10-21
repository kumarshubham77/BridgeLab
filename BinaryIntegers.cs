// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinaryIntegers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Creating a class BinaryIntegers
    /// </summary>
    class BinaryIntegers
    {

        public static void BinaryforIntergers()
        {
            //Taking Input from the User, and Converting it to integer form.
            Console.WriteLine("Enter the N upto which you want your elements");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[N];
            int low = 0;
            int high = arr.Length - 1;
            //taking input from user upto N, which is given by the user
            //and converting them to integers one by one.
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Taking input from the user which they want to search and
            //Storing it in a variable called key.
            Console.WriteLine("Enter the number you want to search in an array");
            int key = Convert.ToInt32(Console.ReadLine());
            //Checking whether if low is smaller is equal to high.
            while (low <= high)
            {
                //Calculating mid.
                int mid = (low + high) / 2;
                //Checking if key is equal to the array of mid?
                if (key == arr[mid])
                {
                    Console.WriteLine("Number found on the index of " + mid);
                }
                if (key > 0)
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

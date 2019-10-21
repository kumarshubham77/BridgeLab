// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BubblesortIntergers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BubblesortIntergers
    {
        public static void BubblesortIntegers()
        {
            //Taking input from the user and storing it in the Variable N.
            Console.WriteLine("Enter the value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[N];
            //Entering the Element one by one
            //And converting them to the integers.
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            //Printing the Sorted Array.
            for (int k = 0; k < N; k++)
            {
                Console.Write(arr[k] + ",");
            }
        }
    }
}

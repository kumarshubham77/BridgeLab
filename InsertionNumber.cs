// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InsertionNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class InsertionNumber
    {
        public static void InsertionNumbers()
        {
            int i, n;
            int j, val, flag;
            //Taking input from the user, for total number of element they want to add.
            //Converting the input into the Integers.
            Console.WriteLine("Enter the number of total elements you want to add");
            n = Convert.ToInt32(Console.ReadLine());
            //Creating the array of the size, want user input above.
            int[] arr = new int[n];
            //Taking input from the User.
            for (int k = 0; k < n; k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Insertion Sort " + arr);
            Console.WriteLine("Initial array :");
            //Showing the array for the first time.
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("sorted");
            //After sorting printing the value of sorted Array.
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

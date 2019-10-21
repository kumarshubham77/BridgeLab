// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Binarynibbles.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Binarynibbles
    {
        public static void BinaryNibbles()
        {
            //Converting decimal to Binary
            //Takinf Input from the User.
            Console.WriteLine("ENter the Number here");
            int num = Convert.ToInt32(Console.ReadLine());
            //Declaring the Size of the array.
            int[] arr = new int[8];
            int n = arr.Length;
            //Console.WriteLine(n);
            //Comparing the values of num to 0
            while (num > 0)
            {
                int rem = num % 2;
                arr[n - 1] = rem;
                num = num / 2;
                n--;
            }
            //Printing the Values.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine("\n");
            double sum = 0;
            //Converting binary to decimal
            int m = 0;
            n = arr.Length;
            //Looping goes from last to first.
            for (int i = n - 1; i >= 0; i--)
            {
                //Console.WriteLine("Entered");
                int val = arr[i];
                double res = val * Math.Pow(2, m);
                sum = sum + res;
                m++;


            }
            Console.WriteLine(sum);

            //Making two distincts array each of length half of the array
            //and one array that can store both two half arrays
            n = arr.Length;
            int n1 = n / 2;
            int k = 0;
            //arr1 is half arr2 is half and arr3 is full arrays.
            int[] arr1 = new int[n / 2];
            int[] arr2 = new int[n / 2];
            int[] arr3 = new int[n];
            //inserting full values of  arr[i] upto half into arr1.
            for (int i = 0; i < n / 2; i++)
            {
                arr1[i] = arr[i];
            }
            //Inserting full values of arr[i] from half onwards to the new array i.e., arr2[]
            //and incrementing n1
            for (int i = 0; i < n / 2; i++)
            {
                arr2[i] = arr[n1];
                n1++;
            }
            //taking arr2 and put them into full array of arr3.
            for (int i = 0; i < n / 2; i++)
            {
                arr3[i] = arr2[i];
            }
            //Rest of the elements i.e., in arr1 put it into the second half of
            //the full array arr3[]
            for (int i = n / 2; i < n; i++)
            {
                arr3[i] = arr1[k];
                k++;
            }
            double sum1 = 0;
            int s = 0;
            int ni = arr3.Length;
            for (int i = ni - 1; i >= 0; i--)
            {
                //Console.WriteLine("Entered");
                int val1 = arr3[i];
                double res = val1 * Math.Pow(2, s);
                sum1 = sum1 + res;
                s++;


            }
            Console.WriteLine(sum1);
        }
    }
}
 

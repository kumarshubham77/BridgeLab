using System;
using System.IO;

namespace Algorithms
{
    // --------------------------------------------------------------------------------------------------------------------
    // <copyright file=Program.cs" company="Bridgelabz">
    //   Copyright © 2019 Company="BridgeLabz"
    // </copyright>
    // <creator name="Kumar Shubham"/>
    // --------------------------------------------------------------------------------------------------------------------

    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            //calling by second utility class
            //Utility1.Anagram("cat", "man");
            BinaryIntegers.BinaryforIntergers();
            BinaryStrings.BinaryforStrings();
            InsertionNumber.InsertionNumbers();
            BubblesortIntergers.BubblesortIntegers();
            BubbleStrings.BubblesortString();
            FindyourNumber.FindyourNumbers();
            WordFromWordlist.WordfromWordList();
            Dayofweek.DayOfWeek(9,20,2019);
            TemperatureCalc.Temparature();
            Monthlypayment.MonthlyPayment();
            SquareRoot.Sqrt();
            Utility.BinaryNibbles();


            /*
            Console.WriteLine("Enter Ruppes here");
            int note = Convert.ToInt32(Console.ReadLine());
            Vending obj = new Vending();
            obj.check(note);
            */

            /*
            int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            int n = 10, i;
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //MergeSort(arr, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");


            }*/


        }
    }
}


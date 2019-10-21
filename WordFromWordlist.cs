// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WordFromWordlist.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithms
{
    class WordFromWordlist
    {
        public static void WordfromWordList()
        {
            //Reading from a CSV file and storing in a variable.
            string infile = @"C:\Users\Bridgelabz\Desktop\mytext.txt";
            StreamReader sr = new StreamReader(infile);
            string text = System.IO.File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\mytext.txt");
            int length = text.Length;
            //making string arr that will spilit the CSV file into (','). 
            string[] arr = text.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");

            }
            //taking input from user to search a word and implementing binary search for strings
            Console.WriteLine("Enter the word you want to search");
            string key = Console.ReadLine();
            int low = 0;
            int high = arr.Length - 1;
            //Comparing the two values i.e., High and Low.
            while (low <= high)
            {
                //Calculating Mid.
                int mid = (low + high) / 2;
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    Console.WriteLine("value is in " + mid);
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

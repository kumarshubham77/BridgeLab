// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BubbleStrings.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BubbleStrings
    {
        public static void BubblesortString()
        {
            // To measure time elapsed we start the timer at function call
            DateTime now = DateTime.Now;
            string e = now.ToLongTimeString();
            Console.WriteLine(e);
            //Taking input from the user and converting them to Integers.
            Console.WriteLine("Enter the N");
            int N = Convert.ToInt32(Console.ReadLine());
            //Creating array of string of N value.
            string[] str = new string[N];
            //taking input from the user and storing it in the string array.
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            for (int i = 1; i < str.Length; i++)
            {
                //Making temp variable Empty.
                string temp = string.Empty;
                for (int j = 0; j < str.Length - 1; j++)
                {
                    //Comparing the values.
                    if (str[j].CompareTo(str[j + 1]) > 0)
                    {
                        temp = str[j + 1];
                        str[j + 1] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i] + ",");
            }
            // Again timer is being called and stored in a variable
            DateTime now1 = DateTime.Now;
            string s = now1.ToLongTimeString();
            Console.WriteLine(s);
            //Calcualting the dauration of the both the function being called in the first and After.
            TimeSpan duration = DateTime.Parse(s).Subtract(DateTime.Parse(e));
            Console.WriteLine("Time elapsed is" + duration);
            Console.ReadKey();
        }
    }
}

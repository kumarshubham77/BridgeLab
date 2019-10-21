using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Insertionforstrings
    {
        public static void InsertionforString()
        {
            Console.WriteLine("Enter the N");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[N];
            Console.WriteLine("Enter the string");
            for (int i = 0; i < N; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the element to search");
            string key = Console.ReadLine();
            for (int i = 1; i < N; i++)
            {
                string val = arr[i];
                int flag = 0;
                //for (int j = i - 1; j >= 0 && flag != 1)
                {
                    //if (val < arr[j])
                }

            }
        }
    }
}

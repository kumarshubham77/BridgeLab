using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PalindromeDetection
    {
        public static void Palindrome(int num)
        {
            int temp;
            int rem;
            int sum = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Non Palindrome");
            }
        }
    }
}

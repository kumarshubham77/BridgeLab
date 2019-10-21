using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Anagram
    {
        public static void Anagrams(String str1, String str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            // Sorting the two arrys
            Array.Sort(ch1);
            Array.Sort(ch2);
            //Creating new references
            string newword = new string(ch1);
            string newword1 = new string(ch2);
            //Checking both are Equal ?
            if (newword == newword1)
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Both are not Anagram");
            }

        }
    }
}

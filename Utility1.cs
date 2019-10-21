using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithms
{
    /// <summary>
    /// List of Algorithm programs
    /// That is to be called from the main class i.e., Program.cs
    /// </summary>
    /// 

    // --------------------------------------------------------------------------------------------------------------------
    // <copyright file=Utility1.cs" company="Bridgelabz">
    //   Copyright © 2019 Company="BridgeLabz"
    // </copyright>
    // <creator name="Kumar Shubham"/>
    // --------------------------------------------------------------------------------------------------------------------

    class Utility1
    {
        /// <summary>
        /// Anagrams check for the two string given by the user.
        /// </summary>
        /// <param name="str1">First string given by the User</param>
        /// <param name="str2">Second string given by the User</param>
        public static void Anagram(String str1, String str2)
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
            if(newword == newword1)
            {
                Console.WriteLine("Both are Anagram");
            }
            else
            {
                Console.WriteLine("Both are not Anagram");
            }

        }
        /// <summary>
        /// Isprimes the specified n.
        /// </summary>
        /// <param name="n">Taking iput from user as an integer.</param>
        /// <returns>Returns boolean whether the given number is prime or not.</returns>
        public static bool Isprime(int n)
        {
            int count = 0;
            Boolean b = false;
            for(int i =0;i<=n;i++)
            {
                if(n % i ==0)
                {
                    count++;
                }
            }
            if (count==1)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        /// <summary>
        /// Palindromes the specified number.
        /// </summary>
        /// <param name="num">Checking for the number is palindrome or not</param>
        public static void Palindrome(int num)
        {
            int temp;
            int rem;
            int sum = 0;
            temp = num;
            while(num > 0)
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
        /// <summary>
        /// Binarysearch for the intergers.
        /// </summary>
        public static void BinaryforIntergers()
        {
            
            Console.WriteLine("Enter the N upto which you want your elements");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[N];
            int low = 0;
            int high = arr.Length - 1;
            //taking input from user upto N, which is given by the user
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number you want to search in an array");
            int key = Convert.ToInt32(Console.ReadLine());
            while(low<=high)
            {
                int mid = (low + high) / 2;
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
        /// <summary>
        /// Binary Search for the strings.
        /// </summary>
        public static void BinaryforStrings()
        {
            Console.WriteLine("This is binary search for strings");
            Console.WriteLine("Enter the N to enter the strings upto N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements upto" + N);
            string[] arr = new string[N];
            // taking user input upto N, i.e., given by user itself
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the string you want to search");
            string key = Console.ReadLine();
            int low = 0;
            int high = arr.Length - 1;
            while(low<high)
            {
                int mid = (low + high) / 2;
                //String that is to be searched gets compared with Array of mid
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    Console.WriteLine("string found on" + mid);
                }
                if(res > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
        /// <summary>
        /// Insertion sort for the number.
        /// </summary>
        public static void InsertionNumber()
        {
            int i, n;
            int j, val, flag;
            Console.WriteLine("Enter the number of total elements you want to add");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int k = 0; k < n; k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Insertion Sort " + arr);
            Console.WriteLine("Initial array :");
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
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        /*
        public static void InsertionforString()
        {
            Console.WriteLine("Enter the N");
            int N =Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[N];
            Console.WriteLine("Enter the string");
            for(int i = 0;i < N;i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the element to search");
            string key = Console.ReadLine();
            for(int i =1;i < N;i++)
            {
                string val = arr[i];
                int flag = 0;
                for(int j = i-1;j>=0 && flag !=1)
                {
                    if(val < arr[j])
                }

            }
        }
        */
        /// <summary>
        /// Bubble sort for the integers.
        /// </summary>
        public static void BubblesortIntegers()
        {
            Console.WriteLine("Enter the value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[N];
            for (int i=0; i < N;i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for(int j =0; j<= arr.Length-2;j++)
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
            for(int k =0;k < N;k++)
            {
                Console.Write( arr[k]+",");
            }
        }
        /// <summary>
        /// Bubblesort for the string.
        /// </summary>
        public static void BubblesortString()
        {
            // To measure time elapsed we start the timer at function call
            DateTime now = DateTime.Now;
            string e = now.ToLongTimeString();
            Console.WriteLine(e);

            Console.WriteLine("Enter the N");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[N];
            for(int i =0;i<str.Length;i++)
            {
                str[i] = Console.ReadLine();
            }
            for(int i=1;i<str.Length;i++)
            {
                string temp = string.Empty;
                for(int j =0;j<str.Length-1;j++)
                {
                    if(str[j].CompareTo(str[j+1])>0)
                    {
                        temp = str[j + 1];
                        str[j + 1] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            for(int i =0;i<str.Length;i++)
            {
                Console.WriteLine(str[i] + ",");
            }
            // Again timer is being called and stored in a variable
            DateTime now1 = DateTime.Now;
            string s = now1.ToLongTimeString();
            Console.WriteLine(s);
            TimeSpan duration = DateTime.Parse(s).Subtract(DateTime.Parse(e));
            Console.WriteLine("Time elapsed is"+duration);
            Console.ReadKey();
        }
        /// <summary>
        /// Program simply find your number what you imagined in b/w 0 to N
        /// </summary>
        public static void FindyourNumber()
        {
            Console.WriteLine("Enter the value upto N(what upto you think)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thinked number must lie in between 0 to " + N);
            int low = 0;
            int high = N - 1;
            int num = N;
            //Implementing binary Search Algorithm here
            while(low<high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("number you choose is " + mid);
                Console.WriteLine("number you choose is >" + mid);
                Console.WriteLine("number you choose is <" + mid);
                Console.WriteLine("Enter your choice please");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Number found !!!"+mid);
                }
                if(choice == 2)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
        }
        /// <summary>
        /// Reading words from another text file 
        /// and searching a string into it 
        /// and finding it's index value.
        /// </summary>
        public static void WordfromWordList()
        {
            //Reading from a CSV file and storing in a variable.
            string infile = @"C:\Users\Bridgelabz\Desktop\mytext.txt";
            StreamReader sr = new StreamReader(infile);
            string text = System.IO.File.ReadAllText(@"C:\Users\Bridgelabz\Desktop\mytext.txt");
            int length = text.Length;
            //making string arr that will spilit the CSV file into (','). 
            string[] arr = text.Split(',');
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+",");
                
            }
            //taking input from user to search a word and implementing binary search for strings
            Console.WriteLine("Enter the word you want to search");
            string key = Console.ReadLine();
            int low = 0;
            int high = arr.Length - 1;
            while(low<= high)
            {
                int mid = (low + high) / 2;
                int res = key.CompareTo(arr[mid]);
                if(res ==0)
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
        /// <summary>
        /// Taking input from the user as month date and year 
        /// and printing the day which it falls
        /// </summary>
        /// <param name="m">I/P given by user as month</param>
        /// <param name="d">I/P given by user as date</param>
        /// <param name="y">I/P given by user as Year</param>
        public static void DayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            if (d0 == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (d0 == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (d0 == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (d0 == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (d0 == 4)
            {
                Console.WriteLine("Thrusday");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("Saturday");
            }
            Console.WriteLine("Value of d0 = " + d0);
        }
        /// <summary>
        /// Temparature Conversion i.e., Farenheit to Celcius or vice-versa
        /// </summary>
        public static void Temparature()
        {

            Console.WriteLine("Temperature Conversion Program");
            Console.WriteLine("Enter temperature here to find in farenheit --> celcius or Vice-Versa");
            Console.WriteLine("Enter your temperature here");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which type of conversion you want ?");
            Console.WriteLine("press 1 for farenheit to celcius");
            Console.WriteLine("Press 2 for celcius to farenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

                int c = (temp - 32) * 5 / 9;
                Console.WriteLine("Your temperature in celcius is -->" + c);
            }
            if (choice == 2)
            {

                int f = (temp * 9 / 5) + 32;
                Console.WriteLine("Your temperature in farenheit is -->" + f);
            }
        }
        /// <summary>
        /// Calculation of the Monthly payment 
        /// </summary>
        public static void MonthlyPayment()
        {
            double payment = 0;
            Console.WriteLine("Enter principal loan amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            double R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            double Y = Convert.ToInt32(Console.ReadLine());
            double n = 12 * Y;
            double r = R / (12 * 100);
            double N = (1 + r);

            payment = (P * r) / (1 - (Math.Pow(N, -n)));
            Console.WriteLine("Your payment is " + payment);
        }
        /// <summary>
        /// Square Root of the number using inbuild Epsilon.
        /// </summary>
        public static void Sqrt()
        {
            Console.WriteLine("Enter the number here");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            while (Math.Abs(t - c / t) > Double.Epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            Console.WriteLine(t);
        }
        /// <summary>
        /// Program Computing both decimal to binary and Vice-Versa
        /// On addition it's swipe the two half nibbles and convert again them in binary
        /// </summary>
        public static void BinaryNibbles()
        {
            //Converting decimal to Binary
            Console.WriteLine("ENter the Number here");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[8];
            int n = arr.Length;
            //Console.WriteLine(n);
            while (num > 0)
            {
                int rem = num % 2;
                arr[n - 1] = rem;
                num = num / 2;
                n--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine("\n");
            double sum = 0;
            //Converting binary to decimal
            int m = 0;
            n = arr.Length;
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

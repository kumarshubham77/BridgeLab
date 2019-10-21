using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithms
{
    class Utility
    {
        public static void Anagram(string str1, string str2)
        {
            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();
            Console.WriteLine(char1);
            Array.Sort(char1);
            Array.Sort(char2);
            string newword1 = new string(char1);
            string newword2 = new string(char2);
            if (newword1 == newword2)
            {
                Console.WriteLine("They are annagram");
            }
            else
            {
                Console.WriteLine("Not a anagram sorry");
            }
        }
        public static void PrimeRange()
        {
            bool isprime = true;
            Console.WriteLine("Prime Numbers :");
            Console.WriteLine("Enter the upper limit :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower limit :");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= m; i++)
            {
                for (int j = 2; j <= m; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }
        public static void Palindome(int n)
        {
            int r;
            int sum = 0;
            int temp;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
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
        public static int BinarySearch(int[] arr, int key, int low, int high)
        {
            DateTime now = DateTime.Now;
            string e = now.ToLongTimeString();
            while (low <= high)
            {




                int mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    BinarySearch(arr, key, low, mid - 1);
                }
                else
                {
                    BinarySearch(arr, key, mid + 1, high);
                }
            }
            DateTime now1 = DateTime.Now;
            string s = now1.ToLongTimeString();
            TimeSpan duration = DateTime.Parse(s).Subtract(DateTime.Parse(e));
            Console.WriteLine(duration);
            return -1;
        }
        public static int BinaryString(string[] arr, string x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = (l + (r - l) / 2);
                int res = x.CompareTo(arr[m]);
                if (res == 0)
                {
                    return m;
                }
                else if (res > 0)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }

            }
            return -1;
        }
        /// <summary>
        /// Vendings the machine.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void VendingMachine(int N)
        {
            int ONE = 1;
            int TWO = 2;
            int FIVE = 5;
            int TEN = 10;
            int FIFTY = 50;
            int HUNDRED = 100;
            int FIVEHUNDERED = 500;
            int THOUSAND = 1000;
            
            int tempmoney = N;
            while (tempmoney > 0)
            {
                int noofnotes = 0; 
                if (tempmoney > 1000)
                {
                    noofnotes += tempmoney / THOUSAND;
                    tempmoney = tempmoney % THOUSAND;
                    Console.WriteLine("No. of Thousand Rupees Note is :" +noofnotes);
                }
                else if (tempmoney >= FIVEHUNDERED && tempmoney < THOUSAND)
                {
                    noofnotes += tempmoney / FIVEHUNDERED;
                    tempmoney = tempmoney % FIVEHUNDERED;
                    Console.WriteLine("No. of Five Hundred Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= HUNDRED && tempmoney < FIVEHUNDERED)
                {
                    noofnotes += tempmoney / HUNDRED;
                    tempmoney = tempmoney % HUNDRED;
                    Console.WriteLine("No. of Hundred Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= FIFTY && tempmoney < HUNDRED)
                {
                    noofnotes += tempmoney / FIFTY;
                    tempmoney = tempmoney % FIFTY;
                    Console.WriteLine("No. of Fifty Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= TEN && tempmoney < FIFTY)
                {
                    noofnotes += tempmoney / TEN;
                    tempmoney = tempmoney % TEN;
                    Console.WriteLine("No. of Ten Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= FIVE && tempmoney < TEN)
                {
                    noofnotes += tempmoney / FIVE;
                    tempmoney = tempmoney % FIVE;
                    Console.WriteLine("No. of Five Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= TWO && tempmoney < FIVE)
                {
                    noofnotes += tempmoney / TWO;
                    tempmoney = tempmoney % TWO;
                    Console.WriteLine("No. of Two Rupees Note is :" + noofnotes);
                }
                else
                {
                    noofnotes += tempmoney / ONE;
                    tempmoney = tempmoney % ONE;
                    Console.WriteLine("No. of One Rupees Note is :" + noofnotes);
                }
                Console.WriteLine("Minimum number of notes to be given is " + noofnotes);

            }
            

        }
        public static void DayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            if(d0 == 0)
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
            Console.WriteLine("Value of d0 = "+ d0);
        }
       
        
                    
        
        public static void InsertionNumber()
        {
            int i, n;
            int j, val, flag;
            Console.WriteLine("Enter the number of total elements you want to add");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int k =0;k < n;k++)
            {
                arr[k] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Insertion Sort "+arr);
            Console.WriteLine("Initial array :");
            for(i = 0;i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for(i =1;i<n;i++)
            {
                val = arr[i];
                flag = 0;
                for(j=i-1;j>=0 && flag != 1;)
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
            Console.WriteLine("sorted");
            for(i =0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void InsertionString()
        {

        }
        public static void Bubble()
        {
            Console.WriteLine("Enter the total number of elements here");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int k=0;k<n;k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Bubble sort");
            Console.WriteLine("The element is :");
            for(int i =0;i < n;i++)
            {
                Console.WriteLine("Element is " + arr[i]);
            }
            int temp;
            for(int i =0;i<=arr.Length-2;i++)
            {
                for(int j =0;j<=arr.Length-2;j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted ----");
            foreach(int p in arr)
            {
                Console.WriteLine("   " + p);
            }
        }
        public static void BubblesortString()
        {
            DateTime now = DateTime.Now;
            string e = now.ToLongTimeString();
            Console.WriteLine("This is the bubble sort for strings");
            Console.WriteLine("Enter the number upto uh want to insert your strings");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            string temp = string.Empty;
            Console.WriteLine("Enter the elements");
            for(int k =0 ; k < s.Length; k++)
            {
                s[k] = Console.ReadLine();
            }
            for(int i =1; i<s.Length;i++)
            {
                for(int j =0;j <s.Length-i;j++)
                {
                    if (s[j].CompareTo(s[j + 1]) > 0)
                    {
                        temp = s[j];
                        s[j]= s[j + 1];
                        s[j+1] = temp;
                    }
                }
            }
            for(int i = 0; i<s.Length;i++)
            {
                Console.Write(s[i]+"  ");
                Console.WriteLine("\n");
            }
            DateTime now1 = DateTime.Now;
            string t = now1.ToLongTimeString();
            TimeSpan duration = DateTime.Parse(t).Subtract(DateTime.Parse(e));
            Console.WriteLine(duration);

        }
        public static void ToDecimal()
        {
            Console.WriteLine("Enter the number in Binary Format");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int num = n;
            int base1 = 1;
            int value = 0;
            int temp = num;
            while(num> 0)
            {
                int last = temp % 10;
                temp /= 10;
                value += last * base1;
                base1 *= 2;
                Console.WriteLine(value);
            }
            
            
        }
        public static void Findmynumber()
        {
            Console.WriteLine("Please Enter the value upto waht to you > 0");
            int n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is that your number in Between 0 to" + n);
            int low = 0;
            int high = n - 1;
            int num = n;
            while(low<high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("Choose Your option ");
                Console.WriteLine("1-" + mid + "is the option that you chosen");
                Console.WriteLine("2-" + mid + "Choose this if the number is smaller than" +mid);
                Console.WriteLine("3-" + mid + "Choose this if the number is greater than" +mid);
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice ==1)
                {
                    Console.WriteLine("The number is found");
                    break;
                }
                else if(choice == 2 )
                {
                    high = mid - 1;
                }
                else if (choice == 3)
                {
                    low = mid + 1;
                }
                else
                {
                    Console.WriteLine("Wrong !!! Wrong !!! Wrong !!!");
                }
            }
        }
        public static void BinaryforIntegers()
        {
            Console.WriteLine("This is Binary Search for Integers");
            Console.WriteLine("Enter the number in which you want to find");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the Elements");
            for(int k =0; k<arr.Length;k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the key what you wanna search in the array");
            int key = Convert.ToInt32(Console.ReadLine());
            int low = 0;
            int high = arr.Length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    Console.WriteLine("The number is found on--->" +mid);
                    break;
                }
                if(key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        public static void BinaryforStrings()
        {
            DateTime now = DateTime.Now;
            string e = now.ToLongTimeString();
            Console.WriteLine("This is the binary search for strings");
            Console.WriteLine("Enter the number upto N");
            int n = Convert.ToInt32(Console.ReadLine());
            String[] arr = new string[n];
            Console.WriteLine("Enter the strings");
            int i;
            for( i =0;i<arr.Length;i++)
            {
                arr[i] = Console.ReadLine();
                
            }
            Console.WriteLine("Enter the string you want to search");
            String str = Console.ReadLine();
            int low = 0;
            int high = arr.Length - 1;
            //int mid = (low + high) / 2;
            //Console.WriteLine(mid);
            while (low <= high)
            {
                int mid = low + (high - 1) / 2;
                int res = str.CompareTo(arr[mid]);
                Console.WriteLine(res);
                DateTime now1 = DateTime.Now;
                string s = now1.ToLongTimeString();
                TimeSpan duration = DateTime.Parse(s).Subtract(DateTime.Parse(e));
                Console.WriteLine(duration);

                if (res == 0)
                {
                    Console.WriteLine("Found on " + mid);
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
        public static void Todecimal(String binary)
        {
            int dec = 0;
            for (int i= 0,j =binary.Length-1;i < binary.Length;i++,j--)
            {
                if(binary[j] == '1')
                {
                    dec = dec + (int)Math.Pow(2, i); 
                }
                
            }
            Console.WriteLine(dec);
        }
        public static void MonthlyPayment()
        {
            double payment = 0;
            Console.WriteLine("Enter principal loan amount");
            double P =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            double R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            double Y = Convert.ToInt32(Console.ReadLine());
            double  n = 12 * Y;
            double r = R / (12 * 100);
            double N = (1 + r);

           payment = (P * r) / (1 -(Math.Pow(N,-n)));
            Console.WriteLine("Your payment is " +payment);
        }


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
                
                int c = (temp - 32) * 5/9;
                Console.WriteLine("Your temperature in celcius is -->" +c);
            }
            if (choice ==2)
            {
                
                int f = (temp * 9/5) + 32;
                Console.WriteLine("Your temperature in farenheit is -->" + f);
            }
        }
        public static void BinaryNibbles()
        {
            Console.WriteLine("ENter the Number here");
            int num =Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[8];
            int n = arr.Length;
            //Console.WriteLine(n);
            while(num > 0)
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
            double sum =0;
            
            int m = 0;
            n = arr.Length;
            for(int i=n-1;i>=0;i--)
            {
                //Console.WriteLine("Entered");
                int val = arr[i];
                double res = val * Math.Pow(2, m);
                sum = sum + res;
                m++;
               

            }
            Console.WriteLine(sum);
            n = arr.Length;
            int n1 = n / 2;
            int k = 0;
            int[] arr1 = new int[n / 2];
            int[] arr2 = new int[n / 2];
            int[] arr3 = new int[n];
            for(int i =0;i<n/2;i++)
            {
                arr1[i] = arr[i];
            }
            for(int i =0;i<n/2;i++)
            {
                arr2[i] = arr[n1];
                n1++;
            }
            for(int i =0;i<n/2;i++)
            {
                arr3[i] = arr2[i];
            }
            for(int i =n/2;i<n;i++)
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
       
        public static void Sqrt()
        {
            Console.WriteLine("Enter the number here");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            while(Math.Abs(t -c/t) > Double.Epsilon * t )
            {
                t =  (c / t + t) / 2;
            }
            Console.WriteLine(t);
        }
        public static void WordList(string[] words, string search)
        {
            
            int low = 0;
            int high = words.Length - 1;
            while(low < high)
            {
                int mid = (low + high) / 2;
                int res = search.CompareTo(words[mid]);
                if (res == 0)
                {
                    Console.WriteLine("Number found on" + mid);
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

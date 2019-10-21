using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Poweroftwo
    {
        public void Command()
        {
            Console.WriteLine("Enter the Number Here");
            int num = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 0; i <= num; i++)
            {
                //string k = "4";
                int r = Convert.ToInt32(Math.Pow(2, i));
                string s = r.ToString();
                Console.WriteLine(s);
                //if (s.Length == k)
                {
                    //int v = Convert.FromBase64String(r);
                    if ((r % 4 == 0 && r % 100 != 0) || (r % 400 == 0))
                    {
                        Console.WriteLine("Number is Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Number is not a leap year");
                    }
                }
            }
        }
    }
}

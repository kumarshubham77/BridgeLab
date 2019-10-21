using System;
using System.Collections;
using System.Linq;
using System.Text;





namespace Functional
{
    class Coupon
    {
        public static void GenerateCoupon()
        {
            Console.WriteLine("Enter the number upto which you want random number");
            int N =Convert.ToInt32(Console.ReadLine());
            ArrayList arr = new ArrayList();
            int count = 0;
            for (int i = 0; i <= N; i++)
            { 
                Random rand = new Random();
                int r = rand.Next(0, N);
                //Console.WriteLine(r);
                if (arr.Contains(r) == false)
                {
                    arr.Add(r);
                    count += 1;
                }
                
            }
            foreach (int i in arr)
            Console.WriteLine("The array is " + i);
            Console.WriteLine("Total Distinct numbers are " + count);
        }
    }
}

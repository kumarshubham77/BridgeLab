using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrimeDetection
    {
        public static bool Isprime(int n)
        {
            int count = 0;
            Boolean b = false;
            for (int i = 0; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
    }
}

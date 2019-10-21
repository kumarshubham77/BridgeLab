using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Harmonic
    {
        public void Harmonics()
        {
            Console.WriteLine("Enter the number upto which your want harmonic number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //int i = 1;
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += (1 + i);
                    //Console.WriteLine(sum);
                }
                
            }
            Console.WriteLine("Harmonic Value" +sum);

        }
        
    }
}

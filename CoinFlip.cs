using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class CoinFlip
    {
        public void Flipcoin()
        {
            Console.WriteLine("Enter the number you want to flip the coin ?");
            int flip = Convert.ToInt32(Console.ReadLine());
            int tail = 0;
            int head = 0;
            for (int i = 0; i <= flip; i++)
            {
                Random rand = new Random();
                int r = rand.Next(0,10);
                //Console.WriteLine(r);
                if(r<5)
                {
                    tail += 1;
                }
                else
                {
                    head += 1;
                }
            }
            float headp = ((head * 100)/flip);
            float tailp = ((tail * 100) / flip);
            Console.WriteLine("The percentage of head is"+headp);
            Console.WriteLine("The percentage of tail is" + tailp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Gambler
    {
        public void Gambling()
        {
            Console.WriteLine("Place your stake");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Place your Goal");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Place your times");
            int times = Convert.ToInt32(Console.ReadLine());
            int bets = 0;
            int win = 0;
            int loss = 0;
            float winp;
            float lossp;
            int cash = stake;
            int t = times;
                
                
                while (cash > 0 && cash < goal && times > 0 )
                {
                    bets += 1;

                    Random rand = new Random();
                    int r = rand.Next(0, 2);
                    //Console.WriteLine(r);
                    if (r == 0)
                    {
                        cash += 1;
                        win += 1;
                    }
                    else
                    {
                        cash -= 1;
                        loss += 1;
                    }
                times -= 1;
                }
                /*
                if(cash == goal)
                {
                    win += 1;
                    //Console.WriteLine(win);
                }
            */
            
            Console.WriteLine("No of wins =" +win);
            Console.WriteLine("No of Loss =" +loss);
            winp = Convert.ToInt32((win / t) * 100);
            lossp = Convert.ToInt32((loss / t) * 100);
            Console.WriteLine("wins percentage =" +winp);
            Console.WriteLine("Loss percentage =" +lossp) ;
        }
    }
}

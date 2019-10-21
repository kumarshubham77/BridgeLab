using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class DateandTime
        
    {
        
        public void SimulateDateTime()
        {
            
            
            Console.WriteLine("Press E to strt timer");
            if (Console.ReadLine() == "E")
            {
                DateTime now = DateTime.Now;
                string e = now.ToLongTimeString();
                
                Console.WriteLine(e);



                Console.WriteLine("Press S to stop timer");
                if (Console.ReadLine() == "S")
                {
                    DateTime now1 = DateTime.Now;
                    string s = now1.ToLongTimeString();

                    Console.WriteLine(s);

                    TimeSpan duration = DateTime.Parse(s).Subtract(DateTime.Parse(e));
                    Console.WriteLine(duration);
                    Console.ReadKey();
                }
                
            }

            

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class TwoDarray
    {
        public void Darray()
        {
            int[,] arr = new int[3, 3];
            Console.Write("Enter the elements");
            for(int i = 0 ; i < 3 ; i++)
            {
                for (int j = 0 ; j < 3; j++)
                {
                    Console.Write("element -- [{0},{1}]" ,i,j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The Matrix is");
            for (int i = 0 ; i < 3 ; i++)
            {
                Console.Write("\n");
                for (int j = 0 ; j < 3 ; j++)
                {
                    Console.Write("{0}", arr[i, j]);
                }
            }
            Console.Write("\n\n");
        }
    }
}

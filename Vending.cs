using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{// --------------------------------------------------------------------------------------------------------------------
 // <copyright file=Vending.cs" company="Bridgelabz">
 //   Copyright © 2019 Company="BridgeLabz"
 // </copyright>
 // <creator name="Kumar Shubham"/>
 // -------------------------------------------------------------------------------------------------------------------- 
 /// <summary>
 /// This is a vending machine tool 
 /// It gives minimum number of resulting notes to fulfill the required notes.
 /// </summary>
    class Vending
    {
        
        int total = 0;
        int[] arr = { 1, 2, 5, 10, 50, 100, 200, 500, 1000 };
        /// <summary>
        /// this method will check for the value in the list 
        /// that is bigger than the note/n given by the user
        /// if found, then it calls for another function and given two parameters attached wuth it.
        /// that is the n and the value in the array smaller than note.
        /// </summary>
        /// <param name="n">Note given by the user as n</param>
        public void check(int n)
        {
            if (n != 0)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    //Console.WriteLine("Entered");
                    if (n < arr[i])
                    {
                        Divide(n, arr[i - 1]);
                        break;
                    }
                }
                if (n > 1000)
                {
                    Divide(n, 1000);
                }
            }
            ///This method will take two parameters given by the check method 
            ///it divides the note with the nearestvalue which is given as a parameter
            ///from then it calculates the  minimum no of notes given and 
            ///which note upto how much to be give.
            void Divide(int note, int nearvalue)
            {
                int sum = 0;
               
                if (n != 0)
                {
                    sum =sum + note / nearvalue;
                    total = total + sum;
                    int num = note % nearvalue;
                    Console.WriteLine("number of"+nearvalue +"is-->"+sum);
                    check(num);
                }
               
            }
            Console.WriteLine("Total number of cash -->" + total);
        }
      
    }
}
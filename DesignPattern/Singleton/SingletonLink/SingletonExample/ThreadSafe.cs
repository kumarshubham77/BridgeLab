// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ThreadSafe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.SingletonLink.SingletonExample
{
    /*
     *  Sealed ensures the class being inherited and
     *  object instantiation is restricted in the derived class
     */
    public sealed class ThreadSafe
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private ThreadSafe()
        {
            counter++;
            Console.WriteLine("Value of the Counter is" + counter);
        }
        private static ThreadSafe instance = null;
        public static ThreadSafe getInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafe();
                        }
                    }

                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

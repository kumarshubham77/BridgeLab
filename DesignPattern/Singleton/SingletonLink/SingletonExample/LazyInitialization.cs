// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LazyInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.SingletonLink.SingletonExample
{
    class LazyInitialization
    {
        public static int counter = 0;
        private LazyInitialization()
        {
            counter++;
            Console.WriteLine("The value of the Count is " + counter);
        }
        
        private static readonly Lazy<LazyInitialization> instance = new Lazy<LazyInitialization>(()=>new LazyInitialization());
        public static LazyInitialization getInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

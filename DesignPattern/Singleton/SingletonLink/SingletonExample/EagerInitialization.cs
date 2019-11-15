// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.SingletonLink.SingletonExample
{
    public sealed class EagerInitialization
    {
        public static int counter = 0;
        private EagerInitialization()
        {
            counter++;
            Console.WriteLine("The value of the Count is " + counter);
        }
        private static readonly EagerInitialization instance = new EagerInitialization();
        public static EagerInitialization getInstance
        {
            get
            {
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

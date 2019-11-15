// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SingletonExampleone.cs" company="Bridgelabz">
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
    public sealed class SingletonExampleone
    {
        public static int counter = 0;
        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        private static SingletonExampleone instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static SingletonExampleone GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonExampleone();
                }
                return instance;
            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private SingletonExampleone()
        {
            counter++;
            Console.WriteLine("The value of counter is " + counter.ToString());
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

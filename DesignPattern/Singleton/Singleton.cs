
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Code demonstrate the Singeton Design Pattern
/// Making all constructors Private
/// Avoiding creation of making more than one Instance.
/// </summary>
namespace DesignPattern.Singleton
{
    /// <summary>
    /// Making Class sealed so that it cannot inherited anymore.
    /// As Sealed restricts the Inheritance.
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj=new object();
        /// <summary>
        /// As The COnstructor is private So,we cant instantiate the class
        /// to overcome this problem, We need to create a
        /// Singeton Object Creation.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        /// Single Instance of a Singeton class.
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {

                        //We need to create instance only if the 
                        //above declared private property is null.
                        if (instance == null)
                            return instance = new Singleton();
                    }
                }
                
                return instance;
            }
        }
        //Making all Constructor as Private, 
        //Just to satisfy the Consdition of creating a singeton class.
        // As well as no other object creation would occcur.


        /// <summary>
        /// public property is used to return only one instance of the class.
        /// Prevents a default instance of the <see cref="Singleton"/> class from being created.
        /// </summary>
        private Singleton()
        {
            counter++;
            Console.WriteLine("The value of the counter is " + counter.ToString());
        }
        //Public method which can be invoked through the singleton instance.
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

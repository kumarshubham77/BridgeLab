// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// Creating a class of PatternTest
    /// </summary>
    public class PatternTest
    {
        /// <summary>
        /// Start method created as a static which will return void.
        /// </summary>
        public static void Start()
        {

            ////Enter the option to execute.
            Console.WriteLine("1.Admin.\n2.Manager");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    ////creating the object for Admin class and calling the functions.
                    Admin admin = new Admin();
                    admin.companyName = "BridgeLabz";
                    admin.name = "Sachin";
                    admin.salary = 100000;

                    ////Cloning the object of the Admin class.
                    Admin admincopy = (Admin)admin.Clone();
                    admincopy.name = "manish";
                    Console.WriteLine(admin.GetDetails());
                    Console.WriteLine(admincopy.GetDetails());
                    break;
                case 2:

                    ////creating the object for Manager class and calling the functions.
                    Manager manager = new Manager();
                    manager.companyName = "BridgeLabz";
                    manager.name = "Avinash";
                    manager.salary = 10000000;

                    ////Cloning the object of the Manager class.
                    Manager managercopy = (Manager)manager.Clone();
                    managercopy.name = "Manish";
                    Console.WriteLine(manager.GetDetails());
                    Console.WriteLine(managercopy.GetDetails());
                    break;
            }

            ////for repeating the process.
            Console.WriteLine("Do you still want to execute (y/n)");
            string repeat = Console.ReadLine();
            if (repeat == "y" || repeat == "Y")
            {
                PatternTest.Start();
            }
        }
    }
}

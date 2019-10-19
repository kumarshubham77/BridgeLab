// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Bike.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.CreationalDesignPattern.FactoryDesignPattern
{
    /// <summary>
    ///  Creating a class Scooter which inherit the IFactory
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.CreationalDesignPattern.FactoryDesignPattern.IFactory" />
    public class Bike : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }
    }
}

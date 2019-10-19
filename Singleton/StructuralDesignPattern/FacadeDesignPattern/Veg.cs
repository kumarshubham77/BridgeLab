// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Veg.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// class Veg which Inherit the Hotel class Interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern.Hotel" />
    public class Veg : Hotel
    {
        /// <summary>
        /// Creating a method called Vegetarians.
        /// </summary>
        public void Vegetarian()
        {
            Console.WriteLine("Here all the Vegetarian Items are available");
        }
    }
}

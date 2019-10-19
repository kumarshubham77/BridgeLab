// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NonVeg.cs" company="Bridgelabz">
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
    /// class NonVeg which Inherit the Hotel class Interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern.Hotel" />
    public class NonVeg : Hotel
    {
        /// <summary>
        /// Creating a method called Nonvegetarians.
        /// </summary>
        public void Nonvegetarian()
        {
            Console.WriteLine("Here all the Non Vegetarian Itams are Found!!!");
        }
    }
}

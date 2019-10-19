// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BothNonVegandVeg.cs" company="Bridgelabz">
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
    /// class BothNonVegandVeg which Inherit the Hotel class Interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.StructuralDesignPattern.FacadeDesignPattern.Hotel" />
    public class BothNonVegandVeg : Hotel
    {
        /// <summary>
        /// Creating a method Both().
        /// </summary>
        public void Both()
        {
            Console.WriteLine("Here both item can be found Non veg as well as Veg also");
        }
    }
}

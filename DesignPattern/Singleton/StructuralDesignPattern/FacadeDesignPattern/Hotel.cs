// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Hotel.cs" company="Bridgelabz">
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
    /// Creating an Interface of Hotel class.
    /// </summary>
    interface Hotel
    {
        /// <summary>
        /// Creating a method i.e., Method().
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("This is the main Building for all Hotels");
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Mouse.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.StructuralDesignPattern.AdapterDesignPattern
{
    /// <summary>
    /// Creating a class Mouse
    /// </summary>
    class Mouse
    {
        /// <summary>
        /// Creating a Method i.e., connectB().
        /// </summary>
        public void connectB()
        {
            Console.WriteLine("Sending Signal to USB Connector!");
        }
    }
}

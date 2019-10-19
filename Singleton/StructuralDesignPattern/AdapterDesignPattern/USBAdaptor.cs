// --------------------------------------------------------------------------------------------------------------------
// <copyright file=USBAdaptor.cs" company="Bridgelabz">
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
    /// Creating a class USBAdaptor
    /// </summary>
    public class USBAdaptor
    {
        /// <summary>
        /// Creating object of Mouse class.
        /// </summary>
        Mouse mouse = new Mouse();
        /// <summary>
        /// Creating a method i.e., connectA().
        /// </summary>
        public void connectA()
        {
            //Calling connectB method from mouse class.
            mouse.connectB();
            Console.WriteLine("Recived Signal from Mouse and Converting it");
            Console.WriteLine("Sending new converted signal to Computer");
        }
    }
}

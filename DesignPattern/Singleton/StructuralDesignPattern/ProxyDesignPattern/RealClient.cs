// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RealClient.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.StructuralDesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// Class RealClient inherit the IClient interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.StructuralDesignPattern.ProxyDesignPattern.IClient" />
    public class RealClient : IClient
    {
        string data;
        /// <summary>
        /// Defining a new method i.e., RealClient()
        /// Initializes a new instance of the <see cref="RealClient"/> class.
        /// </summary>
        public RealClient()
        {
            Console.WriteLine("Real Client Initialized");
            data = "Dot Net Tricks";
        }
        /// <summary>
        ///As this class Inherit the IClient class thus all mehtods are get invoked.
        /// </summary>
        /// <returns>data</returns>
        public string getdata()
        {
            return data;
        }
    }
}

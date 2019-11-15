// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeFactor.cs" company="Bridgelabz">
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
    /// Class ProxyClient inherit the IClient interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.StructuralDesignPattern.ProxyDesignPattern.IClient" />
    public class ProxyClient : IClient
    {
        /// <summary>
        /// Creating an object of the RealClient Class
        /// </summary>
        RealClient RealClient = new RealClient();
        /// <summary>
        /// Creating a method ProxyClient().
        /// Initializes a new instance of the <see cref="ProxyClient"/> class.
        /// </summary>
        public ProxyClient()
        {
            Console.WriteLine("Proxy Constructor Initialized");
        }

        /// <summary>
        /// As this class Inherit the IClient class thus all mehtods are get invoked.
        /// </summary>
        /// <returns> RealCLient getdata method.</returns>
        public string getdata()
        {
            return RealClient.getdata();
        }
    }
}

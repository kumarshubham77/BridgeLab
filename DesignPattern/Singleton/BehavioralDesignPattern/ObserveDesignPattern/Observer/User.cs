// --------------------------------------------------------------------------------------------------------------------
// <copyright file=User.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.BehavioralDesignPattern.Observer
{
    /// <summary>
    /// User is a class which inherits the ISubscriber Interface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.Observer.ISubscriber" />
    public class User : ISubscriber
    {
        /// <summary>
        /// Notifies this instance
        /// Notify method will notify here as it Inherit the ISubscriber Interface.
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("User has been Updated about the channel Update and about the new Video Launched.!");
        }
    }
}

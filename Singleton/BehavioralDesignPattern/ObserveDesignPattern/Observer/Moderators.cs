// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Moderators.cs" company="Bridgelabz">
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
    /// Moderators is a class which inherits the ISubscriber Interface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.Observer.ISubscriber" />
    public class Moderators : ISubscriber
    {
        /// <summary>
        /// Notifies this instance
        /// Notify method will Notify here as it inherit the ISubscriber Interface
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("Moderator Need to review the Video!");
        }
    }
}

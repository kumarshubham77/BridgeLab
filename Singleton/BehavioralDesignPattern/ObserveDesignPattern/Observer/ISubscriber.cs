// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ISubscriber.cs" company="Bridgelabz">
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
    /// Creating an Interface of ISubscriber
    /// which we will use in other classes.
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// Notifies this instance
        /// Creating a method i.e., Notify that will
        /// Notify all the classes which inheit the ISubscribe Interface.
        /// </summary>
        void Notify();
    }
}

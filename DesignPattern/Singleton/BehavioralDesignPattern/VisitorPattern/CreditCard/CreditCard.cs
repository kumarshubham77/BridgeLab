// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CreditCard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.Offers;

namespace DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.CreditCard
{
    /// <summary>
    /// Creating an interface of the class CreditCard
    /// </summary>
    interface CreditCard
    {
        /// <summary>
        /// Creating a method i.e., getName() 
        /// Which will return the name in the classes which Inherit the CreditCard Interface.
        /// </summary>
        /// <returns></returns>
        string getName();
        /// <summary>
        /// Accepts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        void accept(OfferVisitor v);
    }
}

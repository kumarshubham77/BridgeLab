// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SilverCreditCard.cs" company="Bridgelabz">
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
    /// SilverCreditCard is a class whit Inherit the CreditCard interface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.CreditCard.CreditCard" />
    public class SilverCreditCard : CreditCard
    {
        /// <summary>
        /// Accepts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        public void accept(OfferVisitor v)
        {
            v.visitSilverCreditCard(this);
        }
        /// <summary>
        /// Creating a method i.e., getName()
        /// Which will return the name 
        /// This class Inherit the CreditCard Interface.
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return "Silver";
        }
    }
}

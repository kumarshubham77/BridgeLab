// --------------------------------------------------------------------------------------------------------------------
// <copyright file=GoldCreditCard.cs" company="Bridgelabz">
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
    /// GoldCreditCard is a class whit Inherit the CreditCard interface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.CreditCard.CreditCard" />
    public class GoldCreditCard : CreditCard
    {
        /// <summary>
        /// Accepts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        public void accept(OfferVisitor v)
        {
            v.visitGoldCreditCard(this);
        }
        /// <summary>
        /// Creating a method i.e., getName()
        /// Which will return the name 
        /// And is Inherit by the CrediCard Interface.
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return "Gold";
        }
    }
}

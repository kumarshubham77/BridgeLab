// --------------------------------------------------------------------------------------------------------------------
// <copyright file=GasOfferVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.CreditCard;

namespace DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.Offers
{
    /// <summary>
    /// Class GasOfferVisitor which inherit the OfferVisitor Interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.VisitorPattern.Offers.OfferVisitor" />
    class GasOfferVisitor : OfferVisitor
    {
        /// <summary>
        /// As Current class is inheriting the OfferVisitor Interface 
        /// thus, it will get all the property defined in that Interface.
        /// <param name="bronze">The bronze.</param>
        public void visitBronzeCreditCard(BronzeCreditCard bronze)
        {
            Console.WriteLine("We are Computing Gas offer cashback for the bronze Credit card");
        }
        /// <summary>
        /// As Current class is inheriting the OfferVisitor Interface 
        /// thus, it will get all the property defined in that Interface.
        /// <param name="bronze">The bronze.</param>
        public void visitGoldCreditCard(GoldCreditCard bronze)
        {
            Console.WriteLine("We are Computing Gas offer cashback for the Gold Credit card");
        }
        /// <summary>
        /// As Current class is inheriting the OfferVisitor Interface 
        /// thus, it will get all the property defined in that Interface.
        /// <param name="bronze">The bronze.</param>
        public void visitSilverCreditCard(SilverCreditCard bronze)
        {
            Console.WriteLine("We are Computing Gas offer cashback for the Silver Credit card");
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OfferVisitor.cs" company="Bridgelabz">
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
    /// Creating an Interface of the OfficeVisitor Class.
    /// </summary>
    public interface OfferVisitor
    {
        /// <summary>
        /// Visits the bronze credit card.
        /// </summary>
        /// <param name="bronze">The bronze.</param>
        void visitBronzeCreditCard(BronzeCreditCard bronze);
        /// <summary>
        /// Visits the silver credit card.
        /// </summary>
        /// <param name="bronze">The bronze.</param>
        void visitSilverCreditCard(SilverCreditCard bronze);
        /// <summary>
        /// Visits the gold credit card.
        /// </summary>
        /// <param name="bronze">The bronze.</param>
        void visitGoldCreditCard(GoldCreditCard bronze);
    }
}

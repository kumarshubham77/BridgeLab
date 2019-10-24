// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CommercialInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.CommercialData
{
    /// <summary>
    /// Creating an Interface i.e., CommercialInterface and defining 
    /// Some methods that will inherit by the another class to sperform
    /// some operations.
    /// Implementing Encapsulation.
    /// </summary>
    interface CommercialInterface
    {
        //Display Current Stock
        void DisplayStock();
        //Display the Account
        void DisplayAccount();
        //Buying the Shares.
        void Buy();
        //Selling the Shares.
        void Sell();
    }
}

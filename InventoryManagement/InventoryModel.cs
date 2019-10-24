// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.InventoryManagement
{
    /// <summary>
    /// Creating a class InventoryModel
    /// and making variables as a private.
    /// </summary>
    class InventoryModel
    {
        private string name;
        private double weight;
        private double priceperkg;
        /// <summary>
        /// Using the Concept of Expression Body Members i.e., 
        /// intoroduced in C# 7.0.
        /// </summary>
        /// 
        //Using Property of Get and Set with Lambda Expression
        //so that we can assign the value of name with the value showing below.
        public string Name
        {
            get => name;
            set => name = value;
        }
        //Using Property of Get and Set with Lambda Expression
        //so that we can assign the value of name with the value showing below.
        public double Weight
        {
            get => weight;
            set => weight = value;
        }
        //Using Property of Get and Set with Lambda Expression
        //so that we can assign the value of name with the value showing below.
        public double PricePerKg
        {
            get => priceperkg;
            set => priceperkg = value;
        }
             
    }
}

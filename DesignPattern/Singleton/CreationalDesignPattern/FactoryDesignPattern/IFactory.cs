// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.CreationalDesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// Creating an Interface i.e., IFactory
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        void Drive(int miles);
    }
}

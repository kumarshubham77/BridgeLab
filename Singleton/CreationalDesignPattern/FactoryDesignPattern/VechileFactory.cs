// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VechileFactory.cs" company="Bridgelabz">
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
    /// Creating an Abstract class of the VechileFactory
    /// </summary>
    public abstract class VechileFactory
    {
        public abstract IFactory GetVechile(string Vechile);
        
    }
}

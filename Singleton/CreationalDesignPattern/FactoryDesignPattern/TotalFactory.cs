// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TotalFactory.cs" company="Bridgelabz">
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
    /// Creating class TotalFactory which inherit the abstract class i.e., VechileFactory
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.CreationalDesignPattern.FactoryDesignPattern.VechileFactory" />
    public class TotalFactory : VechileFactory
    {
        /// <summary>
        /// Override the method defined in the VechileFactory class.
        /// </summary>
        /// <param name="Vechile">The vechile.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public override IFactory GetVechile(string Vechile)
        {
            //Implementing Switch case 
            switch (Vechile)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vechile));
            }
        }
    }
    
}

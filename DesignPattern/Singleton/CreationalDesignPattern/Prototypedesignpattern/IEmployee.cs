// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// Creating an INterface of the class IEmployee.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        IEmployee Clone();

        /// <summary>
        /// Gets the details.
        /// GetDetails method of the string type.
        /// </summary>
        /// <returns></returns>
        string GetDetails();
    }
}

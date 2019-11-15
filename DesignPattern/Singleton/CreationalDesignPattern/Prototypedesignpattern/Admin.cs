// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Admin.cs" company="Bridgelabz">
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
    /// Creating a class Admin which inherit the IEmployee interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.IEmployee" />
    public class Admin : IEmployee
    {
        /// <summary>
        /// The company name
        /// </summary>
        public string companyName;
        /// <summary>
        /// The name
        /// </summary>
        public string name;
        /// <summary>
        /// The salary
        /// </summary>
        public double salary;

        /// <summary>
        /// Sets the name of the company.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        /// <summary>
        /// Gets the name of the company.
        /// </summary>
        /// <returns></returns>
        public string GetCompanyName()
        {
            return this.companyName;
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Sets the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        /// <summary>
        /// Gets the salary.
        /// </summary>
        /// <returns></returns>
        public double GetSalary()
        {
            return this.salary;
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// Gets the details.
        /// GetDetails method of the string type.
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            return string.Format("{0}----{1}----{2}", companyName, name, salary);
        }
    }

}

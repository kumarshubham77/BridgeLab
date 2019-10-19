// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.FactoryDesign
{
    /// <summary>
    /// Creating an Absrtact class of the ComputerFactory.
    /// </summary>
    public abstract class ComputerFactory
    {
        /// <summary>
        /// Abstarct Method of String type i.e., GetaRAM().
        /// </summary>
        /// <returns></returns>
        public abstract String GetRAM();
        /// <summary>
        /// Abstarct Method of String type i.e., GetHDD().
        /// </summary>
        /// <returns></returns>
        public abstract String GetHDD();
        /// <summary>
        /// Abstarct Method of String type i.e., GetaMotherBoard().
        /// </summary>
        /// <returns></returns>
        public abstract String GetMotherBoard();

        /// <summary>
        /// Ovveride the string method to toString.
        /// </summary>
        /// <returns> Returns the value of RAM,HDD,MotherBoarad</returns>
        public String toString()
        {
            return "RAM= " + this.GetRAM() + ", HDD=" + this.GetHDD() + ", CPU=" + this.GetMotherBoard();
        }
    }
}

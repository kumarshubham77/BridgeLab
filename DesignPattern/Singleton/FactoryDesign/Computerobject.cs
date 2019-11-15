// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Computerobject.cs" company="Bridgelabz">
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
    /// Creating a class of the Computerobject.
    /// </summary>
    class Computerobject
    {
        /// <summary>
        /// Creates the Method i.e., CreateObject which will take the following parameters.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="MotherBoard">The mother board.</param>
        /// <returns></returns>
        public ComputerFactory CreateObject(String type, String ram, String hdd, String MotherBoard)
        {
            //Checking if the type is equals to Server 
            //if true, Execute the Following Operation in the If Loop.
            if(type.Equals("Server"))
            {
                return new Server(ram,hdd,MotherBoard);
            }
            //If false, execute the else loop.
            else if(type.Equals("PC"))
            {
                return new PersonalComputer(ram, hdd, MotherBoard);
            }
            //If nothing returns Null.
            return null;
        }
    }
}

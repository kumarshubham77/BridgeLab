﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Server.cs" company="Bridgelabz">
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
    /// Class of Server which inherit the ComputerFactory interface.
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.FactoryDesign.ComputerFactory" />
    class Server :ComputerFactory
    {
        private String ram;
        private String hdd;
        private String motherboard;

        public Server(String ram, String hdd, String motherboard)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.motherboard = motherboard;
        }
        /// <summary>
        /// Ovverride the Method GetHDD.
        /// As after inhertit the class methods also come alongside.
        /// <returns></returns>
        public override string GetHDD()
        {
            return this.hdd;
        }
        /// <summary>
        /// Ovverride the Method GetHDD.
        /// As after inhertit the class methods also come alongside.
        /// <returns></returns>
        public override string GetRAM()
        {
            return this.ram;
        }
        /// <summary>
        /// Ovverride the Method GetHDD.
        /// As after inhertit the class methods also come alongside.
        /// <returns></returns>
        public override string GetMotherBoard()
        {
            return this.motherboard;
        }
    }
}


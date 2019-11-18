// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RedisSetting.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.NotesModels
{
    /// <summary>
    /// Creating an class RedisSetting.
    /// </summary>
    public class RedisSetting
    {
        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string host { get; set; }
        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int port { get; set; }
    }
}

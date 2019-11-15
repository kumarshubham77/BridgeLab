// --------------------------------------------------------------------------------------------------------------------
// <copyright file=User.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton.BehavioralDesignPattern.MeadiatorDesignPattern
{
    /// <summary>
    /// Creating abstract class User
    /// </summary>
    public abstract class User
    {
        protected IChat mediator;
        protected string name;
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// Constructor Creation
        /// </summary>
        /// <param name="chat">The chat.</param>
        /// <param name="name">The name.</param>
        public User(IChat chat,string name)
        {
            this.mediator = chat;
            this.name = name;
        }
        /// <summary>
        /// Creating abstract method Send
        /// For Snding Message
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void send(string msg);
        /// <summary>
        /// Creating abstract method receive which
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void receive(string msg);
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserImpl.cs" company="Bridgelabz">
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
    /// UserImpl is a class which inherit the User class Interface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.MeadiatorDesignPattern.User" />
    class UserImpl : User
    {
        public UserImpl(IChat chat,string name):base(chat,name)
        {

        }
        /// <summary>
        /// Ovveride the receive method that was 
        /// already defined int the User class
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void receive(string msg)
        {
            Console.WriteLine(this.name + " Message Reciecved :" + msg);
        }

        /// <summary>
        /// Ovveride the send Method 
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void send(string msg)
        {
            Console.WriteLine(this.name +" Message Sent:" + msg);
            mediator.SendToAll(msg, this);

        }
    }
}

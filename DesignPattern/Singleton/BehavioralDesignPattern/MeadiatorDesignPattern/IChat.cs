// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IChat.cs" company="Bridgelabz">
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
    /// IChat is an inteface 
    /// </summary>
    public interface IChat
    {
        /// <summary>
        /// Sends to all.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="users">The users.</param>
        void SendToAll(string msg, User users);
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(User user);
    }
}

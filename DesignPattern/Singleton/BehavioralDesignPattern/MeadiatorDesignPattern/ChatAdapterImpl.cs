// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ChatAdapterImpl.cs" company="Bridgelabz">
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
    /// ChatAdapterImpl is a class which inherit the IChat inteface
    /// </summary>
    /// <seealso cref="DesignPattern.Singleton.BehavioralDesignPattern.MeadiatorDesignPattern.IChat" />
    class ChatAdapterImpl : IChat
    {
        /// <summary>
        /// Making List of generic type User
        /// </summary>
        public List<User> list;
        public ChatAdapterImpl()
        {
            this.list=new List<User>();
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user)
        {
            this.list.Add(user);
        }
        /// <summary>
        /// Sending message to all the users
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="users">The users.</param>
        public void SendToAll(string msg, User users)
        {
            foreach(var u in this.list)
            {
                if(u!=users)
                {
                    u.receive(msg);
                }
            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ChatClient.cs" company="Bridgelabz">
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
    /// ChatClient is a class which test the Meadiator Design Pattern
    /// </summary>
    class ChatClient
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void test()
        {
            /////Creating Object 
            IChat chat = new ChatAdapterImpl();
            ////User implementation
            User user1 = new UserImpl(chat, "Shubham");
            User user2 = new UserImpl(chat, "Cramp");
            User user3 = new UserImpl(chat, "Aishwarya");
            User user4 = new UserImpl(chat, "Gautam");
            User user5 = new UserImpl(chat, "RobbinHood");
            User user6 = new UserImpl(chat, "Rahul");
            ////Adding user  
            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);
            chat.AddUser(user4);
            chat.AddUser(user5);
            chat.AddUser(user6);
            user1.send("Hii I have a Cramp");

        }
    }
}

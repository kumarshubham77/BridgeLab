// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountCreation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.CommercialData
{
    class AccountCreation
    {
        /// <summary>
        /// Create a method Create
        /// </summary>
        public void Create()
        {
            //Declaring variables such as accountname,sharenumber,shareprice
            string accountname = null;
            int sharenumber = 0;
            double shareprice = 0;
            Console.WriteLine("Enter Name to create an account");
            accountname = Console.ReadLine();
            ////sending data to the model class by creating object and store it like json file
            AccountModel.CreateAccountObject(accountname, sharenumber, shareprice);
            Console.WriteLine("New Account been created Congrats!!! " + accountname);
        }
    }
}

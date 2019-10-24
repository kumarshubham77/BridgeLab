// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.CommercialData
{
    class AccountModel
    {
        public AccountModel(string accountname, int sharenumber, double shareprice)
        {
            //Assigning them to the new Variables.
            AccountName = accountname;
            ShareNumber = sharenumber;
            Shareprice = shareprice;
        }
        //Declaring Get Set for each variables.
        public string AccountName { get; set; }
        public int ShareNumber { get; set; }
        public double Shareprice { get; set; }
        /// <summary>
        /// Creates the account object.
        /// </summary>
        /// <param name="accountname">The accountname.</param>
        /// <param name="sharenumber">The sharenumber.</param>
        /// <param name="shareprice">The shareprice.</param>
        public static void CreateAccountObject(string accountname, int sharenumber, double shareprice)
        {
            AccountModel account = new AccountModel(accountname, sharenumber, shareprice);
            NewAccount newAccount = JsonRead.JsonReadFile();
            newAccount.AccountList.Add(account);
            //Console.WriteLine(newAccount);
            FileWrite.WriteInToFile(newAccount);
            Console.WriteLine("Account had been successfully created");
        }
    }
}

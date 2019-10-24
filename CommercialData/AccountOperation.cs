// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountOperation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.CommercialData
{
    /// <summary>
    /// Creating a class AccountOperation that will
    /// inherit the CommercialInterface interface.
    /// Implementing Inheritance.
    /// As well as Ploymorphism as the method that are already defined into the 
    /// interface class get override here. Thus,result in the Poymorphism.
    /// </summary>
    class AccountOperation : CommercialInterface
    {
        /// <summary>
        /// Inheriting all method of the CommercialInterface that is been inherit by
        /// the class AccountOperation.
        /// </summary>
        public void DisplayStock()
        {
            //Reading of json file that is in string 
            //
            NewAccount newAccount = JsonRead.JsonReadFile();
            ////Convert all data into the list type
            List<AccountModel> accountModels = newAccount.AccountList;
            double sum = 0;
            //Iterating each data one by one.
            foreach (var account in accountModels)
            {
                Console.WriteLine("");
                Console.WriteLine("Account Name:" + account.AccountName + "\n sahre number" + account.ShareNumber + "\n stock price " + account.Shareprice);
                sum += account.Shareprice;
            }
            Console.WriteLine("Total value of accounts store in database Rs." + sum);
        }
        /// <summary>
        /// Displays the account.
        /// </summary>
        public void DisplayAccount()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
                
                NewAccount newAccount = JsonRead.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Account Name:" + name.AccountName + "\n sahre number" + name.ShareNumber + "\n stock price " + name.Shareprice);
                    }
                }
                break;

            }
        }
        /// <summary>
        /// This method Buy() will buy the shares to the users.
        /// </summary>
        public void Buy()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
                /////Updating the share number and price
                NewAccount newAccount = JsonRead.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Enter share price buy");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter share Number You want to Buy");
                        int Number = Convert.ToInt32(Console.ReadLine());
                        name.ShareNumber = name.ShareNumber + Number;
                        name.Shareprice = name.Shareprice + price;
                    }

                }
                FileWrite.WriteInToFile(newAccount);
                Console.WriteLine(accountname + "Successfully Buyed the shares.");
                break;
            }

        }
        /// <summary>
        /// Sells the shares of the particular users.
        /// Taking input from user which you want to sell.
        /// </summary>
        public void Sell()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to Sell");
                accountname = Console.ReadLine();
                
                ////Updating the share number and price after sell
                NewAccount newAccount = JsonRead.JsonReadFile();
                List<AccountModel> accounts = newAccount.AccountList;
                foreach (AccountModel name in accounts)
                {
                    //Checking each data with the user input 
                    if (name.AccountName.Equals(accountname))
                    {
                        Console.WriteLine("Enter share number you want to buy");
                        double price = Convert.ToDouble(Console.ReadLine());
                        int Number = Convert.ToInt32(Console.ReadLine());
                        name.ShareNumber = name.ShareNumber - Number;
                        name.Shareprice = name.Shareprice - price;
                    }

                }
                FileWrite.WriteInToFile(newAccount);
                Console.WriteLine(accountname + "Selled the stock Price");
                break;
            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.INventoryManagementProgram
{
    /// <summary>
    /// Creating a class InventoryManager
    /// </summary>
    class InventoryManager
    {
        /// <summary>
        /// Creating a method Manager
        /// </summary>
        public void Manager()
        {
            InventoryFactory inventory = new InventoryFactory();
            NewAccount newAccount = InventoryFactory.JsonReadFile();
            List<InventoryFactory> accountModels = newAccount.AccountList;
            //Console.WriteLine(accountModels);
            double sum = 0;
            //Iterating theough each account using foreach loop and printing the values.
            foreach (var account in accountModels)
            {
                Console.WriteLine("");
                Console.WriteLine("Name:" + account.Name + "\nWeight" + account.Weight + "\nPrice " + account.Priceperkg);
                sum += inventory.Total(account.Weight, account.Priceperkg);
                Console.WriteLine("total Price for this item :" + sum);
            }
            //Printing the Total cost.
            Console.WriteLine("total Price Is :" + sum);
        }
    }
}

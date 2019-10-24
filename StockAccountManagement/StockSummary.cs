// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StockSummary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.StockAccountManagement
{
    class StockSummary : Display
    {
        /// <summary>
        /// Display the stock.
        /// </summary>
        public void DisplayStock()
        {
            Newlist newAccount = Read.JsonReadFile();
            List<StockModel> accountModels = newAccount.AccountList;
            double sum = 0;
            foreach (var account in accountModels)
            {
                Console.WriteLine("");
                Console.WriteLine("Stock Name:" + account.Stockname + "\n sahre number" + account.Shareperson + "\n stock price " + account.Stockprice);
                sum += account.Stockprice * account.Shareperson;
            }
            Console.WriteLine("Total value of accounts store in database Rs." + sum);
        }
        /// <summary>
        /// this method will take the user input i.e., how much inputs you want 
        /// </summary>

        public void Summary()
        {
            double totalstockcost = 0;
            Console.WriteLine("How Many Inputs You want?");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter the Stock Name:");
                string StockName = Console.ReadLine();
                Console.WriteLine("Enter the Number of Share");
                int ShareNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Stock Price");
                double StockCost = Convert.ToInt32(Console.ReadLine());
                totalstockcost = totalstockcost + (ShareNumber * StockCost);
                StockModel.CreatObjectModel(StockName, ShareNumber, StockCost);
            }
            //calling the method Dislay Stock that is defined in the interface Display
            Console.WriteLine("Total  Added Cost for all Stock = Rs." + totalstockcost);
            DisplayStock();
        }
    }
}

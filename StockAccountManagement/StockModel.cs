// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StockModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace RestOOPs.StockAccountManagement
{
    class StockModel
    {
        /// <summary>
        /// Creating a method i.e., StockModel
        /// that will take the Following Parameters.
        /// </summary>
        /// <param name="stockname"></param>
        /// <param name="stockperson"></param>
        /// <param name="stockprice"></param>
        public StockModel(string stockname, int stockperson, double stockprice)
        {
            Stockname = stockname;
            Shareperson = stockperson;
            Stockprice = stockprice;
        }
        public string Stockname { get; set; }
        public int Shareperson { get; set; }
        public double Stockprice { get; set; }

        /// <summary>
        /// Creating a method i.e., CreateObjectModel
        /// that will take up the Following arguments.
        /// </summary>
        /// <param name="stockname"></param>
        /// <param name="shareperson"></param>
        /// <param name="stockprice"></param>
        public static void CreatObjectModel(string stockname, int shareperson, double stockprice)
        {
            StockModel stock = new StockModel(stockname, shareperson, stockprice);
            Newlist newAccount = Read.JsonReadFile();
            newAccount.AccountList.Add(stock);
            FileWrite.WriteInToFile(newAccount);
        }
    }
}

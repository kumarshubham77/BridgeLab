// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RestOOPs.INventoryManagementProgram
{
    /// <summary>
    /// Creating a class InventoryFactory
    /// </summary>
    class InventoryFactory
    {
        private string name;
        private double weight;
        private double priceperkg;
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Priceperkg { get; set; }

        /// <summary>
        /// Creating a method That will read the JSON file 
        /// and Convert it into String type.
        /// </summary>
        /// <returns>account</returns>
        public static NewAccount JsonReadFile()
        {
            string path = @"C:\Users\USER\source\repos\RestOOPs\INventoryManagementProgram\DataTwo.json";
            StreamReader read = new StreamReader(path);
            string json = read.ReadToEnd();
            Console.WriteLine(json);
            //// Convert json format to string format.
            NewAccount account = JsonConvert.DeserializeObject<NewAccount>(json);
            ///---------------------------------------------------
            //Console.WriteLine(account);
            read.Close();
            return account;
        }
        /// <summary>
        /// Creating a method that will return the total cost.
        /// </summary>
        /// <param name="w">Weight</param>
        /// <param name="p">Price</param>
        /// <returns></returns>
        public double Total(double w, double p)
        {
            return (w * p);
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RestOOPs.InventoryManagement
{
    /// <summary>
    /// Creating a class InventoryData
    /// </summary>
    class InventoryData
    {
        /// <summary>
        /// Creating method i.e., Display
        /// Which will read the json from the file,
        /// and displays it's Content in a regular Fashion.
        /// </summary>
        public void Display()
        {
            string path = @"C:\Users\USER\source\repos\RestOOPs\InventoryManagement\DataOne.json";
            StreamReader read = new StreamReader(path);
            var json = read.ReadToEnd();
            var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
            //Iterating each element by foreach Loop and Printing value.
            foreach (var item in items)
            {
                Console.WriteLine(item.Name + "\t" + item.Weight + "\t" + item.PricePerKg + "\t" + (item.Weight * item.PricePerKg));
            }
            
            
        }
    }
}

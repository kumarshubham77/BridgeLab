// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Read.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RestOOPs.StockAccountManagement
{
    class Read
    {
        /// <summary>
        /// Reading the Json File 
        /// </summary>
        /// <returns></returns>
        public static Newlist JsonReadFile()
        {
            string path = (@"C:\Users\USER\source\repos\RestOOPs\StockAccountManagement\DataThree.json");
            StreamReader read = new StreamReader(path);
            string json = read.ReadToEnd();
            //// Convert json format to string format.
            Newlist account = JsonConvert.DeserializeObject<Newlist>(json);
            read.Close();
            return account;
        }
    }
}

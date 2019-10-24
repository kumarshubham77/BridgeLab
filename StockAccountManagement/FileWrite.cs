// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FileWrite.cs" company="Bridgelabz">
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
    class FileWrite
    {
        /// <summary>
        /// Write the data into the JSON file.
        /// </summary>
        /// <param name="newAccount"></param>
        public static void WriteInToFile(Newlist newAccount)
        {
            string path = (@"C:\Users\USER\source\repos\RestOOPs\StockAccountManagement\DataThree.json");
            ////Serialize the object into json Compatible    
            var writeData = JsonConvert.SerializeObject(newAccount);
            StreamWriter stream = new StreamWriter(path);
            stream.Write(writeData);
            stream.Close();
        }
    }
}

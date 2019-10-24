// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JsonRead.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RestOOPs.CommercialData
{
    class JsonRead
    {
        public static NewAccount JsonReadFile()
        {
            string path = (@"C:\Users\USER\source\repos\RestOOPs\CommercialData\Data.json");
            StreamReader read = new StreamReader(path);
            string json = read.ReadToEnd();
            //// Convert json format to string format.
            NewAccount account = JsonConvert.DeserializeObject<NewAccount>(json);
            read.Close();
            return account;
        }
    }
}

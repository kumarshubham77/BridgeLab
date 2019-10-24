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

namespace RestOOPs.CommercialData
{
    class FileWrite
    {

        public static void WriteInToFile(NewAccount newAccount)
        {
            string path = (@"C:\Users\USER\source\repos\RestOOPs\CommercialData\Data.json");
            ////Serialize the object into json Compatible
            var writeData = JsonConvert.SerializeObject(newAccount);
            StreamWriter stream = new StreamWriter(path);
            stream.Write(writeData);
            stream.Close();
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPS.AddressBookProblem
{
    class FileWrite
    {
        public static void WriteInFile(Address address)
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\add.json";
            StreamWriter write = new StreamWriter(path);
            var writeData = JsonConvert.SerializeObject(address);
            write.Write(writeData);
            write.Flush();
            write.Close();
        }
    }
}

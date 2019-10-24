using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json; 


namespace OOPS.AddressBookProblem
{
    class JSON
    {
        public static Address JsonRead()
        {
            string path = @"C:\Users\Bridgelabz\source\repos\OOPS\add.json";
            StreamReader read = new StreamReader(path);
            var json = read.ReadToEnd();
            Address address = JsonConvert.DeserializeObject<Address>(json);
            read.Close();
            return address;

        }
    }
}

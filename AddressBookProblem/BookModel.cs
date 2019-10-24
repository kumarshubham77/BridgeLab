using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.AddressBookProblem
{
    class BookModel
    {
        public BookModel(string fname,string lname,long phonenumber, string city, string state, int zip)
        {
            Name = fname;
            LastName = lname;
            PhoneNumber = phonenumber;
            City = city;
            State = state;
            Zip = zip;
  
            
         }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string State{ get; set; }
        public int Zip { get; set; }
       
        public static void CreatObject(string fname, string lname,   long phonenumber, string city, string state, int zip)
        {
            BookModel book = new BookModel(fname, lname,  phonenumber, city, state, zip);
            Address address1 = JSON.JsonRead();
            address1.AddressList.Add(book);
            FileWrite.WriteInFile(address1);
            

        }




    }
}

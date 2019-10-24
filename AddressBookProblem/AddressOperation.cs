using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.AddressBookProblem
{
    public interface Operation
    {
        void NewItem();
        void Edit();
        void delete();
        void display();
    }
    class AddressOperation:Operation
    {
        public void NewItem()
        {
            Console.WriteLine("Enter the number of Details You Want To enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int item = 1;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the First Name");
                string fname = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                string lname = Console.ReadLine();
               
                Console.WriteLine("Enter the City Name");
                string city = Console.ReadLine();
                Console.WriteLine("Enter the State Name");
                string state = Console.ReadLine();
                Console.WriteLine("Enter the Zip Name");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Phone number Name");
                long pnumber = Convert.ToInt64(Console.ReadLine());
                BookModel.CreatObject(fname, lname,pnumber, city, state, zip);
                Console.WriteLine(item++ +"New item Added");

            }
        }
        public void Edit()
        {
            Address address2 = JSON.JsonRead();
            
            List<BookModel> models = address2.AddressList;
            //Console.WriteLine(models);
            Console.WriteLine("Enter the first Name");
            string firstname = Console.ReadLine();
            foreach(var items in models)
            {
                if(items.Name.Equals(firstname))
                {
                    Console.WriteLine("Enter the last name");
                    string lastname = Console.ReadLine();
                    items.LastName = lastname;
                    Console.WriteLine("Enter the phone number");
                    long pnum = Convert.ToInt64(Console.ReadLine());
                    items.PhoneNumber = pnum;
                    break;
                }
            }
            FileWrite.WriteInFile(address2);
            Console.WriteLine(firstname + "Data will be updated");
        }
        public void delete()
        {
            Address address2 = JSON.JsonRead();
            List<BookModel> models = address2.AddressList;
            Console.WriteLine("Enter the first Name");
            string firstname = Console.ReadLine();
            foreach (var items in models)
            {
                if (items.Name.Equals(firstname))
                {
                    models.Remove(items);
                    break;

                }
            }
            FileWrite.WriteInFile(address2);
        }
        public void display()
        {
            Address address2 = JSON.JsonRead();
            List<BookModel> models = address2.AddressList;
            foreach (var items in models)
            {
                Console.WriteLine("First Name" + items.Name);
                Console.WriteLine("Last Name" + items.LastName);
                Console.WriteLine("PhoneNumber" + items.PhoneNumber);
                Console.WriteLine(" City" + items.City);
                Console.WriteLine(" Zip" + items.Zip);
                Console.WriteLine("State" + items.State);

            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DS
{
    /// <summary>
    /// 
    /// </summary>
    class UnorderedList
    {
        /// <summary>
        /// Creating object of Utility and calling functions from there one by one.
        /// </summary>
        Utility util = new Utility();
        LinkedList<string> link = new LinkedList<string>();
        public void OperationalFile()
        {
            //Reading a file into a String
            string st = util.ReadFile("C://Users//USER//source//repos//DS/DS//mytext.txt");
            //Spliting data into space sepearted values
            string[] data = st.Split(" ");
            for(int i =0;i<data.Length;i++)
            {
                //Adding data one by one into list using Addlast method from Utility.
                link.AddLast(data[i]);
            }
            link.ReadAll();
            //Ask user to search an element and storing into a avariable called element.
            Console.WriteLine("Enter the element you want to search");
            string element = util.InputString();
            //Search function implemented from Utility and returns true if matches else False
            bool find = link.Search(element);
            if(find == true)
            {
                // Delete function from Utility class and deleting a particualr element if found.
                link.Delete(element);
                Console.WriteLine(element + "Deleted");
                bool f = util.WriteInFile("C://Users//USER//source//repos//DS/DS//mytext.txt", link.GetLinkLis());
                if(f==true)
                {
                    Console.WriteLine("Write all elements in the file");
                }
                else
                {
                    Console.WriteLine("Not all written in the file");
                }
            }
            else
            {
                //if search result equals false then adding them into the list.
                link.AddLast(element);
                Console.WriteLine(element + "Added");
                bool f = util.WriteInFile("C://Users//USER//source//repos//DS/DS//mytext1.txt", link.GetLinkLis());
                if (f == true)
                {
                    Console.WriteLine("Write all Element in file");
                }
                else
                {
                    Console.WriteLine("Not Write in File");
                }
            }
        }
    }
}

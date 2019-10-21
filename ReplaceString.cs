using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class ReplaceString
    {
        public void Inputt()
        {
            string str = "Hello <<username>>, how are you ?";
            Console.WriteLine(str);
            Console.WriteLine("Enter the string you want to replace");
            string str1 = Console.ReadLine();
            Console.WriteLine(str.Replace("<<username>>", str1));



        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Utility.cs" company="Bridgelabz">
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
    class Utility
    {
        public string ReadFile(string Filename)
        {
            string st = "";
            try
            {
                StreamReader sr = new StreamReader(Filename);
                string str = sr.ReadLine();

                while(str != null)
                {
                    st = str + st;
                    str = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return st;
        }
        public string InputString()
        {
            return Console.ReadLine();
        }
        public int InputInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public bool WriteInFile(string filename, string line)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(line);
                sw.Flush();
                sw.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public int DepositeCash(BankingCashCounter bankdata)
        {
            int amount;
            Console.WriteLine("Enter the Amount You Want Deposite:");
            Console.WriteLine("Note:Amount should Be greater then zero");
            amount = InputInteger();
            if (amount > 0)
            {
                BankingCashCounter.InitialAmount = BankingCashCounter.InitialAmount + amount;
                BankingCashCounter.DepositeAmount = BankingCashCounter.DepositeAmount + amount;
                Console.WriteLine("Transaction Successfull.");
            }
            else
            {
                Console.WriteLine("Transaction Failed:");
                Console.WriteLine("Amount Should Be Greater then Zero");
                return -1;
            }
            return BankingCashCounter.InitialAmount;
        }
        /// <summary>
        /// Withdraw the amount of cash.
        /// </summary>
        /// <param name="bankdata">The bankdata.</param>
        /// <returns></returns>
        public int WithDrawalCash(BankingCashCounter bankdata)
        {
            int amount;
            Console.WriteLine("Available Bank Cash Balance is: " + BankingCashCounter.InitialAmount);
            Console.WriteLine("Enter the Amount For Withdraw");
            amount = InputInteger();
            if (amount < BankingCashCounter.InitialAmount)
            {
                BankingCashCounter.InitialAmount = BankingCashCounter.InitialAmount - amount;
                BankingCashCounter.WithdrawAmount = BankingCashCounter.WithdrawAmount + amount;
                Console.WriteLine("Transaction Suceessfull");
                Console.WriteLine("Please Collect your Cash");
            }
            else
            {
                Console.WriteLine("Enter the Amount Equal OR Less the Available BAlance");
                return -1;
            }
            return BankingCashCounter.InitialAmount;
        }
        public bool Prime(int n)
        {
            for (int j = 2; j <= n / 2; j++)
            {
                if (n % j == 0)
                {
                    return false;
                }

            }
            return true;
        }
        public bool Anagram(int n1, int n2)
        {
            int[] n1count = Count(n1);
            int[] n2count = Count(n2);
            for (int i = 0; i < n2count.Length; i++)
            {
                if (n1count[i] != n2count[i])
                {
                    return false;
                }
            }
            return true;
        }
        public int[] Count(int n)
        {
            int[] count = new int[10];
            int temp = n;
            while (temp != 0)
            {
                int r = temp % 10;
                count[r]++;
                temp = temp / 10;
            }
            return count;
        }
    }
}

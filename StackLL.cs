// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StackLL.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    class StackLL
    {
        public char data;
        public StackLL next;

        public StackLL(char data)
        {
            this.data = data;
        }
    }

    public class LinkedListStackLL
    {
        StackLL top;
        int size = 0;
        public char data;

        public void push(char ch)
        {
            StackLL n1 = new StackLL(data);
            if (top == null)
            {
                top = n1;
                size++;
            }
            else
            {
                n1.next = top;
                top = n1;
                size++;
            }
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Cant pop anything !");
            }
            else
            {
                top = top.next;
                size--;
            }
        }
        public void check(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                    push(ch[i]);
                }
                if (ch[i] == ')')
                {
                    pop();
                }
            }
        }
        public void show()
        {
            if (top == null)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public void display()
        {
            StackLL temp = top;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}

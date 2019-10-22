// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    class Stack
    {
        int max = 100;
        char[] arr = new char[100];

        int size = 0;
        int top = -1;

        public void push(char ch)
        {
            if (top == max)
            {
                Console.WriteLine("Stack is currently full");
            }
            else
            {
                arr[++top] = ch;
                size++;
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top--;
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
        public void display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        public void show()
        {
            if (top == -1)
            {
                Console.WriteLine("Balanced ");
            }
            else
            {
                Console.WriteLine("Unbalanced");
            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeAnagramStack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    class PrimeAnagramStack
    {
        //Creating object of the class utility
        //Containing all methods that is to be called.
        Utility util = new Utility();
        StackLinkedList<int> Stack = new StackLinkedList<int>();
        /// <summary>
        /// find Prime number and store in the stack.
        /// </summary>
        /// Creating method PrimeStack that will
        /// check if it is prime it will push it into the stack.
        public void PrimeStack()
        {
            for(int i=2;i<=1000;i++)
            {
                if(util.Prime(i))
                {
                    Stack.Push(i);
                }
            }
            /////poping element one by one and pint in Linked List Class
            while(!Stack.IsEmpty())
            {
               Stack.Pop();
            }
        }
    }
}

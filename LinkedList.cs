// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LinkedList<T>.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    /// <summary>
    /// Making class of LinkedList generics type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList<T> where T : IComparable<T>
    {
        Node<T> head = null;

        //Method to Add at last taking data that is to be added
        //from last.
        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node<T> current = head; 
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
                newItem.next = null;
            }
        }
        //Reading all data.
        public void ReadAll()
        {
            Node<T> start = head;
            while(start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
            Console.WriteLine();
        }
        //Deleting the particular data.
        public bool Delete(T item)
        {
            if(head.data.Equals(item))
            {
                head = head.next;
                return true;
            }
            else
            {
                Node<T> x = head;
                Node<T> y = head.next;
                while(true)
                {
                    //Comparing both the data.
                    if(y ==null || y.data.Equals(item))
                    {
                        break;
                    }
                    else
                    {
                        x = y;
                        y = y.next;
                    }
                }
                if(y != null)
                {
                    x.next = y.next;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        // SEarching for the particular Item.
        public bool Search(T item)
        {
            Node<T> a = head;
            while(a != null)
            {
                if(a.data.Equals(item))
                {
                    return true;
                }
                a = a.next;
            }
            return false;
        }
        //Generating Linklist.
        public string GetLinkLis()
        {
            Node<T> last;
            string data = "";
            if (head == null)
                return null;
            else
            {
                last = head;
                while (last != null)
                {
                    data = data + last.data + " ";
                    last = last.next;
                }
                return data;
            }
        }
        //Insertion in the sorted form.
        public void SortedInsert(T item)
        {
            Node<T> new_node = new Node<T>();
            Node<T> current;

            if(head == null || head.data.CompareTo(new_node.data)>0)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;
                while (current.next != null &&
                    current.next.data.CompareTo(new_node.data) < 0)
                    current = current.next;
                new_node.next = current.next;
                current.next = new_node;
            }
        }
    }
}
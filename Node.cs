// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Node.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    /// <summary>
    /// Creating class of Node Generics type.
    /// Taking data and add of next node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {

        public T data;
        public Node<T> next;
    }
}

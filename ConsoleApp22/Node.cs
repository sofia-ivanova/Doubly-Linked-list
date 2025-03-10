using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node<T> Prev;
        public Node(T newData)
        {
            Data = newData;
            Next = null;
            Prev = null;
        }
    }
}

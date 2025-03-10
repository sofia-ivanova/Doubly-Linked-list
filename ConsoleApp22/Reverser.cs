using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Reverser<T>
    {
        public static Node<T> Reverse(Node<T> head)
        {
            if (head == null || head.Next == null)
                return head;
            Node<T> prevNode = null;
            Node<T> currNode = head;
            while (currNode != null)
            {
                prevNode = currNode.Prev;
                currNode.Prev = currNode.Next;
                currNode.Next = prevNode;
                currNode = currNode.Prev;
            }
            head = prevNode.Prev;
            return head;
        }
    }
}

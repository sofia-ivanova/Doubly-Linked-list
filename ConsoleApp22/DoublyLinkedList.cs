using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class DoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }
        public Node<T> Head => head;
        public Node<T> Tail => tail;
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }
    }
}

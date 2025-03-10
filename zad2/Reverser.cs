using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Reverser<T>
    {
        public static T GetMiddle(Node<T> head)
        {
            Node<T> slow_ptr = head;
            Node<T> fast_ptr = head;
            while (fast_ptr != null && fast_ptr.Next != null)
            {
                fast_ptr = fast_ptr.Next.Next;
                slow_ptr = slow_ptr.Next;
            }
            return slow_ptr.Data;
        }
    }
}

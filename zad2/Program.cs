using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> head = new Node<int>(10);
            head.Next = new Node<int>(20);
            head.Next.Next = new Node<int>(30);
            head.Next.Next.Next = new Node<int>(40);
            head.Next.Next.Next.Next = new Node<int>(50);
            head.Next.Next.Next.Next.Next = new Node<int>(60);
            Console.WriteLine("The middle is: " + Reverser<int>.GetMiddle(head));
            Console.ReadKey();
        }
    }
}

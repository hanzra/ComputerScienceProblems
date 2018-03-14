using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfLinkedListIsPalindrom
{
    class Node
    {
        public char Value;
        public Node Next;

        public Node(char data)
        {
            Value = data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node('a');
            head.Next = new Node('a');
            head.Next.Next = new Node('b');
            head.Next.Next.Next = new Node('a');
            head.Next.Next.Next.Next = new Node('d');

            Console.WriteLine(  isListPalindrome(head));

            Console.ReadLine();
        }


        public static Node DeleteNode(Node head, char key)
        {
            //dummy>a>b>c>d>e
            if (head == null)
                return null;

            Node dummyhead = new Node('a');
            dummyhead.Next = head;

            Node current = dummyhead.Next;
            Node prev = dummyhead;

            while (current != null)
            {
                if(current.Value == key)
                {
                    prev.Next = current.Next;
                    break;
                }

                prev = current;
                current = current.Next;
            }

            return dummyhead.Next;
            
        }

        public static Node DeleteDuplicatesWhenListSorted(Node node)
        {
            //a>a>b>b>c>d

            Node current = node;

            while (current.Next != null)
            {
                if(current.Value == current.Next.Value)
                {
                    current.Next = current.Next.Next;
                }
                current = current.Next;
            }

            return node;
        }

        public static Node ReverseLinkedList(Node head)
        {
            //1>2>3>4>5

            Node current = head;
            Node next = null;
            Node prev = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next; 
            }

            return current;
        }

        //a>d>m>d>a
        //a>d>d>a

       public static bool CheckIfPalindrom(Node head)
        {
            //made mistake
            // Didnt put while to find mid
            // did pop from stack after finding that its odd list and slow needs to move to next
            // forgot to move slow to next in the last while

            var slow = head;
            var fast = head;
            Stack<char> Stc = new Stack<char>();

            while(fast!=null && fast.Next != null)
            {
                Stc.Push(slow.Value);

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if(fast.Next == null)
            {
                slow = slow.Next;                
            }

            while (slow != null)
            {
                if (slow.Value != Stc.Pop())
                    return false;
                slow = slow.Next;
            }
            return true;
        }

        public static bool isListPalindrome(Node l)
        {

            Node slow = l;
            Node fast = l;
            Stack<int> st = new Stack<int>();

            while (fast != null && fast.Next != null)
            {
                st.Push(slow.Value);
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            //a>b>c>d>c

            if (fast.Next == null)
            {
                slow = slow.Next;
            }

            while (slow != null)
            {
                if (slow.Value != st.Pop())
                {
                    return false;
                }
                slow = slow.Next;
            }
            return true;
        }
    }
}

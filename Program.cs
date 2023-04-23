using System;
namespace Stack_and_queue_Problems
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public int PopLast()
        {
            if (head == null)
            {
                throw new Exception("Linked list is empty");
            }
            if (head.next == null)
            {
                int data = head.data;
                head = null;
                return data;
            }
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            int tailData = current.next.data;
            current.next = null;
            return tailData;
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);

            linkedList.PopLast();

            Console.WriteLine("Final Sequence: ");
            linkedList.PrintList();
        }
    }
}


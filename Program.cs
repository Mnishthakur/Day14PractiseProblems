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

        public void Insert(int data, int position)
        {
            Node newNode = new Node(data);
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }

            Node current = head;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
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
            linkedList.Add(56);
            linkedList.Insert(30, 1);

            Console.WriteLine("Final Sequence: ");
            linkedList.PrintList();
        }
    }
}


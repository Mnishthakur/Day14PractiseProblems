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

        public int Pop()
        {
            if (head == null)
            {
                throw new Exception("Linked list is empty");
            }
            int data = head.data;
            head = head.next;
            return data;
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

            linkedList.Pop();

            Console.WriteLine("Final Sequence: ");
            linkedList.PrintList();
        }
    }
}


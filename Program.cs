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
            this.next = null;
        }
    }

    class OrderedList
    {
        public Node head;

        public OrderedList()
        {
            this.head = null;
        }

        public void add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else if (data < head.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;

                while (current.next != null && current.next.data < data)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
            }
        }

        public void printList()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }

            Console.Write("null\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderedList list = new OrderedList();
            list.add(56);
            list.add(30);
            list.add(40);
            list.add(70);
            list.printList();
        }
    }
}


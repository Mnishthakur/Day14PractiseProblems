using System;
namespace Stack_and_queue_Problems
{
    class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class SortedLinkedList<T> where T : IComparable
    {
        public Node<T> head;

        public SortedLinkedList()
        {
            this.head = null;
        }

        public void add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else if (data.CompareTo(head.data) < 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;

                while (current.next != null && data.CompareTo(current.next.data) > 0)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
            }
        }

        public void printList()
        {
            Node<T> current = head;

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
            SortedLinkedList<int> list = new SortedLinkedList<int>();
            list.add(56);
            list.add(30);
            list.add(40);
            list.add(70);
            list.printList();
        }
    }
}


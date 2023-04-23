using System;
namespace Stack_and_queue_Problems
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LLSearch
    {
        Node head;
        public void insert(int data)  // 56 30 70
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }
            else
            {
                n.next = head;
                head = n;
            }
        }
        public void Search(int value)
        {
            Node t = head;
            bool con = false;
            while (t != null)
            {
                if (t.data.Equals(value))
                {
                    con = true;
                    Console.WriteLine("{0}is found", value);
                }
                t = t.next;
            }
            if (con == false)
            { Console.WriteLine("{0}is not found", value); }
        }
        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        static void Main()
        {
            LLSearch ll = new LLSearch();
            ll.insert(70);
            //ll.insert(40);
            ll.insert(30);
            ll.insert(56);
            ll.Search(40);
            ll.display();


        }
    }
}
}


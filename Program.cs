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
    public class LLPopFirst
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

        public void PopFirst()// 56 30 40 70
        {
            Node t = head;
            if (t == null)
            { throw new NullReferenceException("list is empty"); }
            else
            {
                head = t.next;
            }
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
            LLPopFirst ll = new LLPopFirst();
            ll.insert(70);
            ll.insert(40);
            ll.insert(30);
            ll.insert(56);
            ll.PopFirst(); ll.PopFirst(); ll.PopFirst();
            ll.display();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue_Problems
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class Stack
    {
        private Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int data = top.data;
            top = top.next;
            return data;
        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

}

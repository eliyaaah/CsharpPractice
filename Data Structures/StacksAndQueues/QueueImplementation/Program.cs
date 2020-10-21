using System;

namespace QueueImplementation
{
    internal class Node
    {
        public int Data { get; set;}
        public Node Next { get; set; }
        public Node(int data)
        {
            this.Data = data;
        }
    }
    internal class Queue
    {
        private Node _head;
        private Node _tail;
        private int _count = 0;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (_head == null)
            {
                _head = new Node(data);
                _tail = _head;
            }
            else
            {
                _tail.Next = newNode;
                _tail = _tail.Next;
            }
            _count++;
        }
        public int Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Queue is empty!");
            }
            int _result = _head.Data;
            _head = _head.Next;
            return _result;
        }
        public int Peek()
        {
            if (_head == null)
            {
                throw new Exception("Queue is empty!");
            }
            int _result = _head.Data;
            return _result;
        }
        public void PrintQueue()
        {
            Console.Write("Queue: ");
            Node currNode = _head;
            while(currNode != null)
            {
                Console.Write(currNode.Data + " ");
                currNode = currNode.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(9);
            queue.Dequeue();
            queue.Dequeue();
            queue.PrintQueue();
        }
    }
}

using System;
using System.Collections.Generic;

namespace QueueThroughStack
{
    class Program
    {
        internal class Queue
        {
            Stack<int> stack_queue = new Stack<int>();
            Stack<int> stack_helper = new Stack<int>();


            public void Enqueue(int data)
            {
                if (stack_queue.Count == 0 && stack_helper.Count != 0)
                    while (stack_helper.Count != 0) stack_queue.Push(stack_helper.Pop());
                stack_queue.Push(data);
            }
            public void Dequeue()
            {
                Peek();
                stack_helper.Pop();
            }
            public int Peek()
            {
                if (stack_helper.Count != 0) return stack_helper.Peek();
                while (stack_queue.Count != 0) stack_helper.Push(stack_queue.Pop());
                return stack_helper.Peek();
            }

            public void PrintQueue()
            {
                if (stack_queue.Count != 0 && stack_helper.Count == 0)
                    while (stack_queue.Count != 0) stack_helper.Push(stack_queue.Pop());
                if (stack_helper.Count != 0)
                {
                    Console.WriteLine("Queue:");
                    foreach (int x in stack_helper)
                    {
                        Console.Write(x);
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.WriteLine("Queue empty");
                }
            }
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(6);
            // queue.Enqueue(9);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(10);
            Console.WriteLine(queue.Peek());
            queue.PrintQueue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.PrintQueue();
        }
    }
}

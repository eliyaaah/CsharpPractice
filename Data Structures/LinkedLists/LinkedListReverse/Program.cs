using System;
using System.Collections.Generic;

namespace LinkedListReverse
{
    class Program
    {
        static public LinkedList<int> ReverseLinkedList1(LinkedList<int> linkedList)
        {
            LinkedList<int> copyList = new LinkedList<int>();
            LinkedListNode<int> start = linkedList.Last;

            while (start != null)
            {
                copyList.AddLast(start.Value);
                start = start.Previous;
            } 

            return copyList;
        }
        static public void PrintLinkedList(LinkedList<int> linkedList)
        {
            foreach (int item in linkedList)
            {
                Console.Write(item + ", ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8};
            LinkedList<int> linkedList = new LinkedList<int>(arr);
            PrintLinkedList(ReverseLinkedList1(linkedList));
        }
    }
}

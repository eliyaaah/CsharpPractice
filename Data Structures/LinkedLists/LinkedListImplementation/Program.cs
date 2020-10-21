using System;

namespace LinkedListImplementation
{
    internal class SingleLinkedList {  
        internal Node head;  
        internal void InsertFront(int new_data) 
        {    
            Node new_node = new Node(new_data);    
            new_node.next = this.head;    
            this.head = new_node;    
        }
        
        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void InsertEnd(int new_data)
        {
            if (this.head == null)
            {
                this.head = new Node(new_data);
                return;
            }
            Node last = GetLastNode(this);
            last.next = new Node(new_data);
        }
        internal void PrintLinkedList()
        {
            Node currNode = this.head;
            while (currNode != null)
            {
                Console.Write(currNode.data + ", ");
                currNode = currNode.next;
            }
            Console.WriteLine();
        }
        internal void ReverseLinkedList()
        {
            Node prevNode = null;
            Node currNode = this.head;
            Node nextNode = null;
            while (currNode != null)
            {
                nextNode = currNode.next;
                currNode.next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            this.head = prevNode;
        }
        internal class Node
        {  
            internal int data;  
            internal Node next;  
            public Node(int d) {  
                data = d;  
                next = null;  
            }  
        } 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.InsertEnd(5);
            list.InsertEnd(8);
            list.InsertEnd(9);
            list.InsertFront(1);
            list.PrintLinkedList();
            list.ReverseLinkedList();
            list.PrintLinkedList();
        }
    }
}

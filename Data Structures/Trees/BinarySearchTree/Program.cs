using System;

namespace BinarySearchTree
{
    public enum NodePosition
    {
        left,
        right,
        center
    }
    class Node
    {

        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int data)
        {
            this.Value = data;
        }

        // Below is additional functions required for printing of the BST
        private void PrintValue(string value, NodePosition nodePostion)
        {
            switch (nodePostion)
            {
                case NodePosition.left:
                    PrintLeftValue(value);
                    break;
                case NodePosition.right:
                    PrintRightValue(value);
                    break;
                case NodePosition.center:
                    Console.WriteLine(value);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void PrintLeftValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("L:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void PrintRightValue(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R:");
            Console.ForegroundColor = (value == "-") ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void PrintPretty(string indent, NodePosition nodePosition, bool last, bool empty)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }

            var stringValue = empty ? "-" : Value.ToString();
            PrintValue(stringValue, nodePosition);

            if (!empty && (this.Left != null || this.Right != null))
            {
                if (this.Left != null)
                    this.Left.PrintPretty(indent, NodePosition.left, false, false);
                else
                    PrintPretty(indent, NodePosition.left, false, true);

                if (this.Right != null)
                    this.Right.PrintPretty(indent, NodePosition.right, true, false);
                else
                    PrintPretty(indent, NodePosition.right, true, true);
            }
        }
        public void PrintNode()
        {
            Console.Write("└─");
            Console.WriteLine(Value);
            Console.Write("  ├─");
            var stringValue = Left == null ? "-" : Left.Value.ToString();
            PrintValue(stringValue, NodePosition.left);
            Console.Write("  └─");
            stringValue = Right == null ? "-" : Right.Value.ToString();
            PrintValue(stringValue, NodePosition.right);
        }

    }

    class Tree
    {
        public Node Root, currNode, prevNode;

        public bool Add(int value)
        {
            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                currNode = Root;
                while (currNode != null)
                {
                    prevNode = currNode;
                    if (value > currNode.Value)
                    {
                        currNode = currNode.Right;
                    }
                    else if (value < currNode.Value)
                    {
                        currNode = currNode.Left;
                    }
                    else
                    {
                        return false;
                    }
                }
                currNode = newNode;
                if (prevNode.Value > currNode.Value)
                    prevNode.Left = currNode;
                else
                    prevNode.Right = currNode;
            }
            return true;
        }
        public Node Lookup(int value)
        {
            if (Root == null)
            {
                throw new Exception("Tree is empty");
            }
            else
            {
                currNode = Root;
                while (currNode.Value != value)
                {
                    prevNode = currNode;
                    if (value > currNode.Value)
                        currNode = currNode.Right;
                    else if (value < currNode.Value)
                        currNode = currNode.Left;
                    if (currNode == null)
                        throw new Exception("Node not found");
                }
                return currNode;
            }
        }
        private int MinValue(Node node)
        {
            int minv = node.Value;

            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }

            return minv;
        }
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Value)
                parent.Left = Remove(parent.Left, key);
            else if (key > parent.Value)
                parent.Right = Remove(parent.Right, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.Left == null)
                    return parent.Right;
                else if (parent.Right == null)
                    return parent.Left;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Value = MinValue(parent.Right);

                // Delete the inorder successor  
                parent.Right = Remove(parent.Right, parent.Value);
            }

            return parent;
        }
        public void Print()
        {
            if (Root == null)
                throw new Exception("Tree is empty");
            Root.PrintPretty("", NodePosition.center, true, false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(2);
            tree.Add(9);
            tree.Add(4);
            tree.Add(6);
            tree.Add(20);
            tree.Add(170);
            tree.Add(15);
            tree.Add(1);
            tree.Remove(9);
            tree.Print();
            //tree.Lookup(172).PrintNode();
        }
    }
}

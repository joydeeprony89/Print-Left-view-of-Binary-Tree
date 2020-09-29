using System;
using System.Collections;
using System.Collections.Generic;

namespace Print_Left_view_of_Binary_Tree
{
    public class Node
    {
        public int value;
        public Node left, right;
        public Node(int value = 0)
        {
            this.value = value;
            left = right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.left.left.left = new Node(-2);
            Console.WriteLine("Left view is !");
            PrintLeftView(root);
        }

        static void PrintLeftView(Node root)
        {
            if (root == null) return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(null); // delimeter for each level

            while(queue.Count > 0)
            {
                Node node = queue.Peek();
                if (node != null)
                {
                    Console.WriteLine(node.value);
                    while (queue.Peek() != null)
                    {
                        if (node.left != null) queue.Enqueue(node.left);
                        if (node.right != null) queue.Enqueue(node.right);
                        queue.Dequeue();
                        node = queue.Peek();
                    }
                    queue.Enqueue(null); // add delimeter
                }
                else
                {
                    queue.Dequeue(); // dremove delimeter
                }
            }
        }
    }


}

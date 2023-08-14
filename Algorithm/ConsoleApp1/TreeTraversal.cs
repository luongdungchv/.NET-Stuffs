using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TreeTraversal
    {      
        public static void PrintLeaves(Node root)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(root);
            while(nodeQueue.Count != 0)
            {
                var n = nodeQueue.Dequeue();
                if(n.left == null && n.right == null)
                {
                    Console.WriteLine(n.label);
                    continue;
                }
                if (n.left != null) nodeQueue.Enqueue(n.left);
                if (n.right != null) nodeQueue.Enqueue(n.right);
            }
        }
    }
    public class Node
    {
        public string label;
        public Node left, right;
        public Node(string _label)
        {
            label = _label;
        }
    }
}

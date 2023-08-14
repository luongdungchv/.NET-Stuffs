using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BinarySearchTree
    {
        public TreeNode root;
        public static int[] sampleData = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public BinarySearchTree(int[] arr)
        {
            root = GetNode(0, arr.Length - 1, arr);
        }
        public void Add(int key)
        {
            if(root == null)
            {
                root = new TreeNode(key);
                return;
            }
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            while(nodeQueue.Count != 0)
            {
                var n = nodeQueue.Dequeue();
                if (n.key == key) return;
                if(key > n.key)
                {
                    if (n.right != null) nodeQueue.Enqueue(n.right);
                    else
                    {
                        n.right = new TreeNode(key);
                        return;
                    }
                }
                if(key < n.key)
                {
                    if (n.left != null) nodeQueue.Enqueue(n.left);
                    else
                    {
                        n.left = new TreeNode(key);
                        return;
                    }
                }
            }
        }
        TreeNode GetNode(int s, int e, int[] arr)
        {
            int m = (s + e) / 2;
            var res = new TreeNode(arr[m]);
            if (m < e) res.right = GetNode(m + 1, e, arr);
            if (m > s) res.left = GetNode(s, m - 1, arr);
            var lheight = res.left != null ? res.left.height : 0;
            var rheight = res.right != null ? res.right.height : 0;
            res.height = 1 + Math.Max(rheight, lheight);
            return res;
        }
        public void PrintTree()
        {
            void Print(TreeNode node)
            {
                if (node == null) return;
                Print(node.left);
                Console.Write($"{node.key} ");
                Print(node.right);
            }
            Print(root);
        }
        public TreeNode DeleteAvl(TreeNode n, int key)
        {
            

            return n;
        }
        public LinkedList<int> FindPath(int k1, int k2)
        {
            int tmp = k1;
            if(k1 > k2)
            {
                k1 = k2;
                k2 = tmp;
            }

            LinkedList<int> Find2(TreeNode node)
            {
                Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
                nodeQueue.Enqueue(node);
                var path = new LinkedList<int>();
                while (nodeQueue.Count > 0)
                {
                    var n = nodeQueue.Dequeue();
                    path.AddFirst(n.key);
                    if (n.key == k1) break;
                    else if (k1 > n.key && n.right != null) nodeQueue.Enqueue(n.right);
                    else if (k1 < n.key && n.left != null) nodeQueue.Enqueue(n.left);

                }
                nodeQueue.Enqueue(node.right);
                while (nodeQueue.Count > 0)
                {
                    var n = nodeQueue.Dequeue();
                    path.AddLast(n.key);
                    if (n.key == k1) break;
                    else if (k2 > n.key && n.right != null) nodeQueue.Enqueue(n.right);
                    else if (k2 < n.key && n.left != null) nodeQueue.Enqueue(n.left);
                }
                return path;
            }


            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            while (nodeQueue.Count != 0)
            {
                var n = nodeQueue.Dequeue();
                if (k1 < n.key && k2 > n.key)
                {
                    return Find2(n);
                }
                if (k1 < n.key && k2 < n.key)
                {
                    nodeQueue.Enqueue(n.left);
                }
                if (k1 > n.key && k2 > n.key)
                {
                    nodeQueue.Enqueue(n.right);
                }
            }
            return new LinkedList<int>();
        }
    }
    class TreeNode
    {
        public int key;
        public TreeNode left, right;
        public int height;
        public TreeNode(int key)
        {
            this.key = key;
            height = 1;
        }
    }
}

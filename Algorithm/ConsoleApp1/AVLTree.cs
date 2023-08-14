using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AVLTree
    {
        public AVLTreeNode root;
        public void Add(int key)
        {
            AVLTreeNode Method(AVLTreeNode node)
            {
                if (node == null) return new AVLTreeNode() { value = key, height = 1 };
                if(key < node.value)
                {
                    node.left = Method(node.left);
                }
                if(key > node.value)
                {
                    node.right = Method(node.right);
                }
                int lh = node.left == null ? 0 : node.left.height;
                int rh = node.right == null ? 0 : node.right.height;

                node.height = Math.Max(lh, rh) + 1;
                int balanceFactor = rh - lh;
                if(balanceFactor < -1)
                {
                    //Console.WriteLine("Unbalanced" + node.value.ToString());
                    node = RotateLeft(node);
                }
                return node;              
            }
            root = Method(root);
        }
        AVLTreeNode RotateLeft(AVLTreeNode node)
        {
            var ln = node.left;
            var lnr = ln.right;
            ln.right = node;
            node.left = lnr;

            return ln;
            //Console.WriteLine(node.value);
        }
    }
    public class AVLTreeNode
    {
        public int value;
        public int balanceFactor;
        public AVLTreeNode left;
        public AVLTreeNode right;
        public int height;
    }
}

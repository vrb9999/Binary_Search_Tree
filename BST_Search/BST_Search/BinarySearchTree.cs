using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Search
{
    class BinarySearchTree<T> where T : IComparable
    {
        int treeSize = 0;

        public INode<T> root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int element)
        {
            INode<T> newNode = new INode<T>();
            newNode.NodeData = element;
            if (root == null)
            {
                root = newNode;
                treeSize++;
            }
            else
            {
                INode<T> newRoot = root;
                INode<T> parent;
                while (true)
                {
                    parent = newRoot;
                    if (element < newRoot.NodeData)
                    {
                        newRoot = newRoot.LeftTree;
                        if (newRoot == null)
                        {
                            parent.LeftTree = newNode;
                            treeSize++;
                            return;
                        }
                    }
                    else
                    {
                        newRoot = newRoot.RightTree;
                        if (newRoot == null)
                        {
                            parent.RightTree = newNode;
                            treeSize++;
                            return;
                        }
                    }
                }
            }
        }
        public void SizeOfTree()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            Console.WriteLine("\nSize of tree is : " + treeSize);
        }
        public void SearchTree(INode<T> newNode, int value)
        {
            if (null == newNode)
            {
                Console.WriteLine("{0} is Not Present in BST", value);
            }
            else if (newNode.NodeData == value)
            {
                Console.WriteLine("{0} is Present in BST", value);
            }
            else if (value < newNode.NodeData)
                SearchTree(newNode.LeftTree, value);
            else
                SearchTree(newNode.RightTree, value);
        }
        public void Traverse(INode<T> Root)
        {
            if (Root != null)
            {
                Traverse(Root.LeftTree);
                Console.Write(Root.NodeData + " ");
                Traverse(Root.RightTree);
            }
        }
    }
}

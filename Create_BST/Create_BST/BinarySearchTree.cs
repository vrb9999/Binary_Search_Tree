using System;

namespace Create_BST
{
    class BinarySearchTree<T> where T : IComparable
    {
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
                            return;
                        }
                    }
                    else
                    {
                        newRoot = newRoot.RightTree;
                        if (newRoot == null)
                        {
                            parent.RightTree = newNode;
                            return;
                        }
                    }
                }
            }
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
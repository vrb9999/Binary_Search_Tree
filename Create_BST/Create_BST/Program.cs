using System;

namespace Create_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            Console.WriteLine("Root : 56 ");
            binarySearch.Insert(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            Console.WriteLine("Binary Search Tree Elements ::");
            binarySearch.Traverse(binarySearch.root);
        }
    }
}

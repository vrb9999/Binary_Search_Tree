using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Search
{
    public class INode<T> where T : IComparable
    {
        public int NodeData;
        public INode<T> LeftTree;
        public INode<T> RightTree;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LironAvlTree
{
    class Node<T> where T : IComparable<T>
    {
        public bool IsLeftChild()
        {
            if (Parent == null)
            {
                return false;
            }
            else if (Parent.Left == this)
            {
                return true;
            }
            return false;

        }

        public int ChildCount()
        {
            int count = 0;

            if (Left != null)
            {
                count++;
            }

            if (Right != null)
            {
                count++;
            }

            return count;
        }

        public bool IsRightChild()
        {
            return (Parent != null && Parent.Right == this);
        }
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Parent { get; set; }

        public T Value { get; set; }

        public Node(T Value)
        {
            this.Value = Value;
            this.Parent = Parent;
        }


    }
}


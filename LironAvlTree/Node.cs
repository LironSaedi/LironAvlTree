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
        public int Height
        {
            get
            {


                if (Right == null && Left == null)
                {
                    return 1;
                }

                else if (Right == null)
                {
                    return Left.Height + 1;
                }

                else if (Left == null)
                {
                    return Right.Height + 1;
                }

                int height = Math.Max(Right.Height, Left.Height) + 1;
                return height;
            }
        }

        public int Balence
        {
            get
            {
                // check for left or right null
                // balance is the other node's height if null
                int height = Right.Height - Left.Height;
                return height;
            }
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


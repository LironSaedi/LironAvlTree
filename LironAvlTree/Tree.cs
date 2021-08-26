using System;
using System.Collections.Generic;
using System.Text;

namespace LironAvlTree
{
    class Tree<T> where T : IComparable<T>
    {
        Node<T> root;


        /*
        public void Insert(T value)
        {
            //Node<T> node = new Node<T>(value);
            //if (root == null)
            //{
            //    root = node;
            //    return;
            //}

            //Node<T> holder = root;
            //while (true)
            //{
            //    int index = node.Value.CompareTo(holder.Value);
            //    if (index >= 0)
            //    {
            //        if (holder.Right == null)
            //        {
            //            holder.Right = node;
            //            node.Parent = holder;
            //            return;
            //        }
            //        holder = holder.Right;

            //    }

            //    else
            //    {
            //        if (holder.Left == null)
            //        {
            //            holder.Left = node;
            //            node.Parent = holder;
            //            return;
            //        }
            //        holder = holder.Left;
            //    }
        }

        */
        //Update Height
        //Call Balence

        public Node<T> Insert(T value, Node<T> parent)
        {
            if(parent == null)
            {
                return new Node<T>(value);
            }

            int holder = value.CompareTo(parent.Value);

            if(holder >= 0)
            {
                parent.Right = Insert(value, parent.Right); //call right else call left
            }
            else if(holder < 0)
            {
                parent.Left = Insert(value, parent.Left);
            }

            return Balance(parent);
            
            //update height, return balence
        }


        
            public Node<T> LeftRotate(Node<T> node)
            {
            return null;
            }

            public Node<T> RightRotate(Node<T> node)
            {
            return null;
            }
        /*
            public void BalencingNode()
            {
                if (Balence() < -1 || Balence() > 1)
                {

                }
            }
        */
    }
}
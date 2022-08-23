using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Model
{
    class Node<T> 
        where T: IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node()
        {

        }
        public Node(T data)
        {
            Data = data;
        }

        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if (data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = newNode;
                    return;
                }
                Left.Add(data);
            }
            if (data.CompareTo(Data) >= 0)
            {
                if (Right == null)
                {
                    Right = newNode;
                    return;
                }
                Right.Add(data);
            }
        }

        //public static bool operator <(Node<T> item1, Node<T> item2)
        //{
        //    if (item1.Data.CompareTo(item2.Data) < 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator >(Node<T> item1, Node<T> item2)
        //{
        //    if (item1.Data.CompareTo(item2.Data) > 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

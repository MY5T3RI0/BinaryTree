using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Model
{
    class Tree<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data); ;
                return;
            }
            Root.Add(data);
        }

        public List<T> PreOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return PreOrder(Root, result);
            }
            return default;
        }

        private List<T> PreOrder(Node<T> node, List<T> result)
        {
            result.Add(node.Data);

            if (node.Left != null)
            {
                PreOrder(node.Left, result);
            }

            if (node.Right != null)
            {
                PreOrder(node.Right, result);
            }

            return result;
        }

        public List<T> PostOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return PostOrder(Root, result);
            }
            return default;
        }

        private List<T> PostOrder(Node<T> node, List<T> result)
        {
            if (node.Left != null)
            {
                PostOrder(node.Left, result);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right, result);
            }

            result.Add(node.Data);

            return result;
        }

        public List<T> InOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return InOrder(Root, result);
            }
            return default;
        }

        private List<T> InOrder(Node<T> node, List<T> result)
        {
            if (node.Left != null)
            {
                InOrder(node.Left, result);
            }

            result.Add(node.Data);

            if (node.Right != null)
            {
                InOrder(node.Right, result);
            }

            return result;
        }

    }
}

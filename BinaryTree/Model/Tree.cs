using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Model
{
    /// <summary>
    /// Бинарное дерево.
    /// </summary>
    /// <typeparam name="T">Тип хранимых в узле данных.</typeparam>
    class Tree<T>
        where T : IComparable
    {
        /// <summary>
        /// Корневой узел.
        /// </summary>
        public Node<T> Root { get; set; }

        /// <summary>
        /// Добавить узел.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Данные не могут быть null");
            }

            if (Root == null)
            {
                Root = new Node<T>(data); ;
                return;
            }
            Root.Add(data);
        }

        /// <summary>
        /// Префиксный обход.
        /// </summary>
        /// <returns>Список элементов дерева.</returns>
        public List<T> PreOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return PreOrder(Root, result);
            }
            return default;
        }

        /// <summary>
        /// Префиксный обход.
        /// </summary>
        /// <param name="node">Корневой узел.</param>
        /// <param name="result">Список элементов дерева.</param>
        /// <returns>Список элементов дерева.</returns>
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

        /// <summary>
        /// Постфиксный обход.
        /// </summary>
        /// <returns>Список элементов дерева.</returns>
        public List<T> PostOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return PostOrder(Root, result);
            }
            return default;
        }

        /// <summary>
        /// Постфиксный обход.
        /// </summary>
        /// <param name="node">Корневой узел</param>
        /// <param name="result">Список элементов дерева.</param>
        /// <returns>Список элементов дерева.</returns>
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

        /// <summary>
        /// Инфиксный обход.
        /// </summary>
        /// <returns>Список элементов дерева.</returns>
        public List<T> InOrder()
        {
            if (Root != null)
            {
                var result = new List<T>();
                return InOrder(Root, result);
            }
            return default;
        }

        /// <summary>
        /// Инфиксный обход.
        /// </summary>
        /// <param name="node">Корневой узел.</param>
        /// <param name="result">Список элементов дерева.</param>
        /// <returns>Список элементов дерева.</returns>
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

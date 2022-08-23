using BinaryTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            tree.Add(9);
            tree.Add(5);
            tree.Add(11);
            tree.Add(4);
            tree.Add(7);
            tree.Add(8);
            tree.Add(13);

            var preorder = tree.PreOrder();

            foreach(var item in preorder)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            var postorder = tree.PostOrder();

            foreach (var item in postorder)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            var inorder = tree.InOrder();

            foreach (var item in inorder)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

using ConsoleApp35;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(8);
            tree.Add(7);
            tree.Add(4);
            tree.Add(1);
            tree.Add(6);
            tree.Add(9);
            tree.Add(2);

            var preorder = tree.Preorder();
            foreach (var item in preorder)
            {
                Console.WriteLine(item);
            }

            var postorder = tree.PostOrder();
            Console.WriteLine();
            foreach (var item in postorder)
            {
                Console.WriteLine(item);
            }

            var inorder = tree.InOrder();
            Console.WriteLine();
            foreach (var item in inorder)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();
        }
    }
}

using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.AddNode(1);
            binaryTree.AddNode(2);
            binaryTree.AddNode(3);
            binaryTree.AddNode(4);
            binaryTree.AddNode(5);
            binaryTree.AddNode(6);
            binaryTree.AddNode(7);
            var binaryTreeResult = binaryTree.AddNode(8);

            Console.ReadKey();

        }
    }
}

using System;

namespace LargestBSTinBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(25);
            tree.left = new Node(18);
            tree.left.left = new Node(19);
            tree.left.left.right = new Node(15);
            tree.left.right = new Node(20);
            tree.left.right.right = new Node(25);
            tree.left.right.left = new Node(18);

            tree.right = new Node(50);
            tree.right.right = new Node(60);
            tree.right.right.right = new Node(70);
            tree.right.right.left = new Node(55);
            tree.right.left = new Node(35);
            tree.right.left.left = new Node(20);
            tree.right.left.left.right = new Node(25);
            tree.right.left.right = new Node(40);

            LargestBST LB = new LargestBST();

            Console.WriteLine(LB.FindlargestBST(tree));
            Console.ReadLine();
        }
    }
}

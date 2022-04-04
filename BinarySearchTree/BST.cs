using System;

namespace BinarySearchTree
{
    class BST
    {
        class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;

        BST()
        {
            root = null;
        }

        BST(int value)
        {
            root = new Node(value);
        }

        void insert(int key)
        {
            root = insertRec(root, key);
        }

        Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
            {
                root.left = insertRec(root.left, key);
            }
            else if (key > root.key)
            {
                root.right = insertRec(root.right, key);
            }

            return root;
        }

        void inorder() { 
            inorderRec(root); 
        }

        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.key + " ");
                inorderRec(root.right);
            }
        }

        static void Main(string[] args)
        {
            BST biSeTr = new BST();

            biSeTr.insert(7);
            biSeTr.insert(5);
            biSeTr.insert(1);
            biSeTr.insert(8);
            biSeTr.insert(3);
            biSeTr.insert(6);
            biSeTr.insert(0);
            biSeTr.insert(9);
            biSeTr.insert(4);
            biSeTr.insert(2);

            biSeTr.inorder();
        }
    }
}

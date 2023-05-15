using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinaryTree
{
    internal class MyBinaryTree<T>
    {
        public BST<T> newNode;

        public void Insert(T data)
        {
            BST<T> node = new BST<T>(data);
            if (newNode == null)
            {
                newNode = node;
            }
            else
            {
                BST<T> temp = newNode;

                while (temp != null)
                {
                    if (temp.left == null)
                    {
                        temp.left = node;
                        break;
                    }
                    else if (Comparer<T>.Default.Compare(temp.left.data, node.data) <= 0 && temp.right == null)
                    {
                        temp.right = node;
                        break;
                    }
                    else if (temp.right == null)
                    {
                        temp.right = temp.left;
                        temp.left = node;
                        break;
                    }
                    temp = temp.left;
                }
            }
        }

        public void Display()
        {
            BST<T> temp = newNode;
            Console.WriteLine($"        {newNode.data}");

            while (temp.left != null)
            {
                Console.Write($" |         |\n {temp.left.data}");
                if (temp.right != null)
                {
                    Console.Write($"             {temp.right.data}\n");
                }
                temp = temp.left;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBinaryTree
{
    internal class MyBinaryTree1<T>
    {
        public BST<T> newNode;
        int leftCount = 0;
        int rightCount = 0;
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
                        leftCount++;
                        break;
                    }
                    else if (Comparer<T>.Default.Compare(temp.left.data, node.data) <= 0 && temp.right == null)
                    {
                        temp.right = node;
                        rightCount++;
                        break;
                    }
                    else if (temp.right == null)
                    {
                        temp.right = temp.left;
                        temp.left = node;
                        rightCount++;
                        break;
                    }

                    if (leftCount <= rightCount)
                    {
                        temp = temp.left;
                    }
                    else if (leftCount > rightCount)
                    {
                        temp = temp.right;
                    }

                }
            }
        }

        public void Display()
        {
            int leftCount = 0;
            int rightCount = 0;
            BST<T> temp = newNode;
            Console.WriteLine($"        {newNode.data}");

            while (temp.left != null && temp.right != null)
            {
                if (temp.left != null)
                {
                    Console.Write($" |               |\n {temp.left.data}");
                    leftCount++;
                }
                if (temp.right != null)
                {
                    Console.Write($"             {temp.right.data}\n");
                    rightCount++;
                }
                if (leftCount < rightCount)
                {
                    temp = temp.left;
                }
                if (leftCount >= rightCount)
                {
                    temp = temp.right;
                }
            }
        }


        public void Size()
        {
            Console.WriteLine($"size of BST: {leftCount + rightCount}");
        }



        public void Search(T input)
        {
            int leftCount = 0;
            int rightCount = 0;
            BST<T> temp = newNode;

            while (temp.left != null && temp.right != null)
            {
                if (temp.left != null)
                {
                    if (temp.left.data.Equals(input))
                    {
                        Console.WriteLine($"search result: {input}");
                        break;
                    }
                    leftCount++;
                }
                if (temp.right != null)
                {
                    if (temp.right.data.Equals(input))
                    {
                        Console.WriteLine($"search result: {input}");
                        break;
                    }
                    rightCount++;
                }
                if (leftCount < rightCount)
                {
                    temp = temp.left;
                }
                if (leftCount >= rightCount)
                {
                    temp = temp.right;
                }
            }
        }
    }
}

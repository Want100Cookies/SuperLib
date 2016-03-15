using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLib.Collections
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T data)
            {
                this.Data = data;
            } 
        }

        public Node<T> RootNode { get; private set; } 

        public BinarySearchTree()
        {
            RootNode = null;
        }

        public void Insert(T element)
        {
            Node<T> newNode = new Node<T>(element);

            if (RootNode == null)
            {
                RootNode = newNode;
            }
            else
            {
                Node<T> currentNode = RootNode;

                while (true)
                {
                    Node<T> parentNode = currentNode;

                    if (newNode.Data.CompareTo(currentNode.Data) < 0)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode != null) continue;

                        parentNode.Left = newNode;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode != null) continue;

                        parentNode.Right = newNode;
                        break;
                    }
                }
            }
        }

        public IEnumerable<T> EnumerableInOrder(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                foreach (T leftElement in EnumerableInOrder(rootNode.Left))
                {
                    yield return leftElement;
                }

                yield return rootNode.Data;

                foreach (T rightElement in EnumerableInOrder(rootNode.Right))
                {
                    yield return rightElement;
                }
            }
        }
    }
}

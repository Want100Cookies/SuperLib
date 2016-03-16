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

        private Node<T> GetSuccessor(Node<T> delNode)
        {
            Node<T> successorParent = delNode;
            Node<T> successor = delNode;
            Node<T> current = delNode.Right;

            while (current != null)
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }

            if (successor != delNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }

            return successor;
        }

        public bool Delete(T value)
        {
            Node<T> current = RootNode;
            Node<T> parent = RootNode;

            bool isLeftChild = true;

            while (current.Data.CompareTo(value) != 0)
            {
                parent = current;
                if (value.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current == null)
                {
                    return false;
                }
            }
            Console.WriteLine("Found: " + current.Data);
            Console.WriteLine("\r\nLeft: " + current.Left + "\r\nRight: " + current.Right);

            if ((current.Left == null) && (current.Right == null))
            {
                if (current == RootNode) { 
                    RootNode = null;
                }
                else if (isLeftChild)
                { 
                    parent.Left = null;
                }
                else
                { 
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            { 
                if (current == RootNode)
                { 
                    RootNode = current.Left;
                }
                else if (isLeftChild)
                { 
                    parent.Left = current.Left;
                }
                else
                { 
                    parent.Right = current.Right;
                }
            }
            else if (current.Left == null)
            {
                if (current == RootNode)
                {
                    RootNode = current.Right;
                }
                else if (isLeftChild)
                {
                    parent.Left = parent.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                Node<T> successor = GetSuccessor(current);
                Console.WriteLine("Need successor: " + successor.Data);
                // Todo: Fix cause of infinite loop somewhere here

                if (current == RootNode)
                {
                    RootNode = successor;
                }
                else if (isLeftChild)
                {
                    parent.Left = successor;
                }
                else
                {
                    parent.Right = successor;
                }
                successor.Left = current.Left;
            }
            return true;
        }

        public T Min
        {
            get
            {
                Node<T> current = RootNode;
                while (current.Left != null)
                {
                    current = current.Left;
                }
                return current.Data;
            }
        }

        public T Max
        {
            get
            {
                Node<T> current = RootNode;
                while (current.Right != null)
                {
                    current = current.Right;
                }
                return current.Data;
            }
        }

        public Node<T> FindNode(T value)
        {
            Node<T> current = RootNode;

            while (current.Data.CompareTo(value) != 0)
            {
                if (value.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }

                if (current == null) return null;
            }

            return current;
        } 

        public IEnumerable<T> EnumerableInOrder(Node<T> rootNode)
        {
            if (rootNode == null) yield break;

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

        public IEnumerable<T> EnumerablePreOrder(Node<T> node)
        {
            if (node == null) yield break;

            yield return node.Data;

            foreach (T leftElement in EnumerablePreOrder(node.Left))
            {
                yield return leftElement;
            }

            foreach (T rightElement in EnumerablePreOrder(node.Right))
            {
                yield return rightElement;
            }
        }

        public IEnumerable<T> EnumerablePostOrder(Node<T> node)
        {
            if (node == null) yield break;

            foreach (T leftElement in EnumerablePreOrder(node.Left))
            {
                yield return leftElement;
            }

            foreach (T rightElement in EnumerablePreOrder(node.Right))
            {
                yield return rightElement;
            }

            yield return node.Data;
        } 
    }
}
